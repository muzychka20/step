USE bookstore;

CREATE TABLE Author(
	author_id INT PRIMARY KEY AUTO_INCREMENT,
    name_author VARCHAR(50)
);

CREATE TABLE Book (
	book_id INT PRIMARY KEY AUTO_INCREMENT,
    name_book VARCHAR(50),
    genre VARCHAR(50),
    author_id INT,
    FOREIGN KEY (author_id) REFERENCES Author(author_id)
);

INSERT INTO Author (name_author) VALUES
('Stephen King'),
('J.K. Rowling'),
('George Orwell'),
('Harper Lee'),
('J.R.R. Tolkien'),
('Agatha Christie');

INSERT INTO Book (name_book, genre, author_id) VALUES
('The Shining', 'Horror', 1),
('Harry Potter and the Philosopher''s Stone', 'Fantasy', 2),
('1984', 'Dystopian', 3),
('To Kill a Mockingbird', 'Fiction', 4),
('The Lord of the Rings', 'Fantasy', 5),
('Murder on the Orient Express', 'Mystery', 6),
('It', 'Horror', 1),
('Harry Potter and the Chamber of Secrets', 'Fantasy', 2),
('Animal Farm', 'Political Satire', 3),
('The Hobbit', 'Fantasy', 5),
('And Then There Were None', 'Mystery', 6),
('Carrie', 'Horror', 1),
('Harry Potter and the Prisoner of Azkaban', 'Fantasy', 2),
('The Great Gatsby', 'Classic', 3),
('The Catcher in the Rye', 'Fiction', 4);

SELECT * FROM Book;
SELECT * FROM Author;

SELECT name_book, genre, name_author
FROM Book
JOIN Author ON Book.author_id = Author.author_id;

SELECT name_author, COUNT(*) AS 'Amount'
FROM Book
JOIN Author ON Book.author_id = Author.author_id
GROUP BY Book.author_id;

SELECT name_book, name_author
FROM Book
JOIN Author ON Book.author_id = Author.author_id
WHERE genre = 'Mystery';

SELECT name_book, name_author, genre
FROM Book
JOIN Author ON Book.author_id = Author.author_id
WHERE Author.name_author = 'Stephen King';