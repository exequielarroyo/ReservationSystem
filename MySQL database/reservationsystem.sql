/*
SQLyog Community v13.1.7 (64 bit)
MySQL - 8.0.21 : Database - reservationsystem
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`reservationsystem` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `reservationsystem`;

/*Table structure for table `room` */

DROP TABLE IF EXISTS `room`;

CREATE TABLE `room` (
  `roomID` int NOT NULL AUTO_INCREMENT,
  `roomNumber` int DEFAULT NULL,
  `roomPersonCount` int DEFAULT NULL,
  `roomStatus` varchar(24) DEFAULT NULL,
  `roomPrice` decimal(6,2) DEFAULT NULL,
  `roomDetails` varchar(100) DEFAULT NULL,
  `roomOutDate` date DEFAULT NULL,
  `roomInDate` date DEFAULT NULL,
  PRIMARY KEY (`roomID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `room` */

insert  into `room`(`roomID`,`roomNumber`,`roomPersonCount`,`roomStatus`,`roomPrice`,`roomDetails`,`roomOutDate`,`roomInDate`) values 
(1,103,5,'Available',999.99,'Maganda po ito','2021-03-01','2021-02-22');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `userID` int NOT NULL AUTO_INCREMENT,
  `userName` varchar(24) DEFAULT NULL,
  `userPassword` varchar(24) DEFAULT NULL,
  `userFirstName` varchar(24) DEFAULT NULL,
  `userLastName` varchar(24) DEFAULT NULL,
  `userNumber` varchar(11) DEFAULT NULL,
  `userSex` varchar(6) DEFAULT NULL,
  `userBirthdate` date DEFAULT NULL,
  `userEmail` varchar(50) DEFAULT NULL,
  `userType` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `user` */

insert  into `user`(`userID`,`userName`,`userPassword`,`userFirstName`,`userLastName`,`userNumber`,`userSex`,`userBirthdate`,`userEmail`,`userType`) values 
(1,'master','1234','Exequiel','Arroyo','09123456789','Male','2021-02-22','zekielarroyo@gmail.com','admin');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
