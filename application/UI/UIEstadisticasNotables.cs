using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.application.services;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;

namespace campuslove.application.UI
{
    public class UIEstadisticasNotables
    {
        public static  void MenuEstadisticasNotables()
        {
            IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
            var ServicioUsuario = new UsuarioService(factory.CreateUsuarioRepository());
            Console.Clear();
                        ServicioUsuario.RetornarCantidadGeneros();
                        ServicioUsuario.RetornarCarreraMasCursada();
                        ServicioUsuario.MayorCantidadMatches();
                        Console.WriteLine("\nPor favor, presione enter para continuar");
                        Console.ReadKey(true);
        }
    }
}