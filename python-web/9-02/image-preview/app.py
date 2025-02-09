import os
from datetime import datetime
from flask import Flask, render_template, request, redirect, url_for, session
from werkzeug.utils import secure_filename
from forms import ImageForm
from config import Config


app = Flask(__name__)
app.config.from_object(Config)


@app.route('/', methods=['GET', 'POST'])
def index():
    form = ImageForm()
    if request.method == 'POST' and form.validate_on_submit():
        file = form.file.data
        filename = secure_filename(datetime.now().strftime(
            "%Y%m%d%H%M%S") + "_" + file.filename)
        file.save(os.path.join(app.config['UPLOAD_FOLDER'], filename))
        return redirect(url_for('index'))
    path = "./static/uploads"
    dir_list = os.listdir(path)
    images = {i: path + '/' + file for i, file in enumerate(dir_list)}
    return render_template('index.html', form=form, images=images)


if __name__ == '__main__':
    app.run(debug=True)
