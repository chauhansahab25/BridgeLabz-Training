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

CREATE TABLE prescriptions (
    prescription_id INT PRIMARY KEY IDENTITY(1,1),
    visit_id INT,
    medicine_name NVARCHAR(200),
    dosage NVARCHAR(100),
    duration NVARCHAR(100),
    FOREIGN KEY (visit_id) REFERENCES visits(visit_id)
);

CREATE TABLE bills (
    bill_id INT PRIMARY KEY IDENTITY(1,1),
    visit_id INT,
    consultation_fee DECIMAL(10,2),
    additional_charges DECIMAL(10,2),
    total_amount DECIMAL(10,2),
    payment_status NVARCHAR(20),
    payment_date DATETIME,
    payment_mode NVARCHAR(50),
    FOREIGN KEY (visit_id) REFERENCES visits(visit_id)
);

CREATE TABLE payment_transactions (
    transaction_id INT PRIMARY KEY IDENTITY(1,1),
    bill_id INT,
    amount DECIMAL(10,2),
    payment_mode NVARCHAR(50),
    transaction_date DATETIME,
    FOREIGN KEY (bill_id) REFERENCES bills(bill_id)
);

CREATE TABLE audit_log (
    audit_id INT PRIMARY KEY IDENTITY(1,1),
    table_name NVARCHAR(100),
    action NVARCHAR(50),
    user_name NVARCHAR(100),
    action_timestamp DATETIME DEFAULT GETDATE()
);

-- Trigger for audit logging on patients table
CREATE TRIGGER trg_patients_audit
ON patients
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @action NVARCHAR(50)
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @action = 'UPDATE'
    ELSE IF EXISTS (SELECT * FROM inserted)
        SET @action = 'INSERT'
    ELSE
        SET @action = 'DELETE'
    
    INSERT INTO audit_log (table_name, action, user_name)
    VALUES ('patients', @action, SYSTEM_USER)
END;

-- Trigger for audit logging on doctors table
CREATE TRIGGER trg_doctors_audit
ON doctors
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @action NVARCHAR(50)
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @action = 'UPDATE'
    ELSE IF EXISTS (SELECT * FROM inserted)
        SET @action = 'INSERT'
    ELSE
        SET @action = 'DELETE'
    
    INSERT INTO audit_log (table_name, action, user_name)
    VALUES ('doctors', @action, SYSTEM_USER)
END;

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

-- UC-4.1: Record Patient Visit
-- INSERT INTO visits (appointment_id, patient_id, doctor_id, visit_date, diagnosis, notes) VALUES (@appointmentId, @patientId, @doctorId, @visitDate, @diagnosis, @notes)
-- UPDATE appointments SET status = 'COMPLETED' WHERE appointment_id = @appointmentId

-- UC-4.2: View Patient Medical History
-- SELECT v.visit_date, d.name AS doctor_name, v.diagnosis, v.notes, p.medicine_name, p.dosage, p.duration FROM visits v JOIN doctors d ON v.doctor_id = d.doctor_id LEFT JOIN prescriptions p ON v.visit_id = p.visit_id WHERE v.patient_id = @patientId ORDER BY v.visit_date DESC

-- UC-4.3: Add Prescription Details
-- INSERT INTO prescriptions (visit_id, medicine_name, dosage, duration) VALUES (@visitId, @medicineName, @dosage, @duration)

-- UC-5.1: Generate Bill for Visit
-- INSERT INTO bills (visit_id, consultation_fee, additional_charges, total_amount, payment_status) VALUES (@visitId, @consultationFee, @additionalCharges, @totalAmount, 'UNPAID')

-- UC-5.2: Record Payment
-- UPDATE bills SET payment_status = 'PAID', payment_date = GETDATE(), payment_mode = @paymentMode WHERE bill_id = @billId
-- INSERT INTO payment_transactions (bill_id, amount, payment_mode, transaction_date) VALUES (@billId, @amount, @paymentMode, GETDATE())

-- UC-5.3: View Outstanding Bills
-- SELECT b.bill_id, p.name AS patient_name, b.total_amount, b.payment_status, SUM(b.total_amount) OVER (PARTITION BY v.patient_id) as patient_total FROM bills b JOIN visits v ON b.visit_id = v.visit_id JOIN patients p ON v.patient_id = p.patient_id WHERE b.payment_status = 'UNPAID'

-- UC-5.4: Generate Revenue Report
-- SELECT CONVERT(DATE, b.payment_date) as payment_date, d.name AS doctor_name, s.specialty_name, SUM(b.total_amount) as total_revenue FROM bills b JOIN visits v ON b.visit_id = v.visit_id JOIN doctors d ON v.doctor_id = d.doctor_id JOIN specialties s ON d.specialty_id = s.specialty_id WHERE b.payment_status = 'PAID' AND b.payment_date BETWEEN @startDate AND @endDate GROUP BY CONVERT(DATE, b.payment_date), d.name, s.specialty_name HAVING SUM(b.total_amount) > 0

-- UC-6.1: Manage Specialty Lookup
-- INSERT INTO specialties (specialty_name) VALUES (@name)
-- UPDATE specialties SET specialty_name = @name WHERE specialty_id = @id
-- SELECT COUNT(*) FROM doctors WHERE specialty_id = @id
-- DELETE FROM specialties WHERE specialty_id = @id

-- UC-6.2: Database Backup
-- Uses DatabaseMetaData and batch operations

-- UC-6.3: View System Audit Logs
-- SELECT * FROM audit_log WHERE table_name = @tableName AND action_timestamp >= @startDate ORDER BY action_timestamp DESC

-- Sample Data
INSERT INTO specialties (specialty_name) VALUES ('Cardiology'), ('Neurology'), ('Pediatrics'), ('Orthopedics'), ('Dermatology');

SELECT * FROM patients;
SELECT * FROM doctors;
SELECT * FROM specialties;
SELECT * FROM appointments;
SELECT * FROM visits;
SELECT * FROM prescriptions;
SELECT * FROM bills;
SELECT * FROM payment_transactions;
SELECT * FROM audit_log;
