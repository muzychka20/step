from flask import Flask, render_template, redirect, url_for, request, flash
from flask_sqlalchemy import SQLAlchemy
from datetime import datetime

app = Flask(__name__)
app.config['SECRET_KEY'] = 'supersecretkey'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///tasks.db'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False

db = SQLAlchemy(app)


class Task(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    text = db.Column(db.String(512), nullable=False)
    date = db.Column(db.DateTime, nullable=False)


@app.route('/', methods=['GET', 'POST'])
def index():
    if request.method == 'POST':
        text = request.form.get('task-message')
        date = datetime.now()

        new_task = Task(text=text, date=date)
        db.session.add(new_task)
        db.session.commit()

    tasks = Task.query.all()
    t = [{"id": task.id, "date": task.date, "text": task.text}
         for task in tasks]
    return render_template("index.html", tasks=t)


@app.route('/delete/<int:id>', methods=["POST"])
def delete(id):
    if request.method == 'POST':
        t = Task.query.filter_by(id=id).first()
        if t:
            db.session.delete(t)
            db.session.commit()
    return redirect(url_for("index"))


@app.route('/update/<int:id>', methods=["POST"])
def update(id):
    if request.method == 'POST':
        data = request.get_json()
        t = Task.query.filter_by(id=id).first()
        if t:
            t.text = data["new_text"]
            db.session.commit()
    return redirect(url_for("index"))


# Запуск приложения
if __name__ == "__main__":
    with app.app_context():
        db.create_all()
    app.run(debug=True, host="0.0.0.0", port=5001)
