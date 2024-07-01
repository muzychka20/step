CREATE DATABASE BankAccounts;

USE BankAccounts;

CREATE TABLE FIO (
	fio_id INT PRIMARY KEY AUTO_INCREMENT,
	fio_name VARCHAR(100),
    fio_surname VARCHAR(100)
);

CREATE TABLE Card (
	card_id INT PRIMARY KEY AUTO_INCREMENT,
    card_number INT,
    card_type VARCHAR(100),
    cvv INT
);

CREATE TABLE Account(
	account_id INT PRIMARY KEY AUTO_INCREMENT,
    summa INT,
    blocked BOOLEAN,
    card_fk INT,
    fio_fk INT,
    FOREIGN KEY (card_fk) REFERENCES Card(card_id),
	FOREIGN KEY (fio_fk) REFERENCES FIO(fio_id)
);

INSERT INTO FIO (fio_name, fio_surname) VALUES 
('Иван', 'Иванов'),
('Петр', 'Петров'),
('Мария', 'Сидорова'),
('Анна', 'Павлова'),
('Сергей', 'Козлов');

INSERT INTO Card (card_number, card_type, cvv) VALUES 
(123456789, 'credit', 123),
(987654321, 'debit', 456),
(555566667, 'credit', 789),
(111122223, 'credit', 321),
(888877776, 'debit', 654);

INSERT INTO Account (summa, blocked, card_fk, fio_fk) VALUES 
(10000, FALSE, 1, 1),
(5000, FALSE, 2, 2),
(7500, TRUE, 3, 3),
(20000, FALSE, 4, 4),
(15000, TRUE, 5, 5);

SELECT FIO.fio_name, FIO.fio_surname, Account.blocked, Account.summa, Card.card_number, Card.card_type, Card.cvv
FROM Account
JOIN FIO ON FIO.fio_id = Account.fio_fk
JOIN Card ON Card.card_id = Account.card_fk;

UPDATE Account
SET summa = 1
WHERE account_id = 1;

UPDATE Account
SET blocked = true
WHERE account_id = 1;

UPDATE FIO
JOIN Account ON FIO.fio_id = Account.fio_fk
SET FIO.fio_name = 'test'
WHERE account_id = 1;

UPDATE FIO
JOIN Account ON FIO.fio_id = Account.fio_fk
SET FIO.fio_surname = 'TEST'
WHERE account_id = 1;

UPDATE Card
JOIN Account ON Card.card_id = Account.card_fk
SET Card.card_number = 12344321,
	Card.card_type = 'debit',
    Card.cvv = 999
WHERE account_id = 1;

SELECT * FROM Account;
SELECT * FROM FIO;
SELECT * FROM Card;