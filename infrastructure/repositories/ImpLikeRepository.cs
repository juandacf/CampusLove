using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;
using campuslove.infrastructure.postgreSQL;
using campusLove.domain.ports;
using Npgsql;

namespace campusLove.infrastructure.repositories
{
    public class ImpLikeRepository : IGenericRepository<Like>, ILikeRepository
    {
        private readonly ConexionPostgresSingleton _conexion;

        public ImpLikeRepository(string connectionString)
        {
            _conexion = ConexionPostgresSingleton.Instancia(connectionString);
        }

        public void Actualizar(Like entity)
        {
            var connection = _conexion.ObtenerConexion();
        }

        public void Crear(Like entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO likes(cedula_ciudadania_dador, cedula_ciudadania_recipiente) VALUES(@cedula_ciudadania_dador, @cedula_ciudadania_recipiente);";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cedula_ciudadania_dador", entity.cedula_ciudadania_dador);
            cmd.Parameters.AddWithValue("@cedula_ciudadania_recipiente", entity.cedula_ciudadania_recipiente);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int var)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "DELETE FROM likes WHERE id=@id";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", var);
            cmd.ExecuteNonQuery();
        }

        public List<Like> ObtenerTodos()
        {
            var LikesList = new List<Like>();
            var connection = _conexion.ObtenerConexion();
            string query = "SELECT Id, cedula_ciudadania_dador, cedula_ciudadania_recipiente FROM likes;";
            using var cmd = new NpgsqlCommand(query, connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LikesList.Add(new Like
                {
                    id_like = reader.GetInt32("Id"),
                    cedula_ciudadania_dador = reader.GetString("cedula_ciudadania_dador"),
                    cedula_ciudadania_recipiente = reader.GetString ("cedula_ciudadania_recipiente")
                });
            }
            return LikesList;
        }
    }
}