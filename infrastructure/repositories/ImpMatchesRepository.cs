using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;
using campuslove.infrastructure.postgreSQL;
using campusLove.domain.ports;
using Npgsql;

namespace campusLove.infrastructure.repositories
{
    public class ImpMatchesRepository : IGenericRepository<Matches>, IMatchesRepository
    {

        private readonly ConexionPostgresSingleton _conexion;

        public ImpMatchesRepository(string connectionString){
                 _conexion = ConexionPostgresSingleton.Instancia(connectionString);
        }
        public void Actualizar(Matches entity)
        {
            throw new NotImplementedException();
        }

        public void Crear(Matches entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO matches(cedula_ciudadania_1, cedula_ciudadania_2) VALUES(@cedula_ciudadania_1, @cedula_ciudadania_2);";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cedula_ciudadania_1", entity.cedula_ciudadania_1);
            cmd.Parameters.AddWithValue("@cedula_ciudadania_2", entity.cedula_ciudadania_2);
            cmd.ExecuteNonQuery();

        }

        public void Eliminar(int var)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "DELETE FROM matches WHERE id=@id";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", var);
             cmd.ExecuteNonQuery();
        }

        public List<Matches> ObtenerTodos()
        {
            var connection = _conexion.ObtenerConexion();
            var MatchesList = new List<Matches>();
            string query = "select id, cedula_ciudadania_1, cedula_ciudadania_2 FROM matches;";
            using var cmd = new NpgsqlCommand(query, connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MatchesList.Add(new Matches
                {
                    id_match = reader.GetInt32("id"),
                    cedula_ciudadania_1 = reader.GetString("cedula_ciudadania_1"),
                    cedula_ciudadania_2 = reader.GetString("cedula_ciudadania_2")
                });
            }
            return MatchesList;

        }
    }
}