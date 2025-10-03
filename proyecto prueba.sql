CREATE DATABASE Biblioteca;
USE Biblioteca;

CREATE TABLE Categorias(
ID_Categoria INT auto_increment primary key,
Nombre_Categoria varchar(100) NOT NULL,
Descripcion varchar(255)
);

CREATE TABLE Usuarios(
ID_Usuario INT auto_increment primary key,
Nombre varchar(100)not null,
Apellido varchar(100)not null,
Numero_Identificacion varchar(50)not null,
Correo_Electronico varchar(100)not null,
Telefono varchar(20),
Tipo_Usuario ENUM('Estudiante', 'Profesor', 'Visitante') not null,
Contraseña varchar(255)not null
);

CREATE TABLE Personal (
ID_Personal int auto_increment primary key,
Nombre varchar(100)not null,
Apellido varchar(100)not null,
Numero_Identificacion varchar(50)not null,
Correo_Electronico varchar(100)not null,
Telefono varchar(20),
Cargo varchar(100) not null,
Fecha_Contratacion datetime not null,
Estado ENUM ('Activo', 'Inactivo', 'Vaciones')not null
);

CREATE TABLE Libros (
ID_Libro int auto_increment primary key,
Titulo varchar(255)not null,
Autor varchar(100) not null,
ISBN varchar(20) not null,
Editorial varchar(100)not null,
Año_Publicacion int check (año_Publicacion > 0),
Numero_Copias int check (Numero_Copias >= 0),
ID_Categoria int,
Estado ENUM ('Disponible', 'Prestado', 'Reservado','En Reparacion') NOT NULL DEFAULT 'Disponible',
ID_Personal_Registro INT,
foreign key(ID_Categoria) references Categorias(ID_Categoria),
foreign key (ID_Personal_Registro) references Personal(ID_Personal)
);

CREATE TABLE Sanciones (
ID_Sancion int auto_increment primary key,
ID_Usuario int,
ID_Personal_Sancion int,
Monto decimal(10, 2) check (Monto >= 0),
Fecha_Sancion datetime not null,
DiasSancion int check (DiasSancion >=0),
Estado ENUM('Activo','Cumplido','Vetado') not null,
Descripcion varchar(255),
Motivo varchar(255),
foreign key (ID_Usuario) references Usuarios(ID_Usuario),
foreign key (id_Personal_Sancion) references Personal(ID_Personal)
);

CREATE TABLE Transacciones (
Tipo ENUM('Reseerva','Prestamo') not null,
ID_Libro int,
ID_Usuario int,
ID_Personal int,
Fecha_Inicio datetime not null,
Fecha_Fin datetime,
Fecha_Devolucion_Real datetime,
Estado ENUM('Activo','Devuelto','Cancelada','Activa') not null,
foreign key (ID_Libro) references Libros(ID_Libro),
foreign key(ID_Usuario) references Usuarios(ID_Usuario),
foreign key (ID_Personal) references Personal(ID_Personal)
);

