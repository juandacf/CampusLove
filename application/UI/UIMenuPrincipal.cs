using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.application.UI;
using campusLove.application.UI;

namespace campusLove.application.UI
{
    public class UIMenuPrincipal
    {
        public static void MenuPrincipal(){
            while (true){
            Console.Clear();
            Console.WriteLine("¡Bienvenido a CampusLove! \n1.Soy Admin \n2.Soy usuario \n0.Salir ");
            Console.WriteLine("Opción: ");
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                switch (KeyPressed.KeyChar)
                {
                    case '1':
                        UIAdmin.MenuAdmin();
                    break;
                    case '2':
                        UIUsuario.MenuUsuario();
                    break;
                    case  '0':
                    Console.Clear();
                    Console.WriteLine("¡Gracias por usar nuestro software! :)");
                    Environment.Exit(0);
                    break;
                    default:
                    Console.WriteLine("La opción ingresada no coincide con ninguna de nuestras opciones. Por favor, presione enter e inténtelo de nuevo.");
                    Console.ReadKey();
                    MenuPrincipal();
                    break;
                }
            }
        }


    }
}