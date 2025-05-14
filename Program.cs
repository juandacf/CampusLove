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

       Interes interes = new Interes {
        id_interes = 16,
        nombre_interes = "ejemplitoModificado"
       };
    
    ServicioInteres.EliminarInteres(16);
    



    }
}