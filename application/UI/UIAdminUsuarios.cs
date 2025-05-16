using campuslove.domain.entities;
using campusLove.application.UI;
namespace CampusLove.application.UI
{
    public class UIAdminUsuarios
    {
        public static void MenuAdminUsuarios()
        {
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
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                         string teclaComoString = keyInfo.KeyChar.ToString();
                        if (teclaComoString == 'h')
                        {

                        }

                        
                        Usuario usuario = new Usuario
                        { 
                            
                        };

                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
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