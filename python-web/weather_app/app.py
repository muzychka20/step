from flask import Flask, render_template, request
import requests

app = Flask(__name__)

# Замените 'your_api_key' на ваш ключ API от OpenWeatherMap
API_KEY = ''
BASE_URL = 'http://api.openweathermap.org/data/2.5/weather'
FORECAST_URL = 'http://api.openweathermap.org/data/2.5/forecast'


@app.route('/', methods=['GET', 'POST'])
def index():
    weather_data = None
    forecast_data = None
    if request.method == 'POST':
        city = request.form['city']
        weather_data = get_weather(city)
        forecast_data = get_forecast(city)
    return render_template('index.html', weather=weather_data, forecast=forecast_data)


def get_weather(city):
    params = {
        'q': city,
        'appid': API_KEY,
        'units': 'metric'
    }
    response = requests.get(BASE_URL, params=params)
    return response.json()


def get_forecast(city):
    params = {
        'q': city,
        'appid': API_KEY,
        'units': 'metric'
    }
    response = requests.get(FORECAST_URL, params=params)
    return response.json()


if __name__ == '__main__':
    app.run(debug=True)
