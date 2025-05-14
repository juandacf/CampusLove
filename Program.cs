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

        Usuario usuario = new Usuario {
            cedula_ciudadania = "1007669080",
            nombre = "JuanEditado",
            apellido = "Caballero",
            contraseña = "juanda0425",
            genero = false,
            id_carrera=1
        };

        ServicioUsuario.EliminarUsuario("1007669080");
          
    }
}