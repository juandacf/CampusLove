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
    public class UIAdminInteres
    {
        public static void MenuAdminInteres()
        {
            IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
            var ServicioInteres = new InteresService(factory.CreateInteresRepository());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Este es el menú de intereses para administrador.Por favor, escoja una de las siguientes opciones: \n1.Agregar interés   \n2.Ver intereses \n3.Editar intereses   \n4. Eliminar intereses  \n0. Volver al menú de admin");
                Console.WriteLine("Opción: ");
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                switch (KeyPressed.KeyChar)
                {
                    case '0':
                    UIAdmin.MenuAdmin();
                        break;                
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Por favor, ingrese el nombre del nuevo interés:");
                        string NombreInteres = Console.ReadLine();

                        Interes miInteresMio = new Interes
                        {
                            id_interes = 000,
                            nombre_interes = NombreInteres
                        };
                        ServicioInteres.CrearInteres(miInteresMio);
                        Console.WriteLine("El interés ha sido creado con éxito. Por favor, presione enter para volver al menú de Intereses: ");
                        Console.ReadKey(true);
                        break;
                    case '2':
                        Console.Clear();
                        ServicioInteres.VerInteres();
                        Console.WriteLine("Por favor, presione enter para volver al menú de intereses: ");
                        Console.ReadKey(true);                        
                        break;
                    case '3':
                        Console.Clear();
                        ServicioInteres.VerInteres();
                        Console.WriteLine("Por favor, ingrese el ID del interés que quiere modificar: ");
                        int IdAModificar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Por favor, ingrese el nuevo nombre del interés: ");
                        string NombreNuevoInteres = Console.ReadLine();
                        Interes interesEditado = new Interes
                        {
                            id_interes = IdAModificar,
                            nombre_interes = NombreNuevoInteres
                        };
                        ServicioInteres.EditarInteres(interesEditado);
                        Console.WriteLine("El interés ha sido modificado con éxito. Por favor, presione enter para continuar:");
                        Console.ReadKey(true);                        
                        break;
                    case '4':
                        Console.Clear();
                        ServicioInteres.VerInteres();
                        Console.WriteLine("Por favor, ingrese el id del interés a eliminar: ");
                        int IDAEliminar = int.Parse(Console.ReadLine());
                        ServicioInteres.EliminarInteres(IDAEliminar);
                        Console.WriteLine("El interés ha sido borrado con éxito. Por favor, presione enter para volver al menú de intereses.");
                        Console.ReadKey(true);
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