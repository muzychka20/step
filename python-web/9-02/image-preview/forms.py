from flask_wtf import FlaskForm
from wtforms import SubmitField, FileField
from wtforms.validators import DataRequired


class ImageForm(FlaskForm):
    file = FileField('Выберите файл', validators=[DataRequired()])
    submit = SubmitField('Сохранить')
