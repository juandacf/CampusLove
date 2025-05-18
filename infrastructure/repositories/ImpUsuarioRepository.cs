using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;
using campuslove.infrastructure.postgreSQL;
using Npgsql;

namespace campuslove.infrastructure.repositories
{
    public class ImpUsuarioRepository : IGenericRepository<Usuario>, IUsuarioRepository
    {
        private readonly ConexionPostgresSingleton _conexion;
        public ImpUsuarioRepository(string connectionString)
        {
            _conexion = ConexionPostgresSingleton.Instancia(connectionString);
        }
        public void Actualizar(Usuario entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "UPDATE usuario SET nombre=@nombre, apellido=@apellido, genero=@genero, id_carrera = @id_carrera, contraseña=@contraseña WHERE cedula_ciudadania=@cedula_ciudadania";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nombre", entity.nombre);
            cmd.Parameters.AddWithValue("@apellido", entity.apellido);
            cmd.Parameters.AddWithValue("@genero", entity.genero);
            cmd.Parameters.AddWithValue("@id_carrera", entity.id_carrera);
            cmd.Parameters.AddWithValue("@cedula_ciudadania", entity.
            cedula_ciudadania);
            cmd.Parameters.AddWithValue("@contraseña", entity.contraseña);
            cmd.ExecuteNonQuery();


        }

        public void Crear(Usuario entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO usuario(cedula_ciudadania, nombre, apellido, genero, id_carrera, contraseña) VALUES(@cedula_ciudadania, @nombre, @apellido, @genero, @id_carrera, @contraseña)";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cedula_ciudadania", entity.cedula_ciudadania);
            cmd.Parameters.AddWithValue("@nombre", entity.nombre);
            cmd.Parameters.AddWithValue("@apellido", entity.apellido);
            cmd.Parameters.AddWithValue("@genero", entity.genero);
            cmd.Parameters.AddWithValue("@id_carrera", entity.id_carrera);
            cmd.Parameters.AddWithValue("@contraseña", entity.contraseña);
            cmd.ExecuteNonQuery();


        }

        public void Eliminar(int var)
        {
            throw new NotImplementedException();

        }

        public void Eliminar(string var)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "DELETE FROM usuario WHERE cedula_ciudadania=@var";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@var", var);
            cmd.ExecuteNonQuery();

        }

        public List<Usuario> ObtenerTodos()
        {
            var connection = _conexion.ObtenerConexion();
            var UsuarioList = new List<Usuario>();
            string query = "SELECT cedula_ciudadania, nombre, apellido, genero, id_carrera, contraseña FROM usuario";
            using var cmd = new NpgsqlCommand(query, connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UsuarioList.Add(new Usuario
                {
                    cedula_ciudadania = reader.GetString("cedula_ciudadania"),
                    nombre = reader.GetString("nombre"),
                    apellido = reader.GetString("apellido"),
                    genero = reader.GetBoolean("genero"),
                    id_carrera = reader.GetInt32("id_carrera"),
                    contraseña = reader.GetString("contraseña")
                });
            }

            return UsuarioList;
        }
    }
}