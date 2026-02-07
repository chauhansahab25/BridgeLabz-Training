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

-- UC-1.1: Register New Patient
-- INSERT INTO patients (name, dob, phone, email, address, blood_group) VALUES (@name, @dob, @phone, @email, @address, @bloodGroup)

-- UC-1.2: Update Patient Information
-- UPDATE patients SET name = @name, phone = @phone, email = @email, address = @address, blood_group = @bloodGroup WHERE patient_id = @patientId

-- UC-1.3: Search Patient Records
-- SELECT * FROM patients WHERE name LIKE @search OR patient_id = @id OR phone = @search

SELECT * FROM patients;
