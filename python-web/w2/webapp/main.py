# Задание 1
# Используя механизм маршрутизации создайте вебприложение, отображающее информацию о стране.
# В приложении должны быть такие разделы:
# ■ Главная;
# ■ История;
# ■ Города;
# ■ Факты о стране.
# Доступ к разным разделам должен производиться по
# разным адресам.
# Например, если пользователь указал 127.0.0.1:8000,
# должен открыться раздел Главная. Если было указано
# 127.0.0.1:8000/history, должен открыться раздел История.
# Если было указано 127.0.0.1:8000/cities, должен открыться раздел Города. Если было указано 127.0.0.1:8000/facts,
# должен открыться раздел Факты о стране.


# Задание 2
# Добавьте к проекту из первого задания возможность
# обработки запросов вида:
# ■ 127.0.0.1:8000/cities/Paris — должна открыться страница с информацией о Париже.
# ■ 127.0.0.1:8000/cities/Marseille — должна открыться
# страница с информацией о Марселе.
# Если информации об указанном городе нет, необходимо делать переадресацию на раздел Города


# Задание 3
# Добавьте к проекту из первого задания возможность
# обработки запросов вида:
# ■ 127.0.0.1:8000/history/1885 — должна открыться страница
# с информацией о том, что происходило во Франции
# в 1885 году.
# ■ 127.0.0.1:8000/history/1914 — должна открыться страница
# с информацией о том, что происходило во Франции
# в 1914 году.
# Если информации об указанном годе нет, необходимо
# делать переадресацию на раздел История.


# Задание 4
# Добавьте к проекту из первого задания возможность
# обработки запросов вида:
# ■ 127.0.0.1:8000/cities/Paris/1924 — должна открыться
# страница с информацией о том, что происходило в
# Париже в 1924 году.
# ■ 127.0.0.1:8000/cities/Marseille/1956 — должна открыться
# страница с информацией о том, что происходило в
# Марселе в 1956 году.
# Если информации об указанном годе нет, необходимо
# делать переадресацию на страницу Города

from flask import Flask, redirect

app = Flask(__name__)


def get_navigation():
    return (
        "<nav>"
            "<a href='/'>Главная</a> | "
            "<a href='/history'>История</a> | "
            "<a href='/cities'>Города</a> | "
            "<a href='/facts'>Факты о стране</a>"        
        "</nav><hr>"
    )


@app.route("/")
def main():
    return get_navigation() + "<h1>Hello</h1>"


@app.route("/history")
def history():
    return get_navigation() + "<h1>History</h1>" + \
        """
        <nav>
            <a href='/history/1885'>1885</a> |
            <a href='/history/1914'>1914</a>
        </nav><hr>
        """        


@app.route("/history/<string:history_name>")
def history_options(history_name):
    history_info = {
        "1885": "1885",
        "1914": "1914",
    }
    if history_name in history_info.keys():
        return get_navigation() + f"<h1>{history_name}</h1>"    
    return redirect("/history")


@app.route("/cities")
def cities():
    return get_navigation() + "<h1>Cities</h1>" + \
        """
        <nav>
            <a href='/cities/Paris'>Paris</a> |
            <a href='/cities/Marseille'>Marseille</a>
        </nav><hr>
        """    


@app.route("/cities/<string:city_name>")
def cities_options(city_name):
    city_info = {
        "Paris": "Paris",
        "Marseille": "Marseille",
    }
    if city_name in city_info.keys():
        return get_navigation() + f"<h1>{city_name}</h1>" + \
            f"""
                <nav>
                    <a href='/cities/{city_name}/1885'>1885</a> |
                    <a href='/cities/{city_name}/1914'>1914</a>
                </nav><hr>
            """  
    return redirect("/cities")


@app.route("/cities/<string:city_name>/<string:city_name_year>")
def cities_options_years(city_name, city_name_year):
    city_years = {
        "1885": "Paris 1885",
        "1914": "Marseille",
    }
    if city_name_year in city_years.keys():
        return get_navigation() + f"<h1>{city_name} - {city_name_year}</h1>"  
    return redirect(f"/cities/{city_name}")


@app.route("/facts")
def facts():
    return get_navigation() + "<h1>Facts</h1>"


app.run()