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

/*Data for the table `bill_fines` */

/*Data for the table `bills` */

/*Data for the table `categories` */

insert  into `categories`(`CATEGORY_ID`,`CATEGORY_NAME`) values 
('C01','Basic'),
('C02','Basic+'),
('C03','Standard'),
('C04','Family'),
('C05','Family 6'),
('C07','President Suite '),
('C08','President Suite '),
('C09','VIP'),
('C10','VVIP');

/*Data for the table `customers` */

insert  into `customers`(`CUSTOMER_ID`,`CUSTOMER_NAME`,`CUSTOMER_ADDRESS`,`CUSTOMER_PHONE`) values 
('3578151107040001','Roy','Jalan Ngantuk Sekali No. 17','81348595268'),
('3578150312040001','Nixon','Jalan Kebenaran No. 101','821568954389'),
('3578151002040001','Albert','Jalan Bersamamu Senang No. 72','81375265985');

/*Data for the table `d_bills` */

/*Data for the table `facilities` */

/*Data for the table `fines` */

/*Data for the table `room_inventory` */

/*Data for the table `rooms` */

/*Data for the table `staffs` */

/*Data for the table `vouchers` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
