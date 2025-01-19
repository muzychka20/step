# Задание 5
# Создайте форму для подписки на новости вашей
# компании. Пользователь должен ввести следующие
# данные:
# ■ Имя;
# ■ Фамилия;
# ■ Возраст;
# ■ Пол;
# ■ Email.
# Полученные от пользователя данные нужно отобразить в браузере.

from flask import Flask, render_template, request

app = Flask(__name__)

@app.route("/", methods=["GET", "POST"])
def index():
    if request.method == "POST":
        first_name = request.form.get("first_name")
        last_name = request.form.get("last_name")
        age = request.form.get("age")
        gender = request.form.get("gender")
        email = request.form.get("email")
        
        data = {
            "first_name": first_name,
            "last_name": last_name,
            "age": age,
            "gender": gender,
            "email": email,
        }
        
        return render_template("index.html", data=data)
    return render_template("index.html")

if __name__ == "__main__":
    app.run(debug=True)