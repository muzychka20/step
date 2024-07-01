CREATE DATABASE BooksDB;

USE BooksDB;

CREATE TABLE Books (
	book_id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(100),
    author VARCHAR(100)
);

CREATE TABLE Warehouse (
	warehouse_id INT PRIMARY KEY AUTO_INCREMENT,
    amount INT    
);

CREATE TABLE  Shop (
	shop_id INT PRIMARY KEY AUTO_INCREMENT,
    price INT
);

INSERT INTO Books (title, author) VALUES 
('Book 1', 'Author 1'),
('Book 2', 'Author 2'),
('Book 3', 'Author 3'),
('Book 4', 'Author 4'),
('Book 5', 'Author 5'),
('Book 6', 'Author 1');

INSERT INTO Warehouse (amount) VALUES 
(10),
(20),
(15),
(30),
(25);

INSERT INTO Shop (price) VALUES 
(100),
(150),
(200),
(250),
(300);

SELECT * FROM Books;
SELECT * FROM Warehouse;
SELECT * FROM Shop;

-- количество книг на складе
SELECT SUM(amount) AS 'Количество книг на складе' FROM Warehouse;

-- максимальная минимальная цена
SELECT MIN(price) AS 'Максимальная цена', MAX(price) AS 'Минимальная цена' FROM Shop;

-- минимальное максимальное количество книг на складе
SELECT MIN(amount) AS 'Минимальное количество книг на складе', MAX(amount) AS 'Максимальное количество книг на складе' FROM Warehouse;

-- количество книг автора
SELECT COUNT(*) AS 'Количество книг автора - Author 1'
FROM Books
WHERE author = 'Author 1';
