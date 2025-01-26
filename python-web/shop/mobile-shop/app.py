from flask import Flask, render_template, request, redirect, url_for, flash, session
from flask_sqlalchemy import SQLAlchemy
from werkzeug.security import generate_password_hash, check_password_hash

app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///shop.db'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.secret_key = 'your_secret_key'

db = SQLAlchemy(app)

cart = []

# Модель базы данных
class User(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(50), unique=True, nullable=False)
    password = db.Column(db.String(200), nullable=False)

class Product(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(256), unique=True, nullable=False)
    price = db.Column(db.Integer, nullable=False)
    image = db.Column(db.String(256), nullable=False)

@app.route('/')
def main():
    return redirect(url_for('login'))

# Главная страница с формой авторизации
@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        username = request.form['username']
        password = request.form['password']
        user = User.query.filter_by(username=username).first()

        if user and check_password_hash(user.password, password):
            session['user_id'] = user.id
            return redirect(url_for('home'))
        else:
            flash('Неправильное имя пользователя или пароль', 'danger')

    return redirect(url_for('home')) if session.get('user_id', 0) else render_template('login.html')

# Страница регистрации
@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        username = request.form['username']
        password = request.form['password']
        confirm_password = request.form['confirm_password']

        if password != confirm_password:
            flash('Пароли не совпадают', 'danger')
            return redirect(url_for('register'))

        hashed_password = generate_password_hash(password, method='pbkdf2:sha256')
        new_user = User(username=username, password=hashed_password)

        try:
            db.session.add(new_user)
            db.session.commit()
            flash('Регистрация прошла успешно', 'success')
            return redirect(url_for('login'))
        except:
            flash('Пользователь с таким именем уже существует', 'danger')

    return redirect(url_for('home')) if session.get('user_id', 0) else render_template('register.html')

# Выход из системы
@app.route('/logout')
def logout():
    global cart
    session.pop('user_id', None)
    cart = []
    flash('Вы вышли из системы', 'info')
    return redirect(url_for('login'))

@app.route('/home')
def home():    
    return render_template('home.html') if session.get('user_id', 0) else redirect(url_for('login'))

@app.route('/products/<brand>')
def products_page(brand):
    products = Product.query.all()
    filtered_products = [p for p in products if brand.lower() in p.name.lower()]    
    return render_template('products.html', brand=brand.capitalize(), products=filtered_products)

@app.route('/add_to_cart/<int:product_id>', methods=['POST'])
def add_to_cart(product_id):
    product = Product.query.filter_by(id=product_id).first()        
    if product:
        cart.append(product)
    return redirect(url_for('home'))

@app.route('/cart')
def cart_page():
    total = sum(item.price for item in cart)
    return render_template('cart.html', cart=cart, total=total)

@app.route('/remove_from_cart/<int:product_id>', methods=['POST'])
def remove_from_cart(product_id):
    global cart
    cart = [item for item in cart if item.id != product_id]
    return redirect(url_for('cart_page'))

def populate_db():
    if Product.query.count() == 0:
        products = [
            # Xiaomi Products
            {"name": "Xiaomi Redmi Note 12", "price": 200, "image": "xiaomi1.jpg"},
            {"name": "Xiaomi Mi 11", "price": 500, "image": "xiaomi2.jpg"},
            {"name": "Xiaomi Poco X5", "price": 300, "image": "xiaomi3.jpg"},
            {"name": "Xiaomi Black Shark 5", "price": 600, "image": "xiaomi4.jpg"},
            {"name": "Xiaomi Mi 10", "price": 400, "image": "xiaomi5.jpg"},
            {"name": "Xiaomi 13 Pro", "price": 800, "image": "xiaomi6.jpg"},
            # Samsung Products
            {"name": "Samsung Galaxy S23", "price": 900, "image": "samsung1.jpg"},
            {"name": "Samsung Galaxy A54", "price": 350, "image": "samsung2.jpg"},
            {"name": "Samsung Galaxy Z Fold 4", "price": 1500, "image": "samsung3.jpg"},
            {"name": "Samsung Galaxy S22", "price": 700, "image": "samsung4.jpg"},
            { "name": "Samsung Galaxy M14", "price": 250, "image": "samsung5.jpg"},
            {"name": "Samsung Galaxy Note 20", "price": 950, "image": "samsung6.jpg"},
            # Apple Products
            {"name": "Apple iPhone 14", "price": 1000, "image": "apple1.jpg"},
            {"name": "Apple iPhone 13", "price": 850, "image": "apple2.jpg"},
            {"name": "Apple iPhone 12", "price": 700, "image": "apple3.jpg"},
            {"name": "Apple iPhone 11", "price": 600, "image": "apple4.jpg"},
            {"name": "Apple iPhone SE (2022)", "price": 400, "image": "apple5.jpg"},
            {"name": "Apple iPhone 14 Pro", "price": 1200, "image": "apple6.jpg"},
            # Oppo Products
            {"name": "Oppo Find X5", "price": 700, "image": "oppo1.jpg"},
            {"name": "Oppo Reno 8", "price": 450, "image": "oppo2.jpg"},
            {"name": "Oppo A96", "price": 300, "image": "oppo3.jpg"},
            {"name": "Oppo F21 Pro", "price": 350, "image": "oppo4.jpg"},
            {"name": "Oppo Find X3 Pro", "price": 900, "image": "oppo5.jpg"},
            {"name": "Oppo A57", "price": 250, "image": "oppo6.jpg"}
        ]
        for product in products:
            db.session.add(Product(**product))
            print('done')
        db.session.commit()

if __name__ == '__main__':
    with app.app_context():
        db.create_all()
        populate_db()
    app.run(debug=True)