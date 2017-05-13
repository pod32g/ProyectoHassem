-- MySQL dump 10.13  Distrib 5.5.55, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: proyecto
-- ------------------------------------------------------
-- Server version	5.5.55-0ubuntu0.14.04.1

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
-- Current Database: `proyecto`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `proyecto` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `proyecto`;

--
-- Table structure for table `Alumnos`
--

DROP TABLE IF EXISTS `Alumnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Alumnos` (
  `matricula` int(11) NOT NULL,
  `usuario_id` int(11) NOT NULL,
  `carrera` varchar(70) NOT NULL,
  `nivel` varchar(30) NOT NULL,
  `turno` varchar(30) NOT NULL,
  PRIMARY KEY (`matricula`),
  KEY `usuario_id` (`usuario_id`),
  CONSTRAINT `Alumnos_ibfk_1` FOREIGN KEY (`usuario_id`) REFERENCES `Usuario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Alumnos`
--

LOCK TABLES `Alumnos` WRITE;
/*!40000 ALTER TABLE `Alumnos` DISABLE KEYS */;
INSERT INTO `Alumnos` VALUES (2,7,'pop','pop','pop'),(122,4,'test','test','test'),(211403646,5,'Informatica','Licenciatura','Matutino');
/*!40000 ALTER TABLE `Alumnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `DatosContacto`
--

DROP TABLE IF EXISTS `DatosContacto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `DatosContacto` (
  `id_usuario` int(11) NOT NULL,
  `correo` varchar(70) NOT NULL,
  `cargo` varchar(70) NOT NULL,
  `telefono` varchar(70) NOT NULL,
  UNIQUE KEY `correo` (`correo`),
  KEY `id_usuario` (`id_usuario`),
  CONSTRAINT `DatosContacto_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `Usuario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DatosContacto`
--

LOCK TABLES `DatosContacto` WRITE;
/*!40000 ALTER TABLE `DatosContacto` DISABLE KEYS */;
INSERT INTO `DatosContacto` VALUES (6,'cjsdb','visudfbv','9'),(8,'ll','ll','12'),(2,'pod32g@mail.net','pod32g','123'),(1,'root@root.com','root','123'),(3,'test','test','123');
/*!40000 ALTER TABLE `DatosContacto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `DatosUsuario`
--

DROP TABLE IF EXISTS `DatosUsuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `DatosUsuario` (
  `usuario_id` int(11) NOT NULL,
  `nombre1` varchar(50) NOT NULL,
  `nombre2` varchar(50) DEFAULT NULL,
  `apellidoMaterno` varchar(50) DEFAULT NULL,
  `apellidoPaterno` varchar(50) DEFAULT NULL,
  KEY `usuario_id` (`usuario_id`),
  CONSTRAINT `DatosUsuario_ibfk_1` FOREIGN KEY (`usuario_id`) REFERENCES `Usuario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DatosUsuario`
--

LOCK TABLES `DatosUsuario` WRITE;
/*!40000 ALTER TABLE `DatosUsuario` DISABLE KEYS */;
INSERT INTO `DatosUsuario` VALUES (1,'root','root','root','root'),(2,'pod32g','pod32g','pod32g','pod32g'),(3,'test','test','test','test'),(4,'test2','test2','te','te'),(5,'David','Ivan','Perez','Salazar'),(6,'cosdhco','vsdnvo','vsoivns','vsoinvi'),(7,'lol','lol','lol','lol'),(8,'ll','ll','ll','ll');
/*!40000 ALTER TABLE `DatosUsuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Empresa`
--

DROP TABLE IF EXISTS `Empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Empresa` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(70) NOT NULL,
  KEY `id_usuario` (`id_usuario`),
  CONSTRAINT `Empresa_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `Usuario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Empresa`
--

LOCK TABLES `Empresa` WRITE;
/*!40000 ALTER TABLE `Empresa` DISABLE KEYS */;
INSERT INTO `Empresa` VALUES (8,'ll');
/*!40000 ALTER TABLE `Empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Profesores`
--

DROP TABLE IF EXISTS `Profesores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Profesores` (
  `codigo` int(50) NOT NULL,
  `usuario_id` int(11) NOT NULL,
  `carrera` varchar(50) NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `usuario_id` (`usuario_id`),
  CONSTRAINT `Profesores_ibfk_1` FOREIGN KEY (`usuario_id`) REFERENCES `Usuario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Profesores`
--

LOCK TABLES `Profesores` WRITE;
/*!40000 ALTER TABLE `Profesores` DISABLE KEYS */;
INSERT INTO `Profesores` VALUES (1,6,'vsdbni'),(123,3,'test');
/*!40000 ALTER TABLE `Profesores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Proyecto`
--

DROP TABLE IF EXISTS `Proyecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Proyecto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(70) NOT NULL,
  `fechaInicio` date NOT NULL,
  `fechaFin` date NOT NULL,
  `estatus` varchar(20) NOT NULL,
  `resultados` longtext,
  `objetivo` mediumtext NOT NULL,
  `alumno_encargado` int(11) NOT NULL,
  `maestro_encargado` int(11) NOT NULL,
  `empresa` varchar(70) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`),
  KEY `alumno_encargado` (`alumno_encargado`),
  KEY `maestro_encargado` (`maestro_encargado`),
  CONSTRAINT `Proyecto_ibfk_1` FOREIGN KEY (`alumno_encargado`) REFERENCES `Alumnos` (`matricula`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Proyecto_ibfk_2` FOREIGN KEY (`maestro_encargado`) REFERENCES `Profesores` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Proyecto`
--

LOCK TABLES `Proyecto` WRITE;
/*!40000 ALTER TABLE `Proyecto` DISABLE KEYS */;
INSERT INTO `Proyecto` VALUES (6,'blyat','2017-05-12','2017-05-27','en marcha','','vsdvsdv',122,123,'lol123'),(9,'csdcvsdvsvs','2017-05-12','2017-05-12','completado','','vsdvsdvsdv',2,1,'vsdvdsssdv'),(10,'ll','2017-05-12','2017-05-12','en marcha','','ll',211403646,1,'ll');
/*!40000 ALTER TABLE `Proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TipoUsuario`
--

DROP TABLE IF EXISTS `TipoUsuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `TipoUsuario` (
  `usuario_id` int(11) NOT NULL,
  `tipo` varchar(10) NOT NULL,
  KEY `usuario_id` (`usuario_id`),
  CONSTRAINT `TipoUsuario_ibfk_1` FOREIGN KEY (`usuario_id`) REFERENCES `Usuario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TipoUsuario`
--

LOCK TABLES `TipoUsuario` WRITE;
/*!40000 ALTER TABLE `TipoUsuario` DISABLE KEYS */;
INSERT INTO `TipoUsuario` VALUES (1,'admin'),(2,'admin'),(3,'teach'),(4,'student'),(5,'student'),(6,'teach'),(7,'student'),(8,'enter');
/*!40000 ALTER TABLE `TipoUsuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario`
--

DROP TABLE IF EXISTS `Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(70) NOT NULL,
  `password` varchar(70) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `userName` (`userName`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario`
--

LOCK TABLES `Usuario` WRITE;
/*!40000 ALTER TABLE `Usuario` DISABLE KEYS */;
INSERT INTO `Usuario` VALUES (1,'root','theriata'),(2,'pod32g','theriata'),(3,'test','test'),(4,'te','test'),(5,'p0x21g','theriata'),(6,'lol','lol'),(7,'pop','pop'),(8,'ll','ll');
/*!40000 ALTER TABLE `Usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-12 23:03:47
