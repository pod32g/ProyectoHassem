CREATE TABLE `Usuario` (
	`id` int NOT NULL AUTO_INCREMENT,
	`userName` varchar(70) NOT NULL UNIQUE,
	`password` varchar(70) NOT NULL UNIQUE,
	PRIMARY KEY (`id`)
);

CREATE TABLE `DatosUsuario` (
	`usuario_id` int NOT NULL,
	`nombre1` varchar(50) NOT NULL,
	`nombre2` varchar(50),
	`apellidoMaterno` varchar(50),
	`apellidoPaterno` varchar(50),
	FOREIGN KEY (`usuario_id`) REFERENCES `Usuario`(`id`) ON DELETE CASCADE ON UPDATE CASCADE
)

ENGINE = InnoDB;

CREATE TABLE `Alumnos` (
	`matricula` int NOT NULL AUTO_INCREMENT,
	`usuario_id` int NOT NULL,
	`carrera` varchar(70) NOT NULL,
	`nivel` varchar(30) NOT NULL,
	`turno` varchar(30) NOT NULL,
	PRIMARY KEY (`matricula`),
	FOREIGN KEY (`usuario_id`) REFERENCES `Usuario`(`id`) ON DELETE CASCADE ON UPDATE CASCADE
)

ENGINE = InnoDB;

CREATE TABLE `TipoUsuario` (
	`usuario_id` int NOT NULL,
	`tipo` varchar(10) NOT NULL,
	FOREIGN KEY (`usuario_id`) REFERENCES `Usuario`(`id`) ON DELETE CASCADE ON UPDATE CASCADE
)

ENGINE = InnoDB;

CREATE TABLE `Profesores` (
	`codigo` int(50) NOT NULL AUTO_INCREMENT,
	`usuario_id` int NOT NULL,
	`carrera` varchar(50) NOT NULL,
	PRIMARY KEY (`codigo`),
	FOREIGN KEY (`usuario_id`) REFERENCES `Usuario`(`id`) ON UPDATE CASCADE ON DELETE CASCADE
)

ENGINE = InnoDB;

CREATE TABLE `DatosContacto` (
	`id_usuario` int NOT NULL,
	`correo` varchar(70) NOT NULL UNIQUE,
	`cargo` varchar(70) NOT NULL,
	`telefono` varchar(70) NOT NULL,
	FOREIGN KEY (`id_usuario`) REFERENCES `Usuario`(`id`) ON UPDATE CASCADE ON DELETE CASCADE
)

ENGINE = InnoDB;

CREATE TABLE `Empresa` (
	`id_usuario` int NOT NULL,
	`nombre` varchar(70) NOT NULL,
	FOREIGN KEY (`id_usuario`) REFERENCES `Usuario`(`id`) ON UPDATE CASCADE ON DELETE CASCADE
)

ENGINE = InnoDB;

CREATE TABLE `Proyecto` (
	`id` int NOT NULL,
	`nombre` varchar(70) NOT NULL UNIQUE,
	`fechaInicio` DATE NOT NULL,
	`fechaFin` DATE NOT NULL,
	`resultados` longtext NOT NULL,
	`objetivo` mediumtext NOT NULL,
	`alumno_encargado` int NOT NULL,
	`maestro_encargado` int NOT NULL,
	PRIMARY KEY (`id`),
	FOREIGN KEY (`alumno_encargado`) REFERENCES `Alumnos`(`matricula`) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (`maestro_encargado`) REFERENCES `Profesores`(`codigo`) ON UPDATE CASCADE ON DELETE CASCADE
)

ENGINE = InnoDB;
