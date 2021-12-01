-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 24-Nov-2021 às 14:57
-- Versão do servidor: 5.7.26
-- versão do PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `valorant_esports`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `players`
--

DROP TABLE IF EXISTS `players`;
CREATE TABLE IF NOT EXISTS `players` (
  `pla_id` int(11) NOT NULL AUTO_INCREMENT,
  `pla_nome` varchar(45) DEFAULT NULL,
  `pla_datanasc` varchar(40) DEFAULT NULL,
  `tim_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`pla_id`),
  KEY `tim_id_idx` (`tim_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `players`
--

INSERT INTO `players` (`pla_id`, `pla_nome`, `pla_datanasc`, `tim_id`) VALUES
(1, 'ShahZaM', '08/10/1993', 1),
(2, 'TenZ', '05/05/2001', 1),
(3, 'dapr', '01/01/1999', 1),
(4, 'zombs', '02/10/1998', 1),
(5, 'SicK', '02/09/1998', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `regiao`
--

DROP TABLE IF EXISTS `regiao`;
CREATE TABLE IF NOT EXISTS `regiao` (
  `reg_id` varchar(64) NOT NULL,
  `reg_nome` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`reg_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `regiao`
--

INSERT INTO `regiao` (`reg_id`, `reg_nome`) VALUES
('BR', 'Brasil'),
('NA', 'América do Norte');

-- --------------------------------------------------------

--
-- Estrutura da tabela `times`
--

DROP TABLE IF EXISTS `times`;
CREATE TABLE IF NOT EXISTS `times` (
  `tim_id` int(11) NOT NULL AUTO_INCREMENT,
  `tim_nome` varchar(45) DEFAULT NULL,
  `tim_earn` float DEFAULT NULL,
  `reg_id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`tim_id`),
  KEY `reg_id_idx` (`reg_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `times`
--

INSERT INTO `times` (`tim_id`, `tim_nome`, `tim_earn`, `reg_id`) VALUES
(1, 'Sentinels', 531.5, 'NA');

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `players`
--
ALTER TABLE `players`
  ADD CONSTRAINT `tim_id` FOREIGN KEY (`tim_id`) REFERENCES `times` (`tim_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
