from flask import Flask, render_template, request, send_file, redirect, url_for
from PIL import Image
from fpdf import FPDF
from docx import Document
import os

app = Flask(__name__)
app.config['UPLOAD_FOLDER'] = 'static/uploads/'
app.config['ALLOWED_EXTENSIONS'] = {'png', 'jpg', 'jpeg', 'docx'}

# Создание папки, если она не существует
if not os.path.exists(app.config['UPLOAD_FOLDER']):
    os.makedirs(app.config['UPLOAD_FOLDER'])

# Проверка допустимых расширений файлов


def allowed_file(filename):
    return '.' in filename and filename.rsplit('.', 1)[1].lower() in app.config['ALLOWED_EXTENSIONS']

# Конвертация изображения в PDF


def convert_image_to_pdf(image_path, output_path):
    image = Image.open(image_path)
    pdf = FPDF()
    pdf.add_page()
    pdf.image(image_path, x=10, y=10, w=190)
    pdf.output(output_path, "F")

# Конвертация .docx в PDF


def convert_docx_to_pdf(docx_path, output_path):
    doc = Document(docx_path)  # Чтение .docx файла
    pdf = FPDF()
    pdf.add_page()
    
    # Добавление внешнего шрифта с поддержкой кириллицы (например, DejaVuSans.ttf)
    pdf.add_font('DejaVuSans', '', "/Users/muzychka/Documents/djsans/DejaVuSans.ttf", uni=True)  # Указание шрифта с поддержкой Unicode
    pdf.set_font('DejaVuSans', size=12)

    # Adding text from the .docx to the PDF
    for paragraph in doc.paragraphs:        
        pdf.multi_cell(0, 10, paragraph.text)
        pdf.ln()  # New line

    pdf.output(output_path, "F")


@app.route('/', methods=['GET', 'POST'])
def index():
    if request.method == 'POST':
        # Проверка, что файл был загружен
        if 'file' not in request.files:
            return redirect(request.url)
        file = request.files['file']
        if file.filename == '':
            return redirect(request.url)
        if file and allowed_file(file.filename):
            # Сохранение файла
            filename = file.filename
            filepath = os.path.join(app.config['UPLOAD_FOLDER'], filename)
            file.save(filepath)

            # Определение типа файла и конвертация
            if filename.endswith('.docx'):
                pdf_path = os.path.join(
                    app.config['UPLOAD_FOLDER'], filename.rsplit('.', 1)[0] + '.pdf')
                convert_docx_to_pdf(filepath, pdf_path)
            else:  # Для изображений
                pdf_path = os.path.join(
                    app.config['UPLOAD_FOLDER'], filename.rsplit('.', 1)[0] + '.pdf')
                convert_image_to_pdf(filepath, pdf_path)

            return send_file(pdf_path, as_attachment=True)
    return render_template('index.html')


if __name__ == '__main__':
    app.run(debug=True)
