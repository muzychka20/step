use Demo2;
-- INNER JOIN: Возвращает строки, когда условие соответствия выполняется в обеих таблицах.
-- LEFT JOIN (LEFT OUTER JOIN): Возвращает все строки из левой таблицы, соответствующие строки из правой таблицы, и NULL в случае отсутствия соответствия.
-- RIGHT JOIN (RIGHT OUTER JOIN): Аналогично LEFT JOIN, но возвращает все строки из правой таблицы.
-- FULL JOIN (FULL OUTER JOIN): Возвращает строки, когда есть соответствие хотя бы в одной из таблиц.
-- CROSS JOIN: Возвращает декартово произведение двух таблиц, т.е. каждая строка одной таблицы соединяется с каждой строкой другой таблицы.


 -- INNER JOIN Возвращает строки, когда условие соответствия выполняется в обеих таблицах.
-- Описание: Получить имена сотрудников вместе с названиями их отделов. Этот запрос возвращает только те строки, где сотрудники привязаны к отделам.
SELECT Employees.Name, Departments.DepartmentName
FROM Employees
INNER JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID;

-- LEFT JOIN Возвращает все строки из левой таблицы, соответствующие строки из правой таблицы, и NULL в случае отсутствия соответствия.
-- Описание: Получить всех сотрудников и названия их отделов, включая тех, кто не привязан к какому-либо отделу. Сотрудники без отдела будут показаны с NULL в столбце 
SELECT Employees.Name, Departments.DepartmentName
FROM Employees
LEFT JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID;

-- RIGHT JOIN Аналогично LEFT JOIN, но возвращает все строки из правой таблицы.
-- Описание: Получить все отделы и имена сотрудников, которые к ним привязаны. Отделы без сотрудников также будут включены в результат с NULL в столбце Name.
SELECT Employees.Name, Departments.DepartmentName
FROM Employees
RIGHT JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID;

-- FULL JOIN Возвращает строки, когда есть соответствие хотя бы в одной из таблиц.
-- Описание: Получить список всех отделов и всех сотрудников, включая тех, кто не привязан к отделам, и отделы, к которым не привязаны сотрудники. 
-- Этот запрос дает полное представление о сотрудниках и отделах.
SELECT Employees.Name, Departments.DepartmentName
FROM Employees
FULL JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID;

SELECT E.Name AS EmployeeName, D.DepartmentName
FROM Employees E
LEFT JOIN Departments D ON E.DepartmentID = D.DepartmentID
UNION
SELECT E.Name AS EmployeeName, D.DepartmentName
FROM Employees E
RIGHT JOIN Departments D ON E.DepartmentID = D.DepartmentID;


-- CROSS JOIN Возвращает декартово произведение двух таблиц, т.е. каждая строка одной таблицы соединяется с каждой строкой другой таблицы.
-- Описание: Сгенерировать декартово произведение сотрудников и проектов, что даст все возможные комбинации сотрудников и проектов.
SELECT Employees.Name, Projects.ProjectName
FROM Employees
CROSS JOIN Projects;
