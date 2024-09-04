CREATE DATABASE gestor_hotel;

USE gestor_hotel;

CREATE TABLE clientes (
    documento_identidad_cliente INT PRIMARY KEY NOT NULL,
    primer_nombre VARCHAR(15) NOT NULL,
    segundo_nombre VARCHAR(15),
    primer_apellido VARCHAR(15) NOT NULL,
    segundo_apellido VARCHAR(15),
    email VARCHAR(100) NOT NULL UNIQUE,
    telefono VARCHAR(15),
    fecha_registro DATE NOT NULL
);

CREATE TABLE habitaciones (
    id_habitacion INT PRIMARY KEY NOT NULL,
    tipo_habitacion VARCHAR(50) NOT NULL,
    precio DECIMAL(10, 2) NOT NULL,
    disponible BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE reservas (
    id_reserva INT AUTO_INCREMENT PRIMARY KEY,
    documento_identidad_cliente INT,
    id_habitacion INT,
    fecha_entrada DATE NOT NULL,
    fecha_salida DATE NOT NULL,
    FOREIGN KEY (documento_identidad_cliente)
        REFERENCES clientes (documento_identidad_cliente),
    FOREIGN KEY (id_habitacion)
        REFERENCES habitaciones (id_habitacion)
);

/*Datos de ejemplo*/

INSERT INTO clientes (documento_identidad_cliente, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, email, telefono, fecha_registro) VALUES
(1006032396,'Andrich', 'Fernando','Barreto', 'Hernandez', 'andrich.andrich@cun.edu.co', '3206151722', CURDATE()),
(1136548975,'Mariangel',NULL, 'Barreto', NULL, 'mariangel@gmail.com', '32165498721', CURDATE());

INSERT INTO habitaciones (id_habitacion,tipo_habitacion, precio, disponible) VALUES
(101,'Individual', 75.00, TRUE),
(102,'Doble', 100.00, TRUE);

INSERT INTO reservas (documento_identidad_cliente, id_habitacion, fecha_entrada, fecha_salida) VALUES
(1, 1, '2024-09-05', '2024-09-10'),
(2, 2, '2024-09-08', '2024-09-12');