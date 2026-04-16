Create database unidades12;

use unidades12;

create table practica1(
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(100),
	nota1 DOUBLE,
	nota2 DOUBLE,
	nota3 DOUBLE,
	nota4 DOUBLE,
	promedio DOUBLE
);

create table practica2(
	id INT AUTO_INCREMENT PRIMARY KEY,
	medio VARCHAR(100),
	cantidad INT,
	precio DOUBLE,
	bruto DOUBLE,
	descuento DOUBLE,
	neto DOUBLE
);

create table practica3(
	id int AUTO_INCREMENT primary key,
	categoria VARCHAR (3),
	promedio double,
	pensionbase double,
	descuento double,
	total double,
	fecha datetime
);


create table practica4 (
	id int AUTO_INCREMENT PRIMARY KEY,
	edad double,
	genero varchar(100),
	estado varchar(100),
	totalasistentes double
);
	
create table practica5(
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombre varchar(100),
	fechaed double,
	paginas double,
	costos double,
	editorial varchar(100)
);
	