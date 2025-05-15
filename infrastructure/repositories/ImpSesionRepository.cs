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
    public class ImpSesionRepository : IGenericRepository<Sesion>, ISesionRepository
    {
        private readonly ConexionPostgresSingleton _conexion;

        public ImpSesionRepository(string connectionString){
                 _conexion = ConexionPostgresSingleton.Instancia(connectionString);
        }

        public void Actualizar(Sesion entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "update sesion set fecha_ultimo_like = NOW(), cantidad_likes = @cantidad_likes, usuario_habilitado = @usuario_habilitado where cedula_ciudadania = @cedula_ciudadania;";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cantidad_likes", entity.cantidad_likes);
            cmd.Parameters.AddWithValue("@usuario_habilitado", entity.usuario_habilitado);
            cmd.Parameters.AddWithValue("@cedula_ciudadania", entity.cedula_ciudadania_ciudadania);
            cmd.ExecuteNonQuery();
        }

        public void Crear(Sesion entity)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "INSERT INTO sesion(cedula_ciudadania, fecha_ultimo_like, cantidad_likes, usuario_habilitado) VALUES(@cedula_ciudadania,NOW(), @cantidad_likes, TRUE);";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cedula_ciudadania", entity.cedula_ciudadania_ciudadania);
            cmd.Parameters.AddWithValue("@cantidad_likes", entity.cantidad_likes);
            cmd.ExecuteNonQuery();
            
        }

        public void Eliminar(int var)
        {
            var connection = _conexion.ObtenerConexion();
            string query = "DELETE FROM sesion WHERE id=@id";
            using var cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", var);
            cmd.ExecuteNonQuery();

        }

        public List<Sesion> ObtenerTodos()
        {
            var SesionList = new List<Sesion>();
            var connection = _conexion.ObtenerConexion();
            string query = "SELECT id, cedula_ciudadania, fecha_ultimo_like, cantidad_likes, usuario_habilitado FROM sesion;";
            using var cmd = new NpgsqlCommand(query, connection);
            using var reader = cmd.ExecuteReader();
            while(reader.Read()){
                SesionList.Add(new Sesion{
                    id_sesion = reader.GetInt32("id"),
                    cedula_ciudadania_ciudadania = reader.GetString("cedula_ciudadania"),
                    fecha_ultimo_like = reader.GetDateTime("fecha_ultimo_like"),
                    cantidad_likes = reader.GetInt32("cantidad_likes"),
                    usuario_habilitado = reader.GetBoolean("usuario_habilitado")
                });
            }
            return SesionList;
            
        }
    }
}