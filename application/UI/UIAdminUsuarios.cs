using System.Reflection;
using campuslove.application.services;
using campuslove.application.UI;
using campuslove.domain.entities;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;
using campusLove.application.UI;
namespace CampusLove.application.UI
{
    public class UIAdminUsuarios
    {
        public static void MenuAdminUsuarios()
        {
            IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
            var ServicioCarrera = new CarreraService(factory.CreateCarreraRepository());
            var ServicioUsuario = new UsuarioService(factory.CreateUsuarioRepository());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Este es el menú de usuarios para administrador. Por favor, escoja una de las siguientes opciones: \n1.Agregar Usuario   \n2.Ver Usuarios \n3.Editar Usuario   \n4. Eliminar Usuario  \n0. Volver al menú de admin");
                Console.WriteLine("Opción: ");
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                switch (KeyPressed.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Por favor, ingrese la cédula de ciudadanía del usuario.");
                        string CedulaCiudadania = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese el nombre del usuario:");
                        string NombreUsuario = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese el apellido del usuario: ");
                        string ApellidoUsuario = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese la contraseña del usuario: ");
                        string ContraseñaUsuario = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese el género del usuario h/m");
                        Console.Clear();
                        ServicioCarrera.VerCarrera();
                        Console.WriteLine("Por favor, ingrese el id de la carrera del usuario: ");
                        int IdCarreraUsuario = int.Parse(Console.ReadLine());
                        bool GeneroUsuario = UIUtils.VerificadorGenero();
                        Usuario usuario = new Usuario
                        {
                            cedula_ciudadania = CedulaCiudadania,
                            nombre = NombreUsuario,
                            apellido = ApellidoUsuario,
                            contraseña = ContraseñaUsuario,
                            genero = GeneroUsuario,
                            id_carrera = IdCarreraUsuario

                        };
                        ServicioUsuario.CrearUsuario(usuario);
                        Console.WriteLine("El usuario ha sido creado con éxito. Presione enter para volver al menú:");
                        Console.ReadKey(true);
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Por favor, ingrese la cédula de ciudadanía del usuario a editar.");
                        string CedulaCiudadaniaE = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese el nuevo nombre del usuario:");
                        string NombreUsuarioE = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese el nuevo apellido del usuario: ");
                        string ApellidoUsuarioE = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese la nueva contraseña del usuario: ");
                        string ContraseñaUsuarioE = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese el nuevo género del usuario h/m");
                        Console.Clear();
                        ServicioCarrera.VerCarrera();
                        Console.WriteLine("Por favor, ingrese el id de la nueva carrera del usuario: ");
                        int IdCarreraUsuarioE = int.Parse(Console.ReadLine());
                        bool GeneroUsuarioE = UIUtils.VerificadorGenero();
                        Usuario usuarioE = new Usuario
                        {
                            cedula_ciudadania = CedulaCiudadaniaE,
                            nombre = NombreUsuarioE,
                            apellido = ApellidoUsuarioE,
                            contraseña = ContraseñaUsuarioE,
                            genero = GeneroUsuarioE,
                            id_carrera = IdCarreraUsuarioE

                        };
                        ServicioUsuario.EditarUsuario(usuarioE);
                        Console.WriteLine("El usuario ha sido creado con éxito. Presione enter para volver al menú:");
                        Console.ReadKey(true);
                        break;
                    case '3':
                        Console.Clear();
                        ServicioUsuario.VerUsuarios();
                        Console.WriteLine("Por favor, presione enter para volver al menú:");
                        Console.ReadKey(true);
                        break;
                    case '4':
                        Console.Clear();
                        ServicioUsuario.VerUsuarios();
                        Console.WriteLine("Por favor, digite la cédula del usuario a eliminar ");
                        string CedulaUsuarioEliminar = Console.ReadLine();
                        ServicioUsuario.EliminarUsuario(CedulaUsuarioEliminar);
                        Console.WriteLine("¡El usuario ha sido eliminado con éxito! Por favor, presione enter para volver al menú.");
                        Console.ReadKey(true);
                        break;
                    case '0':
                        UIAdmin.MenuAdmin();
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