from flask import Flask, render_template, request

app = Flask(__name__)

@app.route("/", methods=["GET", "POST"])
def index():
    if request.method == "POST":
        first_name = request.form.get("first_name")
        last_name = request.form.get("last_name")
        if first_name and last_name:
            greeting = f"Добрый день, {first_name} {last_name}!"
            return render_template("index.html", greeting=greeting)
    return render_template("index.html")

if __name__ == "__main__":
    app.run(debug=True)