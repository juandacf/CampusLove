using campuslove.application.services;
using campuslove.domain.entities;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;

namespace campuslove;
internal class Program
{
    private static void Main(string[] args)
    {
         IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
         var ServicioInteres = new InteresService(factory.CreateInteresRepository());
          var ServicioCarrera = new CarreraService(factory.CreateCarreraRepository());
        var ServicioUsuario = new UsuarioService(factory.CreateUsuarioRepository());
        var ServicioSesion = new SesionService(factory.CreateSesionRepository());
        

        Sesion  sesion = new Sesion {
            cedula_ciudadania_ciudadania = "1001",
            cantidad_likes = 88,
            usuario_habilitado = true
        };
        ServicioSesion.EliminarSesion(11);
          
    }
}