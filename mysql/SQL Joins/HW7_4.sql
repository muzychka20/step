USE Company2;
CREATE TABLE EmployeeInfo (
    EmployeeID int PRIMARY KEY,
    FullName varchar(255),
    Details varchar(255)
);

INSERT INTO EmployeeInfo (EmployeeID, FullName, Details) VALUES
(101, 'John Doe', 'Department: Human Resources, Project: Website Redesign'),
(102, 'Jane Smith', 'Department: Finance, Project: Annual Budget'),
(103, 'Alice Johnson', 'Department: IT, Project: Recruitment Drive'),
(104, 'Bob Brown', 'Department: Human Resources, No project');