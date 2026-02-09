------------------------------------------
-- 1. CREATE DATABASE
------------------------------------------
-- CREATE DATABASE database_name;

CREATE DATABASE StudentDB;

------------------------------------------
-- 2. USE DATABASE
------------------------------------------
-- USE database_name;
USE StudentDB;

------------------------------------------
-- 3. CREATE TABLE
----------------------
--------------------
-- CREATE TABLE table_name (
--   column datatype,
--   column datatype
-- );

CREATE TABLE Students (
    StudentID INT,
    Name VARCHAR(50),
    Age INT,
    Course VARCHAR(50)
);
------------------------------------------
-- 4. ALTER TABLE – ADD COLUMN
------------------------------------------
-- ALTER TABLE table_name ADD column datatype;
ALTER TABLE Students
ADD Email VARCHAR(100);
------------------------------------------
-- 5. ALTER TABLE – ALTER COLUMN
------------------------------------------
-- ALTER TABLE table_name ALTER COLUMN column datatype;
ALTER TABLE Students
ALTER COLUMN Name VARCHAR(100);
------------------------------------------
-- 6. ALTER TABLE – DROP COLUMN
------------------------------------------
-- ALTER TABLE table_name DROP COLUMN column;
ALTER TABLE Students
DROP COLUMN Email;

------------------------------------------
-- 7. INSERT DATA
------------------------------------------
-- INSERT INTO table_name VALUES (value1, value2, ...);
INSERT INTO Students VALUES (1, 'Rahul', 20, 'BCA');
INSERT INTO Students VALUES (2, 'Ankit', 21, 'BTech');
INSERT INTO Students VALUES (3, 'Priya', 19, 'BSc');


------------------------------------------
-- 8. SELECT DATA
------------------------------------------
-- SELECT * FROM table_name;
SELECT * FROM Students;

------------------------------------------
-- 9. SELECT WITH WHERE
------------------------------------------
-- SELECT * FROM table_name WHERE condition;
SELECT * FROM Students WHERE Age > 20;

------------------------------------------
-- 10. UPDATE DATA
------------------------------------------
-- UPDATE table_name SET column=value WHERE condition;
UPDATE Students
SET Course = 'MCA'
WHERE StudentID = 1;

------------------------------------------
-- 11. DELETE DATA
------------------------------------------
-- DELETE FROM table_name WHERE condition;
DELETE FROM Students WHERE StudentID = 3;

------------------------------------------
-- 12. TRUNCATE TABLE
------------------------------------------
-- TRUNCATE TABLE table_name;
TRUNCATE TABLE Students;

------------------------------------------
-- 13. DROP TABLE
------------------------------------------
-- DROP TABLE table_name;
DROP TABLE Students;

------------------------------------------
-- 14. DROP DATABASE
------------------------------------------
-- DROP DATABASE database_name;
use master;

ALTER DATABASE StudentDB
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;

DROP DATABASE StudentDB;






