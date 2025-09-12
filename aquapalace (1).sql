-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 12, 2025 at 11:41 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aquapalace`
--

-- --------------------------------------------------------

--
-- Table structure for table `checkins`
--

CREATE TABLE `checkins` (
  `checkin_id` int(11) NOT NULL,
  `checkin_subscription_id` int(11) NOT NULL,
  `checkin_customer_id` int(11) DEFAULT NULL,
  `checkin_time` timestamp NOT NULL DEFAULT current_timestamp(),
  `checkin_method` enum('zuil','receptie') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `checkins`
--

INSERT INTO `checkins` (`checkin_id`, `checkin_subscription_id`, `checkin_customer_id`, `checkin_time`, `checkin_method`) VALUES
(1, 1, 1, '2025-09-03 11:16:31', 'zuil'),
(2, 2, 3, '2025-09-03 11:16:31', 'receptie');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `customer_user_id` int(11) DEFAULT NULL,
  `customer_firstname` varchar(50) NOT NULL,
  `customer_lastname` varchar(50) NOT NULL,
  `customer_address` varchar(100) DEFAULT NULL,
  `customer_zipcode` varchar(10) DEFAULT NULL,
  `customer_city` varchar(50) DEFAULT NULL,
  `customer_email` varchar(100) DEFAULT NULL,
  `customer_phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `customer_user_id`, `customer_firstname`, `customer_lastname`, `customer_address`, `customer_zipcode`, `customer_city`, `customer_email`, `customer_phone`) VALUES
(1, 3, 'Jan', 'Jansen', 'Dorpsstraat 1', '1234AB', 'Amsterdam', 'jan@voorbeeld.com', '0612345678'),
(3, 1, 'Rik', 'de Jong', 'Haverstraat 11', '2155IK', 'Nieuw Vennep', 'rikdejong@gmail.com', '0681818181');

-- --------------------------------------------------------

--
-- Table structure for table `subscriptions`
--

CREATE TABLE `subscriptions` (
  `subscription_id` int(11) NOT NULL,
  `subscription_customer_id` int(11) NOT NULL,
  `subscription_type_id` int(11) NOT NULL,
  `subscription_start_date` date NOT NULL,
  `subscription_end_date` date DEFAULT NULL,
  `subscription_remaining_rides` int(11) DEFAULT NULL,
  `subscription_active` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subscriptions`
--

INSERT INTO `subscriptions` (`subscription_id`, `subscription_customer_id`, `subscription_type_id`, `subscription_start_date`, `subscription_end_date`, `subscription_remaining_rides`, `subscription_active`) VALUES
(1, 1, 1, '2025-09-01', '2025-09-30', NULL, 1),
(2, 1, 3, '2025-08-15', NULL, 8, 1);

-- --------------------------------------------------------

--
-- Table structure for table `subscription_log`
--

CREATE TABLE `subscription_log` (
  `subscription_log_id` int(11) NOT NULL,
  `subscription_log_subscription_id` int(11) NOT NULL,
  `subscription_log_customer_id` int(11) NOT NULL,
  `subscription_log_subscription_end_date` date NOT NULL,
  `subscription_log_logged_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `subscription_log_status` varchar(50) DEFAULT 'expired'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subscription_log`
--

INSERT INTO `subscription_log` (`subscription_log_id`, `subscription_log_subscription_id`, `subscription_log_customer_id`, `subscription_log_subscription_end_date`, `subscription_log_logged_at`, `subscription_log_status`) VALUES
(1, 1, 3, '2025-09-17', '2025-09-04 12:53:11', 'expired');

-- --------------------------------------------------------

--
-- Table structure for table `subscription_types`
--

CREATE TABLE `subscription_types` (
  `subscription_type_id` int(11) NOT NULL,
  `subscription_type_name` varchar(50) NOT NULL,
  `subscription_type_description` text DEFAULT NULL,
  `subscription_type_price` decimal(10,2) NOT NULL,
  `subscription_type_duration_days` int(11) DEFAULT NULL,
  `subscription_type_rides` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subscription_types`
--

INSERT INTO `subscription_types` (`subscription_type_id`, `subscription_type_name`, `subscription_type_description`, `subscription_type_price`, `subscription_type_duration_days`, `subscription_type_rides`) VALUES
(1, 'Maandabonnement', 'Onbeperkt toegang voor 1 maand', 45.00, 30, NULL),
(2, 'Jaarabonnement', 'Onbeperkt toegang voor 1 jaar', 450.00, 365, NULL),
(3, '10-rittenkaart', 'Toegang voor 10 bezoeken', 80.00, NULL, 10);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `user_username` varchar(50) NOT NULL,
  `user_password_hash` varchar(255) NOT NULL,
  `user_role` enum('gast','medewerker','beheerder') NOT NULL DEFAULT 'gast',
  `user_created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_username`, `user_password_hash`, `user_role`, `user_created_at`) VALUES
(1, 'admin', '$2a$11$vSpOx2WLIc/p2fT3OfSn9OO69qAilei9V9dPaK8WoY7jhPAQ5rRkW', 'beheerder', '2025-09-03 11:16:30'),
(2, 'medewerker1', '$2a$11$AtfiTqP98YkTaNNMZ7bvWOoOTGP3gSB9lS4qBK88fWFlXhmwAzj0y', 'medewerker', '2025-09-03 11:16:30'),
(3, 'klant1', '$2a$11$AtfiTqP98YkTaNNMZ7bvWOoOTGP3gSB9lS4qBK88fWFlXhmwAzj0y', 'gast', '2025-09-03 11:16:30');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `checkins`
--
ALTER TABLE `checkins`
  ADD PRIMARY KEY (`checkin_id`),
  ADD KEY `subscription_id` (`checkin_subscription_id`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`),
  ADD KEY `user_id` (`customer_user_id`);

--
-- Indexes for table `subscriptions`
--
ALTER TABLE `subscriptions`
  ADD PRIMARY KEY (`subscription_id`),
  ADD KEY `customer_id` (`subscription_customer_id`),
  ADD KEY `type_id` (`subscription_type_id`);

--
-- Indexes for table `subscription_log`
--
ALTER TABLE `subscription_log`
  ADD PRIMARY KEY (`subscription_log_id`),
  ADD KEY `fk_subscription` (`subscription_log_subscription_id`),
  ADD KEY `fk_customer` (`subscription_log_customer_id`);

--
-- Indexes for table `subscription_types`
--
ALTER TABLE `subscription_types`
  ADD PRIMARY KEY (`subscription_type_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`user_username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `checkins`
--
ALTER TABLE `checkins`
  MODIFY `checkin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `subscriptions`
--
ALTER TABLE `subscriptions`
  MODIFY `subscription_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `subscription_log`
--
ALTER TABLE `subscription_log`
  MODIFY `subscription_log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `subscription_types`
--
ALTER TABLE `subscription_types`
  MODIFY `subscription_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `checkins`
--
ALTER TABLE `checkins`
  ADD CONSTRAINT `checkins_ibfk_1` FOREIGN KEY (`checkin_subscription_id`) REFERENCES `subscriptions` (`subscription_id`);

--
-- Constraints for table `customers`
--
ALTER TABLE `customers`
  ADD CONSTRAINT `customers_ibfk_1` FOREIGN KEY (`customer_user_id`) REFERENCES `users` (`user_id`);

--
-- Constraints for table `subscriptions`
--
ALTER TABLE `subscriptions`
  ADD CONSTRAINT `subscriptions_ibfk_1` FOREIGN KEY (`subscription_customer_id`) REFERENCES `customers` (`customer_id`),
  ADD CONSTRAINT `subscriptions_ibfk_2` FOREIGN KEY (`subscription_type_id`) REFERENCES `subscription_types` (`subscription_type_id`);

--
-- Constraints for table `subscription_log`
--
ALTER TABLE `subscription_log`
  ADD CONSTRAINT `fk_customer` FOREIGN KEY (`subscription_log_customer_id`) REFERENCES `customers` (`customer_id`),
  ADD CONSTRAINT `fk_subscription` FOREIGN KEY (`subscription_log_subscription_id`) REFERENCES `subscriptions` (`subscription_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
