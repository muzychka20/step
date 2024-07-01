USE Company2;

SELECT Employees.FirstName, Employees.LastName, Departments.DepartmentName
FROM Employees
JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID;

CREATE TABLE Projects (
    ProjectID int PRIMARY KEY,
    ProjectName varchar(255),
    LeadID int,
    FOREIGN KEY (LeadID) REFERENCES Employees(EmployeeID)
);

INSERT INTO Projects (ProjectID, ProjectName, LeadID) VALUES
(201, 'Website Redesign', 103),
(202, 'Annual Budget', 102),
(203, 'Recruitment Drive', 101);

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID) VALUES
(110, 'Sash', 'Shishkanova', 3),
(111, 'Kyrylo', 'Muzychka', 3);

INSERT INTO Projects (ProjectID, ProjectName, LeadID) VALUES
(206, 'Sales', NULL),
(204, 'Sales', 110),
(205, 'Advertising', 111);

SELECT Projects.ProjectName, Employees.FirstName, Employees.LastName
FROM Projects
JOIN Employees ON Projects.LeadID = Employees.EmployeeID;

SELECT Projects.ProjectName, Employees.FirstName, Employees.LastName
FROM Projects
LEFT JOIN Employees ON Projects.LeadID = Employees.EmployeeID;
