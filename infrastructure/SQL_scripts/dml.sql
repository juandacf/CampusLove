-- INSERTS PARA CARRERA

INSERT INTO carrera (nombre_carrera) VALUES ('Ingeniería de Sistemas');
INSERT INTO carrera (nombre_carrera) VALUES ('Psicología');
INSERT INTO carrera (nombre_carrera) VALUES ('Administración de Empresas');
INSERT INTO carrera (nombre_carrera) VALUES ('Diseño Gráfico');
INSERT INTO carrera (nombre_carrera) VALUES ('Medicina');
INSERT INTO carrera (nombre_carrera) VALUES ('Derecho');
INSERT INTO carrera (nombre_carrera) VALUES ('Arquitectura');
INSERT INTO carrera (nombre_carrera) VALUES ('Economía');


-- INSERTS PARA INTERES

INSERT INTO interes (nombre) VALUES ('Leer');
INSERT INTO interes (nombre) VALUES ('Cine');
INSERT INTO interes (nombre) VALUES ('Videojuegos');
INSERT INTO interes (nombre) VALUES ('Deportes');
INSERT INTO interes (nombre) VALUES ('Viajar');
INSERT INTO interes (nombre) VALUES ('Música');
INSERT INTO interes (nombre) VALUES ('Arte');
INSERT INTO interes (nombre) VALUES ('Programar');
INSERT INTO interes (nombre) VALUES ('Bailar');
INSERT INTO interes (nombre) VALUES ('Cocinar');
INSERT INTO interes (nombre) VALUES ('Fotografía');
INSERT INTO interes (nombre) VALUES ('Naturaleza');
INSERT INTO interes (nombre) VALUES ('Idiomas');
INSERT INTO interes (nombre) VALUES ('Mascotas');
INSERT INTO interes (nombre) VALUES ('Tecnología');


-- INSERTS PARA USUARIO

INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000001', 'Jorge', 'Gómez', TRUE, 'pass001', 2);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000002', 'Lucía', 'López', TRUE, 'pass002', 1);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000003', 'Carlos', 'López', TRUE, 'pass003', 5);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000004', 'María', 'Pérez', TRUE, 'pass004', 2);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000005', 'Carlos', 'Martínez', FALSE, 'pass005', 2);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000006', 'Luis', 'Martínez', FALSE, 'pass006', 5);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000007', 'Luis', 'Pérez', TRUE, 'pass007', 5);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000008', 'Ana', 'Gómez', FALSE, 'pass008', 4);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000009', 'Juan', 'López', FALSE, 'pass009', 6);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000010', 'Luis', 'Ramírez', FALSE, 'pass010', 8);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000011', 'Luis', 'Ramírez', TRUE, 'pass011', 5);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000012', 'Pedro', 'Rodríguez', FALSE, 'pass012', 5);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000013', 'Laura', 'Martínez', FALSE, 'pass013', 7);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000014', 'Juan', 'Ramírez', TRUE, 'pass014', 2);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000015', 'María', 'Ortega', TRUE, 'pass015', 7);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000016', 'María', 'Martínez', FALSE, 'pass016', 3);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000017', 'Lucía', 'Rodríguez', FALSE, 'pass017', 7);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000018', 'Carlos', 'Gómez', FALSE, 'pass018', 4);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000019', 'Lucía', 'Ortega', FALSE, 'pass019', 1);
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, contraseña, id_carrera) VALUES ('1000000020', 'Juan', 'Sánchez', FALSE, 'pass020', 5);


-- INSERTS PARA INTERES_USUARIO

INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000001', 13);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000001', 5);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000001', 2);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000002', 7);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000002', 14);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000002', 1);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000003', 10);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000003', 3);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000003', 2);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000004', 7);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000004', 13);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000004', 11);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000005', 5);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000005', 12);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000005', 10);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000006', 8);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000006', 9);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000006', 3);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000007', 6);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000007', 4);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000007', 13);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000008', 7);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000008', 2);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000008', 6);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000009', 8);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000009', 3);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000009', 7);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000010', 5);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000010', 4);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000010', 3);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000011', 10);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000011', 14);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000011', 3);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000012', 9);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000012', 13);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000012', 14);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000013', 10);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000013', 8);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000013', 11);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000014', 4);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000014', 1);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000014', 3);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000015', 11);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000015', 3);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000015', 7);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000016', 1);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000016', 13);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000016', 8);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000017', 4);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000017', 3);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000017', 10);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000018', 15);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000018', 7);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000018', 6);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000019', 6);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000019', 15);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000019', 1);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000020', 5);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000020', 10);
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES ('1000000020', 15);





INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000017', '1000000020');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000020', '1000000017');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000018', '1000000014');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000015', '1000000006');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000003', '1000000009');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000010', '1000000015');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000005', '1000000006');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000011', '1000000007');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000011', '1000000020');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000014', '1000000012');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000013', '1000000018');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000012', '1000000010');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000001', '1000000004');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000016', '1000000020');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000015', '1000000003');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000010', '1000000016');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000010', '1000000003');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000007', '1000000016');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000016', '1000000015');
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES ('1000000013', '1000000018');


