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
    public class UIUsuario
    {
        public static Usuario UsuarioLoggeado;
        public static void MenuUsuario()
        {
            while (true)
            {
                IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
                var ServicioCarrera = new CarreraService(factory.CreateCarreraRepository());
                var ServicioUsuario = new UsuarioService(factory.CreateUsuarioRepository());
                Console.Clear();
                Console.WriteLine("Bienvenido a CampusLove, usuario. Por favor, escoja alguna de las siguientes opciones:\n1.Crear Usuario   \n2.Ingresar  \n0.Volver al menú anterior ");
                Console.WriteLine("Opción: ");
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                switch (KeyPressed.KeyChar)
                {
                    case '0':
                        Console.Clear();
                        UIMenuPrincipal.MenuPrincipal();
                        break;
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Por favor, ingrese su cédula de ciudadanía.");
                        string CedulaCiudadania = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese su nombre:");
                        string NombreUsuario = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese su apellido:");
                        string ApellidoUsuario = Console.ReadLine();
                        Console.WriteLine("Por favor, ingrese su contraseña:");
                        string ContraseñaUsuario = Console.ReadLine();

                        ServicioCarrera.VerCarrera();
                        Console.WriteLine("Por favor, ingrese el id de su carrera: ");
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
                        Console.WriteLine("Por favor, ingresa tu cédula de ciudadanía");
                        string CedulaLogin = Console.ReadLine();
                        Console.WriteLine("Por favor, ingresa tu contraaseña");
                        string ContraseñaLogin = Console.ReadLine();                        
                        UsuarioLoggeado = ServicioUsuario.LoginUsuario(CedulaLogin, ContraseñaLogin);
                        Console.WriteLine(UsuarioLoggeado.nombre);
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