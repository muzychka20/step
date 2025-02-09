import os

BASE_DIR = os.path.abspath(os.path.dirname(__file__))


class Config:
    SECRET_KEY = 'your_secret_key'
    UPLOAD_FOLDER = os.path.join(BASE_DIR, 'static/uploads')
