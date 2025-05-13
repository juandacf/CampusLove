-- CARRERAS
INSERT INTO carrera (nombre_carrera) VALUES
('Ingeniería de Sistemas'),
('Psicología'),
('Administración de Empresas'),
('Medicina'),
('Diseño Gráfico'),
('Derecho'),
('Arquitectura'),
('Contaduría Pública');

-- INTERESES
INSERT INTO interes (nombre) VALUES
('Cine'),
('Videojuegos'),
('Lectura'),
('Viajar'),
('Música'),
('Deportes'),
('Cocina'),
('Arte'),
('Tecnología'),
('Animales'),
('Baile'),
('Senderismo'),
('Idiomas'),
('Cómics'),
('Fotografía');

-- USUARIOS
INSERT INTO usuario (cedula_ciudadania, nombre, apellido, genero, id_carrera) VALUES
('1001', 'Ana', 'Gómez', TRUE, 1),
('1002', 'Luis', 'Martínez', FALSE, 2),
('1003', 'Camila', 'Rodríguez', TRUE, 3),
('1004', 'Carlos', 'Pérez', FALSE, 4),
('1005', 'Laura', 'Fernández', TRUE, 5),
('1006', 'Juan', 'López', FALSE, 1),
('1007', 'Sofía', 'Ramírez', TRUE, 6),
('1008', 'David', 'García', FALSE, 7),
('1009', 'Isabella', 'Moreno', TRUE, 8),
('1010', 'Mateo', 'Torres', FALSE, 2);

-- INTERES_USUARIO
INSERT INTO interes_usuario (cedula_ciudadania, id_interes) VALUES
('1001', 1), ('1001', 3), ('1001', 5),
('1002', 2), ('1002', 4), ('1002', 6),
('1003', 3), ('1003', 7), ('1003', 9),
('1004', 1), ('1004', 10), ('1004', 11),
('1005', 2), ('1005', 5), ('1005', 13),
('1006', 6), ('1006', 8), ('1006', 9),
('1007', 3), ('1007', 5), ('1007', 12),
('1008', 1), ('1008', 4), ('1008', 7),
('1009', 2), ('1009', 10), ('1009', 15),
('1010', 1), ('1010', 6), ('1010', 14);

-- SESIONES
INSERT INTO sesion (cedula_ciudadania, fecha_ultimo_like, cantidad_likes, usuario_habilitado) VALUES
('1001', TRUE, 5, TRUE),
('1002', FALSE, 0, TRUE),
('1003', TRUE, 3, TRUE),
('1004', FALSE, 0, FALSE),
('1005', TRUE, 2, TRUE),
('1006', TRUE, 4, TRUE),
('1007', FALSE, 0, TRUE),
('1008', TRUE, 6, TRUE),
('1009', FALSE, 0, FALSE),
('1010', TRUE, 1, TRUE);

-- LIKES
INSERT INTO likes (cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES
('1001', '1002'),
('1002', '1003'),
('1003', '1001'),
('1004', '1005'),
('1005', '1006'),
('1006', '1007'),
('1007', '1008'),
('1008', '1009'),
('1009', '1010'),
('1010', '1001');

-- MATCHES
INSERT INTO matches (cedula_ciudadania_1, cedula_ciudadania_2) VALUES
('1001', '1003'),
('1002', '1003'),
('1005', '1006'),
('1008', '1009');
