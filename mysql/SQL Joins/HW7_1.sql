-- Создание базы данных
CREATE DATABASE Company2;
USE Company2;

CREATE TABLE Departments (
    DepartmentID int PRIMARY KEY,
    DepartmentName varchar(255)
);

CREATE TABLE Employees (
    EmployeeID int PRIMARY KEY,
    FirstName varchar(255),
    LastName varchar(255),
    DepartmentID int,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'Human Resources'),
(2, 'Finance'),
(3, 'IT');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID) VALUES
(101, 'John', 'Doe', 1),
(102, 'Jane', 'Smith', 2),
(103, 'Alice', 'Johnson', 3);


INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID) VALUES
(104, 'Sam', 'Maeve', 3),
(105, 'Kate', 'Charlotte', 3),
(106, 'Bob', 'Rory', 3),
(107, 'Thomas', 'Arrow', 2),
(108, 'Davis', 'Bennett', 2),
(109, 'Rowan', 'Adalet', 2);

SELECT Employees.FirstName, Employees.LastName, Departments.DepartmentName
FROM Employees
JOIN Departments ON Departments.DepartmentID = Employees.DepartmentID
WHERE Departments.DepartmentName = "IT";