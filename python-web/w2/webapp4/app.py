#Команда для установки библиотек: pip install flask flask-sqlalchemy flask-wtf
from flask import Flask, render_template, redirect, url_for, request
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///market.db'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
db = SQLAlchemy(app)


# Модели
class Seller(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(100), nullable=False)
    items = db.relationship('Item', backref='seller', lazy=True)


class Buyer(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(100), nullable=False)
    sales = db.relationship('Sale', backref='buyer', lazy=True)


class Item(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(100), nullable=False)
    price = db.Column(db.Float, nullable=False)
    seller_id = db.Column(db.Integer, db.ForeignKey('seller.id'), nullable=False)


class Sale(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    item_id = db.Column(db.Integer, db.ForeignKey('item.id'), nullable=False)
    buyer_id = db.Column(db.Integer, db.ForeignKey('buyer.id'), nullable=False)
    quantity = db.Column(db.Integer, nullable=False)
    item = db.relationship('Item', backref='sales')


# Создание базы данных
with app.app_context():
    db.create_all()


#добавьте маршруты для отображения информации
@app.route('/')
def index():
    buyers = Buyer.query.all()
    sellers = Seller.query.all()
    items = Item.query.all()
    sales = Sale.query.all()    
    return render_template('index.html', buyers=buyers, sellers=sellers, items=items, sales=sales)

#Форма добавления данных
@app.route('/add_buyer', methods=['GET', 'POST'])
def add_buyer():
    if request.method == 'POST':
        name = request.form['name']
        buyer = Buyer(name=name)
        db.session.add(buyer)
        db.session.commit()
        return redirect(url_for('index'))
    return render_template('add_buyer.html')


@app.route('/add_seller', methods=['GET', 'POST'])
def add_seller():
    if request.method == 'POST':
        name = request.form['name']
        seller = Seller(name=name)
        db.session.add(seller)
        db.session.commit()
        return redirect(url_for('index'))
    return render_template('add_seller.html')


@app.route('/add_item', methods=['GET', 'POST'])
def add_item():
    if request.method == 'POST':
        name = request.form['name']
        price = request.form['price']
        seller_id = request.form['seller_id']
        item = Item(name=name, price=price, seller_id=seller_id)        
        db.session.add(item)
        db.session.commit()
        return redirect(url_for('index'))
    sellers = [(el.id, el.name) for el in Seller.query.all()]
    return render_template('add_item.html', sellers=sellers)


@app.route('/add_sale', methods=['GET', 'POST'])
def add_sale():
    if request.method == 'POST':
        quantity = request.form['quantity']
        item_id = request.form['item_id']
        buyer_id = request.form['buyer_id']
        sale = Sale(item_id=item_id, buyer_id=buyer_id, quantity=quantity)
        db.session.add(sale)
        db.session.commit()
        return redirect(url_for('index'))
    buyers = [(el.id, el.name) for el in Seller.query.all()]
    items = [(el.id, el.name) for el in Item.query.all()]
    return render_template('add_sale.html', buyers=buyers, items=items)


if __name__ == '__main__':
    app.run(debug=True)