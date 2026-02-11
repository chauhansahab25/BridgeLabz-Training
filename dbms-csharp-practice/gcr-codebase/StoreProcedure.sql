------------------------------------------
-- 1. CREATE DATABASE
------------------------------------------
-- CREATE DATABASE database_name;
CREATE DATABASE SP_DB;

------------------------------------------
-- 2. USE DATABASE
------------------------------------------
-- USE database_name;
USE SP_DB;

------------------------------------------
-- 3. CREATE TABLE
------------------------------------------
-- CREATE TABLE table_name (
--   column datatype,
--   column datatype
-- );
CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT,
    Age INT,
    ManagerID INT
);

------------------------------------------
-- 4. STORED PROCEDURE : INSERT
------------------------------------------
-- INSERT using Stored Procedure
CREATE PROCEDURE InsertEmployee
    @EmpID INT,
    @EmpName VARCHAR(50),
    @Department VARCHAR(50),
    @Salary INT,
    @Age INT,
    @ManagerID INT
AS
BEGIN
    INSERT INTO Employees
    VALUES (@EmpID, @EmpName, @Department, @Salary, @Age, @ManagerID);
END;

------------------------------------------
-- 5. EXEC INSERT PROCEDURE
------------------------------------------
EXEC InsertEmployee 1, 'Rahul', 'IT', 40000, 25, NULL;
EXEC InsertEmployee 2, 'Ankit', 'HR', 30000, 28, 1;
EXEC InsertEmployee 3, 'Priya', 'IT', 50000, 26, 1;

------------------------------------------
-- 6. STORED PROCEDURE : SELECT ALL
------------------------------------------
CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT * FROM Employees;
END;

------------------------------------------
-- 7. EXEC SELECT PROCEDURE
------------------------------------------
EXEC GetAllEmployees;

------------------------------------------
-- 8. STORED PROCEDURE : SELECT WITH WHERE
------------------------------------------
CREATE PROCEDURE GetEmployeeByDept
    @Dept VARCHAR(50)
AS
BEGIN
    SELECT * FROM Employees
    WHERE Department = @Dept;
END;

------------------------------------------
-- 9. EXEC WHERE PROCEDURE
------------------------------------------
EXEC GetEmployeeByDept 'IT';

------------------------------------------
-- 10. STORED PROCEDURE : UPDATE
------------------------------------------
CREATE PROCEDURE UpdateSalary
    @EmpID INT,
    @NewSalary INT
AS
BEGIN
    UPDATE Employees
    SET Salary = @NewSalary
    WHERE EmpID = @EmpID;
END;

------------------------------------------
-- 11. EXEC UPDATE PROCEDURE
------------------------------------------
EXEC UpdateSalary 2, 35000;

------------------------------------------
-- 12. STORED PROCEDURE : DELETE
------------------------------------------
CREATE PROCEDURE DeleteEmployee
    @EmpID INT
AS
BEGIN
    DELETE FROM Employees
    WHERE EmpID = @EmpID;
END;

------------------------------------------
-- 13. EXEC DELETE PROCEDURE
------------------------------------------
EXEC DeleteEmployee 3;

------------------------------------------
-- 14. STORED PROCEDURE : AGGREGATE (COUNT)
------------------------------------------
CREATE PROCEDURE CountEmployees
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees;
END;

------------------------------------------
-- 15. EXEC COUNT PROCEDURE
------------------------------------------
EXEC CountEmployees;

------------------------------------------
-- 16. STORED PROCEDURE : AGGREGATE (SUM)
------------------------------------------
CREATE PROCEDURE TotalSalaryByDept
    @Dept VARCHAR(50)
AS
BEGIN
    SELECT SUM(Salary) AS TotalSalary
    FROM Employees
    WHERE Department = @Dept;
END;

------------------------------------------
-- 17. EXEC SUM PROCEDURE
------------------------------------------
EXEC TotalSalaryByDept 'IT';

------------------------------------------
-- 18. STORED PROCEDURE : SELF JOIN
------------------------------------------
CREATE PROCEDURE EmployeeManager
AS
BEGIN
    SELECT E.EmpName AS Employee, M.EmpName AS Manager
    FROM Employees E
    LEFT JOIN Employees M
    ON E.ManagerID = M.EmpID;
END;

------------------------------------------
-- 19. EXEC SELF JOIN PROCEDURE
------------------------------------------
EXEC EmployeeManager;

------------------------------------------
-- 20. DROP DATABASE
------------------------------------------
USE master;
ALTER DATABASE SP_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE SP_DB;