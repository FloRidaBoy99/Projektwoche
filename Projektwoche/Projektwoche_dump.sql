-- MySQL dump 10.16  Distrib 10.1.19-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: localhost
-- ------------------------------------------------------
-- Server version	10.1.19-MariaDB

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
-- Current Database: `projektwoche2018`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `projektwoche2018` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `projektwoche2018`;

--
-- Table structure for table `klasse`
--

DROP TABLE IF EXISTS `klasse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `klasse` (
  `klasseID` int(11) NOT NULL AUTO_INCREMENT,
  `bezeichnung` varchar(50) NOT NULL,
  PRIMARY KEY (`klasseID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klasse`
--

LOCK TABLES `klasse` WRITE;
/*!40000 ALTER TABLE `klasse` DISABLE KEYS */;
INSERT INTO `klasse` VALUES (1,'AIF11'),(2,'AIF21'),(3,'AIF31'),(4,'AIA11'),(5,'AIA21'),(6,'AIA31');
/*!40000 ALTER TABLE `klasse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rel_workshop_schueler_wahl`
--

DROP TABLE IF EXISTS `rel_workshop_schueler_wahl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rel_workshop_schueler_wahl` (
  `wahlID` int(11) NOT NULL AUTO_INCREMENT,
  `workshopID` int(11) NOT NULL,
  `schuelerID` int(11) NOT NULL,
  PRIMARY KEY (`wahlID`),
  KEY `workshopID` (`workshopID`),
  KEY `schuelerID` (`schuelerID`),
  CONSTRAINT `rel_workshop_schueler_wahl_ibfk_1` FOREIGN KEY (`workshopID`) REFERENCES `workshop` (`workshopID`) ON DELETE CASCADE,
  CONSTRAINT `rel_workshop_schueler_wahl_ibfk_2` FOREIGN KEY (`schuelerID`) REFERENCES `schueler` (`schuelerID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rel_workshop_schueler_wahl`
--

LOCK TABLES `rel_workshop_schueler_wahl` WRITE;
/*!40000 ALTER TABLE `rel_workshop_schueler_wahl` DISABLE KEYS */;
/*!40000 ALTER TABLE `rel_workshop_schueler_wahl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schueler`
--

DROP TABLE IF EXISTS `schueler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schueler` (
  `schuelerID` int(11) NOT NULL AUTO_INCREMENT,
  `vorname` char(30) NOT NULL,
  `nachname` char(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `klasseID` int(11) NOT NULL,
  PRIMARY KEY (`schuelerID`),
  KEY `klasseID` (`klasseID`),
  CONSTRAINT `schueler_ibfk_1` FOREIGN KEY (`klasseID`) REFERENCES `klasse` (`klasseID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schueler`
--

LOCK TABLES `schueler` WRITE;
/*!40000 ALTER TABLE `schueler` DISABLE KEYS */;
INSERT INTO `schueler` VALUES (3,'asfa','adfa','adsfa',3),(5,'asfjj','afwdawf','sdfgh',4);
/*!40000 ALTER TABLE `schueler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workshop`
--

DROP TABLE IF EXISTS `workshop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `workshop` (
  `workshopID` int(11) NOT NULL AUTO_INCREMENT,
  `nr` int(11) NOT NULL,
  `titel` varchar(150) NOT NULL,
  `kosten` varchar(100) NOT NULL,
  `beschreibung` text NOT NULL,
  `voraussetzungen` text NOT NULL,
  `teilnehmerMin` int(11) NOT NULL,
  `teilnehmerMax` int(11) NOT NULL,
  PRIMARY KEY (`workshopID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workshop`
--

LOCK TABLES `workshop` WRITE;
/*!40000 ALTER TABLE `workshop` DISABLE KEYS */;
INSERT INTO `workshop` VALUES (2,0,'aijofhuieq','','asfafs','',0,0),(5,26,'kacken123','12','asdfaqdfqw','asd',1,2),(6,12,'asd','','afwfawe','asd',0,1);
/*!40000 ALTER TABLE `workshop` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-26 21:18:53
