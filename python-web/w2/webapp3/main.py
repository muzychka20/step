# Задание 6
# Создайте форму для заказа воды. Форма должна содержать такие данные:
# ■ Имя;
# ■ Фамилия;
# ■ E-mail;
# ■ Контактный телефон;
# ■ Адрес;
# ■ Количество месяцев доставки воды (возможные варианты: один месяц, три месяца, шесть месяцев, двенадцать месяцев);
# ■ Объём баллона воды (возможные варианты: 5 литров,
# 10 литров, 15 литров).
# Полученную информацию нужно вывести в отформатированном виде.

from flask import Flask, render_template, request

app = Flask(__name__, static_url_path='', static_folder='./static', template_folder='./templates')

@app.route("/", methods=["GET", "POST"])
def index():
    if request.method == "POST":
        first_name = request.form.get("first_name")
        last_name = request.form.get("last_name")
        email = request.form.get("email")
        phone = request.form.get("phone")
        address = request.form.get("address")
        months = request.form.get("months")
        volume = request.form.get("volume")
        
        data = {
            "first_name": first_name,
            "last_name": last_name,
            "email": email,
            "phone": phone,
            "address": address,
            "months": months,
            "volume": volume,
        }
        
        return render_template("index.html", data=data)
    return render_template("index.html")

if __name__ == "__main__":
    app.run(debug=True)