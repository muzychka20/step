CREATE DATABASE carsalon; 

USE carsalon;

SET SQL_SAFE_UPDATES = 0;

CREATE TABLE car(
	CarID INT AUTO_INCREMENT PRIMARY KEY,
    Make VARCHAR(50),
    Model VARCHAR(50),
    Year INT,
    Color VARCHAR(30)
);

CREATE TABLE carsalon.vehicle (
	VehicleID INT AUTO_INCREMENT PRIMARY KEY,
    Make VARCHAR(50),
    Model VARCHAR(50),
    Year INT,
    Color VARCHAR(30)
);

DROP TABLE carsalon.vehicle;

INSERT INTO car (Make, Model, Year, Color) VALUES
('Toyota', 'Camry', 2020, 'Black'),
('Skoda', 'Octavia', 2018, 'Black'),
('Skoda', 'Fabia', 2021, 'Red'),
('Audi', 'A4', 2022, 'Grey'),
('Volkswagen', 'Passat', 2014, 'Grey');

DELETE FROM car WHERE CarID = 3;

SELECT * FROM car;


CREATE TABLE Employees (
	EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Position VARCHAR(50),
    Department VARCHAR(50),
    Salary INT
);

INSERT INTO Employees(FirstName, LastName, Position, Department, Salary) VALUES
('John', 'Doe', 'Manager', 'Marketing', 70000),
('Jane', 'Doe', 'Assistnat', 'Marketing', 45000),
('Jin', 'Bean', 'Developer', 'IT', 80000),
('Jill', 'Valentine', 'Designer', 'IT', 75000);

SELECT FirstName, LastName FROM Employees;

SELECT Department FROM Employees;

SELECT LastName 
FROM Employees
WHERE FirstName = 'John';

INSERT INTO Employees(FirstName, LastName, Position, Department, Salary) VALUES
('Tim', 'Doe', 'Manager', 'Marketing', 70000),
('Tim', 'Bean', 'Designer', 'IT', 60000),
('Tim', 'Lev', 'Developer', 'IT', 50000);

SELECT * 
FROM Employees
WHERE FirstName = 'Tim';

SELECT FirstName, LastName, Salary
FROM Employees
WHERE FirstName = 'Tim'
AND Salary = 70000;



SELECT *
FROM Employees
WHERE Salary < 65000;



SELECT *
FROM Employees
WHERE Salary > 65000;

SELECT *
FROM Employees
WHERE Salary = 70000;

DELETE FROM Employees
WHERE Salary = 70000;

UPDATE Employees
SET Salary = 75000
WHERE FirstName = 'Tim';

SELECT * 
FROM Employees
WHERE FirstName = 'Tim'; 

UPDATE Employees
SET Salary = 50000
WHERE LastName = 'Bean'
AND Department = 'IT';

SELECT * 
FROM Employees
WHERE LastName = 'Bean'
AND Department = 'IT';

SELECT *
FROM Employees
ORDER BY Salary ASC;

SELECT LastName, Salary
FROM Employees
ORDER BY Salary DESC;

SELECT * 
FROM Employees
WHERE Department = 'IT'; 


SELECT FirstName
FROM Employees
GROUP BY FirstName;

SELECT FirstName, COUNT(*) AS NumberOfEmployees
FROM Employees
GROUP BY FirstName;

SELECT COUNT(*) FROM Employees;
SELECT * FROM Employees;

SELECT COUNT(*)
FROM Employees
WHERE Department = 'IT';


SELECT *
FROM Employees
WHERE FirstName LIKE 'J%';


CREATE TABLE Pets(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50),
    age INT,
    species VARCHAR(50),
    color VARCHAR(50),
    weight INT,
    type VARCHAR(50)
);

INSERT INTO Pets (name, age, species, color, weight, type) VALUES
('Lucky', 7, 'Labrador', 'Brown', 13, 'Dog'),
('Max', 3, 'Labrador', 'Brown', 10, 'Dog'),
('Bella', 2, 'Persian', 'White', 5, 'Cat'),
('Charlie', 5, 'German Shepherd', 'Black', 12, 'Dog'),
('Lucy', 1, 'Dwarf', 'Gray', 2, 'Rabbit'),
('Buddy', 4, 'Golden Retriever', 'Golden', 8, 'Dog'),
('Luna', 3, 'Siamese', 'Gray', 6, 'Cat'),
('Daisy', 2, 'Poodle', 'White', 7, 'Dog'),
('Milo', 6, 'Parakeet', 'Green', 1, 'Parrot'),
('Sadie', 2, 'Tabby', 'Orange', 4, 'Cat'),
('Bailey', 7, 'Dalmatian', 'Spotted', 11, 'Dog'),
('Oliver', 2, 'Syrian', 'Brown', 0.5, 'Hamster'),
('Chloe', 3, 'Maine Coon', 'Black', 5, 'Cat'),
('Rocky', 4, 'Red-eared Slider', 'Green', 3, 'Turtle'),
('Molly', 2, 'Beagle', 'Brown', 6, 'Dog'),
('Jack', 1, 'Abyssinian', 'Brown', 1, 'Guinea Pig'),
('Sophie', 5, 'Ragdoll', 'Calico', 7, 'Cat'),
('Toby', 8, 'Boxer', 'Brown', 15, 'Dog'),
('Coco', 2, 'Sable', 'White', 2, 'Ferret'),
('Leo', 3, 'American Shorthair', 'Orange', 4, 'Cat'),
('Bella', 4, 'Python', 'Brown', 2, 'Snake');

SELECT * FROM Pets;



SELECT *
FROM Pets
WHERE type = 'Cat';

SELECT *
FROM Pets
WHERE type = 'Cat'
AND color = 'Orange';

UPDATE Pets
SET weight = 5
WHERE id = 9;

DELETE FROM Pets
WHERE id = 3;

SELECT *
FROM Pets
WHERE age > 5;

SELECT *
FROM Pets
ORDER BY weight ASC;

SELECT *
FROM Pets
ORDER BY weight DESC
LIMIT 3;

SELECT type, COUNT(*) AS Amount
FROM Pets
GROUP BY type;

SELECT *
FROM Pets
WHERE species = 'Labrador'
AND weight IN (SELECT MIN(weight) FROM Pets WHERE species = 'Labrador');