CREATE DATABASE HealthClinicDB;
USE HealthClinicDB;

CREATE TABLE patients (
    patient_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    dob DATE NOT NULL,
    phone NVARCHAR(10) UNIQUE NOT NULL,
    email NVARCHAR(100) UNIQUE NOT NULL,
    address NVARCHAR(255),
    blood_group NVARCHAR(5)
);


SELECT * FROM patients;