create database Demo2;
use Demo2;

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(100),
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY,
    ProjectName VARCHAR(100),
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES (1, 'IT');
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES (2, 'HR');
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES (3, 'Marketing');

INSERT INTO Employees (EmployeeID, Name, DepartmentID) VALUES (1, 'Alice', 1);
INSERT INTO Employees (EmployeeID, Name, DepartmentID) VALUES (2, 'Bob', 2);
INSERT INTO Employees (EmployeeID, Name, DepartmentID) VALUES (3, 'Charlie', 1);
INSERT INTO Employees (EmployeeID, Name, DepartmentID) VALUES (4, 'David', NULL); -- David не привязан к отделу

INSERT INTO Projects (ProjectID, ProjectName, DepartmentID) VALUES (1, 'Website Redesign', 1);
INSERT INTO Projects (ProjectID, ProjectName, DepartmentID) VALUES (2, 'New HR System', 2);
INSERT INTO Projects (ProjectID, ProjectName, DepartmentID) VALUES (3, 'Social Media Campaign', 3);
INSERT INTO Projects (ProjectID, ProjectName, DepartmentID) VALUES (4, 'Charity Event', NULL); -- Проект без отдела
