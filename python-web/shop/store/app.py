from flask import Flask, render_template

app = Flask(__name__)

# Главная страница
@app.route('/')
def home():
    return render_template('home.html')

# Страницы с товарами
@app.route('/xiaomi')
def xiaomi():
    products = [
        {"name": "Xiaomi Redmi Note 12", "price": "200$", "image": "xiaomi1.jpg"},
        {"name": "Xiaomi Mi 11", "price": "500$", "image": "xiaomi2.jpg"},
        {"name": "Xiaomi Poco X5", "price": "300$", "image": "xiaomi3.jpg"},
        {"name": "Xiaomi Black Shark 5", "price": "600$", "image": "xiaomi4.jpg"},
        {"name": "Xiaomi Mi 10", "price": "400$", "image": "xiaomi5.jpg"},
        {"name": "Xiaomi 13 Pro", "price": "800$", "image": "xiaomi6.jpg"}
    ]
    return render_template('products.html', brand="Xiaomi", products=products)

@app.route('/samsung')
def samsung():
    products = [
        {"name": "Samsung Galaxy S23", "price": "900$", "image": "samsung1.jpg"},
        {"name": "Samsung Galaxy A54", "price": "350$", "image": "samsung2.jpg"},
        {"name": "Samsung Galaxy Z Fold 4", "price": "1500$", "image": "samsung3.jpg"},
        {"name": "Samsung Galaxy S22", "price": "700$", "image": "samsung4.jpg"},
        {"name": "Samsung Galaxy M14", "price": "250$", "image": "samsung5.jpg"},
        {"name": "Samsung Galaxy Note 20", "price": "950$", "image": "samsung6.jpg"}
    ]
    return render_template('products.html', brand="Samsung", products=products)

@app.route('/apple')
def apple():
    products = [
        {"name": "iPhone 14", "price": "1000$", "image": "apple1.jpg"},
        {"name": "iPhone 13", "price": "850$", "image": "apple2.jpg"},
        {"name": "iPhone 12", "price": "700$", "image": "apple3.jpg"},
        {"name": "iPhone 11", "price": "600$", "image": "apple4.jpg"},
        {"name": "iPhone SE (2022)", "price": "400$", "image": "apple5.jpg"},
        {"name": "iPhone 14 Pro", "price": "1200$", "image": "apple6.jpg"}
    ]
    return render_template('products.html', brand="Apple", products=products)

@app.route('/oppo')
def oppo():
    products = [
        {"name": "Oppo Find X5", "price": "700$", "image": "oppo1.jpg"},
        {"name": "Oppo Reno 8", "price": "450$", "image": "oppo2.jpg"},
        {"name": "Oppo A96", "price": "300$", "image": "oppo3.jpg"},
        {"name": "Oppo F21 Pro", "price": "350$", "image": "oppo4.jpg"},
        {"name": "Oppo Find X3 Pro", "price": "900$", "image": "oppo5.jpg"},
        {"name": "Oppo A57", "price": "250$", "image": "oppo6.jpg"}
    ]
    return render_template('products.html', brand="Oppo", products=products)

if __name__ == '__main__':
    app.run(debug=True)
