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
  `BILL_ID` varchar(18) NOT NULL,
  `ROOM_ID` varchar(5) NOT NULL,
  `VOUCHER_ID` varchar(12) DEFAULT NULL,
  `STAFF_ID` varchar(4) NOT NULL,
  `CUSTOMER_ID` varchar(16) NOT NULL,
  `CHECKIN_DATE` datetime DEFAULT NULL,
  `CHECKOUT_DATE` datetime DEFAULT NULL,
  `BILL_TOTAL` double NOT NULL,
  `BILL_GRANDTOTAL` double NOT NULL,
  `BILL_STATUS` tinyint(1) NOT NULL,
  PRIMARY KEY (`BILL_ID`),
  KEY `FK_RELATIONSHIP_1` (`CUSTOMER_ID`),
  KEY `FK_RELATIONSHIP_2` (`ROOM_ID`),
  KEY `FK_RELATIONSHIP_5` (`STAFF_ID`),
  FULLTEXT KEY `FK_RELATIONSHIP_6` (`VOUCHER_ID`),
  CONSTRAINT `FK_RELATIONSHIP_1` FOREIGN KEY (`CUSTOMER_ID`) REFERENCES `customers` (`CUSTOMER_ID`),
  CONSTRAINT `FK_RELATIONSHIP_2` FOREIGN KEY (`ROOM_ID`) REFERENCES `rooms` (`ROOM_ID`),
  CONSTRAINT `FK_RELATIONSHIP_5` FOREIGN KEY (`STAFF_ID`) REFERENCES `staffs` (`STAFF_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `bills` */

insert  into `bills`(`BILL_ID`,`ROOM_ID`,`VOUCHER_ID`,`STAFF_ID`,`CUSTOMER_ID`,`CHECKIN_DATE`,`CHECKOUT_DATE`,`BILL_TOTAL`,`BILL_GRANDTOTAL`,`BILL_STATUS`) values 
('NOTA18052024183318','A0102','DSC0001','S002','3578111212990002','2024-05-18 18:33:18','2024-05-19 11:55:10',215000,465000,1),
('NOTA19052024132012','A0101',NULL,'S002','3578111212990002','2024-05-19 13:20:12','2024-05-19 11:38:36',540000,1040000,1),
('NOTA19052024165910','A0103',NULL,'S002','3578111212990002','2024-05-19 16:59:10','2024-05-19 22:40:42',1050000,1050000,0);

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
('C07','President Suite+'),
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

insert  into `customers`(`CUSTOMER_ID`,`CUSTOMER_NAME`,`CUSTOMER_ADDRESS`,`CUSTOMER_PHONE`) values 
('3578111212990002','Catherine Wijaya','Jalan Rumah Mewah No 31 Surabaya','81325689425'),
('3578451107040005','Evan','Jalan Penuh Kenangan Blok KK No. 69','81245687529'),
('3578641212990001','Jonathan','Jalan Tiada Ujung No. 12','81258765953'),
('3578871212990002','Amelia','Jalan Ku Berbeda Dengannya No. 54','81276859205');

/*Table structure for table `d_bills` */

DROP TABLE IF EXISTS `d_bills`;

CREATE TABLE `d_bills` (
  `DBILL_ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `FACILITY_ID` bigint(5) NOT NULL,
  `BILL_ID` varchar(18) NOT NULL,
  `QTY` tinyint(3) NOT NULL,
  PRIMARY KEY (`DBILL_ID`),
  KEY `DBILL_ID` (`DBILL_ID`),
  CONSTRAINT `FK_RELATIONSHIP_7` FOREIGN KEY (`FACILITY_ID`) REFERENCES `facilities` (`FACILITY_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `d_bills` */

insert  into `d_bills`(`DBILL_ID`,`FACILITY_ID`,`BILL_ID`,`QTY`) values 
(1,1,'NOTA18052024183318',1),
(2,2,'NOTA19052024132012',1),
(3,4,'NOTA19052024132012',1),
(4,6,'NOTA19052024132012',1),
(5,1,'NOTA19052024165910',1),
(6,3,'NOTA19052024165910',4);

/*Table structure for table `d_fines` */

DROP TABLE IF EXISTS `d_fines`;

CREATE TABLE `d_fines` (
  `DFINE_ID` int(11) NOT NULL AUTO_INCREMENT,
  `FINE_ID` varchar(8) NOT NULL,
  `BILL_ID` varchar(18) NOT NULL,
  PRIMARY KEY (`DFINE_ID`),
  CONSTRAINT `FK_RELATIONSHIP_3` FOREIGN KEY (`FINE_ID`) REFERENCES `fines` (`FINE_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `d_fines` */

insert  into `d_fines`(`DFINE_ID`,`FINE_ID`,`BILL_ID`) values 
(1,'FINE0002','NOTA18052024183318'),
(2,'FINE0003','NOTA19052024165910'),
(3,'FINE0005','NOTA19052024165910'),
(4,'FINE0002','NOTA19052024132012'),
(5,'FINE0002','NOTA19052024132012');

/*Table structure for table `facilities` */

DROP TABLE IF EXISTS `facilities`;

CREATE TABLE `facilities` (
  `FACILITY_ID` bigint(5) NOT NULL AUTO_INCREMENT,
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
) ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `room_inventory` */

insert  into `room_inventory`(`ROOM_INVENTORY_ID`,`FINE_ID`,`ROOM_ID`,`ROOM_INVENTORY_NAME`) values 
(1,'FINE0002','A0101','Single Bed'),
(2,'FINE0002','A0101','Sofa'),
(3,'FINE0003','A0101','Samsung Smart TV 32 in'),
(4,'FINE0003','A0101','Philips Hair Dryer'),
(5,'FINE0002','A0102','Single Bed'),
(6,'FINE0002','A0102','Sofa'),
(7,'FINE0002','A0102','Dining Table'),
(8,'FINE0003','A0102','Samsung Smart TV 32 in'),
(9,'FINE0003','A0102','Philips Hair Dryer'),
(10,'FINE0005','A0102','Toiletries'),
(11,'FINE0002','A0103','Double Bed'),
(12,'FINE0002','A0103','Sofa'),
(13,'FINE0003','A0103','Samsung Smart TV 32 in'),
(14,'FINE0003','A0103','Television STB 4K UHD'),
(15,'FINE0003','A0103','Philips Hair Dryer'),
(16,'FINE0005','A0103','Toiletries'),
(17,'FINE0005','A0103','Bathtub'),
(18,'FINE0002','A0104','Double Bed'),
(19,'FINE0002','A0104','Sofa'),
(20,'FINE0003','A0104','Samsung Smart TV 43 in'),
(21,'FINE0002','A0104','Television STB 4K UHD'),
(22,'FINE0003','A0104','Philips Hair Dryer'),
(23,'FINE0005','A0104','Toiletries'),
(24,'FINE0005','A0104','Bathtub'),
(25,'FINE0002','A0105','King Size Bed'),
(26,'FINE0002','A0105','Sofa'),
(27,'FINE0003','A0105','Samsung Smart TV 43 in'),
(28,'FINE0002','A0105','Television STB 4K UHD'),
(29,'FINE0003','A0105','Philips Hair Dryer'),
(30,'FINE0005','A0105','Toiletries'),
(31,'FINE0005','A0105','Bathtub'),
(32,'FINE0002','A0106','King Size Bed'),
(33,'FINE0002','A0106','Queen Size Bed'),
(34,'FINE0002','A0106','Single Bed'),
(35,'FINE0002','A0106','Sofa'),
(36,'FINE0002','A0106','Kitchens'),
(37,'FINE0002','A0106','Dining Table'),
(38,'FINE0003','A0106','Samsung Smart TV QLED 70 in'),
(39,'FINE0003','A0106','Television STB 4K UHD'),
(40,'FINE0003','A0106','Philips Hair Dryer'),
(41,'FINE0005','A0106','Toiletries'),
(42,'FINE0005','A0106','Bathtub'),
(43,'FINE0002','A0107','King Size Bed'),
(44,'FINE0002','A0107','Queen Size Bed'),
(45,'FINE0002','A0107','Single Bed'),
(46,'FINE0002','A0107','Sofa'),
(47,'FINE0002','A0107','Kitchens'),
(48,'FINE0002','A0107','Dining Table'),
(49,'FINE0003','A0107','Samsung Smart TV QLED 70 in'),
(50,'FINE0003','A0107','Harman Kardon Onyx 7 Speaker'),
(51,'FINE0002','A0107','Television STB 4K UHD'),
(52,'FINE0003','A0107','Philips Hair Dryer'),
(53,'FINE0005','A0107','Toiletries'),
(54,'FINE0005','A0107','Bathtub'),
(55,'FINE0002','A0108','King Size Bed'),
(56,'FINE0002','A0108','Queen Size Bed'),
(57,'FINE0002','A0108','Single Bed'),
(58,'FINE0002','A0108','Sofa'),
(59,'FINE0002','A0108','Kitchens'),
(60,'FINE0002','A0108','Dining Table'),
(61,'FINE0003','A0108','Samsung Smart TV QLED 70 in'),
(62,'FINE0003','A0108','Harman Kardon Onyx 7 Speaker'),
(63,'FINE0003','A0108','Television STB 4K UHD'),
(64,'FINE0003','A0108','Philips Hair Dryer'),
(65,'FINE0005','A0108','Toiletries'),
(66,'FINE0005','A0108','Bathtub'),
(67,'FINE0005','A0108','Private Pool'),
(68,'FINE0002','A0109','King Size Bed'),
(69,'FINE0002','A0109','Queen Size Bed'),
(70,'FINE0002','A0109','Single Bed'),
(71,'FINE0002','A0109','Sofa'),
(72,'FINE0002','A0109','Kitchens'),
(73,'FINE0002','A0109','Dining Table'),
(74,'FINE0003','A0109','Samsung Smart TV QLED 70 in'),
(75,'FINE0003','A0109','Harman Kardon Onyx 7 Speaker'),
(76,'FINE0003','A0109','Television STB 4K UHD'),
(77,'FINE0003','A0109','Philips Hair Dryer'),
(78,'FINE0005','A0109','Toiletries'),
(79,'FINE0005','A0109','Bathtub'),
(80,'FINE0005','A0109','Private Pool'),
(81,'FINE0005','A0109','Private Jacuzzi'),
(82,'FINE0002','A0110','King Size Bed'),
(83,'FINE0002','A0110','Queen Size Bed'),
(84,'FINE0002','A0110','Single Bed'),
(85,'FINE0002','A0110','Sofa'),
(86,'FINE0002','A0110','Kitchens'),
(87,'FINE0002','A0110','Dining Table'),
(88,'FINE0002','A0110','Private Pet Cage'),
(89,'FINE0003','A0110','Samsung Smart TV QLED 70 in'),
(90,'FINE0003','A0110','Harman Kardon Onyx 7 Speaker'),
(91,'FINE0003','A0110','Private Home Theatre'),
(92,'FINE0003','A0110','Television STB 4K UHD'),
(93,'FINE0003','A0110','Philips Hair Dryer'),
(94,'FINE0005','A0110','Toiletries'),
(95,'FINE0005','A0110','Bathtub'),
(96,'FINE0005','A0110','Private Pool'),
(97,'FINE0005','A0110','Private Garden');

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
  `FACILITY_ID` bigint(5) NOT NULL,
  `VOUCHER_NAME` varchar(64) NOT NULL,
  `VOUCHER` bigint(20) NOT NULL,
  `DATE_START` date NOT NULL,
  `DATE_END` date NOT NULL,
  PRIMARY KEY (`VOUCHER_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `vouchers` */

insert  into `vouchers`(`VOUCHER_ID`,`FACILITY_ID`,`VOUCHER_NAME`,`VOUCHER`,`DATE_START`,`DATE_END`) values 
('DSC0001',1,'Disc Ext Bed Baby',10000,'2024-05-01','2024-05-31'),
('DSC0002',2,'Disc Ext Bed M',10,'2024-05-01','2024-05-31');

/* Trigger structure for table `bills` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `roomstatus_checkin` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `roomstatus_checkin` AFTER INSERT ON `bills` FOR EACH ROW UPDATE rooms SET rooms.IS_USABLE = 0 WHERE rooms.ROOM_ID = new.ROOM_ID */$$


DELIMITER ;

/* Trigger structure for table `bills` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `roomstatus_checkout` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `roomstatus_checkout` AFTER UPDATE ON `bills` FOR EACH ROW UPDATE rooms SET rooms.IS_USABLE = 1 WHERE rooms.ROOM_ID = new.ROOM_ID */$$


DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
