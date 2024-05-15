/*
SQLyog Community v13.2.0 (64 bit)
MySQL - 10.4.32-MariaDB : Database - db_project_pad
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_project_pad` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `db_project_pad`;

/*Table structure for table `bills` */

DROP TABLE IF EXISTS `bills`;

CREATE TABLE `bills` (
  `BILL_ID` varchar(16) NOT NULL,
  `ROOM_ID` varchar(5) NOT NULL,
  `VOUCHER_ID` varchar(12) DEFAULT NULL,
  `STAFF_ID` varchar(4) NOT NULL,
  `CUSTOMER_ID` varchar(16) NOT NULL,
  `CHECKIN_DATE` date NOT NULL,
  `CHECKOUT_DATE` date NOT NULL,
  `BILL_TOTAL` bigint(20) NOT NULL,
  `BILL_GRANDTOTAL` bigint(20) NOT NULL,
  `BILL_STATUS` tinyint(1) NOT NULL,
  PRIMARY KEY (`BILL_ID`),
  KEY `FK_RELATIONSHIP_1` (`CUSTOMER_ID`),
  KEY `FK_RELATIONSHIP_2` (`ROOM_ID`),
  KEY `FK_RELATIONSHIP_5` (`STAFF_ID`),
  KEY `FK_RELATIONSHIP_6` (`VOUCHER_ID`),
  CONSTRAINT `FK_RELATIONSHIP_1` FOREIGN KEY (`CUSTOMER_ID`) REFERENCES `customers` (`CUSTOMER_ID`),
  CONSTRAINT `FK_RELATIONSHIP_2` FOREIGN KEY (`ROOM_ID`) REFERENCES `rooms` (`ROOM_ID`),
  CONSTRAINT `FK_RELATIONSHIP_5` FOREIGN KEY (`STAFF_ID`) REFERENCES `staffs` (`STAFF_ID`),
  CONSTRAINT `FK_RELATIONSHIP_6` FOREIGN KEY (`VOUCHER_ID`) REFERENCES `vouchers` (`VOUCHER_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `bills` */

/*Table structure for table `categories` */

DROP TABLE IF EXISTS `categories`;

CREATE TABLE `categories` (
  `CATEGORY_ID` varchar(3) NOT NULL,
  `CATEGORY_NAME` varchar(16) NOT NULL,
  PRIMARY KEY (`CATEGORY_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `categories` */

insert  into `categories`(`CATEGORY_ID`,`CATEGORY_NAME`) values 
('C01','Basic'),
('C02','Basic+'),
('C03','Standard'),
('C04','Family'),
('C05','Family 6'),
('C06','President Suite '),
('C07','President Suite '),
('C08','VIP'),
('C09','VVIP'),
('C10','Home-Like');

/*Table structure for table `customers` */

DROP TABLE IF EXISTS `customers`;

CREATE TABLE `customers` (
  `CUSTOMER_ID` varchar(16) NOT NULL,
  `CUSTOMER_NAME` varchar(64) NOT NULL,
  `CUSTOMER_ADDRESS` varchar(64) NOT NULL,
  `CUSTOMER_PHONE` varchar(13) NOT NULL,
  PRIMARY KEY (`CUSTOMER_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `customers` */

/*Table structure for table `d_bills` */

DROP TABLE IF EXISTS `d_bills`;

CREATE TABLE `d_bills` (
  `FACILITY_ID` bigint(20) NOT NULL,
  `BILL_ID` varchar(16) NOT NULL,
  PRIMARY KEY (`FACILITY_ID`,`BILL_ID`),
  KEY `FK_RELATIONSHIP_8` (`BILL_ID`),
  CONSTRAINT `FK_RELATIONSHIP_7` FOREIGN KEY (`FACILITY_ID`) REFERENCES `facilities` (`FACILITY_ID`),
  CONSTRAINT `FK_RELATIONSHIP_8` FOREIGN KEY (`BILL_ID`) REFERENCES `bills` (`BILL_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `d_bills` */

/*Table structure for table `d_fines` */

DROP TABLE IF EXISTS `d_fines`;

CREATE TABLE `d_fines` (
  `FINE_ID` varchar(8) NOT NULL,
  `BILL_ID` varchar(16) NOT NULL,
  PRIMARY KEY (`FINE_ID`,`BILL_ID`),
  KEY `FK_RELATIONSHIP_4` (`BILL_ID`),
  CONSTRAINT `FK_RELATIONSHIP_3` FOREIGN KEY (`FINE_ID`) REFERENCES `fines` (`FINE_ID`),
  CONSTRAINT `FK_RELATIONSHIP_4` FOREIGN KEY (`BILL_ID`) REFERENCES `bills` (`BILL_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `d_fines` */

/*Table structure for table `facilities` */

DROP TABLE IF EXISTS `facilities`;

CREATE TABLE `facilities` (
  `FACILITY_ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `FACILITY_NAME` varchar(32) NOT NULL,
  `PRICE` bigint(20) NOT NULL,
  PRIMARY KEY (`FACILITY_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `facilities` */

insert  into `facilities`(`FACILITY_ID`,`FACILITY_NAME`,`PRICE`) values 
(1,'Extra Bed (Baby)',100000),
(2,'Extra Bed Single L',150000),
(3,'Extra Bed Single XL',200000),
(4,'Gym Room',40000),
(5,'Karaoke Room',30000),
(6,'Lunch',250000),
(7,'Lunch AYCE',100000),
(8,'Dinner AYCE',200000),
(9,'Extra Towel S',20000),
(10,'Extra Towel M',22500),
(11,'Extra Towel L',25000),
(12,'Extra Towel XL',27500),
(13,'Extra Towel XXL',30000),
(14,'Extra Blanket',20000),
(15,'Extra Blanket L',22500),
(16,'Extra Blanket XL',25000);

/*Table structure for table `fines` */

DROP TABLE IF EXISTS `fines`;

CREATE TABLE `fines` (
  `FINE_ID` varchar(8) NOT NULL,
  `FINE_NAME` varchar(32) NOT NULL,
  `FINE` bigint(20) NOT NULL,
  PRIMARY KEY (`FINE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `fines` */

insert  into `fines`(`FINE_ID`,`FINE_NAME`,`FINE`) values 
('FINE0001','Kerusakan Fasilitas Tambahan',100000),
('FINE0002','Kerusakan Fasilitas Default',250000),
('FINE0003','Kerusakan Elektronik Default',1000000),
('FINE0004','Kerusakan Elektronik Tambahan',2500000),
('FINE0005','Kerusakan Fasilitas Toilet',500000),
('FINE0006','Keterlambatan Check-Out',250000),
('FINE0007','Keterlambatan Check-In',250000);

/*Table structure for table `room_inventory` */

DROP TABLE IF EXISTS `room_inventory`;

CREATE TABLE `room_inventory` (
  `ROOM_INVENTORY_ID` int(11) NOT NULL AUTO_INCREMENT,
  `FINE_ID` varchar(8) NOT NULL,
  `ROOM_ID` varchar(5) NOT NULL,
  `ROOM_INVENTORY_NAME` varchar(32) NOT NULL,
  PRIMARY KEY (`ROOM_INVENTORY_ID`),
  KEY `FK_RELATIONSHIP_10` (`ROOM_ID`),
  KEY `FK_RELATIONSHIP_11` (`FINE_ID`),
  CONSTRAINT `FK_RELATIONSHIP_10` FOREIGN KEY (`ROOM_ID`) REFERENCES `rooms` (`ROOM_ID`),
  CONSTRAINT `FK_RELATIONSHIP_11` FOREIGN KEY (`FINE_ID`) REFERENCES `fines` (`FINE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `room_inventory` */

/*Table structure for table `rooms` */

DROP TABLE IF EXISTS `rooms`;

CREATE TABLE `rooms` (
  `ROOM_ID` varchar(5) NOT NULL,
  `CATEGORY_ID` varchar(3) NOT NULL,
  `ROOM_PRICE` bigint(20) NOT NULL,
  `IS_USABLE` tinyint(1) NOT NULL,
  PRIMARY KEY (`ROOM_ID`),
  KEY `FK_RELATIONSHIP_9` (`CATEGORY_ID`),
  CONSTRAINT `FK_RELATIONSHIP_9` FOREIGN KEY (`CATEGORY_ID`) REFERENCES `categories` (`CATEGORY_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `rooms` */

insert  into `rooms`(`ROOM_ID`,`CATEGORY_ID`,`ROOM_PRICE`,`IS_USABLE`) values 
('A0101','C01',100000,1),
('A0102','C02',125000,1),
('A0103','C03',150000,1),
('A0104','C04',175000,1),
('A0105','C05',200000,1),
('A0106','C06',225000,1),
('A0107','C07',250000,1),
('A0108','C08',250000,1),
('A0109','C09',275000,1),
('A0110','C10',300000,1);

/*Table structure for table `staffs` */

DROP TABLE IF EXISTS `staffs`;

CREATE TABLE `staffs` (
  `STAFF_ID` varchar(4) NOT NULL,
  `STAFF_NAME` varchar(64) NOT NULL,
  `STAFF_EMAIL` varchar(64) NOT NULL,
  `STAFF_PHONE` varchar(13) NOT NULL,
  `STAFF_IS_ACTIVE` tinyint(1) NOT NULL,
  `STAFF_IS_MANAGER` tinyint(1) NOT NULL,
  `STAFF_USERNAME` varchar(32) NOT NULL,
  `STAFF_PASSWORD` varchar(255) NOT NULL,
  PRIMARY KEY (`STAFF_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `staffs` */

insert  into `staffs`(`STAFF_ID`,`STAFF_NAME`,`STAFF_EMAIL`,`STAFF_PHONE`,`STAFF_IS_ACTIVE`,`STAFF_IS_MANAGER`,`STAFF_USERNAME`,`STAFF_PASSWORD`) values 
('S001','Roy Evan','roy.e22@mhs.istts.ac.id','81365985634',1,1,'royevn','roiii123'),
('S002','Nixon Ignasius','nixon.i22@mhs.istts.ac.id','81356842250',1,0,'nxnign','nixxx123'),
('S003','Albert Valentino','albert.v22@mhs.istts.ac.id','81365478211',0,0,'albert','albert123');

/*Table structure for table `vouchers` */

DROP TABLE IF EXISTS `vouchers`;

CREATE TABLE `vouchers` (
  `VOUCHER_ID` varchar(12) NOT NULL,
  `VOUCHER_NAME` varchar(64) NOT NULL,
  `VOUCHER` bigint(20) NOT NULL,
  `DATE_START` date NOT NULL,
  `DATE_END` date NOT NULL,
  PRIMARY KEY (`VOUCHER_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `vouchers` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
