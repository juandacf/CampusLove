using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.application.services;
using campuslove.domain.entities;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;
using campusLove.application.UI;

namespace campuslove.application.UI
{
    public class UIAdminCarrera
    {

        public static void MenuAdminCarrera()
        {
            IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
            var ServicioCarrera = new CarreraService(factory.CreateCarreraRepository());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Este es el menú de administrador para gestionar las carreras. Por favor, escoja una de las siguientes opciones: \n1.Agregar Carrera  \n2.Ver Carreras  \n3. Editar carrera   \n4.eliminar Carrera  \n 0. Volver al menú de admin");
                Console.WriteLine("Opción: ");
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                switch (KeyPressed.KeyChar)
                {
                    case '0':
                        UIAdmin.MenuAdmin();
                        break;
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Por favor, ingrese el nombre de la nueva carrera:");
                        string NuevaCarrera = Console.ReadLine();
                        Carrera carrera = new Carrera
                        {
                            id_carrera = 0,
                            nombre_carrera = NuevaCarrera
                        };
                        ServicioCarrera.CrearCarrera(carrera);
                        Console.WriteLine("La carrera ha sido agregada con éxito. Por favor, presione enter para continuar.");
                        Console.ReadKey(true);
                        break;
                    case '2':
                        Console.Clear();
                        ServicioCarrera.VerCarrera();
                        Console.WriteLine("Por favor, presione enter para continuar.");
                        Console.ReadKey(true);
                        break;
                    case '3':
                        Console.Clear();
                        ServicioCarrera.VerCarrera();
                        Console.WriteLine("Por favor, ingrese el id de la carrera que desea modificar: ");
                        int IdCarreraModificar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Por favor, ingrese el nuevo nombre de la carrera");
                        string NuevoNombre = Console.ReadLine();
                        Carrera carreraNueva = new Carrera
                        {
                            id_carrera = IdCarreraModificar,
                            nombre_carrera = NuevoNombre
                        };
                        ServicioCarrera.EditarCarrera(carreraNueva);
                        Console.WriteLine("La carrera pudo ser modificada. Por favor, presione enter apara continuar.");
                        Console.ReadKey();
                        break;
                    case '4':
                        Console.Clear();
                        ServicioCarrera.VerCarrera();
                        Console.WriteLine("Por favor, ingrese el id de la carrera que desea eliminar: ");
                        int IdCarreraEliminar = int.Parse(Console.ReadLine());
                        ServicioCarrera.EliminarCarrera(IdCarreraEliminar);
                        Console.WriteLine("La carrera pudo ser eliminada con éxito. Por favor, presione enter para continuar");
                        Console.ReadKey();
                        break;
                    default:
                     Console.WriteLine("La opción ingresada no coincide con ninguna de nuestras opciones. Por favor, presione enter e inténtelo de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}