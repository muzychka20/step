create database Demo1;
USE Demo1;
CREATE TABLE Departments (
    ID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
CREATE TABLE Employees (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(ID)
);
INSERT INTO Departments (ID, DepartmentName) VALUES (1, 'HR');
INSERT INTO Employees (ID, Name, DepartmentID) VALUES (1, 'John Doe', 1);
-- Этот запрос вызовет ошибку, потому что не существует отдела с ID = 999
INSERT INTO Employees (ID, Name, DepartmentID) VALUES (2, 'Jane Doe', 999);

INSERT INTO Departments (ID, DepartmentName) VALUES (2, 'Frontend');
INSERT INTO Employees (ID, Name, DepartmentID) VALUES (2, 'Mike Logan', 2);

INSERT INTO Departments (ID, DepartmentName) VALUES (3, 'Android');
INSERT INTO Employees (ID, Name, DepartmentID) VALUES (3, 'Sam Don', 3);


SELECT Employees.Name, Departments.DepartmentName
FROM Employees
INNER JOIN Departments ON Employees.DepartmentID = Departments.ID;
