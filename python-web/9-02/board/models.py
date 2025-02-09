from flask_sqlalchemy import SQLAlchemy


db = SQLAlchemy()


class Category(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    category_name = db.Column(db.String(120), nullable=False)


class Ad(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String(120), nullable=False)
    description = db.Column(db.Text, nullable=False)
    contact_info = db.Column(db.String(120), nullable=False)
    image_filename = db.Column(db.String(120), nullable=True)

    category_id = db.Column(db.Integer, db.ForeignKey(
        'category.id'), nullable=False)
    category = db.relationship('Category', backref='ads', lazy=True)

    def __repr__(self):
        return f"Ad('{self.title}', '{self.category}')"


class Response(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(100), nullable=False)
    message = db.Column(db.Text, nullable=False)

    ad_id = db.Column(db.Integer, db.ForeignKey('ad.id'), nullable=False)
    ad = db.relationship('Ad', backref='responses', lazy=True)

    def __repr__(self):
        return f"Response('{self.name}', '{self.ad.title}')"
