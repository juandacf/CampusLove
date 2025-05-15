using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;
using campusLove.domain.ports;

namespace CampusLove.application.services
{
    public class UsuarioInteresService
    {
        private readonly IUsuarioInteresRepository _repo;

        public UsuarioInteresService(IUsuarioInteresRepository repo)
        {
            _repo = repo;
        }

        public void CrearUsuarioInteres(UsuarioInteres item)
        {
            _repo.Crear(item);
        }

        public void EliminarUsuarioInteres(int id)
        {
            _repo.Eliminar(id);
        }

        public void VerUsuarioInteres()
        {
            var lista = _repo.ObtenerTodos();
            foreach (var item in lista)
            {
                Console.WriteLine($"id : {item.id_usuario_interes},  id_interes {item.id_interes}  cc usuario: {item.cedula_ciudadania}");
            }
        }

        
    }
}