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

        ServicioInteres.VerInteres();
    



    }
}