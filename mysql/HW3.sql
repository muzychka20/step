CREATE DATABASE BookStore;

USE BookStore;

CREATE TABLE Books(	
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    title CHAR(50) NOT NULL,
    author CHAR(50) NOT NULL,
    price INT NOT NULL
);

INSERT INTO Books (title, author, price)
VALUES('Green Mile', 'Stephen King', 17),
	  ('The Casal Vacancy', 'J.K.Rowling', 23);

UPDATE Books 
SET title = 'The Casual Vacancy' WHERE id = 1;

DELETE FROM Books
WHERE id = 2;

SELECT * FROM Books;
