-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: csmicare
-- ------------------------------------------------------
-- Server version	8.0.13
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `csmicare`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `csmicare` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;

USE `csmicare`;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `patients` (
  `Id` char(36) NOT NULL,
  `LastName` longtext,
  `FirstName` longtext,
  `Timestamp` datetime NOT NULL,
  `DateOfBirth` datetime DEFAULT NULL,
  `SchoolId` varchar(15) DEFAULT NULL,
  `Gender` int(11) DEFAULT NULL,
  `Type` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES ('08d664e4-fc6b-e7ce-67c6-26b9f876cf21','Beleren','Jace','2019-04-05 00:00:00','1999-02-03 00:00:00','2019-1-50226e41',1,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf22','Vess','Liliana','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e42',0,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf23','Nalaar','Chandra','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e43',0,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf24','Revane','Nissa','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e44',0,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf25','Tirel','Elspeth','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e45',0,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf26','Moonsage','Tamiyo','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e46',0,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf27','Markov','Sorin','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e47',1,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf28','Vol','Sarkhan','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e48',1,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf29','Wildspeaker','Garruk','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e49',1,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf30','Jura','Gideon','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-50226e50',1,0),('08d664e4-fc6b-e7ce-67c6-26b9f876cf31','Silvergolem','Karn','2019-04-03 14:22:39','1999-04-03 14:22:39',NULL,1,3),('08d664e4-fc6b-e7ce-67c6-26b9f876cf32','Goldmane','Ajani','2019-04-03 14:22:39','1999-04-03 14:22:39',NULL,1,3),('08d664e4-fc6b-e7ce-67c6-26b9f876cf33','Bolas','Nicol','2019-04-03 14:22:39','1999-04-03 14:22:39',NULL,1,3),('08d664e4-fc6b-e7ce-67c6-26b9f876cf34','Elderdragon','Ugin','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-60226100',1,1),('08d664e4-fc6b-e7ce-67c6-26b9f876cf35','Planeswalker','Urza','2019-04-03 14:22:39','1999-04-03 14:22:39','2019-1-60226100',1,1);
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-04-06 11:50:26
