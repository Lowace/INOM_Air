CREATE DATABASE IF NOT EXISTS `inomairtest_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `inomairtest_db`;

CREATE TABLE IF NOT EXISTS `users` (
    `username` VARCHAR(50) NOT NULL PRIMARY KEY,
    `password` VARCHAR(100) NOT NULL,
    `given_name` VARCHAR(100) NOT NULL,
    `surname` VARCHAR(100) NOT NULL,
    `gender` VARCHAR(20) DEFAULT 'Male',
    `date_of_birth` DATE DEFAULT '2000-01-01',
    `contact_number` VARCHAR(30) DEFAULT '+63 9123456789',
    `role` VARCHAR(20) DEFAULT 'Customer',
    `is_senior` TINYINT(1) DEFAULT 0,
    `is_pwd` TINYINT(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `aircrafts` (
    `aircraft_id` VARCHAR(20) NOT NULL PRIMARY KEY,
    `model` VARCHAR(100) NOT NULL,
    `capacity` INT NOT NULL,
    `status` VARCHAR(50) DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `pilots` (
    `pilot_id` VARCHAR(20) NOT NULL PRIMARY KEY,
    `name` VARCHAR(100) NOT NULL,
    `assigned_flight` VARCHAR(50) DEFAULT '',
    `status` VARCHAR(50) DEFAULT 'On Duty'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `flights` (
    `flight_id` VARCHAR(20) NOT NULL PRIMARY KEY,
    `origin` VARCHAR(50) NOT NULL,
    `destination` VARCHAR(50) NOT NULL,
    `flight_date` VARCHAR(50) NOT NULL,
    `departure_time` VARCHAR(20) NOT NULL,
    `arrival_time` VARCHAR(20) NOT NULL,
    `duration` VARCHAR(20) NOT NULL,
    `flight_type` VARCHAR(50) DEFAULT 'Direct Flight',
    `base_fare` DECIMAL(10,2) NOT NULL,
    `status` VARCHAR(50) DEFAULT 'Scheduled',
    `aircraft_model` VARCHAR(100) DEFAULT 'Boeing 737-800'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `bookings` (
    `ticket_number` VARCHAR(50) NOT NULL PRIMARY KEY,
    `username` VARCHAR(50) NOT NULL,
    `passenger_name` VARCHAR(100) NOT NULL,
    `flight_id` VARCHAR(20) NOT NULL,
    `cabin_class` VARCHAR(30) DEFAULT 'Economy',
    `seat_number` VARCHAR(20) DEFAULT 'A1',
    `gate` VARCHAR(20) DEFAULT 'A1',
    `selected_meal` VARCHAR(100) DEFAULT 'Standard In-flight Meal',
    `checked_baggage_kg` INT DEFAULT 0,
    `carry_on_baggage_kg` INT DEFAULT 7,
    `baggage_fee` DECIMAL(10,2) DEFAULT 0.00,
    `is_refundable` TINYINT(1) DEFAULT 0,
    `refund_fee` DECIMAL(10,2) DEFAULT 0.00,
    `discount_amount` DECIMAL(10,2) DEFAULT 0.00,
    `discount_reason` VARCHAR(100) DEFAULT 'None',
    `taxes_and_surcharges` DECIMAL(10,2) DEFAULT 450.00,
    `total_amount` DECIMAL(10,2) DEFAULT 0.00,
    `booking_date` DATETIME DEFAULT CURRENT_TIMESTAMP,
    `status` VARCHAR(50) DEFAULT 'Confirmed'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `users` (`username`, `password`, `given_name`, `surname`, `gender`, `date_of_birth`, `contact_number`, `role`, `is_senior`, `is_pwd`) VALUES
('admin', 'admin123', 'Admin', 'Staff', 'Male', '1990-01-01', '+63 9000000000', 'Admin', 0, 0),
('Naruto', 'password', 'Naruto', 'Uzumaki', 'Male', '1995-10-10', '+63 9123456789', 'Customer', 0, 0)
ON DUPLICATE KEY UPDATE `password`=VALUES(`password`);

INSERT INTO `aircrafts` (`aircraft_id`, `model`, `capacity`, `status`) VALUES
('P001', 'Boeing 737-800', 180, 'Active'),
('P002', 'Airbus A320', 150, 'Under Maintenance'),
('P003', 'Boeing 777-300ER', 300, 'Active'),
('P004', 'Airbus A350-900', 280, 'Inactive')
ON DUPLICATE KEY UPDATE `model`=VALUES(`model`);

INSERT INTO `pilots` (`pilot_id`, `name`, `assigned_flight`, `status`) VALUES
('PT001', 'Kherjie Manuel', 'F001', 'On Duty'),
('PT002', 'Thess Tan', 'F002', 'On Duty'),
('PT003', 'Richmond Paragas', 'F003', 'Standby'),
('PT004', 'Dhelilah Paragas', 'F004', 'On Leave')
ON DUPLICATE KEY UPDATE `name`=VALUES(`name`);

INSERT INTO `flights` (`flight_id`, `origin`, `destination`, `flight_date`, `departure_time`, `arrival_time`, `duration`, `flight_type`, `base_fare`, `status`, `aircraft_model`) VALUES
('F001', 'Manila', 'Cebu', 'November 10, 2026', '10:30 AM', '12:00 PM', '1h 30m', 'Direct Flight', 2000.00, 'Flying', 'Boeing 737-800'),
('F002', 'Manila', 'Cebu', 'November 10, 2026', '2:30 PM', '4:00 PM', '1h 30m', 'Direct Flight', 2000.00, 'Scheduled', 'Airbus A320'),
('F003', 'Manila', 'Tokyo', 'November 12, 2026', '07:22 AM', '12:50 PM', '4h 30m', 'Direct Flight', 8500.00, 'Scheduled', 'Boeing 777-300ER'),
('F004', 'Manila', 'Singapore', 'November 15, 2026', '01:00 PM', '04:40 PM', '3h 40m', 'Direct Flight', 5500.00, 'Scheduled', 'Airbus A350-900'),
('F005', 'Manila', 'Bangkok', 'November 18, 2026', '06:15 PM', '09:45 PM', '3h 30m', 'Direct Flight', 6200.00, 'Scheduled', 'Boeing 737-800')
ON DUPLICATE KEY UPDATE `origin`=VALUES(`origin`);

INSERT INTO `bookings` (`ticket_number`, `username`, `passenger_name`, `flight_id`, `cabin_class`, `seat_number`, `gate`, `selected_meal`, `checked_baggage_kg`, `carry_on_baggage_kg`, `baggage_fee`, `is_refundable`, `refund_fee`, `discount_amount`, `discount_reason`, `taxes_and_surcharges`, `total_amount`, `booking_date`, `status`) VALUES
('INOM-88239014', 'Naruto', 'Naruto Uzumaki', 'F001', 'Economy', 'A1', 'A1', 'Chicken Teriyaki with Rice', 20, 7, 500.00, 0, 0.00, 0.00, 'None', 450.00, 2950.00, NOW(), 'Confirmed')
ON DUPLICATE KEY UPDATE `status`=VALUES(`status`);

