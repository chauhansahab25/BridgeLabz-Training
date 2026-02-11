------------------------------------------
-- 1. CREATE DATABASE
------------------------------------------
-- CREATE DATABASE database_name;
CREATE DATABASE AggregateDB;

------------------------------------------
-- 2. USE DATABASE
------------------------------------------
-- USE database_name;
USE AggregateDB;

------------------------------------------
-- 3. CREATE TABLE
------------------------------------------
-- CREATE TABLE table_name (
--   column datatype,
--   column datatype
-- );
CREATE TABLE Employees (
    EmpID INT,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT,
    Age INT
);

------------------------------------------
-- 4. INSERT DATA
------------------------------------------
-- INSERT INTO table_name VALUES (...);
INSERT INTO Employees VALUES (1, 'Lovish', 'IT', 40000, 25);
INSERT INTO Employees VALUES (2, 'Ankita', 'HR', 30000, 28);
INSERT INTO Employees VALUES (3, 'Priyanshu', 'IT', 50000, 26);
INSERT INTO Employees VALUES (4, 'Nehant', 'Finance', 45000, 30);
INSERT INTO Employees VALUES (5, 'Anamika', 'HR', 35000, 27);

------------------------------------------
-- 5. SELECT ALL DATA
------------------------------------------
-- SELECT * FROM table_name;
SELECT * FROM Employees;

------------------------------------------
-- 6. COUNT() FUNCTION
------------------------------------------
-- COUNT(column_name)
SELECT COUNT(EmpID) AS TotalEmployees
FROM Employees;

------------------------------------------
-- 7. SUM() FUNCTION
------------------------------------------
-- SUM(column_name)
SELECT SUM(Salary) AS TotalSalary
FROM Employees;

------------------------------------------
-- 8. AVG() FUNCTION
------------------------------------------
-- AVG(column_name)
SELECT AVG(Salary) AS AverageSalary
FROM Employees;

------------------------------------------
-- 9. MIN() FUNCTION
------------------------------------------
-- MIN(column_name)
SELECT MIN(Salary) AS MinimumSalary
FROM Employees;

------------------------------------------
-- 10. MAX() FUNCTION
------------------------------------------
-- MAX(column_name)
SELECT MAX(Salary) AS MaximumSalary
FROM Employees;

------------------------------------------
-- 11. COUNT() WITH WHERE
------------------------------------------
-- COUNT with condition
SELECT COUNT(*) AS IT_Employees
FROM Employees
WHERE Department = 'IT';

------------------------------------------
-- 12. SUM() WITH WHERE
------------------------------------------
-- SUM with condition
SELECT SUM(Salary) AS HR_TotalSalary
FROM Employees
WHERE Department = 'HR';

------------------------------------------
-- 13. AVG() WITH WHERE
------------------------------------------
-- AVG with condition
SELECT AVG(Age) AS AverageAge_IT
FROM Employees
WHERE Department = 'IT';

------------------------------------------
-- 14. AGGREGATE WITH GROUP BY
------------------------------------------
-- GROUP BY column
SELECT Department, COUNT(*) AS TotalEmployees
FROM Employees
GROUP BY Department;

------------------------------------------
-- 15. SUM WITH GROUP BY
------------------------------------------
-- SUM + GROUP BY
SELECT Department, SUM(Salary) AS DepartmentSalary
FROM Employees
GROUP BY Department;

------------------------------------------
-- 16. AVG WITH GROUP BY
------------------------------------------
-- AVG + GROUP BY
SELECT Department, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY Department;

------------------------------------------
-- 17. GROUP BY WITH HAVING
------------------------------------------
-- HAVING condition on aggregate
SELECT Department, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY Department
HAVING AVG(Salary) > 40000;

------------------------------------------
-- 18. DELETE TABLE DATA
------------------------------------------
-- DELETE FROM table_name;
DELETE FROM Employees;

------------------------------------------
-- 19. DROP TABLE
------------------------------------------
-- DROP TABLE table_name;
DROP TABLE Employees;

------------------------------------------
-- 20. DROP DATABASE
------------------------------------------
-- DROP DATABASE database_name;
USE master;
ALTER DATABASE AggregateDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE AggregateDB;