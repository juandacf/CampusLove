using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.application.services;
using campuslove.application.UI;
using campuslove.domain.entities;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;
using campusLove.application.UI;


namespace campuslove.application.UI
{
    public class UIAdminSesion
    {


        public static void MenuAdminSesion()
        {
            
            IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
            var ServicioSesion = new SesionService(factory.CreateSesionRepository());
            var ServicioUsuario = new UsuarioService(factory.CreateUsuarioRepository());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Este es el menú de administrador para gestionar sesiones. Por favor, escoja una de las siguientes opciones: \n1.Agregar sesión   \n2.Ver sesiones \n3.Editar sesiones   \n4. Eliminar sesión  \n0. Volver al menú de admin  ");
                Console.WriteLine("Opción: ");
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                switch (KeyPressed.KeyChar)
                {
                    case '0':
                        UIAdmin.MenuAdmin();
                        break;
                    case '1':
                        Console.Clear();
                        ServicioUsuario.VerUsuarios();
                        Console.WriteLine("Por favor, ingrese la cédula del usuario al que quiere agregarle una sesión: ");
                        string CedulaCiudadania = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese la cantidad de likes asignada para el usuario: ");
                        int CantidadLike = int.Parse(Console.ReadLine());
                        Sesion sesion = new Sesion
                        {
                            cedula_ciudadania_ciudadania = CedulaCiudadania,
                            cantidad_likes = CantidadLike    
                        };

                        ServicioSesion.CrearSesion(sesion);
                        Console.WriteLine("La sesión ha sido agregada con éxito. Por favor, presione enter para volver al men+u de sesiones.");
                        Console.ReadKey(true);
                        break;
                    case '2':
                        Console.Clear();
                        ServicioSesion.verSesion();
                        Console.WriteLine("Por favor, presione enter para continuar");
                        Console.ReadKey(true);
                        break;
                    case '3':
                        Console.Clear();
                        ServicioUsuario.VerUsuarios();
                        Console.WriteLine("Por favor, ingrese el número de cédula del usuario cuya sesión desea modificar: ");
                        string CedulaUsuarioE = Console.ReadLine();
                        Console.WriteLine("por favor, ingrese el el permiso para agregar likes habilitado (t)/ deshabilitado (f)");
                        bool EstadoUsuario = UIUtils.VerificadorBooleano();
                        Console.WriteLine("Por favor, ingrese el nuevo número de likes del usuario: ");
                        int CantidadLikesE = int.Parse(Console.ReadLine());
                        Sesion sesionE = new Sesion
                        {
                            cedula_ciudadania_ciudadania = CedulaUsuarioE,
                            usuario_habilitado = EstadoUsuario,
                            cantidad_likes = CantidadLikesE
                        };
                        ServicioSesion.EditarSesion(sesionE);
                        Console.WriteLine("La sesión fue editada con éxito. Por favor, presione enter para continuar.");
                        Console.ReadKey(true);
                        break;
                    case '4':
                        Console.Clear();
                        ServicioSesion.verSesion();
                        Console.WriteLine("Por favor, ingrese el id de la sesión que desea eliminar: ");
                        int IDsesion = int.Parse(Console.ReadLine());
                        ServicioSesion.EliminarSesion(IDsesion);
                        Console.WriteLine("La sesión pudo ser eliminada. Por favor, presione enter para continuar.");
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