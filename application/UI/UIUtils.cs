using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace campuslove.application.UI
{
    public class UIUtils
    {
        public static bool VerificadorGenero()
        {
            Console.Clear();
            Console.WriteLine("Por favor, ingrese el género del usuario h/m");
            char keyInfo = Console.ReadKey(true).KeyChar;

            switch (keyInfo)
            {
                case 'h':
                    return true;
                case 'm':
                    return false;
                default:
                    Console.WriteLine("La opción ingresada no corresponde con ninguna de nuestras opciones de género. Presione enter, y vuelva a empezar.");
                    Console.ReadKey();
                    VerificadorGenero();
                    return false;
            }
        }
    }
}