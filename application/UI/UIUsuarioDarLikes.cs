using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.application.services;
using campuslove.domain.entities;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;
using campusLove.application.services;
using campusLove.application.UI;

namespace campuslove.application.UI
{
    public class UIUsuarioDarLikes
    {
        public static void MenuUsuarioDarLikes()
        {
            IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
            var ServicioUsuario = new UsuarioService(factory.CreateUsuarioRepository());
            var ServicioLike = new LikesService(factory.CreateLikeRepository());
            string CedulaUsuarioLoggeado = UIUsuario.UsuarioLoggeado.cedula_ciudadania;
            var UsersToLike = ServicioUsuario.ObtenerUsuariosSinLike(CedulaUsuarioLoggeado);
            foreach (var item in UsersToLike)
            {
                Console.Clear();
                string GeneroPersona = "";
                if (item.genero)
                {
                    GeneroPersona = "Hombre";
                }
                else
                {
                    GeneroPersona = "Mujer";
                }
                Console.WriteLine($"nombre: {item.nombre}  apellido: {item.apellido} Genero: {GeneroPersona} ");
                Console.WriteLine("¿Desea darle like a esta persona? t/f");
                bool Like = UIUtils.VerificadorBooleano();

                if (Like)
                {
                    Console.Clear();
                    Like like = new Like
                    {
                        id_like = 0,
                        cedula_ciudadania_dador = CedulaUsuarioLoggeado,
                        cedula_ciudadania_recipiente = item.cedula_ciudadania
                    };
                    ServicioLike.CrearLike(like);
                    Console.WriteLine("El like pudo ser guardado con éxito. ¿Desea continuar dando likes? t/f.");
                    bool continar = UIUtils.VerificadorBooleano();
                    if (!continar)
                    {
                        UIUsuarioLogeado.MenuUsuarioLogeado();
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("¿Desea continuar dando likes? t/f.");
                    bool continar = UIUtils.VerificadorBooleano();
                    if (!continar)
                    {
                        UIUsuarioLogeado.MenuUsuarioLogeado();
                    }
                }

                
            }
                Console.Clear();
                Console.WriteLine("No hay más usuarios para ser likeados. Por favor, oprima enter para volver al menú ");
                Console.ReadKey(true);
                UIUsuarioLogeado.MenuUsuarioLogeado();
            ;

        }
    }
}