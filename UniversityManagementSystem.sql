-- DDL - Data Definition Language (CREATE, DROP, RENAME and ALTER) --
-- DML - Data Manipulation Language (INSERT, UPDATE and DELETE) --

-- STEP # 1: TO CREATE A DATABASE --
CREATE DATABASE UniversityManagementSystem;

-- STEP # 2: TO CREATE TABLES INSIDE A DATABASE --
-- WE USE PRIMARY KEY TO UNIQUELY SPECIFY A TUPLE (ROW). HERE, department_id IS PRIMARY KEY --
CREATE TABLE Department
(
department_id int PRIMARY KEY NOT NULL,
dep_name nvarchar(50) NOT NULL,
);

CREATE TABLE Students
(
s_id int PRIMARY KEY NOT NULL,
s_name nvarchar(50) NOT NULL,
dep_id int FOREIGN KEY REFERENCES Department (department_id),
s_address nvarchar(50) NOT NULL,
);

-- STEP # 3: TO ALTER VALUES IN A TABLE --
-- ADD --
ALTER TABLE Department ADD dep_head int NOT NULL;
-- EDIT --
ALTER TABLE Department ALTER COLUMN dep_head nvarchar(50) NOT NULL;
-- DROP --
ALTER TABLE Students DROP COLUMN s_address;

-- STEP # 4: TO INSERT VALUES INSIDE A TABLE --
INSERT INTO Department VALUES
(1, 'Avionics', 'Dr. Syed Arsalan Jawed'),
(2, 'COCIS', 'Dr. Husain Parvez'),
(3, 'Mechatronics', 'Dr. Muhammad Bilal Kadri'),
(5, 'Software Engineering', 'Dr. Muhammad Mazher Iqbal');

INSERT INTO Students VALUES
(1, 'Asad Sheikh', 2),
(2, 'Hadi Khan', 1),
(3, 'Sameer ul Haq', 3),
(4, 'Muzammil Ahmed', 2),
(5, 'Abdul Rafay', 1),
(6, 'Huzaifa Farooq', 2),
(7, 'Ali Tanveer', 3),
(8, 'Ibad Rizwan', 1),
(9, 'Momina Arshad', 3),
(10, 'Ismail Junaid', 1);

-- ANOTHER WAY TO INSERT VALUES INSIDE A TABLE --
INSERT INTO Students (s_id, s_name, dep_id) VALUES
(11, 'Osama Farooq', 2),
(12, 'Reshaile Khan', 3),
(13, 'Fahad Jawaid', 2),
(15, 'Hamzah Aalamgeir', 1);

-- STEP # 5: TO UPDATE VALUES IN A TABLE --
UPDATE Students SET s_id = 14, s_name = 'Hamza Alamgir' WHERE s_id = 15;
UPDATE Department SET department_id = 4 WHERE department_id = 5;

-- STEP # 6: TO DELETE VALUES FROM A TABLE --
DELETE FROM Department WHERE dep_name = 'Software Engineering';
DELETE FROM Students WHERE s_id = 14;

-- STEP # 7: TO SELECT VALUES FROM A TABLE --
SELECT * FROM Department;
SELECT * FROM Students;

-- STEP # 8: TO INNER JOIN TABLES --
SELECT s_id, s_name, dep_name, dep_head FROM Department INNER JOIN Students ON department_id = dep_id;

-- STEP # 9: TO DROP A TABLE --
DROP TABLE Students;
DROP TABLE Department;