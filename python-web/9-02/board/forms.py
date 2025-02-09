from flask_wtf import FlaskForm
from wtforms import StringField, TextAreaField, SubmitField, FileField, SelectField
from wtforms.validators import DataRequired
from flask_wtf.file import FileRequired, FileAllowed


class AdForm(FlaskForm):
    title = StringField('Title', validators=[DataRequired()])
    description = TextAreaField('Description', validators=[DataRequired()])
    contact_info = StringField('Contact Info', validators=[DataRequired()])

    image = FileField('Image', validators=[
        FileAllowed(['jpg', 'jpeg', 'png'], 'Only image files are allowed'),
        FileRequired('File was empty')
    ])

    category_id = SelectField('Category', coerce=int, choices=[])
    submit = SubmitField('Add')

    def populate_categories(self, categories):
        self.category_id.choices = [
            (category.id, category.category_name) for category in categories]


class ResponseForm(FlaskForm):
    name = StringField('Your Name', validators=[DataRequired()])
    message = TextAreaField('Your Message', validators=[DataRequired()])
    submit = SubmitField('Send Response')
