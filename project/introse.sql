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
  `yearid` int(11) NOT NULL,
  `yearname` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`yearid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `academicyear`
--

LOCK TABLES `academicyear` WRITE;
/*!40000 ALTER TABLE `academicyear` DISABLE KEYS */;
INSERT INTO `academicyear` VALUES (1,'2016'),(2,'2015');
/*!40000 ALTER TABLE `academicyear` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `account` (
  `id` int(11) NOT NULL,
  `encodername` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `accounttype` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES (101,'Jason Sy','123','Lead'),(102,'Ralph Bravante','456','Regular');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `attendance` (
  `attendanceid` int(11) NOT NULL,
  `courseoffering_id` int(11) DEFAULT NULL,
  `statusid` varchar(1) DEFAULT NULL,
  `remarks` varchar(100) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  `timeset` varchar(45) DEFAULT NULL,
  `encoder` varchar(45) DEFAULT NULL,
  `checker` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`attendanceid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (1,1,'A','34 mins late','Sunday, October 23, 2016','4:15','a','Jason'),(2,2,'A','34 mins late','Sunday, October 23, 2016','4:15','a','Jason'),(3,3,'A','dsdsd','Tuesday, October 25, 2016','456','a','ged');
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `class`
--

DROP TABLE IF EXISTS `class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `class` (
  `classid` int(11) NOT NULL,
  `class_section` varchar(45) DEFAULT NULL,
  `units` int(11) DEFAULT NULL,
  `class_name` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`classid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class`
--

LOCK TABLES `class` WRITE;
/*!40000 ALTER TABLE `class` DISABLE KEYS */;
/*!40000 ALTER TABLE `class` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `college`
--

DROP TABLE IF EXISTS `college`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `college` (
  `college_code` varchar(10) NOT NULL,
  `college_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`college_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `college`
--

LOCK TABLES `college` WRITE;
/*!40000 ALTER TABLE `college` DISABLE KEYS */;
INSERT INTO `college` VALUES ('CCS','College of Computer Studies'),('CED','College of Education'),('CLA','Colelge of Liberal Arts'),('COB','College of Business'),('COE ','College of Engineering'),('COS','College of Science'),('SOE','School of Economics'),('STC','Science and Technology Complex');
/*!40000 ALTER TABLE `college` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `course` (
  `courseid` int(11) NOT NULL,
  `coursecode` varchar(45) DEFAULT NULL,
  `coursename` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`courseid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course`
--

LOCK TABLES `course` WRITE;
/*!40000 ALTER TABLE `course` DISABLE KEYS */;
/*!40000 ALTER TABLE `course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courseoffering`
--

DROP TABLE IF EXISTS `courseoffering`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courseoffering` (
  `couseoffering_id` int(11) NOT NULL,
  `courseid` int(11) DEFAULT NULL,
  `section` varchar(45) DEFAULT NULL,
  `facultyid` varchar(45) DEFAULT NULL,
  `termid` int(11) DEFAULT NULL,
  `day` varchar(2) DEFAULT NULL,
  `timestart` varchar(45) DEFAULT NULL,
  `timeend` varchar(45) DEFAULT NULL,
  `room` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`couseoffering_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courseoffering`
--

LOCK TABLES `courseoffering` WRITE;
/*!40000 ALTER TABLE `courseoffering` DISABLE KEYS */;
/*!40000 ALTER TABLE `courseoffering` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `departmentid` int(11) NOT NULL,
  `departmentname` varchar(45) DEFAULT NULL,
  `college_code` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`departmentid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
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
  `facref_no` int(11) NOT NULL AUTO_INCREMENT,
  `facultyid` varchar(45) NOT NULL,
  `f_firstname` varchar(45) DEFAULT NULL,
  `f_middlename` varchar(45) DEFAULT NULL,
  `f_lastname` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `mobilenumber` int(11) DEFAULT NULL,
  `departmentid` varchar(45) DEFAULT NULL,
  `status` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`facref_no`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faculty`
--

LOCK TABLES `faculty` WRITE;
/*!40000 ALTER TABLE `faculty` DISABLE KEYS */;
INSERT INTO `faculty` VALUES (1,'112131141','Kevin','A.','Dumalay','kevin_dumalay@dlsu.edu.ph',1091239123,'1001',NULL),(2,'11292828','Star','R.','Yu','star_yu@dlsu.edu.ph',918374719,'1002',NULL),(3,'121411141','Kyle','B. ','Chua','kyle_chua@dlsu.edu.ph',1217418711,'1004',NULL),(4,'21312441','Ted','C.','Lim','ted_lim@dlsu.edu.ph',1238128391,'1003',NULL);
/*!40000 ALTER TABLE `faculty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `makeup`
--

DROP TABLE IF EXISTS `makeup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `makeup` (
  `makeupid` int(11) NOT NULL,
  `facultyid` int(11) DEFAULT NULL,
  `date` varchar(45) DEFAULT NULL,
  `day` varchar(45) DEFAULT NULL,
  `timestart` varchar(45) DEFAULT NULL,
  `timeend` varchar(45) DEFAULT NULL,
  `room` varchar(45) DEFAULT NULL,
  `date_encoded` varchar(45) DEFAULT NULL,
  `date_filed` varchar(45) DEFAULT NULL,
  `encoder` varchar(45) DEFAULT NULL,
  `checker` varchar(45) DEFAULT NULL,
  `madeup` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`makeupid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `makeup`
--

LOCK TABLES `makeup` WRITE;
/*!40000 ALTER TABLE `makeup` DISABLE KEYS */;
INSERT INTO `makeup` VALUES (401,112131141,'9/11/2016','H','11:00','12:30','Y405','9/11/2016','9/13/2016','Ralph Bravante','Ged Agustin','no');
/*!40000 ALTER TABLE `makeup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `term`
--

DROP TABLE IF EXISTS `term`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `term` (
  `termid` int(11) NOT NULL,
  `start` varchar(45) DEFAULT NULL,
  `end` varchar(45) DEFAULT NULL,
  `term` int(11) DEFAULT NULL,
  `yearid` int(11) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`termid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `term`
--

LOCK TABLES `term` WRITE;
/*!40000 ALTER TABLE `term` DISABLE KEYS */;
INSERT INTO `term` VALUES (10001,'07/1/2016','10/14/2016',2,1000001,'Finished');
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

-- Dump completed on 2016-11-09 21:10:01
