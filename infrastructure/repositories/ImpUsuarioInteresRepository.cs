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
    public class ImpUsuarioInteresRepository : IGenericRepository<UsuarioInteres>, IUsuarioInteresRepository
    {
        private readonly ConexionPostgresSingleton _conexion;
        public ImpUsuarioInteresRepository(string connectionString){
                 _conexion = ConexionPostgresSingleton.Instancia(connectionString);
        }

        public void Actualizar(UsuarioInteres entity)
        {
            throw new NotImplementedException();
        }

        public void Crear(UsuarioInteres entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO interes_usuario(cedula_ciudadania, id_interes) VALUES(@cedula_ciudadania, @id_interes );";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cedula_ciudadania", entity.cedula_ciudadania);
            cmd.Parameters.AddWithValue("@id_interes", entity.id_interes);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int var)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "DELETE FROM interes_usuario WHERE id=@id";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", var);
            cmd.ExecuteNonQuery();


        }

        public List<UsuarioInteres> ObtenerTodos()
        {
            var connection = _conexion.ObtenerConexion();
            var UsuarioInteresList = new List<UsuarioInteres>();
            string query = "SELECT Id, cedula_ciudadania, id_interes FROM interes_usuario;";
            using var cmd = new NpgsqlCommand(query, connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UsuarioInteresList.Add(
                    new UsuarioInteres
                    {
                        id_usuario_interes = reader.GetInt32("Id"),
                        cedula_ciudadania = reader.GetString("cedula_ciudadania"),
                        id_interes = reader.GetInt32("id_interes")
                    }
                );
            }
            return UsuarioInteresList;
        }
    }
}