--Crear sesión al crear usuario

CREATE OR REPLACE FUNCTION crear_sesion_al_insertar_usuario()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO sesion (cedula_ciudadania, fecha_ultimo_like, cantidad_likes, usuario_habilitado)
    VALUES (NEW.cedula_ciudadania, NOW(), 3, TRUE);
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


CREATE TRIGGER trigger_crear_sesion
AFTER INSERT ON usuario
FOR EACH ROW
EXECUTE FUNCTION crear_sesion_al_insertar_usuario();


--Borrar sesión al borrar usuario

CREATE OR REPLACE FUNCTION eliminar_sesion()
RETURNS TRIGGER AS $$
BEGIN
    DELETE FROM sesion WHERE cedula_ciudadania = OLD.cedula_ciudadania;
    RETURN OLD;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_eliminar_sesion
BEFORE DELETE ON usuario
FOR EACH ROW
EXECUTE FUNCTION eliminar_sesion();


--Descontador de Likes y deshabilitador de cuenta

CREATE OR REPLACE FUNCTION descontar_like_y_validar_sesion()
RETURNS TRIGGER AS $$
BEGIN
    UPDATE sesion
    SET cantidad_likes = cantidad_likes - 1,
        usuario_habilitado = CASE 
            WHEN cantidad_likes - 1 <= 0 THEN FALSE
            ELSE usuario_habilitado
        END,
        fecha_ultimo_like = NOW()
    WHERE cedula_ciudadania = NEW.cedula_ciudadania_dador;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


CREATE TRIGGER trigger_descuento_like
AFTER INSERT ON likes
FOR EACH ROW
EXECUTE FUNCTION descontar_like_y_validar_sesion();


--Gestión de matches de acuerdo a likes

CREATE OR REPLACE FUNCTION crear_match_si_es_mutuo()
RETURNS TRIGGER AS $$
BEGIN
    -- Verificar si ya existe un like de la otra persona hacia quien insertó este like
    IF EXISTS (
        SELECT 1 FROM likes
        WHERE cedula_ciudadania_dador = NEW.cedula_ciudadania_recipiente
          AND cedula_ciudadania_recipiente = NEW.cedula_ciudadania_dador
    ) THEN
        -- Verificar si ya existe el match (para no duplicarlo)
        IF NOT EXISTS (
            SELECT 1 FROM matches
            WHERE (cedula_ciudadania_1 = NEW.cedula_ciudadania_dador AND cedula_ciudadania_2 = NEW.cedula_ciudadania_recipiente)
               OR (cedula_ciudadania_1 = NEW.cedula_ciudadania_recipiente AND cedula_ciudadania_2 = NEW.cedula_ciudadania_dador)
        ) THEN
            -- Insertar el match ordenando los campos para evitar duplicados invertidos
            INSERT INTO matches (cedula_ciudadania_1, cedula_ciudadania_2)
            VALUES (
                LEAST(NEW.cedula_ciudadania_dador, NEW.cedula_ciudadania_recipiente),
                GREATEST(NEW.cedula_ciudadania_dador, NEW.cedula_ciudadania_recipiente)
            );
        END IF;
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


CREATE TRIGGER trigger_match_mutuo
AFTER INSERT ON likes
FOR EACH ROW
EXECUTE FUNCTION crear_match_si_es_mutuo();
