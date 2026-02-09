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

CREATE TABLE specialties (
    specialty_id INT PRIMARY KEY IDENTITY(1,1),
    specialty_name NVARCHAR(100) NOT NULL
);

CREATE TABLE doctors (
    doctor_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    specialty_id INT,
    phone NVARCHAR(10),
    consultation_fee DECIMAL(10,2),
    is_active BIT DEFAULT 1,
    FOREIGN KEY (specialty_id) REFERENCES specialties(specialty_id)
);

CREATE TABLE appointments (
    appointment_id INT PRIMARY KEY IDENTITY(1,1),
    patient_id INT,
    doctor_id INT,
    appointment_date DATE,
    appointment_time TIME,
    status NVARCHAR(20),
    FOREIGN KEY (patient_id) REFERENCES patients(patient_id),
    FOREIGN KEY (doctor_id) REFERENCES doctors(doctor_id)
);

CREATE TABLE appointment_audit (
    audit_id INT PRIMARY KEY IDENTITY(1,1),
    appointment_id INT,
    action NVARCHAR(50),
    action_date DATETIME
);

CREATE TABLE visits (
    visit_id INT PRIMARY KEY IDENTITY(1,1),
    appointment_id INT,
    patient_id INT,
    doctor_id INT,
    visit_date DATE,
    diagnosis NVARCHAR(500),
    notes NVARCHAR(1000),
    FOREIGN KEY (appointment_id) REFERENCES appointments(appointment_id),
    FOREIGN KEY (patient_id) REFERENCES patients(patient_id),
    FOREIGN KEY (doctor_id) REFERENCES doctors(doctor_id)
);

-- UC-1.1: Register New Patient
-- INSERT INTO patients (name, dob, phone, email, address, blood_group) VALUES (@name, @dob, @phone, @email, @address, @bloodGroup)

-- UC-1.2: Update Patient Information
-- UPDATE patients SET name = @name, phone = @phone, email = @email, address = @address, blood_group = @bloodGroup WHERE patient_id = @patientId

-- UC-1.3: Search Patient Records
-- SELECT * FROM patients WHERE name LIKE @search OR patient_id = @id OR phone = @search

-- UC-1.4: View Patient Visit History
-- SELECT a.appointment_date, a.appointment_time, d.name AS doctor_name, v.diagnosis, v.notes FROM visits v JOIN appointments a ON v.appointment_id = a.appointment_id JOIN doctors d ON v.doctor_id = d.doctor_id WHERE v.patient_id = @patientId ORDER BY v.visit_date DESC

-- UC-2.1: Add Doctor Profile
-- INSERT INTO doctors (name, specialty_id, phone, consultation_fee) VALUES (@name, @specialtyId, @phone, @fee)

-- UC-2.2: Assign/Update Doctor Specialty
-- UPDATE doctors SET specialty_id = @specialtyId WHERE doctor_id = @doctorId

-- UC-2.3: View Doctors by Specialty
-- SELECT d.doctor_id, d.name, d.phone, d.consultation_fee FROM doctors d JOIN specialties s ON d.specialty_id = s.specialty_id WHERE s.specialty_name = @specialtyName AND d.is_active = 1

-- UC-2.4: Deactivate Doctor Profile
-- SELECT COUNT(*) FROM appointments WHERE doctor_id = @doctorId AND appointment_date > GETDATE() AND status = 'SCHEDULED'
-- UPDATE doctors SET is_active = 0 WHERE doctor_id = @doctorId

-- UC-3.1: Book New Appointment
-- INSERT INTO appointments (patient_id, doctor_id, appointment_date, appointment_time, status) VALUES (@patientId, @doctorId, @date, @time, 'SCHEDULED')

-- UC-3.2: Check Doctor Availability
-- SELECT appointment_time, COUNT(*) as bookings FROM appointments WHERE doctor_id = @doctorId AND appointment_date = @date GROUP BY appointment_time

-- UC-3.3: Cancel Appointment
-- UPDATE appointments SET status = 'CANCELLED' WHERE appointment_id = @appointmentId
-- INSERT INTO appointment_audit (appointment_id, action, action_date) VALUES (@appointmentId, 'CANCELLED', GETDATE())

-- UC-3.4: Reschedule Appointment
-- UPDATE appointments SET appointment_date = @date, appointment_time = @time, doctor_id = @doctorId WHERE appointment_id = @appointmentId

-- UC-3.5: View Daily Appointment Schedule
-- SELECT a.appointment_id, a.appointment_time, p.name AS patient_name, d.name AS doctor_name, a.status FROM appointments a JOIN patients p ON a.patient_id = p.patient_id JOIN doctors d ON a.doctor_id = d.doctor_id WHERE a.appointment_date = @date ORDER BY a.appointment_time

-- Sample Data
INSERT INTO specialties (specialty_name) VALUES ('Cardiology'), ('Neurology'), ('Pediatrics'), ('Orthopedics'), ('Dermatology');

SELECT * FROM patients;
SELECT * FROM doctors;
SELECT * FROM specialties;
SELECT * FROM appointments;
