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
  `STAFF_ID` varchar(10) NOT NULL,
  `CUSTOMER_ID` varchar(12) NOT NULL,
  `CHECKIN_DATE` date NOT NULL,
  `CHECKOUT_DATE` date NOT NULL,
  `BILL_TOTAL` bigint(20) NOT NULL,
  `BILL_GRANDTOTAL` bigint(20) NOT NULL,
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

/*Table structure for table `customers` */

DROP TABLE IF EXISTS `customers`;

CREATE TABLE `customers` (
  `CUSTOMER_ID` varchar(12) NOT NULL,
  `CUSTOMER_NAME` varchar(64) NOT NULL,
  `CUSTOMER_ADDRESS` varchar(64) NOT NULL,
  `CUSTOMER_PHONE` varchar(13) NOT NULL,
  `JOIN_DATE` date NOT NULL,
  PRIMARY KEY (`CUSTOMER_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `customers` */

/*Table structure for table `d_bills` */

DROP TABLE IF EXISTS `d_bills`;

CREATE TABLE `d_bills` (
  `FACILITIES_ID` varchar(5) NOT NULL,
  `BILL_ID` varchar(16) NOT NULL,
  `USE_QTY` int(2) NOT NULL,
  PRIMARY KEY (`FACILITIES_ID`,`BILL_ID`),
  KEY `FK_RELATIONSHIP_8` (`BILL_ID`),
  CONSTRAINT `FK_RELATIONSHIP_7` FOREIGN KEY (`FACILITIES_ID`) REFERENCES `facilities` (`FACILITIES_ID`),
  CONSTRAINT `FK_RELATIONSHIP_8` FOREIGN KEY (`BILL_ID`) REFERENCES `bills` (`BILL_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `d_bills` */

/*Table structure for table `d_fine` */

DROP TABLE IF EXISTS `d_fine`;

CREATE TABLE `d_fine` (
  `FINE_ID` varchar(8) NOT NULL,
  `BILL_ID` varchar(16) NOT NULL,
  PRIMARY KEY (`FINE_ID`,`BILL_ID`),
  KEY `FK_RELATIONSHIP_4` (`BILL_ID`),
  CONSTRAINT `FK_RELATIONSHIP_3` FOREIGN KEY (`FINE_ID`) REFERENCES `fines` (`FINE_ID`),
  CONSTRAINT `FK_RELATIONSHIP_4` FOREIGN KEY (`BILL_ID`) REFERENCES `bills` (`BILL_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `d_fine` */

/*Table structure for table `facilities` */

DROP TABLE IF EXISTS `facilities`;

CREATE TABLE `facilities` (
  `FACILITIES_ID` varchar(5) NOT NULL,
  `FACILITIES_NAME` varchar(32) NOT NULL,
  `PRICE` bigint(20) NOT NULL,
  PRIMARY KEY (`FACILITIES_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `facilities` */

/*Table structure for table `fines` */

DROP TABLE IF EXISTS `fines`;

CREATE TABLE `fines` (
  `FINE_ID` varchar(8) NOT NULL,
  `FINE_NAME` varchar(32) NOT NULL,
  `FINE` bigint(20) NOT NULL,
  PRIMARY KEY (`FINE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `fines` */

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

/*Table structure for table `staffs` */

DROP TABLE IF EXISTS `staffs`;

CREATE TABLE `staffs` (
  `STAFF_ID` varchar(10) NOT NULL,
  `STAFF_NAME` varchar(64) NOT NULL,
  `STAFF_EMAIL` varchar(64) NOT NULL,
  `STAFF_PHONE` varchar(13) NOT NULL,
  `STAFF_BIRTHDAY` date NOT NULL,
  `STAFF_JOIN_DATE` date NOT NULL,
  `STAFF_IS_ACTIVE` tinyint(1) NOT NULL,
  PRIMARY KEY (`STAFF_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `staffs` */

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
