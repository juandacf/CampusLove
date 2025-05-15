using campuslove.application.services;
using campuslove.domain.entities;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;
using campusLove.application.services;
using CampusLove.application.services;

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
        var ServicioLike = new LikesService(factory.CreateLikeRepository());
        var ServicioMatch = new MatchesService(factory.CreateMatchesRepository());
        var ServicioIU = new UsuarioInteresService(factory.CreateUsuarioInteresRepository());

        UsuarioInteres ejemplo = new UsuarioInteres
        {
            id_usuario_interes = 0,
            cedula_ciudadania = "1010",
            id_interes = 2,
         };

        ServicioIU.EliminarUsuarioInteres(32);

       

        
          
    }
}