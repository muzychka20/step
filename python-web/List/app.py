from flask import Flask, render_template, request, redirect, url_for
import sqlite3

app = Flask(__name__)

# Инициализация базы данных
def init_db():
    with sqlite3.connect("tasks.db") as conn:
        cursor = conn.cursor()
        cursor.execute("""
            CREATE TABLE IF NOT EXISTS tasks (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                title TEXT NOT NULL,
                completed BOOLEAN NOT NULL DEFAULT 0
            )
        """)
        conn.commit()

init_db()

# Получение всех задач
def get_tasks(filter_status=None):
    with sqlite3.connect("tasks.db") as conn:
        cursor = conn.cursor()
        if filter_status == "completed":
            cursor.execute("SELECT * FROM tasks WHERE completed = 1")
        elif filter_status == "active":
            cursor.execute("SELECT * FROM tasks WHERE completed = 0")
        else:
            cursor.execute("SELECT * FROM tasks")
        return cursor.fetchall()

# Главная страница
@app.route("/")
def index():
    filter_status = request.args.get("filter")
    tasks = get_tasks(filter_status)
    return render_template("index.html", tasks=tasks)

# Добавление новой задачи
@app.route("/add", methods=["POST"])
def add_task():
    title = request.form.get("title")
    if title:
        with sqlite3.connect("tasks.db") as conn:
            cursor = conn.cursor()
            cursor.execute("INSERT INTO tasks (title) VALUES (?)", (title,))
            conn.commit()
    return redirect(url_for("index"))

# Отметка задачи как выполненной
@app.route("/complete/<int:task_id>")
def complete_task(task_id):
    with sqlite3.connect("tasks.db") as conn:
        cursor = conn.cursor()
        cursor.execute("UPDATE tasks SET completed = 1 WHERE id = ?", (task_id,))
        conn.commit()
    return redirect(url_for("index"))

# Удаление выполненных задач
@app.route("/clear")
def clear_completed():
    with sqlite3.connect("tasks.db") as conn:
        cursor = conn.cursor()
        cursor.execute("DELETE FROM tasks WHERE completed = 1")
        conn.commit()
    return redirect(url_for("index"))

if __name__ == "__main__":
    app.run(debug=True)