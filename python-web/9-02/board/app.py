import os
from flask import Flask, render_template, request, redirect, url_for
from werkzeug.utils import secure_filename
from config import Config
from models import db, Ad, Category, Response
from forms import AdForm, ResponseForm


app = Flask(__name__)
app.config.from_object(Config)
db.init_app(app)


def db_populate_categories():
    categories = ['Real Estate', 'Electronics', 'Jobs', 'Services', 'For Sale']
    for category_name in categories:
        category = Category(category_name=category_name)
        db.session.add(category)
    db.session.commit()


def allowed_file(filename):
    return '.' in filename and filename.rsplit('.', 1)[1].lower() in Config.ALLOWED_EXTENSIONS


@app.route('/', methods=['GET', 'POST'])
def index():
    category_id = request.args.get('category_id')
    categories = Category.query.all()
    if category_id:
        ads = Ad.query.filter_by(category_id=category_id).all()
    else:
        ads = Ad.query.all()
    return render_template('index.html', ads=ads, categories=categories, category_id=category_id)


@app.route('/add_ad', methods=['GET', 'POST'])
def add_ad():
    form = AdForm()
    categories = Category.query.all()
    form.populate_categories(categories)
    if form.validate_on_submit():
        if form.image.data:
            image = form.image.data
            image_filename = secure_filename(image.filename)
            image_path = os.path.join(
                app.config['UPLOAD_FOLDER'], image_filename)
            image.save(image_path)
        new_ad = Ad(
            title=form.title.data,
            description=form.description.data,
            contact_info=form.contact_info.data,
            image_filename=image_filename,
            category_id=form.category_id.data
        )
        db.session.add(new_ad)
        db.session.commit()
        return redirect(url_for('index'))
    return render_template('add_ad.html', form=form)


@app.route('/respond/<int:ad_id>', methods=['GET', 'POST'])
def respond_to_ad(ad_id):
    ad = Ad.query.filter_by(id=ad_id)
    form = ResponseForm()
    if form.validate_on_submit():
        response = Response(name=form.name.data,
                            message=form.message.data, ad_id=ad_id)
        db.session.add(response)
        db.session.commit()
        return redirect(url_for('index'))
    return render_template('respond_to_ad.html', form=form, ad=ad)


if __name__ == '__main__':
    app.run(debug=True)
    with app.app_context():
        db.create_all()
        db_populate_categories()
