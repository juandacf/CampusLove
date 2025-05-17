using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;

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
            var UsuarioElegido = (from usuario in lista
                                  where usuario.cedula_ciudadania == cedula
                                  where usuario.cedula_ciudadania == contraseña
                                  select usuario).FirstOrDefault();

            return UsuarioElegido;
        }


    }
}