CREATE DATABASE  IF NOT EXISTS `tcc` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `tcc`;
-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: tcc
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `agenda`
--

DROP TABLE IF EXISTS `agenda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `agenda` (
  `id_agenda` int(11) NOT NULL AUTO_INCREMENT,
  `dataHora` datetime NOT NULL,
  PRIMARY KEY (`id_agenda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agenda`
--

LOCK TABLES `agenda` WRITE;
/*!40000 ALTER TABLE `agenda` DISABLE KEYS */;
/*!40000 ALTER TABLE `agenda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bebidas`
--

DROP TABLE IF EXISTS `bebidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `bebidas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) NOT NULL,
  `tipo` varchar(45) NOT NULL,
  `imagem` varchar(200) DEFAULT NULL,
  `valor` decimal(10,2) NOT NULL,
  `id_rest` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_restaurante_bebidas_idx` (`id_rest`),
  CONSTRAINT `fk_restaurante_bebidas` FOREIGN KEY (`id_rest`) REFERENCES `restaurante` (`id_rest`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bebidas`
--

LOCK TABLES `bebidas` WRITE;
/*!40000 ALTER TABLE `bebidas` DISABLE KEYS */;
INSERT INTO `bebidas` VALUES (11,'Coca Cola 350ml','Não alcoólico','cocacola.jpg',5.35,1),(12,'Del Vale - Maracujá','Não alcoólico','suco-del-valle-maracuja-lata-290ml-97a.jpg',7.50,1),(13,'H2O Limoneto 1,5L','Não alcoólico','limoneto.jpg',5.35,1),(14,'Água Bonafont com gás 500ml','Não alcoólico','agua.png',3.25,1),(15,'Cerveja Heineken Premium Pilsen Lager 330ml','Alcoólico','heineken.jpg',3.89,1),(16,'Fanta Laranja - 350ml','Não alcoólico','fantaLaranja.jpg',5.50,7),(17,'Pepsi - 350ml','Não alcoólico','pepsi.jpg',5.75,7),(18,'Coca Cola - 350ml','Não alcoólico','cocacola.jpg',5.75,7),(19,'CERVEJA BUDWEISER LONG NECK 343 ML','Alcoólico','588-large_default.jpg',3.79,7),(20,'Cerveja Eisenbahn 350ml Lt Pilsen','Alcoólico','eis.jpg',3.69,7),(21,'Vinho Zanotto Tinto Suave Bordô 750 ml','Alcoólico','33966028_1GG.jpg',22.90,1),(22,'Cabernet Sauvignon 2009 - 750ml','Alcoólico','vinho.jpg',403.88,10),(23,'Château Musar rouge 2009 CHÂTEAU MUSAR - 750ml','Alcoólico','Château Musar rouge 2009.jpg',523.61,10),(24,'Catena Cabernet Sauvignon 2016','Alcoólico','Catena Cabernet Sauvignon 2016.jpg',129.48,10);
/*!40000 ALTER TABLE `bebidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `caixa`
--

DROP TABLE IF EXISTS `caixa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `caixa` (
  `id_conta` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id conta',
  `id_mesa` int(11) DEFAULT NULL COMMENT 'id mesa',
  `id_pedido` int(11) DEFAULT NULL COMMENT 'id pedido',
  `total` decimal(10,2) DEFAULT NULL,
  `id_pgto` int(11) DEFAULT NULL COMMENT 'id pagamento',
  PRIMARY KEY (`id_conta`),
  KEY `fk_mesa` (`id_mesa`),
  KEY `fk_pedido` (`id_pedido`),
  KEY `fk_pgto` (`id_pgto`),
  CONSTRAINT `fk_mesa` FOREIGN KEY (`id_mesa`) REFERENCES `mesa` (`id_mesa`),
  CONSTRAINT `fk_pedido` FOREIGN KEY (`id_pedido`) REFERENCES `cozinha` (`id_pedido`),
  CONSTRAINT `fk_pgto` FOREIGN KEY (`id_pgto`) REFERENCES `pagamento` (`id_pgto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caixa`
--

LOCK TABLES `caixa` WRITE;
/*!40000 ALTER TABLE `caixa` DISABLE KEYS */;
/*!40000 ALTER TABLE `caixa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cliente` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `fone` varchar(45) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `funcao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (35,'Carlos Costa Andrade','(12)3123-1321','789.788.978-97','carlos@gmail.com','123','cli'),(36,'Girafales Silva','(11)7878-7877','964.518.427-36','girafales@gmail.com','123','cli'),(37,'Abax','(11)2222-7777','444.444.444-47','abax@abax.com','123','Administrador');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `cliente_AFTER_INSERT` AFTER INSERT ON `cliente` FOR EACH ROW BEGIN
insert into login (nome,fone,email,senha,funcao) select nome,fone,email,senha,funcao from cliente order by id desc limit 1;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `cozinha`
--

DROP TABLE IF EXISTS `cozinha`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cozinha` (
  `id_pedido` int(11) NOT NULL AUTO_INCREMENT,
  `id_mesa` int(11) DEFAULT NULL,
  `id_prato` int(11) DEFAULT NULL,
  `id_bebida` int(11) DEFAULT NULL,
  `id_sobremesa` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_pedido`),
  KEY `fk_mesaCozinha` (`id_mesa`),
  KEY `fk_pratoCozinha` (`id_prato`),
  KEY `fk_bebidaCozinha` (`id_bebida`),
  KEY `fk_sobremesaCozinha` (`id_sobremesa`),
  CONSTRAINT `fk_bebidaCozinha` FOREIGN KEY (`id_bebida`) REFERENCES `bebidas` (`id`),
  CONSTRAINT `fk_mesaCozinha` FOREIGN KEY (`id_mesa`) REFERENCES `mesa` (`id_mesa`),
  CONSTRAINT `fk_pratoCozinha` FOREIGN KEY (`id_prato`) REFERENCES `prato` (`id_prato`),
  CONSTRAINT `fk_sobremesaCozinha` FOREIGN KEY (`id_sobremesa`) REFERENCES `sobremesa` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cozinha`
--

LOCK TABLES `cozinha` WRITE;
/*!40000 ALTER TABLE `cozinha` DISABLE KEYS */;
/*!40000 ALTER TABLE `cozinha` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dia`
--

DROP TABLE IF EXISTS `dia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dia` (
  `id_dia` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) NOT NULL,
  PRIMARY KEY (`id_dia`),
  UNIQUE KEY `id_dia_UNIQUE` (`id_dia`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dia`
--

LOCK TABLES `dia` WRITE;
/*!40000 ALTER TABLE `dia` DISABLE KEYS */;
INSERT INTO `dia` VALUES (1,'Domingo'),(2,'Segunda-Feira'),(3,'Terça-Feira'),(4,'Quarta-Feria'),(5,'Quinta-Feira'),(6,'Sexta-Feira'),(7,'Sábado');
/*!40000 ALTER TABLE `dia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `finalidade`
--

DROP TABLE IF EXISTS `finalidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `finalidade` (
  `id_fin` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(70) NOT NULL,
  PRIMARY KEY (`id_fin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='happy hour, social, negocios, etc';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `finalidade`
--

LOCK TABLES `finalidade` WRITE;
/*!40000 ALTER TABLE `finalidade` DISABLE KEYS */;
/*!40000 ALTER TABLE `finalidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `funcionario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `cargo` varchar(45) DEFAULT NULL,
  `fone` varchar(20) NOT NULL,
  `email` varchar(70) NOT NULL,
  `senha` varchar(16) NOT NULL,
  `funcao` varchar(45) NOT NULL,
  `id_rest` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  KEY `fk_rest_idx` (`id_rest`),
  CONSTRAINT `fk_restaurante_funcionario` FOREIGN KEY (`id_rest`) REFERENCES `restaurante` (`id_rest`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` VALUES (1,'Rafael','Desenvolvedor','11985854747','rafael.rios@abax.com','123','Administrador',1),(3,'aaa',NULL,'12345','gui@ofjhasj.com','123485','func',NULL),(5,'aaa',NULL,'12345','gui@ofhasj.com','123485','func',NULL),(6,'aaa',NULL,'12345','gui@ofasj.com','123485','func',NULL),(7,'Gideão Santos','Chefe','(12)3456-7877','Gideao@teste.com','123','Cozinha',1),(8,'João','Gerente de recursos humanos','1178787877','joao@funcionario.com','123','RH',1),(9,'Pedro','Administrador Sênior','(11)9654-7878','pedro@restaurante.com','123','Administração',1),(10,'Roberta','Caixa','(11)1111-1111','roberta@funcionario.com','123','Caixa',1),(11,'Gisele','Administrador Sênior','(11)4545-7777','gisele@admin.com','123','Administração',7);
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `funcionario_AFTER_INSERT` AFTER INSERT ON `funcionario` FOR EACH ROW BEGIN
insert into login (nome,fone,email,senha,funcao) select nome,fone,email,senha,funcao from funcionario order by id desc limit 1;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `login` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `fone` varchar(20) DEFAULT NULL,
  `email` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `funcao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (1,'Guilherme','33333333','1111111111','fodase@gmail.com',NULL),(3,'aaa','12345','gui@ofjhasj.com','123485','func'),(5,'aaa','12345','gui@ofhasj.com','123485','func'),(9,'guilhe222rme','214214','gu1i','12345678',NULL),(11,'guilhe222rme','214214','gui2','1234335678',NULL),(12,'guilhe222rme','214214','gui3','1234335678',NULL),(14,'guilhe22rme','214214','guizin','1234335678',NULL),(15,'guilhere','111','aaa','123456',NULL),(16,'Rafael Rios',NULL,'rafael@abax.com','123',NULL),(18,'Antonio',NULL,'antonio@teste.com','123',NULL),(19,'Oi',NULL,'Oi@oi.com','123',NULL),(20,'asdf','789741','asdf@asdf.com','789',NULL),(21,'Gisele','1234567','gisele@abax.com','123',NULL),(22,'a','222','aaaaaaa','222','cli'),(23,'gu23i','122343567','gui@aba32x.com','12513456','cli'),(24,'aaa','12345','gui@ofasj.com','123485','func'),(25,'teste','12345678','gdsds@teste.com','123','cozinhaRest'),(26,'hello','1234567','hello@world.com','123','cli'),(27,'João','1178787877','joao@funcionario.com','123','RH'),(28,'Pedro','1196547878','pedro@restaurante.com','123','Administração'),(29,'testeCliente','(12)1231-2332','testecliente@testecliente.com','123','cli'),(32,'Carlos','(12)3123-1321','carlos@teste.com','123','cli'),(33,'Girafales','(11)7878-7877','girafales@professor.com','123','cli'),(34,'Roberta','(11)1111-1111','roberta@funcionario.com','123','Caixa'),(35,'Gisele','(11)4545-7777','gisele@admin.com','123','Administração'),(36,'Abax','(11)2222-7777','abax@abax.com','123','Administrador');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `menu` (
  `id_menu` int(11) NOT NULL AUTO_INCREMENT,
  `id_prato` int(11) DEFAULT NULL,
  `id_bebida` int(11) DEFAULT NULL,
  `id_porcao` int(11) DEFAULT NULL,
  `id_sobremesa` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_menu`),
  KEY `fk_prato` (`id_prato`),
  KEY `fk_bebida` (`id_bebida`),
  KEY `fk_porcao` (`id_porcao`),
  KEY `fk_sobremesa` (`id_sobremesa`),
  CONSTRAINT `fk_bebida` FOREIGN KEY (`id_bebida`) REFERENCES `bebidas` (`id`),
  CONSTRAINT `fk_porcao` FOREIGN KEY (`id_porcao`) REFERENCES `porcao` (`id`),
  CONSTRAINT `fk_prato` FOREIGN KEY (`id_prato`) REFERENCES `prato` (`id_prato`),
  CONSTRAINT `fk_sobremesa` FOREIGN KEY (`id_sobremesa`) REFERENCES `sobremesa` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mesa`
--

DROP TABLE IF EXISTS `mesa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `mesa` (
  `id_mesa` int(11) NOT NULL AUTO_INCREMENT,
  `numero` int(11) NOT NULL,
  `qtdPessoas` int(11) NOT NULL,
  `id_fin` int(11) NOT NULL,
  `ocupacao` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_mesa`),
  KEY `fk_fin_idx` (`id_fin`),
  CONSTRAINT `fk_fin` FOREIGN KEY (`id_fin`) REFERENCES `finalidade` (`id_fin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mesa`
--

LOCK TABLES `mesa` WRITE;
/*!40000 ALTER TABLE `mesa` DISABLE KEYS */;
/*!40000 ALTER TABLE `mesa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagamento`
--

DROP TABLE IF EXISTS `pagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `pagamento` (
  `id_pgto` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(45) NOT NULL,
  PRIMARY KEY (`id_pgto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagamento`
--

LOCK TABLES `pagamento` WRITE;
/*!40000 ALTER TABLE `pagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `porcao`
--

DROP TABLE IF EXISTS `porcao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `porcao` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) NOT NULL,
  `descricao` varchar(200) DEFAULT NULL,
  `imagem` varchar(200) DEFAULT NULL,
  `valor` decimal(10,2) NOT NULL,
  `id_rest` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_porcao_UNIQUE` (`id`),
  KEY `fk_restaurante_porcao_idx` (`id_rest`),
  CONSTRAINT `fk_restaurante_porcao` FOREIGN KEY (`id_rest`) REFERENCES `restaurante` (`id_rest`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `porcao`
--

LOCK TABLES `porcao` WRITE;
/*!40000 ALTER TABLE `porcao` DISABLE KEYS */;
INSERT INTO `porcao` VALUES (2,'Batata frita','Porção de batatas frita','porcao.png',17.75,1),(4,'Camarão','Porção de camarão','camarao.jpg',22.75,1),(5,'Porção Carne','Porção de Picanha','porcaoCarne.jpg',37.50,1),(6,'Porção calabresa','Porção de calabresa acebolada','calabresa_cebola.jpg',17.75,1),(7,'Porção Frango','Porção de frango frito','porcaoFrango.jpg',20.00,1),(8,'Porção de Mini Hambúrguer','Porção de Mini Hambúrguer com molho de alho','hamburguer.jpeg',35.00,7);
/*!40000 ALTER TABLE `porcao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prato`
--

DROP TABLE IF EXISTS `prato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `prato` (
  `id_prato` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) DEFAULT NULL,
  `imagem` varchar(200) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `dia_semana` varchar(45) NOT NULL,
  `id_rest` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_prato`),
  KEY `fk_prato_restaurante_idx` (`id_rest`),
  CONSTRAINT `fk_prato_restaurante` FOREIGN KEY (`id_rest`) REFERENCES `restaurante` (`id_rest`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prato`
--

LOCK TABLES `prato` WRITE;
/*!40000 ALTER TABLE `prato` DISABLE KEYS */;
INSERT INTO `prato` VALUES (20,'Strogonoff - Frango','173715_original.jpg',27.00,'terca-feira',1),(21,'Lasanha a Bolonhesa','lasanha-a-bolonhesa.jpg',20.50,'quarta-feira',1),(22,'Bife de frango a Parmigiana','file-frango-parmegiana-assado-1.jpg',27.65,'terca-feira',1),(23,'Bife de carne a Parmegiana','parmegianaCarne.jpg',30.00,'terca-feira',1),(24,'Feijoada','feijoada-completa.jpg',40.00,'quarta-feira',1),(25,'File de frango','fileDeFrango.jpg',22.00,'segunda-feira',7),(26,'RAVIÓLI DE VITELO E CREME DE FUNGHI PORCINI','RAVIÓLI DE VITELO E CREME DE FUNGHI PORCINI.jpg',47.00,'segunda-feira',10),(27,'PAPPARDELLE COM COGUMELOS, PRESUNTO DE PARMA E LASCAS DE PECORINO','PAPPARDELLE COM COGUMELOS, PRESUNTO DE PARMA E LASCAS DE PECORINO.jpg',78.00,'segunda-feira',10),(28,'FILÉ DE NAMORADO COM RAGU DE TOMATE E MANJERICÃO COM EMULSÃO DE BATATA ROXA','FILÉ DE NAMORADO COM RAGU DE TOMATE E MANJERICÃO COM EMULSÃO DE BATATA ROXA.jpg',72.00,'segunda-feira',10),(29,'OSSOBUCO SUÍNO AO VINHO TINTO, GREMOLATA E RISOTO À PARMEGIANA','OSSOBUCO SUÍNO AO VINHO TINTO, GREMOLATA E RISOTO À PARMEGIANA.jpg',80.00,'segunda-feira',10);
/*!40000 ALTER TABLE `prato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reserva`
--

DROP TABLE IF EXISTS `reserva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `reserva` (
  `idReserva` int(11) NOT NULL AUTO_INCREMENT,
  `mesa` varchar(45) DEFAULT NULL,
  `finalidade` varchar(45) DEFAULT NULL,
  `agenda` varchar(45) DEFAULT NULL,
  `atendimento` varchar(45) DEFAULT NULL,
  `itens` varchar(2000) DEFAULT NULL,
  `idCliente` int(11) DEFAULT NULL,
  `idRestaurante` int(11) DEFAULT NULL,
  `nomeCliente` varchar(100) DEFAULT NULL,
  `nomeRestaurante` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idReserva`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reserva`
--

LOCK TABLES `reserva` WRITE;
/*!40000 ALTER TABLE `reserva` DISABLE KEYS */;
INSERT INTO `reserva` VALUES (1,'10','Casual','28/06/2019 14:35','Sim','1 Lasanha a Bolonhesa\r-2  Bife de carne a Parmegiana\r-1  Vinho Zanotto Tinto Suave Bordô 750 ml\r-1  Porção de camarão',35,1,'Carlos Costa Andrade','Mangiare Gastronomia');
/*!40000 ALTER TABLE `reserva` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restaurante`
--

DROP TABLE IF EXISTS `restaurante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `restaurante` (
  `id_rest` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `fone` varchar(20) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `endereco` varchar(120) NOT NULL,
  `cnpj` varchar(20) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `funcao` varchar(10) DEFAULT NULL,
  `imagem` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_rest`),
  UNIQUE KEY `cnpj_UNIQUE` (`cnpj`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restaurante`
--

LOCK TABLES `restaurante` WRITE;
/*!40000 ALTER TABLE `restaurante` DISABLE KEYS */;
INSERT INTO `restaurante` VALUES (1,'Mangiare Gastronomia','(11)7777-7777','restaurante@restaurante.com','Rua Guaipá','77.777.777/7777-77','123','rest','restaurante4.jpg'),(7,'Veneza Grill','(11)9789-7897','restaurante2@restaurante.com','Av Leopoldina','78.978.979/8789-87','123','rest','restaurante1.jpg'),(9,'Casa Nova','(11)4444-7777','restaurante3@restaurante3.com','Av. Paulista','31.224.998/6221-11','123','rest','jangada-restaurante.jpg'),(10,'Terraço Itália','(11)2189-2929','terracoitalia@italia.com','Av. Ipiranga, 344 – 41º andar ','56.568.484/8441-22','123','rest','piano-bar.jpg');
/*!40000 ALTER TABLE `restaurante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sobremesa`
--

DROP TABLE IF EXISTS `sobremesa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `sobremesa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) NOT NULL,
  `imagem` varchar(200) DEFAULT NULL,
  `valor` decimal(10,2) NOT NULL,
  `id_rest` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_sobremesa_UNIQUE` (`id`),
  KEY `fk_sobremesa_restaurante_idx` (`id_rest`),
  CONSTRAINT `fk_sobremesa_restaurante` FOREIGN KEY (`id_rest`) REFERENCES `restaurante` (`id_rest`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sobremesa`
--

LOCK TABLES `sobremesa` WRITE;
/*!40000 ALTER TABLE `sobremesa` DISABLE KEYS */;
INSERT INTO `sobremesa` VALUES (4,'Torta Holandesa - Limão','tortaLimaoHolandesa.jpg',20.00,1),(5,'Pudim de Leite','pudim-de-leite.jpg',20.00,1),(7,'Bolo de Cenoura - Fatia','imagem3.jpg',7.50,1),(8,'petit gateau','petit-gateau-de-chocolate-600x600.jpg',20.90,1),(9,'Mousse de Maracujá','mousseMacaruja.jpg',5.00,1),(10,'Torta de Morango','tortaMorango.png',12.00,7),(11,'MIL FOLHAS COM CREME DE ZABAIONE E GELATO DE GIANDUIA','MIL FOLHAS COM CREME DE ZABAIONE E GELATO DE GIANDUIA.jpg',51.00,10),(12,'CREMOSO DE AVELÃ COM BISCOITO DE CANELA','CREMOSO DE AVELÃ COM BISCOITO DE CANELA.jpg',42.00,10);
/*!40000 ALTER TABLE `sobremesa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'tcc'
--

--
-- Dumping routines for database 'tcc'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_bebidas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_bebidas`(in p_id int)
begin
delete from bebidas 
where id = p_id;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_cliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_cliente`(in p_id int)
BEGIN
delete from cliente
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_funcionario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_funcionario`(in p_id int)
BEGIN
delete from funcionario
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_porcao` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_porcao`(in p_id int)
BEGIN
delete from porcao
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_pratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_pratos`(in p_id int)
begin
delete from prato 
where id_prato = p_id;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_restaurante` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`abax`@`%` PROCEDURE `sp_delete_restaurante`(in p_id_rest int)
BEGIN
delete from restaurante where id_rest = p_id_rest;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_delete_sobremesa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_delete_sobremesa`(in p_id int)
BEGIN
delete from sobremesa
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_bebidas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_bebidas`(in p_nome varchar(80), in p_tipo varchar (45),in p_imagem mediumblob, in p_valor decimal(10,2), in p_idRest int)
begin
insert into bebidas (nome, tipo, imagem, valor, id_rest) values(p_nome, p_tipo,p_imagem, p_valor, p_idRest);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_cliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_cliente`(in p_nome varchar (100), in p_fone varchar (20), in p_cpf varchar (15), in p_email varchar (70), in p_senha varchar(16), in p_funcao varchar (5))
BEGIN
insert into cliente (nome, fone, cpf, email, senha, funcao) values (p_nome, p_fone, p_cpf, p_email, p_senha, p_funcao);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_funcionario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_funcionario`(in p_nome varchar (100),in p_cargo varchar (45),in p_fone varchar(20), in p_email varchar (70), in p_senha varchar (16), in p_funcao varchar (25), in p_idRest int)
BEGIN
insert into funcionario (nome,cargo,fone,email,senha,funcao,id_rest) values(p_nome,p_cargo,p_fone,p_email,p_senha,p_funcao,p_idRest);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_porcao` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_porcao`(in p_nome varchar (80),in p_descricao varchar(200), in p_imagem mediumblob, in p_valor decimal (10,5), in p_idRest int)
BEGIN
insert into porcao (nome,descricao,imagem,valor,id_rest) values (p_nome,p_descricao,p_imagem,p_valor,p_idRest);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_pratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_pratos`(in p_dia_semana varchar(45) ,in p_nome varchar(80), in p_imagem mediumblob, in p_valor decimal(10,2), in p_idRest int)
begin
insert into prato (dia_semana,nome,imagem,valor,id_rest) values(p_dia_semana, p_nome,p_imagem, p_valor, p_idRest);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_restaurante` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`abax`@`%` PROCEDURE `sp_insert_restaurante`(
in p_nome varchar(100), 
in p_fone varchar(18),
in p_email varchar (100),
in p_endereco varchar (120),
in p_cnpj varchar (20),
in p_senha varchar (16),
in p_funcao varchar(10),
in p_imagem varchar(200))
BEGIN
insert into restaurante (nome, fone, email, endereco, cnpj, senha, funcao, imagem) values(p_nome, p_fone, p_email, p_endereco, p_cnpj, p_senha, p_funcao, p_imagem);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insert_sobremesa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_sobremesa`(in p_nome varchar(80), in p_imagem mediumblob, in p_valor decimal(10,2), in p_idRest int)
BEGIN
insert into sobremesa (nome,imagem,valor,id_rest) values (p_nome,p_imagem,p_valor,p_idRest);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_select_bebidas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_bebidas`(in p_id int)
begin
select * from bebidas
where id = p_id;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_select_cliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_cliente`(p_id int)
BEGIN
select * from cliente
where id= p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_select_funcionario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_funcionario`(in p_id int)
BEGIN
select * from funcionario
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_select_porcao` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_porcao`(in p_id int)
BEGIN
select * from porcao 
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_select_pratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_pratos`(in p_id int)
begin
select * from prato
where id_prato = p_id;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_select_restaurante` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`abax`@`%` PROCEDURE `sp_select_restaurante`(in p_id_rest int)
BEGIN
select * from restaurante where id_rest = p_id_rest;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_select_sobremesa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_select_sobremesa`(in p_id int)
BEGIN
select * from sobremesa
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_bebidas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_bebidas`(in p_id int, in p_nome varchar(80), in p_imagem mediumblob, in p_valor decimal(10,2), in p_tipo varchar(50))
begin
update bebidas set
nome = p_nome,
imagem = p_imagem,
valor = p_valor,
tipo = p_tipo
where id = p_id;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_cliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_cliente`(in p_nome varchar(100),in p_fone varchar(20),  in p_cpf varchar(30),in p_email varchar(70),in p_senha varchar (16), in p_id int)
BEGIN
update cliente set
nome = p_nome,
fone = p_fone,
email = p_email,
cpf = p_cpf,
senha = p_senha
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_funcionario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_funcionario`(in p_nome varchar(100),in p_cargo varchar(45),in p_fone varchar(20),in p_email varchar(70),in p_senha varchar(16),in p_funcao varchar (25),in p_id int)
BEGIN
update funcionario set 
nome = p_nome,
cargo = p_cargo,
fone = p_fone,
email = p_email,
senha = p_senha,
funcao = p_funcao
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_porcao` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_porcao`(in p_nome varchar (80),in p_descricao varchar (200), in p_imagem mediumblob, in p_valor decimal(10,5), in p_id int)
BEGIN
update porcao set 
nome = p_nome,
descricao = p_descricao,
imagem = p_imagem,
valor = p_valor
where id = p_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_pratos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_pratos`(in p_id int, in p_nome varchar(80), in p_imagem mediumblob, in p_valor decimal(10,2), in p_dia_semana varchar(45))
begin
update prato set
nome = p_nome,
imagem = p_imagem,
valor = p_valor,
dia_semana = p_dia_semana
where id_prato = p_id;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_restaurante` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`abax`@`%` PROCEDURE `sp_update_restaurante`(p_nome varchar(100),
p_fone varchar(20),
p_email varchar(100),
p_endereco varchar(120),
p_cnpj varchar(20),
p_senha varchar(16),
p_id_rest int,
p_imagem varchar(200))
BEGIN
update restaurante set
nome = p_nome,
fone = p_fone,
email = p_email,
endereco = p_endereco,
cnpj = p_cnpj,
imagem = p_imagem,
senha = p_senha where id_rest = p_id_rest; 

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_update_sobremesa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_sobremesa`(in p_nome varchar (80), in p_imagem mediumblob, in p_valor decimal(10,2), in p_id int)
BEGIN
update sobremesa set
nome = p_nome,
imagem = p_imagem,
valor = p_valor 
where id = p_id;
END ;;
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

-- Dump completed on 2019-06-26 14:25:24
