import os
from flask import Flask, render_template, request, redirect, url_for, flash
from flask_sqlalchemy import SQLAlchemy
from werkzeug.utils import secure_filename
from config import Config
from models import db, Book, Review
from forms import BookForm

app = Flask(__name__)
app.config.from_object(Config)
db.init_app(app)

# Создание базы данных
with app.app_context():
    db.create_all()

def allowed_file(filename):
    return '.' in filename and filename.rsplit('.', 1)[1].lower() in Config.ALLOWED_EXTENSIONS

@app.route('/')
def index():
    genre = request.args.get('genre', 'Все')
    sort_by = request.args.get('sort', 'rating')

    books = Book.query
    if genre != 'Все':
        books = books.filter_by(genre=genre)

    if sort_by == 'rating':
        books = books.order_by(Book.rating.desc())
    elif sort_by == 'year':
        books = books.order_by(Book.year.desc())

    return render_template('index.html', books=books.all())

@app.route('/add', methods=['GET', 'POST'])
def add_book():
    form = BookForm()
    if form.validate_on_submit():
        file = form.cover_image.data
        filename = 'default.jpg'

        if file and allowed_file(file.filename):
            filename = secure_filename(file.filename)
            file.save(os.path.join(app.config['UPLOAD_FOLDER'], filename))

        book = Book(
            title=form.title.data,
            author=form.author.data,
            year=form.year.data,
            genre=form.genre.data,
            cover_image=filename
        )
        db.session.add(book)
        db.session.commit()
        flash('Книга добавлена!', 'success')
        return redirect(url_for('index'))

    return render_template('add_book.html', form=form)

@app.route('/book/<int:book_id>', methods=['GET', 'POST'])
def book_details(book_id):
    book = Book.query.get_or_404(book_id)

    if request.method == 'POST':
        text = request.form.get('text')
        rating = int(request.form.get('rating'))
        review = Review(book_id=book.id, text=text, rating=rating)
        db.session.add(review)

        # Обновляем средний рейтинг книги
        reviews = Review.query.filter_by(book_id=book.id).all()
        book.rating = sum(r.rating for r in reviews) / len(reviews)
        db.session.commit()

        flash('Отзыв добавлен!', 'success')
        return redirect(url_for('book_details', book_id=book.id))

    return render_template('book_details.html', book=book)