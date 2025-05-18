using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;
using campuslove.application.services;
using campuslove.domain.factory;
using campuslove.infrastructure.PostgreSQL;
using campusLove.application.services;

namespace campuslove.application.services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repo;

        public UsuarioService(IUsuarioRepository repo)
        {
            _repo = repo;
        }

        public void CrearUsuario(Usuario usuario)
        {
            _repo.Crear(usuario);
        }

        public void EliminarUsuario(string IdUsuario)
        {
            _repo.Eliminar(IdUsuario);
        }

        public void VerUsuarios()
        {
            var lista = _repo.ObtenerTodos();
            foreach (var a in lista)
            {
                string Generousuario;
                if (a.genero == true)
                {
                    Generousuario = "Masculino";
                }
                else
                {
                    Generousuario = "Femenino";
                }

                Console.WriteLine($"C.C.: {a.cedula_ciudadania}    nombre: {a.nombre}  apellido: {a.apellido} genero: {Generousuario} ");
            }
        }

        public void EditarUsuario(Usuario usuario)
        {
            _repo.Actualizar(usuario);
        }

        public Usuario LoginUsuario(string cedula, string contraseña)
        {
            var lista = _repo.ObtenerTodos();

            Usuario UsuarioElegido = null;

            foreach (var a in lista)
            {
                if (a.cedula_ciudadania == cedula && a.contraseña == contraseña)
                {
                    UsuarioElegido = a;
                    Console.WriteLine("El usuario se pudo encontrar");
                }
            }

            return UsuarioElegido;
        }

        public List<Usuario> ObtenerUsuariosSinLike(string cedula)
        {
            IDbFactory factory = new PostgresDbFactory(DbParameters.Parameters);
            var ServicioLike = new LikesService(factory.CreateLikeRepository());

            var ListaLikes = ServicioLike.RetornarLikes();
            var listaInicialUsuarios = _repo.ObtenerTodos();
            List<Usuario> listaFinalUsuarios = new List<Usuario>();

            var ListaLikesFiltrada = from likes in ListaLikes
                                     where likes.cedula_ciudadania_dador == cedula
                                     select likes;

            foreach (var item in listaInicialUsuarios)
            {
                bool usuarioTieneLike = false;
                foreach (var element in ListaLikesFiltrada)
                {
                    if (item.cedula_ciudadania == element.cedula_ciudadania_recipiente)
                    {
                        usuarioTieneLike = true;
                    }
                }
                if (!usuarioTieneLike){
                    listaFinalUsuarios.Add(item);
                }
            }           
            return listaFinalUsuarios;
        }


    }
}