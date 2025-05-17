using campuslove.application.UI;
using campusLove.application.UI;

namespace campusLove.application.UI
{
    public class UIAdmin
    {
        public static void MenuAdmin()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Por favor, escoja alguna de las siguientes opciones de adminsitrador: \n1.Gestionar usuarios  \n2.Gestionar Intereses \n3. Gestionar sesiones \n4.Gestionar Carreras \n0.Volver al menú principal ");
                Console.WriteLine("Opción: ");
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                switch (KeyPressed.KeyChar)
                {
                    case '1':
                        UIAdminUsuarios.MenuAdminUsuarios();
                        break;
                    case '2':
                        UIAdminInteres.MenuAdminInteres();
                        break;
                    case '3':
                        UIAdminSesion.MenuAdminSesion();
                        break;
                    case '4':
                        UIAdminCarrera.MenuAdminCarrera();
                        break;
                    case '0':
                        Console.Clear();
                        UIMenuPrincipal.MenuPrincipal();
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