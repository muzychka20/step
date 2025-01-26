from flask import Flask, render_template, request, redirect, url_for

app = Flask(__name__)

# Продукты магазина
products = [
    {"id": 1, "name": "Товар 1", "price": 100, "image": "./static/images/headphones.png"},
    {"id": 2, "name": "Товар 2", "price": 200, "image": "./static/images/laptop.png"},
    {"id": 3, "name": "Товар 3", "price": 300, "image": "./static/images/phone.png"},
    {"id": 4, "name": "Товар 4", "price": 400, "image": "./static/images/phone.png"},
    {"id": 5, "name": "Товар 5", "price": 500, "image": "./static/images/laptop.png"},
    {"id": 6, "name": "Товар 6", "price": 600, "image": "./static/images/headphones.png"},
]

# Корзина
cart = []

@app.route('/')
def main_page():
    return render_template('index.html', products=products)

@app.route('/add_to_cart/<int:product_id>', methods=['POST'])
def add_to_cart(product_id):
    product = next((p for p in products if p['id'] == product_id), None)
    if product:
        cart.append(product)
    return redirect(url_for('main_page'))

@app.route('/cart')
def cart_page():
    total = sum(item['price'] for item in cart)
    return render_template('cart.html', cart=cart, total=total)

@app.route('/remove_from_cart/<int:product_id>', methods=['POST'])
def remove_from_cart(product_id):
    global cart
    cart = [item for item in cart if item['id'] != product_id]
    return redirect(url_for('cart_page'))

if __name__ == '__main__':
    app.run(debug=True)
