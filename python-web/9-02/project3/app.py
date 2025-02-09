from flask import Flask, render_template, request, redirect, url_for, send_file
from flask_sqlalchemy import SQLAlchemy
import pandas as pd
from io import BytesIO
import matplotlib.pyplot as plt
import matplotlib.dates as mdates
from datetime import datetime

# Создание Flask-приложения
app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///expenses.db'  # SQLite база данных
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
db = SQLAlchemy(app)

# Модель расходов
class Expense(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    category = db.Column(db.String(50), nullable=False)
    amount = db.Column(db.Float, nullable=False)
    date = db.Column(db.DateTime, default=datetime.utcnow)

# Главная страница
@app.route('/', methods=['GET', 'POST'])
def index():
    if request.method == 'POST':
        category = request.form['category']
        amount = float(request.form['amount'])
        date = request.form['date']
        date = datetime.strptime(date, '%Y-%m-%d')
        new_expense = Expense(category=category, amount=amount, date=date)
        db.session.add(new_expense)
        db.session.commit()
        return redirect(url_for('index'))

    expenses = Expense.query.all()
    total = sum(expense.amount for expense in expenses)
    return render_template('index.html', expenses=expenses, total=total)

# Экспорт данных в Excel
@app.route('/export')
def export():
    expenses = Expense.query.all()
    df = pd.DataFrame([(e.category, e.amount, e.date) for e in expenses], columns=['Category', 'Amount', 'Date'])
    output = BytesIO()
    with pd.ExcelWriter(output, engine='openpyxl') as writer:
        df.to_excel(writer, index=False)
    output.seek(0)
    return send_file(output, as_attachment=True, download_name='expenses.xlsx', mimetype='application/vnd.openxmlformats-officedocument.spreadsheetml.sheet')

# График расходов
@app.route('/chart')
def chart():
    expenses = Expense.query.all()
    data = {}
    for expense in expenses:
        if expense.date.date() not in data:
            data[expense.date.date()] = 0
        data[expense.date.date()] += expense.amount

    dates = list(data.keys())
    amounts = list(data.values())

    plt.figure(figsize=(10, 6))
    plt.plot(dates, amounts, marker='o')
    plt.gca().xaxis.set_major_formatter(mdates.DateFormatter('%Y-%m-%d'))
    plt.gca().xaxis.set_major_locator(mdates.WeekdayLocator())
    plt.gcf().autofmt_xdate()
    plt.title('Расходы по дням')
    plt.xlabel('Дата')
    plt.ylabel('Сумма')
    
    img = BytesIO()
    plt.savefig(img, format='png')
    img.seek(0)
    return send_file(img, mimetype='image/png')

if __name__ == '__main__':
    # Создаем все таблицы в базе данных в контексте приложения
    with app.app_context():
        db.create_all()
    app.run(debug=True)