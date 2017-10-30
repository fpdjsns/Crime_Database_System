-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: crimedata
-- ------------------------------------------------------
-- Server version	5.7.12-log

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
-- Table structure for table `applicant`
--

DROP TABLE IF EXISTS `applicant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `applicant` (
  `a_id` int(11) NOT NULL AUTO_INCREMENT,
  `a_date` datetime DEFAULT NULL,
  `h_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`a_id`),
  KEY `h_id` (`h_id`),
  CONSTRAINT `applicant_ibfk_1` FOREIGN KEY (`h_id`) REFERENCES `human` (`h_id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicant`
--

LOCK TABLES `applicant` WRITE;
/*!40000 ALTER TABLE `applicant` DISABLE KEYS */;
INSERT INTO `applicant` VALUES (1,'2011-04-17 08:05:55',1),(2,'2012-12-22 09:37:46',2),(3,'2013-07-30 12:47:20',3),(4,'2015-02-01 22:10:25',4),(5,'2012-06-09 21:20:09',5),(6,'2010-04-20 16:05:55',6),(7,'2015-06-10 02:37:46',7),(8,'2012-10-04 05:47:20',8),(9,'2014-11-22 08:10:25',9),(10,'2015-06-02 12:20:09',10),(11,'2016-12-12 20:05:55',11),(12,'2012-06-07 01:37:46',12),(13,'2016-06-09 02:47:20',13),(14,'2012-01-10 05:10:25',14),(15,'2011-08-14 18:20:09',15),(16,'2011-02-22 22:05:55',16),(17,'2015-11-30 19:20:04',17),(18,'2018-11-12 23:37:46',18),(19,'2015-01-22 20:10:25',19),(20,'2012-04-12 21:20:09',20),(21,'2015-07-22 22:05:55',21),(22,'2012-08-12 23:37:46',22),(23,'2014-06-22 22:41:44',23),(24,'2012-08-10 05:10:25',24),(25,'2011-02-14 12:20:09',25),(26,'2014-04-17 14:05:55',26),(27,'2013-06-17 18:37:46',27),(28,'2010-01-17 02:22:46',28),(29,'2012-03-23 06:20:46',29),(30,'2013-06-26 20:20:46',30),(31,'2015-07-29 10:20:46',31),(32,'2012-01-22 12:40:46',32),(33,'2011-02-17 11:20:46',33),(34,'2012-06-29 13:15:46',34);
/*!40000 ALTER TABLE `applicant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classify`
--

DROP TABLE IF EXISTS `classify`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `classify` (
  `c_id` int(11) NOT NULL,
  `crl_id` int(11) NOT NULL,
  PRIMARY KEY (`c_id`,`crl_id`),
  KEY `c_id` (`c_id`),
  KEY `crl_id` (`crl_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classify`
--

LOCK TABLES `classify` WRITE;
/*!40000 ALTER TABLE `classify` DISABLE KEYS */;
INSERT INTO `classify` VALUES (1,1),(2,2),(3,3),(5,6),(6,7),(7,7),(10,2),(11,5),(12,8),(13,9),(16,4),(17,10),(18,11),(19,12),(20,11),(21,1),(22,13),(23,4),(24,11),(25,2),(27,14),(28,15),(30,11);
/*!40000 ALTER TABLE `classify` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `crime`
--

DROP TABLE IF EXISTS `crime`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `crime` (
  `c_id` int(11) NOT NULL AUTO_INCREMENT,
  `c_isend` char(1) DEFAULT NULL,
  `c_time` datetime DEFAULT NULL,
  `c_content` varchar(1000) DEFAULT NULL,
  `c_do` varchar(10) DEFAULT NULL,
  `c_si` varchar(10) DEFAULT NULL,
  `c_gu` varchar(10) DEFAULT NULL,
  `c_dong` varchar(10) DEFAULT NULL,
  `c_arrivaltime` datetime DEFAULT NULL,
  `c_dept` int(11) DEFAULT NULL,
  `c_lg` double DEFAULT NULL,
  `c_la` double DEFAULT NULL,
  PRIMARY KEY (`c_id`),
  KEY `c_dept` (`c_dept`),
  CONSTRAINT `crime_ibfk_1` FOREIGN KEY (`c_dept`) REFERENCES `department` (`d_id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `crime`
--

LOCK TABLES `crime` WRITE;
/*!40000 ALTER TABLE `crime` DISABLE KEYS */;
INSERT INTO `crime` VALUES (1,'Y','2011-04-17 08:05:55','음주 건물 방화',NULL,'울산','남','삼산','2011-04-17 08:10:55',2,35.541035,129.341268),(2,'Y','2012-12-22 09:37:46','피해자 성폭행',NULL,'울산','남','신정','2012-12-22 12:37:46',2,35.540059,129.310176),(3,'Y','2013-07-30 12:47:20','불량식품 판매','충청북도','청주','서원','산남','2013-07-30 12:52:20',5,36.61185,127.468007),(4,'N','2013-07-30 12:52:20','뇌물 수수.',NULL,'서울','강남','압구정','2015-02-01 22:10:25',2,37.528624,127.029505),(5,'Y','2012-06-09 21:20:09','자녀 살해',NULL,'부산','해운대','중1','2012-06-09 21:29:09',5,35.163492,129.169525),(6,'Y','2010-04-20 16:05:55','가정폭력',NULL,'대구','달서','월암','2010-04-20 16:33:55',5,35.830047,128.503337),(7,'Y','2015-06-10 02:37:46','가정폭력','경상남도','진주',NULL,'상대2','2015-06-10 02:52:46',5,35.181004,128.124099),(8,'N','2012-10-04 05:47:20','물품갈취','충청북도','청주','서원','산남','2012-10-04 05:59:20',5,36.611679,127.468333),(9,'N','2014-11-22 08:10:25','음주폭행','충청북도','진천','진천','신정','2014-11-22 08:13:25',5,36.611679,127.468333),(10,'Y','2015-06-02 12:20:09','성폭력','충청남도','천안','동남','봉면','2015-06-02 12:27:09',5,36.80624,127.138273),(11,'Y','2016-12-12 20:05:55','내물수수','경기도','성남','분당','정자','2016-12-12 20:12:55',5,37.367737,127.114834),(12,'Y','2012-06-07 01:37:46','살인미수','경기도','의정부',NULL,'신곡1','2012-06-07 01:42:46',5,37.733427,127.058572),(13,'Y','2016-06-09 02:47:20','공무집행방해','경기도','고양','일산','주엽2','2016-06-09 02:52:20',4,37.667221,126.755237),(14,'N','2012-01-10 05:10:25','주차위반 및 절도','전라북도','전주','완산','태평','2012-01-10 05:17:25',4,35.822355,127.142297),(15,'N','2011-08-14 18:20:09','성폭력 및 강간','전라북도','전주','완산','효자','2011-08-14 18:30:09',5,35.811622,127.105485),(16,'Y','2011-02-22 22:05:55','살해','전라북도','익산시',NULL,'주현','2011-02-22 22:12:55',5,35.931918,126.958031),(17,'Y','2015-11-30 19:20:04','음주운전 및 사고','경상북도','포항','남구','대도','2015-11-30 19:26:04',4,36.013184,129.363321),(18,'Y','2018-11-12 23:37:46','노인학대','경상북도','포항','남구','대도','2018-11-12 23:44:46',5,36.012832,129.363495),(19,'Y','2015-01-22 20:10:25','강간 및 실해','경상북도','경주',NULL,'성동','2015-01-22 20:20:25',5,35.84471,129.217217),(20,'Y','2012-04-12 21:20:09','폭력',NULL,'부산','북','구포2','2012-04-12 21:27:09',5,35.200366,128.998872),(21,'Y','2015-07-22 22:05:55','음주 건물 방화',NULL,'부산','강서','대저2','2015-07-22 22:12:55',2,35.164336,128.946978),(22,'Y','2012-08-12 23:37:46','테러','강원도','태백',NULL,'삼수','2012-08-12 23:45:46',3,37.175929,128.984808),(23,'Y','2014-06-22 22:41:44','내연녀 살해',NULL,'대전','중','유천2','2014-06-22 22:48:44',5,36.320566,127.402931),(24,'Y','2012-08-10 05:10:25','가정폭력',NULL,'대전','중','대흥','2012-08-10 05:20:25',5,36.323523,127.41887),(25,'Y','2011-02-14 12:20:09','성폭력','충청남도','논산',NULL,'취암','2011-02-14 12:30:09',5,36.190493,127.098832),(26,'N','2014-04-17 14:05:55','성폭력','전라북도','군산',NULL,'경암','2014-04-17 14:12:55',5,35.975596,126.727182),(27,'Y','2013-06-17 18:37:46','불량식품 판매','전라북도','군산',NULL,'미룡','2013-06-17 18:45:46',5,35.944685,126.685473),(28,'Y','2010-01-17 02:22:46','절도','전라북도','김제',NULL,'요촌','2010-01-17 02:30:46',5,35.800557,126.888587),(29,'N','2012-03-23 06:20:46','불량식품 판매','전라북도','정읍',NULL,'연지','2012-03-23 06:24:46',5,35.570986,126.844201),(30,'Y','2013-06-26 20:20:46','가정폭력','전라남도','목포',NULL,'용당','2013-06-26 20:35:46',5,34.798571,126.39589),(31,'N','2015-07-29 10:20:46','인신매매',NULL,'부산','부산진','양정','2015-07-29 10:29:46',5,35.16967,129.071483);
/*!40000 ALTER TABLE `crime` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `crimelist`
--

DROP TABLE IF EXISTS `crimelist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `crimelist` (
  `crl_id` int(11) NOT NULL AUTO_INCREMENT,
  `crl_type` varchar(20) DEFAULT NULL,
  `crl_penalty` int(11) DEFAULT NULL,
  `crl_fine` int(11) DEFAULT NULL,
  `crl_content` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`crl_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `crimelist`
--

LOCK TABLES `crimelist` WRITE;
/*!40000 ALTER TABLE `crimelist` DISABLE KEYS */;
INSERT INTO `crimelist` VALUES (1,'방화',18,0,'고의 또는 과실로 불을 놓아 현주건조물/공용건조물/일반건조물/일반물건을 소훼함으로써 성립되는 일종의 공공위험범죄'),(2,'성폭행',60,0,'성에 관계되는 범죄를 말하며, 타인의 자유의사와 관계없이 가해지는 강간이나 강제추행 등의 범죄'),(3,'강도',12,0,'폭행 또는 협박으로 타인의 재물을 강취하거나 기타 재산상의 이익을 취득하거나 또는 제3자로 하여금 이를 취득하게 함으로써 성립하는 범죄'),(4,'살인',108,0,'사람이 사람을 살해하는 행위로써 성립하는 범죄'),(5,'뇌물수수',12,22000000,'공무원 또는 중재인(仲裁人)이 직무행위에 대한 대가로 법이 인정하지 않는 이익을 취득하지 못하도록 하는 내용의 범죄'),(6,'살인',180,0,'사람이 사람을 살해하는 행위로써 성립하는 범죄'),(7,'폭행',60,2000000,'사람에 대한 것이든 물건에 대한 것이든, 모든 종류의 유형력(有形力)의 행사로 성립하는 범죄'),(8,'살인미수',60,0,'살인을 시도했으나 결과가 발생하지 않았거나 끝내지 못한 범죄'),(9,'공무집행방해',0,100000,'직무를 집행하는 공무원에 대하여 폭행 또는 협박하는 죄'),(10,'교통법위반',0,2000000,'도로교통에 관하여 필요한 사항을 규정하기 위해 제정한 법률을 위반함'),(11,'폭행',6,0,'사람에 대한 것이든 물건에 대한 것이든, 모든 종류의 유형력(有形力)의 행사로 성립하는 범죄'),(12,'강간살인',120,0,'강간죄·유사강간죄·강제추행죄·준강간(강제추행)죄 및 미성년자의제강간(강제추행)죄를 범한 자가 사람을 살해하거나 사망에 이르게 함으로써 성립하는 범죄'),(13,'테러',108,1000000,'정치, 종교, 사상적 목적으로 공포감과 불안감을 조성하기 위해 폭력을 행사하는 범죄'),(14,'불법매매',0,100000,'법으로 규정되어있는 조항을 위반하고 어떤 물건을 사고파는 행위의 범죄'),(15,'절도',6,0,'타인의 재물을 절취하는 범죄');
/*!40000 ALTER TABLE `crimelist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `criminal`
--

DROP TABLE IF EXISTS `criminal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `criminal` (
  `cr_id` int(11) NOT NULL AUTO_INCREMENT,
  `c_id` int(11) DEFAULT NULL,
  `h_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`cr_id`),
  KEY `c_id` (`c_id`),
  KEY `h_id` (`h_id`),
  CONSTRAINT `criminal_ibfk_1` FOREIGN KEY (`c_id`) REFERENCES `crime` (`c_id`),
  CONSTRAINT `criminal_ibfk_2` FOREIGN KEY (`h_id`) REFERENCES `human` (`h_id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `criminal`
--

LOCK TABLES `criminal` WRITE;
/*!40000 ALTER TABLE `criminal` DISABLE KEYS */;
INSERT INTO `criminal` VALUES (1,1,36),(2,2,37),(3,3,38),(4,5,39),(5,6,40),(6,7,41),(7,10,42),(8,11,36),(9,12,37),(10,5,38),(11,7,39),(12,27,40),(13,11,41),(14,13,42),(15,16,36),(16,17,37),(17,18,38),(18,19,39),(19,20,40),(20,21,41),(21,22,42),(22,23,41),(23,24,42),(24,25,41);
/*!40000 ALTER TABLE `criminal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `d_location`
--

DROP TABLE IF EXISTS `d_location`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `d_location` (
  `l_id` int(11) NOT NULL AUTO_INCREMENT,
  `d_id` int(11) NOT NULL,
  `l_location` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`l_id`,`d_id`),
  KEY `d_id` (`d_id`),
  CONSTRAINT `d_location_ibfk_1` FOREIGN KEY (`d_id`) REFERENCES `department` (`d_id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `d_location`
--

LOCK TABLES `d_location` WRITE;
/*!40000 ALTER TABLE `d_location` DISABLE KEYS */;
INSERT INTO `d_location` VALUES (1,2,'울산'),(2,4,'울산'),(3,5,'울산'),(4,1,'서울'),(5,2,'서울'),(6,3,'서울'),(7,5,'서울'),(8,4,'청주'),(9,3,'안동'),(10,4,'대전'),(11,5,'대전'),(12,3,'부산'),(13,4,'부산'),(14,5,'부산'),(15,1,'부산'),(16,3,'속초'),(17,4,'속초'),(18,2,'전주'),(19,3,'전주'),(20,4,'전주'),(21,3,'오산'),(22,2,'수원'),(23,3,'수원'),(24,4,'수원'),(25,5,'수원');
/*!40000 ALTER TABLE `d_location` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `d_id` int(11) NOT NULL AUTO_INCREMENT,
  `d_name` varchar(20) DEFAULT NULL,
  `d_tel` varchar(12) DEFAULT NULL,
  `d_captain` int(11) DEFAULT NULL,
  PRIMARY KEY (`d_id`),
  KEY `d_captain` (`d_captain`),
  CONSTRAINT `department_ibfk_1` FOREIGN KEY (`d_captain`) REFERENCES `pofficer` (`p_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Administration','112',1),(2,'Investigation','112',2),(3,'PublicSecurity','112',8),(4,'Traffic','112',9),(5,'Detective','112',5);
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `human`
--

DROP TABLE IF EXISTS `human`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `human` (
  `h_id` int(11) NOT NULL AUTO_INCREMENT,
  `h_name` varchar(20) DEFAULT NULL,
  `h_tel` varchar(12) DEFAULT NULL,
  `h_address` varchar(50) DEFAULT NULL,
  `h_birthdate` date DEFAULT NULL,
  `h_sex` char(1) DEFAULT NULL,
  PRIMARY KEY (`h_id`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `human`
--

LOCK TABLES `human` WRITE;
/*!40000 ALTER TABLE `human` DISABLE KEYS */;
INSERT INTO `human` VALUES (1,'daisy','01023501345','충청남도 천안시 서북구 쌍용동 1390','1977-04-06','W'),(2,'belle','01016602235','충청남도 아산시 온천동 617-1','1945-12-30','W'),(3,'gem','01075826792','충청남도 천안시 서북구 성정동 732-5','1993-04-14','M'),(4,'mark','01024573675','충청남도 천안시 동남구 봉명동 67-13','2000-10-04','M'),(5,'jace','01086327999','충청남도 천안시 서북구 백석동','1988-02-21','M'),(6,'kara','01032350234','충청남도 천안시 서북구 성정동 1394','1999-08-24','W'),(7,'vivian','01049872867','서울특별시 용산구 용산동1가','1993-04-29','M'),(8,'belle','01044626971','서울특별시 마포구 성산동 515','1959-09-08','W'),(9,'kim','01073436125','서울특별시 은평구 응암동','2000-01-01','M'),(10,'amber','01067772346','서울특별시 강북구 미아동 43-32','2003-06-29','W'),(11,'김창수','01023452656','경기도 안성시 대천동','1954-07-22','M'),(12,'김호영','01023482','경기도 오산시 수청로','1967-12-22','M'),(13,'김수진','01024678535','충청남도 천안시 동남구 대흥로','1977-02-21','W'),(14,'양영모','01087574326','충청북도 진천군 진천읍 중앙통로','1982-11-22','M'),(15,'김지원','01033672674','충청북도 청주시 상당구 무심통로','1992-12-02','W'),(16,'심형수','01057852422','충청북도 영동군 영동읍 영동황간로','1988-02-20','M'),(17,'김지민','01045632367','전라북도 무주군 적상면 삼가리','1964-04-29','W'),(18,'라미연','01067823456','전라북도 무주군 설천면 백련사길','1972-03-22','W'),(19,'김진수','01087634562','전라북도 진안군 진안읍 운산리','1985-07-01','M'),(20,'한세미','01057942145','충청북도 청주시 흥덕구 청남로','1979-10-16','W'),(21,'이지수','01086344222','충청북도 보은군 보은읍 교사리','1950-04-06','W'),(22,'김규동','01076423456','충청북도 영동군 황간면 황간리','1966-08-20','M'),(23,'손수정','01074567223','경상북도 김천시 남면 운남리','1977-12-04','W'),(24,'심영민','01064442245','경상북도 김천시 구성면 광명리','2982-12-16','W'),(25,'김광식','01012573634','경상북도 김천시 주마면 강곡리','1990-02-12','M'),(26,'조광식','01074343112','경상남도 거창군 가북면 용암리','1977-10-10','W'),(27,'한나래','01042345364','경상남도 거창군 가조면 일부리','1980-02-22','W'),(28,'김별','01055336773','경상남도 산청군 상장면 평촌유평로','1950-04-12','W'),(29,'이미자','01067425754','경상남도 산청군 단성면 소남리 452','1960-07-22','W'),(30,'고미진','01036884111','전라남도 화순군 한청면 반곡리','1993-07-10','W'),(31,'고준희','01012355000','전라북도 익산시 주현동','1953-02-20','W'),(32,'신민주','01039859692','경상북도 포항시 남구 대도동','1978-07-16','W'),(33,'주민지','01069785324','경기도 고양시 일산구 주엽2동','1990-01-28','W'),(34,'안제희','01096847364','충청남도 천안시 동남구 봉면동','1960-06-10','M'),(35,'안미경','01019284682','울산광역시 남구 삼산동','1959-02-16','W'),(36,'김수민','01029485172','울산광역시 남구 신정동','1968-03-05','W'),(37,'정유진','01019283471','충청북도 청주시 서원구 산남동','1986-10-28','W'),(38,'김진명','01028589281','부산 해운대 중1동','1990-02-21','M'),(39,'안정민','01094868392','경상남도 진주시 상대2동','1981-11-13','M'),(40,'하나래','01019275292','경기도 안산시 단원구 고진동','1947-09-10','W'),(41,'하석준','01039689129','인천광역시 부평구 부평6동','1980-12-18','M'),(42,'하미연','01048529471','경기도 화성시 남양동','1996-02-20','W'),(43,'김민주','01039586731','충청북도 제찬시 서부동','1983-12-25','W'),(44,'라미란','01003059693','전라남도 나주시 이창동','1967-02-19','W'),(45,'조시민','01029357192','경기도 화성시 남양동','1988-06-27','M'),(46,'이진수','01016274967','대전광역시 중구 대흥동','1972-03-30','M'),(47,'이미래','01039587249','충청남도 논산시 취암동','1980-09-23','W'),(48,'고미순','01039393113','강원도 태백 삼수동','1989-11-10','W'),(49,'임창정','01059683919','전라북도 군산시 미룡동','1968-04-10','M'),(50,'임철규','01019285719','부산광역시 강서구 대저2동','1972-03-20','M'),(51,'김철민','01039581925','전라북도 김제시 요촌동','1989-04-28','M'),(52,'김철수','01034069682','대전광역시 중구 유천2동','1991-09-29','M'),(53,'한상헌','01049688392','부산광역시 강서구 대저2동','1993-07-23','M'),(54,'이상진','01002018422','경상북도 포항시 남구 대도동','1967-02-20','M'),(55,'안지혜','01039857192','충청남도 논산시 취암동','1987-05-24','W'),(56,'김현지','01048781947','전라북도 군산시 경남동','1988-08-29','W'),(57,'박진수','01035898393','대전광역시 중구 대흥동','1993-07-22','M'),(58,'박세진','01029473759','전라남도 화순군 한청면 반곡리','1963-07-27','M');
/*!40000 ALTER TABLE `human` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `joinwith`
--

DROP TABLE IF EXISTS `joinwith`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `joinwith` (
  `c_id` int(11) NOT NULL,
  `p_id` int(11) NOT NULL,
  PRIMARY KEY (`c_id`,`p_id`),
  KEY `c_id` (`c_id`),
  KEY `p_id` (`p_id`),
  CONSTRAINT `joinwith_ibfk_1` FOREIGN KEY (`c_id`) REFERENCES `crime` (`c_id`),
  CONSTRAINT `joinwith_ibfk_2` FOREIGN KEY (`p_id`) REFERENCES `pofficer` (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `joinwith`
--

LOCK TABLES `joinwith` WRITE;
/*!40000 ALTER TABLE `joinwith` DISABLE KEYS */;
INSERT INTO `joinwith` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10);
/*!40000 ALTER TABLE `joinwith` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `monitor`
--

DROP TABLE IF EXISTS `monitor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `monitor` (
  `m_id` int(11) NOT NULL AUTO_INCREMENT,
  `m_lg` double DEFAULT NULL,
  `m_la` double DEFAULT NULL,
  `m_from` date DEFAULT NULL,
  `m_to` date DEFAULT NULL,
  `cr_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`m_id`),
  KEY `cr_id` (`cr_id`),
  CONSTRAINT `monitor_ibfk_1` FOREIGN KEY (`cr_id`) REFERENCES `criminal` (`cr_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monitor`
--

LOCK TABLES `monitor` WRITE;
/*!40000 ALTER TABLE `monitor` DISABLE KEYS */;
INSERT INTO `monitor` VALUES (1,35.24,128.31,'2014-12-03','2016-05-03',1),(2,34.92,130.42,'2016-01-27','2016-04-03',2),(3,36.34,130.63,'2013-10-03','2015-05-03',3);
/*!40000 ALTER TABLE `monitor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `occur`
--

DROP TABLE IF EXISTS `occur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `occur` (
  `a_id` int(11) DEFAULT NULL,
  `s_id` int(11) DEFAULT NULL,
  `v_id` int(11) DEFAULT NULL,
  `c_id` int(11) NOT NULL,
  PRIMARY KEY (`c_id`),
  KEY `a_id` (`a_id`),
  KEY `s_id` (`s_id`),
  KEY `v_id` (`v_id`),
  KEY `c_id` (`c_id`),
  CONSTRAINT `occur_ibfk_1` FOREIGN KEY (`a_id`) REFERENCES `applicant` (`a_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `occur`
--

LOCK TABLES `occur` WRITE;
/*!40000 ALTER TABLE `occur` DISABLE KEYS */;
INSERT INTO `occur` VALUES (1,35,8,1),(2,36,9,2),(3,37,10,3),(4,38,11,4),(5,39,12,5),(6,40,13,6),(7,41,14,7),(8,42,15,8),(9,43,16,9),(10,44,17,10),(11,44,18,11),(12,45,19,12),(13,45,NULL,13),(14,46,21,14),(15,47,22,15),(16,48,23,16),(17,49,24,17),(18,50,25,18),(19,51,26,19),(20,52,27,20),(21,53,28,21),(22,54,29,22),(23,55,30,23),(24,56,31,24),(25,57,32,25),(26,58,33,26),(27,36,34,27),(28,37,20,28),(29,38,6,29),(30,39,5,30),(31,40,4,31);
/*!40000 ALTER TABLE `occur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pofficer`
--

DROP TABLE IF EXISTS `pofficer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pofficer` (
  `p_id` int(11) NOT NULL AUTO_INCREMENT,
  `p_name` varchar(20) DEFAULT NULL,
  `p_pos` varchar(20) DEFAULT NULL,
  `p_tel` varchar(12) DEFAULT NULL,
  `d_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  KEY `d_id` (`d_id`),
  CONSTRAINT `pofficer_ibfk_1` FOREIGN KEY (`d_id`) REFERENCES `department` (`d_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pofficer`
--

LOCK TABLES `pofficer` WRITE;
/*!40000 ALTER TABLE `pofficer` DISABLE KEYS */;
INSERT INTO `pofficer` VALUES (1,'Lee','I','01011111111',1),(2,'Park','I','01025305933',2),(3,'Lee','SP','01050492853',2),(4,'Song','P','01099223322',2),(5,'Kim','I','01012345678',5),(6,'Lim','P','01043768943',5),(7,'Jung','P','01037538938',3),(8,'Jang','I','01066890293',3),(9,'Han','AI','01075773000',4),(10,'Yang','P','01029105923',1);
/*!40000 ALTER TABLE `pofficer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suspect`
--

DROP TABLE IF EXISTS `suspect`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suspect` (
  `s_id` int(11) NOT NULL AUTO_INCREMENT,
  `h_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`s_id`),
  KEY `h_id` (`h_id`),
  CONSTRAINT `suspect_ibfk_1` FOREIGN KEY (`h_id`) REFERENCES `human` (`h_id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suspect`
--

LOCK TABLES `suspect` WRITE;
/*!40000 ALTER TABLE `suspect` DISABLE KEYS */;
INSERT INTO `suspect` VALUES (24,35),(1,36),(2,37),(3,38),(4,39),(5,40),(6,41),(7,42),(8,43),(9,44),(10,45),(11,46),(12,47),(13,48),(14,49),(15,50),(16,51),(17,52),(18,53),(19,54),(20,55),(21,56),(22,57),(23,58);
/*!40000 ALTER TABLE `suspect` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `victim`
--

DROP TABLE IF EXISTS `victim`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `victim` (
  `v_id` int(11) NOT NULL AUTO_INCREMENT,
  `h_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`v_id`),
  KEY `h_id` (`h_id`),
  CONSTRAINT `victim_ibfk_1` FOREIGN KEY (`h_id`) REFERENCES `human` (`h_id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `victim`
--

LOCK TABLES `victim` WRITE;
/*!40000 ALTER TABLE `victim` DISABLE KEYS */;
INSERT INTO `victim` VALUES (1,8),(2,9),(3,10),(4,11),(5,12),(6,13),(7,14),(8,15),(9,16),(10,17),(11,18),(12,19),(13,20),(14,21),(15,22),(16,23),(17,24),(18,25),(19,26),(20,27),(21,28),(22,29),(23,30),(24,31),(25,32),(26,33),(27,34);
/*!40000 ALTER TABLE `victim` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-06-08 19:40:44
