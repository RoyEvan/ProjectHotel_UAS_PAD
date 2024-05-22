-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2024 at 11:21 AM
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
-- Database: `db_project_pad`
--

-- --------------------------------------------------------

--
-- Table structure for table `bills`
--

CREATE TABLE `bills` (
  `BILL_ID` varchar(18) NOT NULL,
  `ROOM_ID` varchar(5) NOT NULL,
  `VOUCHER_ID` varchar(12) DEFAULT NULL,
  `STAFF_ID` varchar(4) NOT NULL,
  `CUSTOMER_ID` varchar(16) NOT NULL,
  `CHECKIN_DATE` date NOT NULL,
  `CHECKOUT_DATE` date NOT NULL,
  `BILL_TOTAL` double NOT NULL,
  `BILL_GRANDTOTAL` double NOT NULL,
  `BILL_STATUS` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bills`
--

INSERT INTO `bills` (`BILL_ID`, `ROOM_ID`, `VOUCHER_ID`, `STAFF_ID`, `CUSTOMER_ID`, `CHECKIN_DATE`, `CHECKOUT_DATE`, `BILL_TOTAL`, `BILL_GRANDTOTAL`, `BILL_STATUS`) VALUES
('NOTA18052024183318', 'A0102', 'DSC0001', 'S002', '3578111212990002', '2024-05-18', '2024-05-19', 215000, 0, 1),
('NOTA19052024132012', 'A0101', NULL, 'S002', '3578111212990002', '2024-05-19', '2024-05-20', 540000, 0, 1);

--
-- Triggers `bills`
--
DELIMITER $$
CREATE TRIGGER `roomstatus_checkin` AFTER INSERT ON `bills` FOR EACH ROW UPDATE rooms SET rooms.IS_USABLE = 0 WHERE rooms.ROOM_ID = new.ROOM_ID
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `roomstatus_checkout` AFTER UPDATE ON `bills` FOR EACH ROW UPDATE rooms SET rooms.IS_USABLE = 1 WHERE rooms.ROOM_ID = new.ROOM_ID
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `CATEGORY_ID` varchar(3) NOT NULL,
  `CATEGORY_NAME` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`CATEGORY_ID`, `CATEGORY_NAME`) VALUES
('C01', 'Basic'),
('C02', 'Basic+'),
('C03', 'Standard'),
('C04', 'Family'),
('C05', 'Family 6'),
('C06', 'President Suite '),
('C07', 'President Suite+'),
('C08', 'VIP'),
('C09', 'VVIP'),
('C10', 'Home-Like');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CUSTOMER_ID` varchar(16) NOT NULL,
  `CUSTOMER_NAME` varchar(64) NOT NULL,
  `CUSTOMER_ADDRESS` varchar(64) NOT NULL,
  `CUSTOMER_PHONE` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CUSTOMER_ID`, `CUSTOMER_NAME`, `CUSTOMER_ADDRESS`, `CUSTOMER_PHONE`) VALUES
('3578111212990002', 'Catherine Wijaya', 'Jalan Rumah Mewah No 31 Surabaya', '81325689425'),
('3578451107040005', 'Evan', 'Jalan Penuh Kenangan Blok KK No. 69', '81245687529'),
('3578641212990001', 'Jonathan', 'Jalan Tiada Ujung No. 12', '81258765953'),
('3578871212990002', 'Amelia', 'Jalan Ku Berbeda Dengannya No. 54', '81276859205');

-- --------------------------------------------------------

--
-- Table structure for table `d_bills`
--

CREATE TABLE `d_bills` (
  `DBILL_ID` bigint(20) NOT NULL,
  `FACILITY_ID` bigint(5) NOT NULL,
  `BILL_ID` varchar(18) NOT NULL,
  `QTY` tinyint(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `d_bills`
--

INSERT INTO `d_bills` (`DBILL_ID`, `FACILITY_ID`, `BILL_ID`, `QTY`) VALUES
(1, 1, 'NOTA18052024183318', 1),
(2, 2, 'NOTA19052024132012', 1),
(3, 4, 'NOTA19052024132012', 1),
(4, 6, 'NOTA19052024132012', 1),
(8, 1, 'NOTA19052024134658', 1),
(9, 4, 'NOTA19052024134658', 2);

-- --------------------------------------------------------

--
-- Table structure for table `d_fines`
--

CREATE TABLE `d_fines` (
  `DFINE_ID` int(11) NOT NULL,
  `FINE_ID` varchar(8) NOT NULL,
  `BILL_ID` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `facilities`
--

CREATE TABLE `facilities` (
  `FACILITY_ID` bigint(5) NOT NULL,
  `FACILITY_NAME` varchar(32) NOT NULL,
  `PRICE` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `facilities`
--

INSERT INTO `facilities` (`FACILITY_ID`, `FACILITY_NAME`, `PRICE`) VALUES
(1, 'Extra Bed (Baby)', 100000),
(2, 'Extra Bed Single L', 150000),
(3, 'Extra Bed Single XL', 200000),
(4, 'Gym Room', 40000),
(5, 'Karaoke Room', 30000),
(6, 'Lunch', 250000),
(7, 'Lunch AYCE', 100000),
(8, 'Dinner AYCE', 200000),
(9, 'Extra Towel S', 20000),
(10, 'Extra Towel M', 22500),
(11, 'Extra Towel L', 25000),
(12, 'Extra Towel XL', 27500),
(13, 'Extra Towel XXL', 30000),
(14, 'Extra Blanket', 20000),
(15, 'Extra Blanket L', 22500),
(16, 'Extra Blanket XL', 25000);

-- --------------------------------------------------------

--
-- Table structure for table `fines`
--

CREATE TABLE `fines` (
  `FINE_ID` varchar(8) NOT NULL,
  `FINE_NAME` varchar(32) NOT NULL,
  `FINE` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fines`
--

INSERT INTO `fines` (`FINE_ID`, `FINE_NAME`, `FINE`) VALUES
('FINE0001', 'Kerusakan Fasilitas Tambahan', 100000),
('FINE0002', 'Kerusakan Fasilitas Default', 250000),
('FINE0003', 'Kerusakan Elektronik Default', 1000000),
('FINE0004', 'Kerusakan Elektronik Tambahan', 2500000),
('FINE0005', 'Kerusakan Fasilitas Toilet', 500000),
('FINE0006', 'Keterlambatan Check-Out', 250000),
('FINE0007', 'Keterlambatan Check-In', 250000);

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

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`ROOM_ID`, `CATEGORY_ID`, `ROOM_PRICE`, `IS_USABLE`) VALUES
('A0101', 'C01', 100000, 0),
('A0102', 'C02', 125000, 0),
('A0103', 'C03', 150000, 1),
('A0104', 'C04', 175000, 1),
('A0105', 'C05', 200000, 1),
('A0106', 'C06', 225000, 1),
('A0107', 'C07', 250000, 1),
('A0108', 'C08', 250000, 1),
('A0109', 'C09', 275000, 1),
('A0110', 'C10', 300000, 1);

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
  `STAFF_ID` varchar(4) NOT NULL,
  `STAFF_NAME` varchar(64) NOT NULL,
  `STAFF_EMAIL` varchar(64) NOT NULL,
  `STAFF_PHONE` varchar(13) NOT NULL,
  `STAFF_IS_ACTIVE` tinyint(1) NOT NULL,
  `STAFF_IS_MANAGER` tinyint(1) NOT NULL,
  `STAFF_USERNAME` varchar(32) NOT NULL,
  `STAFF_PASSWORD` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staffs`
--

INSERT INTO `staffs` (`STAFF_ID`, `STAFF_NAME`, `STAFF_EMAIL`, `STAFF_PHONE`, `STAFF_IS_ACTIVE`, `STAFF_IS_MANAGER`, `STAFF_USERNAME`, `STAFF_PASSWORD`) VALUES
('S001', 'Roy Evan', 'roy.e22@mhs.istts.ac.id', '81365985634', 1, 1, 'royevn', 'roiii123'),
('S002', 'Nixon Ignasius', 'nixon.i22@mhs.istts.ac.id', '81356842250', 1, 0, 'nxnign', 'nixxx123'),
('S003', 'Albert Valentino', 'albert.v22@mhs.istts.ac.id', '81365478211', 0, 0, 'albert', 'albert123');

-- --------------------------------------------------------

--
-- Table structure for table `vouchers`
--

CREATE TABLE `vouchers` (
  `VOUCHER_ID` varchar(12) NOT NULL,
  `FACILITY_ID` bigint(5) NOT NULL,
  `VOUCHER_NAME` varchar(64) NOT NULL,
  `VOUCHER` bigint(20) NOT NULL,
  `DATE_START` date NOT NULL,
  `DATE_END` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vouchers`
--

INSERT INTO `vouchers` (`VOUCHER_ID`, `FACILITY_ID`, `VOUCHER_NAME`, `VOUCHER`, `DATE_START`, `DATE_END`) VALUES
('DSC0001', 1, 'Disc Ext Bed Baby', 10000, '2024-05-01', '2024-05-31'),
('DSC0002', 2, 'Disc Ext Bed M', 10, '2024-05-01', '2024-05-31');

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
  ADD KEY `FK_RELATIONSHIP_5` (`STAFF_ID`);
ALTER TABLE `bills` ADD FULLTEXT KEY `FK_RELATIONSHIP_6` (`VOUCHER_ID`);

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
  ADD PRIMARY KEY (`DBILL_ID`),
  ADD KEY `DBILL_ID` (`DBILL_ID`);

--
-- Indexes for table `d_fines`
--
ALTER TABLE `d_fines`
  ADD PRIMARY KEY (`DFINE_ID`);

--
-- Indexes for table `facilities`
--
ALTER TABLE `facilities`
  ADD PRIMARY KEY (`FACILITY_ID`);

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
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `d_bills`
--
ALTER TABLE `d_bills`
  MODIFY `DBILL_ID` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `d_fines`
--
ALTER TABLE `d_fines`
  MODIFY `DFINE_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `facilities`
--
ALTER TABLE `facilities`
  MODIFY `FACILITY_ID` bigint(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `room_inventory`
--
ALTER TABLE `room_inventory`
  MODIFY `ROOM_INVENTORY_ID` int(11) NOT NULL AUTO_INCREMENT;

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
-- Constraints for table `d_bills`
--
ALTER TABLE `d_bills`
  ADD CONSTRAINT `FK_RELATIONSHIP_7` FOREIGN KEY (`FACILITY_ID`) REFERENCES `facilities` (`FACILITY_ID`);

--
-- Constraints for table `d_fines`
--
ALTER TABLE `d_fines`
  ADD CONSTRAINT `FK_RELATIONSHIP_3` FOREIGN KEY (`FINE_ID`) REFERENCES `fines` (`FINE_ID`);

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
