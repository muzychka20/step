from flask import Flask, render_template, redirect, url_for, request, flash, jsonify
from flask_sqlalchemy import SQLAlchemy
from flask_mail import Mail, Message
from flask_login import UserMixin, LoginManager, login_user, login_required, logout_user, current_user
from datetime import datetime
from flask_cors import CORS


app = Flask(__name__)
CORS(app)
app.config['SECRET_KEY'] = 'your_secret_key'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///tasks.db'
app.config['MAIL_SERVER'] = 'smtp.gmail.com'
app.config['MAIL_PORT'] = 465
app.config['MAIL_USERNAME'] = 'your-email@gmail.com'
app.config['MAIL_PASSWORD'] = 'your-email-password'
app.config['MAIL_USE_TLS'] = False
app.config['MAIL_USE_SSL'] = True

db = SQLAlchemy(app)
mail = Mail(app)

login_manager = LoginManager()
login_manager.init_app(app)

# Установка маршрута для входа
login_manager.login_view = "login"  # Перенаправление на страницу входа


# Модели
class User(UserMixin, db.Model):
    id = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(150), unique=True, nullable=False)
    email = db.Column(db.String(150), unique=True, nullable=False)
    password = db.Column(db.String(150), nullable=False)


class Task(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String(150), nullable=False)
    description = db.Column(db.Text, nullable=True)
    date_created = db.Column(db.DateTime, default=datetime.utcnow)
    due_date = db.Column(db.DateTime, nullable=False)

    status_id = db.Column(db.Integer, db.ForeignKey(
        'task_status.id'), default=1, nullable=False)
    status = db.relationship('TaskStatus', backref='tasks', lazy=True)

    user_id = db.Column(db.Integer(), db.ForeignKey('user.id'), nullable=False)


class TaskStatus(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(20))


status_titles = ['Ожидание', 'Выполненное', 'Просроченное']
with app.app_context():
    db.create_all()
    if not TaskStatus.query.first():
        for title in status_titles:
            status = TaskStatus(name=title)
            db.session.add(status)
        db.session.commit()


# Логика входа
@login_manager.user_loader
def load_user(user_id):
    return User.query.get(int(user_id))


@app.route('/')
@login_required
def index():
    tasks = Task.query.filter_by(user_id=current_user.id).all()
    task_statuses = TaskStatus.query.all()
    return render_template('task_list.html', tasks=tasks, task_statuses=task_statuses)


# Регистрация
@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        username = request.form['username']
        email = request.form['email']
        password = request.form['password']
        user = User(username=username, email=email, password=password)
        db.session.add(user)
        db.session.commit()
        flash('Вы успешно зарегистрировались!', 'success')
        return redirect(url_for('login'))
    return render_template('register.html')


# Вход
@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        email = request.form['email']
        password = request.form['password']
        user = User.query.filter_by(email=email).first()
        if user and user.password == password:
            login_user(user)
            flash('Добро пожаловать!', 'success')
            return redirect(url_for('index'))
        flash('Неверные данные для входа', 'danger')
    return render_template('login.html')


# Выход
@app.route('/logout')
def logout():
    logout_user()
    flash('Вы вышли из системы', 'success')
    return redirect(url_for('login'))


@app.route('/create_update_task', methods=['GET', 'POST'])
@app.route('/create_update_task/<int:id>', methods=['GET', 'POST'])
@login_required
def create_update_task(id=None):
    task = None

    if id:
        task = Task.query.get(id)

    if request.method == 'POST':
        title = request.form['title']
        description = request.form['description']
        due_date = datetime.strptime(request.form['due_date'], '%Y-%m-%d')

        if task:
            task.title = title
            task.description = description
            task.due_date = due_date
        else:
            task = Task(title=title, description=description,
                        due_date=due_date, user_id=current_user.id)
            db.session.add(task)

        db.session.commit()
        return redirect(url_for('index'))

    return render_template('create_task.html', task=task)


# Удаление задачи
@app.route('/delete-task', methods=['POST'])
@login_required
def delete_task():
    data = request.get_json()
    task_id = data["task_id"]
    Task.query.filter_by(id=task_id).delete()
    db.session.commit()
    return jsonify({"status": "success", "message": "Task deleted successfully"}), 200


@app.route('/update_task_status/<int:id>', methods=['POST'])
@login_required
def update_task_status(id):
    task = Task.query.get(id)
    status_id = request.form.get('status_id')
    task.status_id = status_id
    db.session.commit()
    return redirect(url_for('index'))


# Отправка напоминания (email)
def send_email(subject, recipient, body):
    msg = Message(subject, sender='kyryll2016@gmail.com',
                  recipients=[recipient])
    msg.body = body
    mail.send(msg)


@app.errorhandler(401)
def unauthorized(error):
    return redirect(url_for('login'))


if __name__ == '__main__':
    app.run(debug=True)
