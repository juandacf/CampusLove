using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using campuslove.application.services;
using campuslove.domain.entities;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;
using campusLove.application.services;
using campusLove.application.UI;

namespace campuslove.application.UI
{
    public class UIUsuarioLogeado
    {
        public static void MenuUsuarioLogeado()
        {
            while (true)
            {
                IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
                var ServicioCarrera = new CarreraService(factory.CreateCarreraRepository());
                var ServicioUsuario = new UsuarioService(factory.CreateUsuarioRepository());
                var ServicioMatch = new MatchesService(factory.CreateMatchesRepository());
                Console.Clear();
                Console.WriteLine($"Bienvenido,{UIUsuario.UsuarioLoggeado.nombre}");
                Console.WriteLine($"Por favor, escoja una de las siguientes opciones: \n1.Editar mis datos  \n2.Dar Likes  \n3.Ver Matches \n 4.Ver estadísticas notables de usuarios  \n5.Eliminar mi cuenta   \n 0.Cerrar sesión");
                Console.WriteLine("Opción: ");
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                switch (KeyPressed.KeyChar)
                {
                    case '0':
                        Console.Clear();
                        UI.UIUsuario.UsuarioLoggeado = null;
                        UIMenuPrincipal.MenuPrincipal();
                        break;
                    case '1':
                    Console.Clear();
                    string CedulaCiudadania = UI.UIUsuario.UsuarioLoggeado.cedula_ciudadania;
                    Console.WriteLine("Por favor, ingrese el nuevo nombre:");
                    string NuevoNombre = Console.ReadLine();
                    Console.WriteLine("Por favor, ingrese el nuevo apellido");
                    string NuevoApellido = Console.ReadLine();
                    Console.WriteLine("Por favor, ingrese su nueva contraseña");
                    string NuevaContraseña = Console.ReadLine();
                    bool NuevoGenero = UIUtils.VerificadorGenero();
                    ServicioCarrera.VerCarrera();
                    Console.WriteLine("Por favor escoja el id de la nueva carrera");
                    int NuevoId = int.Parse(Console.ReadLine());
                        Usuario usuario = new Usuario
                        {
                            cedula_ciudadania = CedulaCiudadania,
                            nombre = NuevoNombre,
                            apellido = NuevoApellido,
                            contraseña = NuevaContraseña,
                            genero = NuevoGenero,
                            id_carrera = NuevoId
                        };
                        ServicioUsuario.EditarUsuario(usuario);
                        Console.WriteLine("El usuario fue actualizado con éxito. Por favor, presinoe enter para continuar ");
                        Console.ReadKey(true);
                        break;
                    case '2':
                        Console.Clear();
                        if (UIUsuario.SesionLoggeada.usuario_habilitado)
                        {
                            UI.UIUsuarioDarLikes.MenuUsuarioDarLikes();
                        }
                        Console.WriteLine("El usuario no tiene likes. presione enter para volver al menú ");
                        Console.ReadKey(true);

                        break;
                    case '3':
                        Console.Clear();
                        var MatchesUsuario = ServicioMatch.MostrarMatchesUsuario(UI.UIUsuario.UsuarioLoggeado.cedula_ciudadania);
                        var Usuarios = ServicioUsuario.RetornarTodosUsuarios();

                        foreach (var user in Usuarios)
                        {
                            foreach (var item in MatchesUsuario)
                            {
                                if (user.cedula_ciudadania !=UI.UIUsuario.UsuarioLoggeado.cedula_ciudadania) {
                                    if (user.cedula_ciudadania == item.cedula_ciudadania_1 || user.cedula_ciudadania == item.cedula_ciudadania_2)
                                {
                                        Console.WriteLine($"Match|| Nombre: {user.nombre} Apellid0: {user.apellido}");
                                } 
                                }
                                
                            }
                        }

                        Console.WriteLine("Por favor, presione enter para continuar");
                        Console.ReadKey(true);
                        break;
                    case '4':
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("Está seguro de que desea borrar su cuenta? t/f");
                        bool DeseaBorrar = UIUtils.VerificadorBooleano();
                        if (DeseaBorrar)
                        {
                            ServicioUsuario.EliminarUsuario(UI.UIUsuario.UsuarioLoggeado.cedula_ciudadania);
                            UI.UIUsuario.UsuarioLoggeado = null;
                            UI.UIUsuario.SesionLoggeada = null;
                            Console.WriteLine("El usuario se ha borrado con éxito. Por favor, presione enter para volver al menú principal.");
                            Console.ReadKey(true);
                            UIMenuPrincipal.MenuPrincipal();
                        } Console.WriteLine("Por favor, presione enter para volver al menú de usuario");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}