
create database JoinDB;
use JoinDB;
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name NVARCHAR(50)
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID INT, 
    CourseName NVARCHAR(50)
);
INSERT INTO Students VALUES (1, 'Rishita'), (2, 'Dev'), (3, 'Rama');
INSERT INTO Enrollments VALUES (101, 1, 'Math'), (102, 2, 'History'), (103, 99, 'Physics');

---------------------------------------------------------
-- 1. INNER JOIN
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM TableA INNER JOIN TableB ON TableA.Key = TableB.Key;
-- Goal: Returns only records where there is a match in BOTH tables.

SELECT S.Name, E.CourseName
FROM Students S
INNER JOIN Enrollments E ON S.StudentID = E.StudentID;



---------------------------------------------------------
-- 2. LEFT JOIN (LEFT OUTER JOIN)
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM TableA LEFT JOIN TableB ON TableA.Key = TableB.Key;
-- Goal: Returns all from the left table and matched from the right. Unmatched show NULL.

SELECT S.Name, E.CourseName
FROM Students S
LEFT JOIN Enrollments E ON S.StudentID = E.StudentID;



---------------------------------------------------------
-- 3. RIGHT JOIN (RIGHT OUTER JOIN)
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM TableA RIGHT JOIN TableB ON TableA.Key = TableB.Key;
-- Goal: Returns all from the right table and matched from the left.

SELECT S.Name, E.CourseName
FROM Students S
RIGHT JOIN Enrollments E ON S.StudentID = E.StudentID;

---------------------------------------------------------
-- 4. FULL JOIN (FULL OUTER JOIN)
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM TableA FULL OUTER JOIN TableB ON TableA.Key = TableB.Key;
-- Goal: Returns all records when there is a match in either left or right table.

SELECT S.Name, E.CourseName
FROM Students S
FULL OUTER JOIN Enrollments E ON S.StudentID = E.StudentID;



---------------------------------------------------------
-- 5. CROSS JOIN
---------------------------------------------------------
-- SYNTAX: SELECT cols FROM TableA CROSS JOIN TableB;
-- Goal: Returns the Cartesian product (every combination of both tables).

SELECT S.Name, E.CourseName
FROM Students S
CROSS JOIN Enrollments E;

---------------------------------------------------------
-- 6. SELF JOIN
---------------------------------------------------------
-- SYNTAX: SELECT A.col, B.col FROM TableA A JOIN TableA B ON A.ID = B.RefID;
-- Goal: Joins a table to itself to show relationships within the same data.

CREATE TABLE Employees (EmpID INT, Name NVARCHAR(50), ManagerID INT);
INSERT INTO Employees VALUES (1, 'Director Sarah', NULL), (2, 'Manager Mike', 1), (3, 'Worker Tim', 2);

SELECT E.Name AS Employee, M.Name AS Manager
FROM Employees E
LEFT JOIN Employees M ON E.ManagerID = M.EmpID;

DROP TABLE Students;
DROP TABLE Enrollments;
DROP TABLE Employees;

USE master;
ALTER DATABASE JoinDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE JoinDB;