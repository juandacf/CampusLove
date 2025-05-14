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
    public class ImpCarreraRepository : IGenericRepository<Carrera>, ICarreraRepository
    {

        private readonly ConexionPostgresSingleton _conexion;

        public ImpCarreraRepository(string connectionString){
                 _conexion = ConexionPostgresSingleton.Instancia(connectionString);
        }

        public void Actualizar(Carrera entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "UPDATE carrera SET nombre_carrera=@nombre WHERE id_carrera=@id";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nombre", entity.nombre_carrera);
            cmd.Parameters.AddWithValue("@id", entity.id_carrera);
            cmd.ExecuteNonQuery();
        }

        public void Crear(Carrera entity)
        {
           var connection = _conexion.ObtenerConexion();
           string query = "INSERT INTO carrera(nombre_carrera) VALUES(@nombre)";
           using var cmd = new NpgsqlCommand(query, connection);
           cmd.Parameters.AddWithValue("@nombre", entity.nombre_carrera);
           cmd.ExecuteNonQuery();
        }

        public void Eliminar(int var)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "DELETE FROM carrera WHERE id_carrera=@id";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", var);
            cmd.ExecuteNonQuery();
        }

        public List<Carrera> ObtenerTodos()
        {
            var CarreraList = new List<Carrera>();
                var connection = _conexion.ObtenerConexion();
                string query = "SELECT id_carrera,nombre_carrera FROM carrera";
                using var cmd = new NpgsqlCommand(query, connection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read()){
                    CarreraList.Add( new Carrera{
                        id_carrera = reader.GetInt32("id_carrera"),
                        nombre_carrera = reader.GetString("nombre_carrera")
                    });
                }

            return CarreraList;
        }
    }

    internal interface ICarreraInteresRepository
    {
    }
}