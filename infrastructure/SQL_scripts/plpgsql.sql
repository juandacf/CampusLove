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


