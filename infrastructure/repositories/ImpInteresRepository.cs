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
    public class ImpInteresRepository : IGenericRepository<Interes>, IInteresRepository
    {
private readonly ConexionPostgresSingleton _conexion;
        public ImpInteresRepository(string connectionString){
                 _conexion = ConexionPostgresSingleton.Instancia(connectionString);
        }
        public void Actualizar(Interes entity)
        {
             var connection = _conexion.ObtenerConexion();
             string query = "UPDATE interes SET nombre=@nombre WHERE id=@id";
             using var cmd = new NpgsqlCommand(query, connection);
             cmd.Parameters.AddWithValue("@nombre", entity.nombre_interes);
             cmd.Parameters.AddWithValue("@id", entity.id_interes);
             cmd.ExecuteNonQuery();
        }

        public void Crear(Interes entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO interes(nombre) VALUES(@nombre)";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nombre", entity.nombre_interes);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int var)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "DETELE FROM interes WHERE id=@id";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", var);
            cmd.ExecuteNonQuery();
        }

        public List<Interes> ObtenerTodos()
        {
            var InterestList = new List<Interes>();
                var connection = _conexion.ObtenerConexion();
                string query = "SELECT id,nombre FROM interes";
                using var cmd = new NpgsqlCommand(query, connection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read()){
                    InterestList.Add( new Interes{
                        id_interes = reader.GetInt32("id"),
                        nombre_interes = reader.GetString("nombre")
                    });
                }

            return InterestList;
        }
    }

}