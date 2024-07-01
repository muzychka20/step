USE Company2;
CREATE TABLE EmployeeProjects (
    EmployeeID int,
    FirstName varchar(255),
    LastName varchar(255),
    DepartmentID int,
    DepartmentName varchar(255),
    ProjectID int,
    ProjectName varchar(255)
);
INSERT INTO EmployeeProjects (EmployeeID, FirstName, LastName, DepartmentID, DepartmentName, ProjectID, ProjectName) VALUES
(101, 'John', 'Doe', 1, 'Human Resources', 201, 'Website Redesign'),
(102, 'Jane', 'Smith', 2, 'Finance', 202, 'Annual Budget'),
(103, 'Alice', 'Johnson', 3, 'IT', 203, 'Recruitment Drive'),
(104, 'Bob', 'Brown', 1, 'Human Resources', NULL, NULL); -- Bob не участвует в проектах
