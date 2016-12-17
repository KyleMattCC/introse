-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: introse
-- ------------------------------------------------------
-- Server version	5.7.14-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `academicyear`
--

DROP TABLE IF EXISTS `academicyear`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `academicyear` (
  `yearid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `yearstart` year(4) NOT NULL,
  `yearend` year(4) NOT NULL,
  `status` char(1) NOT NULL,
  PRIMARY KEY (`yearid`),
  UNIQUE KEY `yearid_UNIQUE` (`yearid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `academicyear`
--

LOCK TABLES `academicyear` WRITE;
/*!40000 ALTER TABLE `academicyear` DISABLE KEYS */;
INSERT INTO `academicyear` VALUES (1,2015,2016,'R'),(2,2016,2017,'A');
/*!40000 ALTER TABLE `academicyear` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `account` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `encodername` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `accounttype` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES (101,'Jason Sy','syjason','Lead','Jason'),(102,'Ralph Bravante','introse','Regular','Ralph'),(103,'Ged','gedagustin','Regular','Regular'),(104,'Kyle Chuapapi','chuakyle','Lead','Lead'),(105,'Sir Ryan','lasalle','Lead','RyanPogi');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `attendance` (
  `attendanceid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `absent_date` date NOT NULL,
  `courseoffering_id` int(11) unsigned NOT NULL,
  `remarks_cd` char(2) NOT NULL,
  `enc_date` date NOT NULL,
  `encoder` varchar(45) NOT NULL,
  `checker` varchar(45) NOT NULL,
  `status` char(1) NOT NULL,
  `report_status` varchar(45) NOT NULL DEFAULT 'Pending',
  PRIMARY KEY (`attendanceid`),
  UNIQUE KEY `attendanceid_UNIQUE` (`attendanceid`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (1,'2016-11-16',1,'LA','2016-11-21','Jason','Dixie','A','Pending'),(2,'2016-11-24',2,'ED','2016-12-05','Ged','Dixie','D','Pending'),(6,'2016-11-21',3,'ED','2016-11-21','Ged','Eric','A','Pending'),(16,'2016-12-15',5,'SW','2016-12-15','Kyle Chuapapi','Noel','A','Generated'),(17,'2016-12-15',9,'XX','2016-12-15','Kyle Chuapapi','Noel','A','Generated'),(18,'2016-12-15',10,'XX','2016-12-15','Kyle Chuapapi','Noel','A','Generated'),(19,'2016-12-15',12,'XX','2016-12-15','Kyle Chuapapi','Noel','A','Generated'),(20,'2016-12-16',13,'LA','2016-12-16','Jason Sy','Eric Dixie','A','Generated');
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `college`
--

DROP TABLE IF EXISTS `college`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `college` (
  `college_code` char(5) NOT NULL,
  `college_name` varchar(45) NOT NULL,
  PRIMARY KEY (`college_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `college`
--

LOCK TABLES `college` WRITE;
/*!40000 ALTER TABLE `college` DISABLE KEYS */;
INSERT INTO `college` VALUES ('CCS','College of Computer Studies'),('CED','College of Education'),('CLA','Colelge of Liberal Arts'),('COB','College of Business'),('COE','College of Engineering'),('COS','College of Science'),('SOE','School of Economics'),('STC','Science and Technology Complex');
/*!40000 ALTER TABLE `college` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `course` (
  `course_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `course_cd` char(7) NOT NULL,
  `units` float unsigned NOT NULL,
  `offered_to` char(1) NOT NULL,
  PRIMARY KEY (`course_id`),
  UNIQUE KEY `course_id_UNIQUE` (`course_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course`
--

LOCK TABLES `course` WRITE;
/*!40000 ALTER TABLE `course` DISABLE KEYS */;
INSERT INTO `course` VALUES (1,'OBJECTP',3,'U'),(2,'PERSEF1',2,'U'),(3,'COMPRO1',3,'U'),(4,'COMPRO2',3,'U'),(5,'LBY-IOT',1,'U'),(6,'COMPASM',3,'U'),(7,'COMORGA',3,'U'),(8,'PERSEF2',2,'U'),(9,'SOCTEC1',3,'U'),(10,'SOCTEC2',3,'U'),(11,'CMPILER',3,'U'),(12,'SECURDE',3,'U'),(13,'SWDESPA',3,'U'),(14,'SOCTEC4',3,'G'),(15,'ADVANDB',3,'G'),(16,'MASTERL',2,'G'),(17,'PERSEF9',3,'G'),(18,'PERSEF8',2,'U'),(19,'KASPIL1',3,'U');
/*!40000 ALTER TABLE `course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courseoffering`
--

DROP TABLE IF EXISTS `courseoffering`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courseoffering` (
  `courseoffering_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `course_id` int(11) unsigned NOT NULL,
  `termid` int(11) unsigned NOT NULL,
  `facref_no` int(11) unsigned NOT NULL,
  `section` char(3) NOT NULL,
  `room` varchar(45) NOT NULL,
  `daysched` char(2) NOT NULL,
  `timestart` int(4) unsigned zerofill NOT NULL,
  `timeend` int(4) unsigned zerofill NOT NULL,
  `hours` float unsigned NOT NULL,
  `status` char(1) NOT NULL,
  PRIMARY KEY (`courseoffering_id`),
  UNIQUE KEY `courseoffering_id_UNIQUE` (`courseoffering_id`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courseoffering`
--

LOCK TABLES `courseoffering` WRITE;
/*!40000 ALTER TABLE `courseoffering` DISABLE KEYS */;
INSERT INTO `courseoffering` VALUES (26,17,1,6,'S14','G101','MW',1245,1415,1.5,'A'),(27,18,1,1,'EK','G101','MW',1245,1415,1.5,'A'),(28,3,1,7,'S17','G302B','TH',0915,1045,1.5,'A'),(29,1,1,2,'S18','G301A','TH',0730,0900,1.5,'A'),(30,19,1,3,'EC','G401','TH',1430,1600,1.5,'A'),(31,17,1,6,'S14','G101','MW',1245,1415,1.5,'A'),(32,18,1,1,'EK','G101','MW',1245,1415,1.5,'A'),(33,3,1,7,'S17','G302B','TH',0915,1045,1.5,'A'),(34,1,1,2,'S18','G301A','TH',0730,0900,1.5,'A'),(35,19,1,3,'EC','G401','TH',1430,1600,1.5,'A'),(36,17,1,6,'S14','G101','MW',1245,1415,1.5,'A'),(37,18,1,1,'EK','G101','MW',1245,1415,1.5,'A'),(38,3,1,7,'S17','G302B','TH',0915,1045,1.5,'A'),(39,1,1,2,'S18','G301A','TH',0730,0900,1.5,'A'),(40,19,1,3,'EC','G401','TH',1430,1600,1.5,'A'),(41,17,1,6,'S14','G101','MW',1245,1415,1.5,'A'),(42,18,1,1,'EK','G101','MW',1245,1415,1.5,'A'),(43,3,1,7,'S17','G302B','TH',0915,1045,1.5,'A'),(44,1,1,2,'S18','G301A','TH',0730,0900,1.5,'A'),(45,19,1,3,'EC','G401','TH',1430,1600,1.5,'A');
/*!40000 ALTER TABLE `courseoffering` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `departmentid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `departmentname` varchar(45) NOT NULL,
  `college_code` char(3) NOT NULL,
  PRIMARY KEY (`departmentid`),
  UNIQUE KEY `departmentid_UNIQUE` (`departmentid`)
) ENGINE=InnoDB AUTO_INCREMENT=1007 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1001,'Physics Department','COS'),(1002,'Software Technology','CCS'),(1003,'Information Technology Department','CCS'),(1004,'History Department','CED'),(1005,'Filipino Department','CED'),(1006,'Accountancy Department','COB');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faculty`
--

DROP TABLE IF EXISTS `faculty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `faculty` (
  `facref_no` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `facultyid` char(8) NOT NULL,
  `f_firstname` varchar(45) NOT NULL,
  `f_middlename` varchar(45) DEFAULT NULL,
  `f_lastname` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  `departmentid` int(11) unsigned NOT NULL,
  `status` char(1) NOT NULL,
  PRIMARY KEY (`facref_no`),
  UNIQUE KEY `facref_no_UNIQUE` (`facref_no`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faculty`
--

LOCK TABLES `faculty` WRITE;
/*!40000 ALTER TABLE `faculty` DISABLE KEYS */;
INSERT INTO `faculty` VALUES (1,'97055286','Kevin','A.','Dumalay','kevin_dumalay@dlsu.edu.ph',1001,'A'),(2,'11292828','Star','R.','Yu','star_yu@dlsu.edu.ph',1002,'A'),(3,'97066783','Kyle','B. ','Chua','gedrite.agustin@live.com',1004,'A'),(4,'20145489','Ted','C.','Lim','ted_lim@dlsu.edu.ph',1003,'A'),(5,'97026012','Ralph','S.','Bravante','ralphchristianbravante@yahoo.com',1006,'A'),(6,'11428066','Jason','A.','Sy','jason_sy@dlsu.edu.ph',1004,'A'),(7,'98011001','Florante','B.','Salvador','florante_salvador@dlsu.edu.ph',1002,'A');
/*!40000 ALTER TABLE `faculty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `makeup`
--

DROP TABLE IF EXISTS `makeup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `makeup` (
  `makeupid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `courseoffering_id` int(11) unsigned NOT NULL,
  `timestart` int(4) unsigned NOT NULL,
  `timeend` int(4) unsigned NOT NULL,
  `hours` double unsigned NOT NULL,
  `room` varchar(45) NOT NULL,
  `reason_cd` char(2) NOT NULL,
  `makeup_date` date NOT NULL,
  `enc_date` date NOT NULL,
  `encoder` varchar(45) NOT NULL,
  `status` char(1) NOT NULL,
  PRIMARY KEY (`makeupid`),
  UNIQUE KEY `makeupid_UNIQUE` (`makeupid`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `makeup`
--

LOCK TABLES `makeup` WRITE;
/*!40000 ALTER TABLE `makeup` DISABLE KEYS */;
INSERT INTO `makeup` VALUES (6,2,900,1030,1.5,'g203','AC','2016-12-05','2016-12-05','Ged','A'),(8,1,1100,1400,3,'A401','FT','2016-12-05','2016-12-05','Ged','A'),(11,2,1430,1600,1.5,'g102','FT','2016-12-07','2016-12-07','Jason','A'),(13,2,1245,1415,1.5,'G210','XX','2016-12-08','2016-12-07','Jason','A'),(14,2,1200,1330,1.5,'g401','OB','2016-12-07','2016-12-07','Jason','D'),(16,2,1230,1430,2,'G401','XX','2016-12-16','2016-12-16','Kyle Chuapapi','A'),(17,2,1230,1430,2,'G401','XX','2016-12-16','2016-12-16','Kyle Chuapapi','A');
/*!40000 ALTER TABLE `makeup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reason`
--

DROP TABLE IF EXISTS `reason`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reason` (
  `reason_cd` char(2) NOT NULL,
  `reason_desc` varchar(45) NOT NULL,
  PRIMARY KEY (`reason_cd`),
  UNIQUE KEY `reason_cd_UNIQUE` (`reason_cd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reason`
--

LOCK TABLES `reason` WRITE;
/*!40000 ALTER TABLE `reason` DISABLE KEYS */;
/*!40000 ALTER TABLE `reason` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reasons`
--

DROP TABLE IF EXISTS `reasons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reasons` (
  `reason_cd` char(2) NOT NULL,
  `reason_des` varchar(45) NOT NULL,
  PRIMARY KEY (`reason_cd`),
  UNIQUE KEY `reason_cd_UNIQUE` (`reason_cd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reasons`
--

LOCK TABLES `reasons` WRITE;
/*!40000 ALTER TABLE `reasons` DISABLE KEYS */;
INSERT INTO `reasons` VALUES ('AC','Alternative Class'),('CF','Attended Conference'),('FT','Field Trip'),('OB','Official Business'),('OL','Online Class'),('PM','Personal Matter'),('XX','Others');
/*!40000 ALTER TABLE `reasons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `remarks`
--

DROP TABLE IF EXISTS `remarks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `remarks` (
  `remark_cd` char(2) NOT NULL,
  `remark_des` varchar(45) NOT NULL,
  PRIMARY KEY (`remark_cd`),
  UNIQUE KEY `remark_cd_UNIQUE` (`remark_cd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `remarks`
--

LOCK TABLES `remarks` WRITE;
/*!40000 ALTER TABLE `remarks` DISABLE KEYS */;
INSERT INTO `remarks` VALUES ('AB','Absent'),('ED','Early Dismissal'),('LA','Late'),('SB','Substitute'),('SW','Seatwork'),('VR','Vacant Room'),('XX','Reason Unknown');
/*!40000 ALTER TABLE `remarks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `term`
--

DROP TABLE IF EXISTS `term`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `term` (
  `termid` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `yearid` int(11) unsigned NOT NULL,
  `term_no` int(1) unsigned NOT NULL,
  `start` date NOT NULL,
  `end` date NOT NULL,
  `status` char(1) NOT NULL,
  PRIMARY KEY (`termid`),
  UNIQUE KEY `termid_UNIQUE` (`termid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `term`
--

LOCK TABLES `term` WRITE;
/*!40000 ALTER TABLE `term` DISABLE KEYS */;
INSERT INTO `term` VALUES (1,2,1,'2016-08-28','2016-12-20','A'),(2,1,1,'2015-05-23','2015-08-25','R'),(3,1,2,'2015-09-14','2015-12-14','R'),(4,1,3,'2016-01-05','2016-04-02','R');
/*!40000 ALTER TABLE `term` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-17 21:55:54
