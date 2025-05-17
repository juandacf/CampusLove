-- CampusLove

DROP SCHEMA public CASCADE;
CREATE SCHEMA public;


CREATE TABLE IF NOT EXISTS carrera (
    id_carrera SERIAL,
    nombre_carrera VARCHAR,
    PRIMARY KEY(id_carrera)
);

CREATE TABLE IF NOT EXISTS interes(
    id SERIAL,
    nombre VARCHAR,
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS usuario (
    cedula_ciudadania VARCHAR,
    nombre VARCHAR,
    apellido VARCHAR,
    genero BOOLEAN,
    contraseña VARCHAR,
    id_carrera INTEGER,
    PRIMARY KEY(cedula_ciudadania),
    FOREIGN KEY(id_carrera)  REFERENCES carrera(id_carrera)
);

CREATE TABLE IF NOT EXISTS sesion (
    id SERIAL,
    cedula_ciudadania VARCHAR UNIQUE,
    fecha_ultimo_like  TIMESTAMP,
    cantidad_likes DECIMAL(2,0),
    usuario_habilitado BOOLEAN,
    PRIMARY KEY(id),
    FOREIGN KEY(cedula_ciudadania) REFERENCES usuario(cedula_ciudadania)
);

CREATE TABLE IF NOT EXISTS likes (
    id SERIAL, 
    cedula_ciudadania_dador VARCHAR,
    cedula_ciudadania_recipiente VARCHAR,
    PRIMARY KEY(id),
    FOREIGN KEY (cedula_ciudadania_dador) REFERENCES usuario(cedula_ciudadania),
    FOREIGN KEY(cedula_ciudadania_recipiente)  REFERENCES usuario(cedula_ciudadania)
);

CREATE TABLE IF NOT EXISTS matches (
    id SERIAL,
    cedula_ciudadania_1 VARCHAR,
    cedula_ciudadania_2 VARCHAR,
    PRIMARY KEY(id),
    FOREIGN KEY(cedula_ciudadania_1) REFERENCES usuario(cedula_ciudadania),
    FOREIGN KEY(cedula_ciudadania_2) REFERENCES usuario(cedula_ciudadania)
);

CREATE TABLE IF NOT EXISTS interes_usuario (
    id SERIAL,
    cedula_ciudadania VARCHAR,
    id_interes INTEGER,
    PRIMARY KEY(id),
    FOREIGN KEY(cedula_ciudadania) REFERENCES usuario(cedula_ciudadania),
    FOREIGN KEY(id_interes) REFERENCES interes(id)
);