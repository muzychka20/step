from flask import Flask, render_template, request, redirect, url_for, session
from flask_sqlalchemy import SQLAlchemy
from werkzeug.security import generate_password_hash, check_password_hash
import random
import string

app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///users.db'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.config['SECRET_KEY'] = 'your_secret_key'
db = SQLAlchemy(app)


class User(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(50), unique=True, nullable=False)
    password = db.Column(db.String(100), nullable=False)
    passwords = db.relationship('Password', backref='owner')


class Password(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    value = db.Column(db.String(100), nullable=False)
    user_id = db.Column(db.Integer, db.ForeignKey('user.id'))


def generate_password(length=12, letters=True, numbers=True, symbols=True):
    characters = ''
    if letters:
        characters += string.ascii_letters
    if numbers:
        characters += string.digits
    if symbols:
        characters += string.punctuation
    return ''.join(random.choice(characters) for _ in range(length))


@app.route('/', methods=['GET', 'POST'])
def index():
    if request.method == 'POST':
        length = int(request.form.get('length', 12))
        letters = 'letters' in request.form
        numbers = 'numbers' in request.form
        symbols = 'symbols' in request.form
        password = generate_password(length, letters, numbers, symbols)
        if 'user_id' in session:
            new_password = Password(value=password, user_id=session['user_id'])
            db.session.add(new_password)
            db.session.commit()
        return render_template('index.html', password=password)
    return render_template('index.html', password=None)


@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        username = request.form['username']
        password = generate_password_hash(request.form['password'])
        if User.query.filter_by(username=username).first():
            return 'User already exists!'
        user = User(username=username, password=password)
        db.session.add(user)
        db.session.commit()
        return redirect(url_for('login'))
    return render_template('register.html')


@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        username = request.form['username']
        password = request.form['password']
        user = User.query.filter_by(username=username).first()
        if user and check_password_hash(user.password, password):
            session['user_id'] = user.id
            return redirect(url_for('index'))
        return 'Invalid credentials!'
    return render_template('login.html')


@app.route('/logout')
def logout():
    session.pop('user_id', None)
    return redirect(url_for('index'))


@app.route('/saved_passwords')
def saved_passwords():
    if 'user_id' not in session:
        return redirect(url_for('login'))
    passwords = Password.query.filter_by(user_id=session['user_id']).all()
    return render_template('saved_passwords.html', passwords=passwords)


if __name__ == '__main__':
    with app.app_context():
        db.create_all()
    app.run(debug=True)
