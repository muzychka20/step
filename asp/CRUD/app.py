from flask import Flask, render_template
app = Flask(__name__)
@app.route("/")
def home():
    return render_template("index.html", greeting = "Hello World")

@app.route("/fr")
def french():
    return render_template("index.html", greeting = "Bonjour, le monde!")

@app.route("/de")
def german():
    return render_template("index.html", greeting = "Hallo Welt!")

@app.route("/es")
def spanish():
    return render_template("index.html", greeting = "Hola, Mundo!")

if __name__ == "__main__":
    app.run(debug=True, port = 8000)