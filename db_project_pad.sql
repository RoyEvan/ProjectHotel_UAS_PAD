-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 13, 2024 at 09:59 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

DROP DATABASE db_project_pad;
CREATE DATABASE db_project_pad;

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_project_pad`
--

-- --------------------------------------------------------

--
-- Table structure for table `bills`
--

CREATE TABLE `bills` (
  `BILL_ID` varchar(16) NOT NULL,
  `ROOM_ID` varchar(5) NOT NULL,
  `VOUCHER_ID` varchar(12) DEFAULT NULL,
  `STAFF_ID` varchar(10) NOT NULL,
  `CUSTOMER_ID` varchar(12) NOT NULL,
  `CHECKIN_DATE` date NOT NULL,
  `CHECKOUT_DATE` date NOT NULL,
  `BILL_TOTAL` bigint(20) NOT NULL,
  `BILL_GRANDTOTAL` bigint(20) NOT NULL,
  `BILL_STATUS` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `bill_fines`
--

CREATE TABLE `bill_fines` (
  `FINE_ID` varchar(8) NOT NULL,
  `BILL_ID` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `CATEGORY_ID` varchar(3) NOT NULL,
  `CATEGORY_NAME` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CUSTOMER_ID` varchar(12) NOT NULL,
  `CUSTOMER_NAME` varchar(64) NOT NULL,
  `CUSTOMER_ADDRESS` varchar(64) NOT NULL,
  `CUSTOMER_PHONE` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `d_bills`
--

CREATE TABLE `d_bills` (
  `FACILITIES_ID` varchar(5) NOT NULL,
  `BILL_ID` varchar(16) NOT NULL,
  `USE_QTY` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `facilities`
--

CREATE TABLE `facilities` (
  `FACILITIES_ID` varchar(5) NOT NULL,
  `FACILITIES_NAME` varchar(32) NOT NULL,
  `PRICE` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `fines`
--

CREATE TABLE `fines` (
  `FINE_ID` varchar(8) NOT NULL,
  `FINE_NAME` varchar(32) NOT NULL,
  `FINE` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `ROOM_ID` varchar(5) NOT NULL,
  `CATEGORY_ID` varchar(3) NOT NULL,
  `ROOM_PRICE` bigint(20) NOT NULL,
  `IS_USABLE` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `room_inventory`
--

CREATE TABLE `room_inventory` (
  `ROOM_INVENTORY_ID` int(11) NOT NULL,
  `FINE_ID` varchar(8) NOT NULL,
  `ROOM_ID` varchar(5) NOT NULL,
  `ROOM_INVENTORY_NAME` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staffs`
--

CREATE TABLE `staffs` (
  `STAFF_ID` varchar(10) NOT NULL,
  `STAFF_USERNAME` varchar(32) NOT NULL,
  `STAFF_PASSWORD` varchar(255) NOT NULL,
  `STAFF_NAME` varchar(64) NOT NULL,
  `STAFF_EMAIL` varchar(64) NOT NULL,
  `STAFF_PHONE` varchar(13) NOT NULL,
  `STAFF_BIRTHDAY` date NOT NULL,
  `STAFF_IS_ACTIVE` tinyint(1) NOT NULL,
  `STAFF_IS_MANAGER` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `vouchers`
--

CREATE TABLE `vouchers` (
  `VOUCHER_ID` varchar(12) NOT NULL,
  `VOUCHER_NAME` varchar(64) NOT NULL,
  `VOUCHER` bigint(20) NOT NULL,
  `DATE_START` date NOT NULL,
  `DATE_END` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bills`
--
ALTER TABLE `bills`
  ADD PRIMARY KEY (`BILL_ID`),
  ADD KEY `FK_RELATIONSHIP_1` (`CUSTOMER_ID`),
  ADD KEY `FK_RELATIONSHIP_2` (`ROOM_ID`),
  ADD KEY `FK_RELATIONSHIP_5` (`STAFF_ID`),
  ADD KEY `FK_RELATIONSHIP_6` (`VOUCHER_ID`);

--
-- Indexes for table `bill_fines`
--
ALTER TABLE `bill_fines`
  ADD PRIMARY KEY (`FINE_ID`,`BILL_ID`),
  ADD KEY `FK_RELATIONSHIP_4` (`BILL_ID`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`CATEGORY_ID`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CUSTOMER_ID`);

--
-- Indexes for table `d_bills`
--
ALTER TABLE `d_bills`
  ADD PRIMARY KEY (`FACILITIES_ID`,`BILL_ID`),
  ADD KEY `FK_RELATIONSHIP_8` (`BILL_ID`);

--
-- Indexes for table `facilities`
--
ALTER TABLE `facilities`
  ADD PRIMARY KEY (`FACILITIES_ID`);

--
-- Indexes for table `fines`
--
ALTER TABLE `fines`
  ADD PRIMARY KEY (`FINE_ID`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`ROOM_ID`),
  ADD KEY `FK_RELATIONSHIP_9` (`CATEGORY_ID`);

--
-- Indexes for table `room_inventory`
--
ALTER TABLE `room_inventory`
  ADD PRIMARY KEY (`ROOM_INVENTORY_ID`),
  ADD KEY `FK_RELATIONSHIP_10` (`ROOM_ID`),
  ADD KEY `FK_RELATIONSHIP_11` (`FINE_ID`);

--
-- Indexes for table `staffs`
--
ALTER TABLE `staffs`
  ADD PRIMARY KEY (`STAFF_ID`);

--
-- Indexes for table `vouchers`
--
ALTER TABLE `vouchers`
  ADD PRIMARY KEY (`VOUCHER_ID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bills`
--
ALTER TABLE `bills`
  ADD CONSTRAINT `FK_RELATIONSHIP_1` FOREIGN KEY (`CUSTOMER_ID`) REFERENCES `customers` (`CUSTOMER_ID`),
  ADD CONSTRAINT `FK_RELATIONSHIP_2` FOREIGN KEY (`ROOM_ID`) REFERENCES `rooms` (`ROOM_ID`),
  ADD CONSTRAINT `FK_RELATIONSHIP_5` FOREIGN KEY (`STAFF_ID`) REFERENCES `staffs` (`STAFF_ID`),
  ADD CONSTRAINT `FK_RELATIONSHIP_6` FOREIGN KEY (`VOUCHER_ID`) REFERENCES `vouchers` (`VOUCHER_ID`);

--
-- Constraints for table `bill_fines`
--
ALTER TABLE `bill_fines`
  ADD CONSTRAINT `FK_RELATIONSHIP_3` FOREIGN KEY (`FINE_ID`) REFERENCES `fines` (`FINE_ID`),
  ADD CONSTRAINT `FK_RELATIONSHIP_4` FOREIGN KEY (`BILL_ID`) REFERENCES `bills` (`BILL_ID`);

--
-- Constraints for table `d_bills`
--
ALTER TABLE `d_bills`
  ADD CONSTRAINT `FK_RELATIONSHIP_7` FOREIGN KEY (`FACILITIES_ID`) REFERENCES `facilities` (`FACILITIES_ID`),
  ADD CONSTRAINT `FK_RELATIONSHIP_8` FOREIGN KEY (`BILL_ID`) REFERENCES `bills` (`BILL_ID`);

--
-- Constraints for table `rooms`
--
ALTER TABLE `rooms`
  ADD CONSTRAINT `FK_RELATIONSHIP_9` FOREIGN KEY (`CATEGORY_ID`) REFERENCES `categories` (`CATEGORY_ID`);

--
-- Constraints for table `room_inventory`
--
ALTER TABLE `room_inventory`
  ADD CONSTRAINT `FK_RELATIONSHIP_10` FOREIGN KEY (`ROOM_ID`) REFERENCES `rooms` (`ROOM_ID`),
  ADD CONSTRAINT `FK_RELATIONSHIP_11` FOREIGN KEY (`FINE_ID`) REFERENCES `fines` (`FINE_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
