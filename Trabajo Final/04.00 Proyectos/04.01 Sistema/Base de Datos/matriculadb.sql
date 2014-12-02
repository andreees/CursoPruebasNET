-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 02-12-2014 a las 01:40:30
-- Versión del servidor: 5.6.12-log
-- Versión de PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `matriculadb`
--
CREATE DATABASE IF NOT EXISTS `matriculadb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `matriculadb`;

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspActualizarCurso`(IN `Nombre` VARCHAR(100), IN `Codigo` VARCHAR(50), IN `Creditos` INT, IN `Requisitos` VARCHAR(100), IN `Ciclo` INT, IN `id` INT)
    NO SQL
UPDATE curso
SET
    nombre = Nombre,
    codigo = Codigo,
    creditos = Creditos,
    requisitos = Requisitos,
	ciclo = Ciclo
WHERE
	idCurso = id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `uspEliminarCurso`(IN `id` INT)
    NO SQL
DELETE c
FROM curso c
WHERE idcurso=id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `uspInsertarCurso`(IN `Nombre` VARCHAR(100), IN `Codigo` VARCHAR(50), IN `Creditos` INT, IN `Requisitos` VARCHAR(100), IN `Ciclo` INT)
    NO SQL
INSERT INTO curso(nombre,codigo,creditos,requisitos,ciclo)
VALUES(Nombre,Codigo,Creditos,Requisitos,Ciclo)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `uspListarCursos`()
    NO SQL
select * from curso$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `uspObtenerPoridCurso`(IN `id` INT)
    NO SQL
SELECT *
FROM curso
WHERE idcurso=id$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administrador`
--

CREATE TABLE IF NOT EXISTS `administrador` (
  `idadministrador` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(100) DEFAULT NULL,
  `apellidos` varchar(100) DEFAULT NULL,
  `idusuario` int(11) NOT NULL,
  PRIMARY KEY (`idadministrador`),
  KEY `administrador_usuario` (`idusuario`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `administrador`
--

INSERT INTO `administrador` (`idadministrador`, `nombres`, `apellidos`, `idusuario`) VALUES
(1, 'Henry', 'Wong', 1),
(2, 'Eduardo', 'Palomino', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumno`
--

CREATE TABLE IF NOT EXISTS `alumno` (
  `idalumno` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(100) DEFAULT NULL,
  `apellidos` varchar(100) DEFAULT NULL,
  `idusuario` int(11) NOT NULL,
  PRIMARY KEY (`idalumno`),
  KEY `alumno_usuario` (`idusuario`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `alumno`
--

INSERT INTO `alumno` (`idalumno`, `nombres`, `apellidos`, `idusuario`) VALUES
(1, 'Roy', 'Taza', 2),
(2, 'Andres', 'Baquerizo', 4),
(3, 'Cesar', 'Palma', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clase`
--

CREATE TABLE IF NOT EXISTS `clase` (
  `idclase` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(50) DEFAULT NULL,
  `dia` varchar(50) DEFAULT NULL,
  `horaInicio` int(11) DEFAULT NULL,
  `horaFin` int(11) DEFAULT NULL,
  `tipoClase` varchar(50) DEFAULT NULL,
  `idseccion` int(11) NOT NULL,
  PRIMARY KEY (`idclase`),
  KEY `fk_clase_seccion` (`idseccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `curso`
--

CREATE TABLE IF NOT EXISTS `curso` (
  `idcurso` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `codigo` varchar(50) DEFAULT NULL,
  `creditos` int(11) DEFAULT NULL,
  `requisitos` varchar(100) DEFAULT NULL,
  `ciclo` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcurso`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=17 ;

--
-- Volcado de datos para la tabla `curso`
--

INSERT INTO `curso` (`idcurso`, `nombre`, `codigo`, `creditos`, `requisitos`, `ciclo`) VALUES
(16, 'Arquitectura de Software', 'HU23', 1, 'Algoritmos Avanzados', 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matricula`
--

CREATE TABLE IF NOT EXISTS `matricula` (
  `idmatricula` int(11) NOT NULL AUTO_INCREMENT,
  `horamatricula` int(11) DEFAULT NULL,
  `fechamatricula` date DEFAULT NULL,
  `idcurso` int(11) NOT NULL,
  `idalumno` int(11) NOT NULL,
  `idseccion` int(11) NOT NULL,
  PRIMARY KEY (`idmatricula`),
  KEY `matricula_alumno` (`idalumno`),
  KEY `matricula_curso` (`idcurso`),
  KEY `fk_matricula_seccion1_idx` (`idseccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `seccion`
--

CREATE TABLE IF NOT EXISTS `seccion` (
  `idseccion` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(50) DEFAULT NULL,
  `profesor` varchar(50) DEFAULT NULL,
  `idcurso` int(11) NOT NULL,
  PRIMARY KEY (`idseccion`),
  KEY `fk_seccion_curso1_idx` (`idcurso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `solicitud`
--

CREATE TABLE IF NOT EXISTS `solicitud` (
  `idsolicitud` int(11) NOT NULL AUTO_INCREMENT,
  `motivo` varchar(1000) DEFAULT NULL,
  `idalumno` int(11) NOT NULL,
  `idcurso` int(11) NOT NULL,
  PRIMARY KEY (`idsolicitud`),
  KEY `solicitud_alumno` (`idalumno`),
  KEY `fk_solicitud_curso1_idx` (`idcurso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) DEFAULT NULL,
  `clave` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idusuario`, `usuario`, `clave`) VALUES
(1, 'hwong', '027e4180beedb29744413a7ea6b84a42'),
(2, 'rtaza', 'd4c285227493531d0577140a1ed03964'),
(3, 'epalomino', '6d6354ece40846bf7fca65dfabd5d9d4'),
(4, 'abaquerizo', '231badb19b93e44f47da1bd64a8147f2'),
(5, 'cpalma', '6f597c1ddab467f7bf5498aad1b41899');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `administrador`
--
ALTER TABLE `administrador`
  ADD CONSTRAINT `fk_administrador_idusuario` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `alumno`
--
ALTER TABLE `alumno`
  ADD CONSTRAINT `fk_alumno_idusuario` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `clase`
--
ALTER TABLE `clase`
  ADD CONSTRAINT `fk_idseccion` FOREIGN KEY (`idseccion`) REFERENCES `seccion` (`idseccion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `matricula`
--
ALTER TABLE `matricula`
  ADD CONSTRAINT `fk_matricula_idalumno` FOREIGN KEY (`idalumno`) REFERENCES `alumno` (`idalumno`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_matricula_idcurso` FOREIGN KEY (`idcurso`) REFERENCES `curso` (`idcurso`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_matricula_seccion1` FOREIGN KEY (`idseccion`) REFERENCES `seccion` (`idseccion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `seccion`
--
ALTER TABLE `seccion`
  ADD CONSTRAINT `fk_seccion_curso1` FOREIGN KEY (`idcurso`) REFERENCES `curso` (`idcurso`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `solicitud`
--
ALTER TABLE `solicitud`
  ADD CONSTRAINT `fk_solicitud_curso1` FOREIGN KEY (`idcurso`) REFERENCES `curso` (`idcurso`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_solicitud_idalumno` FOREIGN KEY (`idalumno`) REFERENCES `alumno` (`idalumno`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
