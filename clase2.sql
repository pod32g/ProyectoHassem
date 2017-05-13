-- MySQL dump 10.13  Distrib 5.7.18, for Linux (x86_64)
--
-- Host: localhost    Database: clase2
-- ------------------------------------------------------
-- Server version	5.7.18-0ubuntu0.16.04.1

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
-- Current Database: `clase2`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `clase2` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `clase2`;

--
-- Table structure for table `auto`
--

DROP TABLE IF EXISTS `auto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `auto` (
  `idAutomovil` int(11) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `linea` varchar(50) DEFAULT 'NISSAN',
  `kilometraje` int(11) DEFAULT NULL,
  `costo_renta` float DEFAULT NULL,
  PRIMARY KEY (`idAutomovil`),
  UNIQUE KEY `marca` (`marca`),
  UNIQUE KEY `modelo` (`modelo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auto`
--

LOCK TABLES `auto` WRITE;
/*!40000 ALTER TABLE `auto` DISABLE KEYS */;
INSERT INTO `auto` VALUES (1,'Toyota','Yaris','Toyota',90,2000),(2,'Test','Yest','Test',900,2300),(3,'Test2','Yest2','Test2',9020,23300),(4,'Test3','Yest3','Test3',9320,2300),(5,'Test4','Yest4','Test4',9420,2400),(6,'Test5','Yest5','Test5',9450,2450),(7,'Test6','Yest6','Test6',9456,2456),(8,'Test8','Yest8','Tes86',9856,2856),(9,'Test9','Yest9','Te986',9896,2956),(10,'Teft9','Yfst9','NISSAN',9896,2956);
/*!40000 ALTER TABLE `auto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `rfc` varchar(13) NOT NULL,
  `nombre` varchar(70) NOT NULL,
  `direccion` varchar(80) NOT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `vehiculos_rentados` int(11) DEFAULT NULL,
  PRIMARY KEY (`rfc`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES ('ABC123894245J','Juan','Aqui','123123',1),('ABC123test45J','Test','Aqui2','124123',2),('ABC123testg5J','Test','Aqui2','124123',3),('ABC123testt5g','Test','Aqui5','424123',2),('ABC123testt5J','Test','Aqui3','424123',2);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER trig_ve_check BEFORE INSERT ON cliente

FOR EACH ROW
BEGIN
    IF (NEW.vehiculos_rentados > 3) THEN
        SIGNAL SQLSTATE '12345'
            SET MESSAGE_TEXT = 'Wrong format';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `detallerenta`
--

DROP TABLE IF EXISTS `detallerenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallerenta` (
  `folio` int(11) NOT NULL,
  `idAuto` int(11) NOT NULL,
  `diasRenta` int(11) NOT NULL,
  KEY `folio` (`folio`),
  KEY `idAuto` (`idAuto`),
  CONSTRAINT `detallerenta_ibfk_1` FOREIGN KEY (`folio`) REFERENCES `renta` (`folio`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `detallerenta_ibfk_2` FOREIGN KEY (`idAuto`) REFERENCES `auto` (`idAutomovil`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallerenta`
--

LOCK TABLES `detallerenta` WRITE;
/*!40000 ALTER TABLE `detallerenta` DISABLE KEYS */;
INSERT INTO `detallerenta` VALUES (1,1,2),(1,2,2),(2,3,2),(2,4,2),(3,5,2),(3,6,2),(4,7,2),(4,8,2),(5,9,2),(5,10,2);
/*!40000 ALTER TABLE `detallerenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(80) NOT NULL,
  `fechaIngreso` date NOT NULL,
  `descripcionPuesto` varchar(100) DEFAULT NULL,
  `salarioDiario` float NOT NULL,
  PRIMARY KEY (`codigo`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('1','Test','1990-01-01','test',200),('2','Test2','1991-01-01','test',100),('3','Test3','1993-01-01','test',150),('4','Test4','1994-01-01','test',140),('5','Test5','1995-01-01','test',170);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER trig_sa_check BEFORE INSERT ON empleado
FOR EACH ROW
BEGIN
    IF (NEW.salarioDiario < 80 && NEW.salarioDiario > 200) THEN
        SIGNAL SQLSTATE '12345'
            SET MESSAGE_TEXT = 'Wrong';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `renta`
--

DROP TABLE IF EXISTS `renta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `renta` (
  `folio` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `rfc_cliente` varchar(13) DEFAULT NULL,
  `codigo_empleado` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`folio`),
  KEY `rfc_cliente` (`rfc_cliente`),
  KEY `codigo_empleado` (`codigo_empleado`),
  CONSTRAINT `renta_ibfk_1` FOREIGN KEY (`rfc_cliente`) REFERENCES `cliente` (`rfc`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `renta_ibfk_2` FOREIGN KEY (`codigo_empleado`) REFERENCES `empleado` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `renta`
--

LOCK TABLES `renta` WRITE;
/*!40000 ALTER TABLE `renta` DISABLE KEYS */;
INSERT INTO `renta` VALUES (1,'1996-02-02','ABC123894245J','1'),(2,'1996-02-03','ABC123test45J','2'),(3,'1996-02-04','ABC123testg5J','3'),(4,'1996-02-05','ABC123testt5g','4'),(5,'1996-02-06','ABC123testt5J','5');
/*!40000 ALTER TABLE `renta` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER trig_fo_check BEFORE INSERT ON renta
FOR EACH ROW
BEGIN
    IF (NEW.folio > 10000) THEN
        SIGNAL SQLSTATE '12345'
            SET MESSAGE_TEXT = 'Wrong';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-13  1:44:51
