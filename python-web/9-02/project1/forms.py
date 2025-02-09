from flask_wtf import FlaskForm
from wtforms import StringField, IntegerField, SelectField, SubmitField, FileField
from wtforms.validators import DataRequired, NumberRange

class BookForm(FlaskForm):
    title = StringField('Название', validators=[DataRequired()])
    author = StringField('Автор', validators=[DataRequired()])
    year = IntegerField('Год издания', validators=[DataRequired(), NumberRange(min=0, max=2025)])
    genre = SelectField('Жанр', choices=[('Фантастика', 'Фантастика'), ('Детектив', 'Детектив'), ('Роман', 'Роман')])
    cover_image = FileField('Обложка')
    submit = SubmitField('Добавить книгу')