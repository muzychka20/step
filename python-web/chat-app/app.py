from flask import Flask, render_template, redirect, url_for, request, flash
from flask_sqlalchemy import SQLAlchemy
from flask_login import LoginManager, UserMixin, login_user, login_required, logout_user, current_user
from flask_socketio import SocketIO, send
import os

app = Flask(__name__)
app.config['SECRET_KEY'] = 'supersecretkey'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///chat.db'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False

db = SQLAlchemy(app)
login_manager = LoginManager(app)
login_manager.login_view = "login"
socketio = SocketIO(app, cors_allowed_origins="*")

# Модель пользователя


class User(UserMixin, db.Model):
    id = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(50), unique=True, nullable=False)
    password = db.Column(db.String(50), nullable=False)


@login_manager.user_loader
def load_user(user_id):
    return User.query.get(int(user_id))

# Главная страница


@app.route('/')
@login_required
def index():
    return render_template("chat.html", username=current_user.username)

# Регистрация


@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        username = request.form.get('username')
        password = request.form.get('password')

        if User.query.filter_by(username=username).first():
            flash("Имя пользователя уже занято!", "danger")
            return redirect(url_for("register"))

        new_user = User(username=username, password=password)
        db.session.add(new_user)
        db.session.commit()
        flash("Вы успешно зарегистрированы! Войдите в систему.", "success")
        return redirect(url_for("login"))

    return render_template("register.html")

# Авторизация


@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        username = request.form.get('username')
        password = request.form.get('password')
        user = User.query.filter_by(
            username=username, password=password).first()

        if user:
            login_user(user)
            return redirect(url_for("index"))
        else:
            flash("Неверные данные", "danger")

    return render_template("login.html")

# Выход


@app.route('/logout')
@login_required
def logout():
    logout_user()
    return redirect(url_for("login"))

# Обработчик сообщений в чате


@socketio.on('message')
def handle_message(msg):
    send(f"{current_user.username}: {msg}", broadcast=True)


# Запуск приложения
if __name__ == "__main__":
    with app.app_context():
        db.create_all()  # Создание базы при первом запуске
    socketio.run(app, host="0.0.0.0", port=5000, debug=True)
