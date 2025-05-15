using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campusLove.domain.ports;

namespace campusLove.application.services
{
    public class LikesService
    {
        private readonly ILikeRepository _repo;

        public LikesService(ILikeRepository repo)
        {
            _repo = repo;
        }
        public void CrearLike(Like like)
        {
            _repo.Crear(like);
        }

        public void EliminarLike(int idLike)
        {
            _repo.Eliminar(idLike);
        }

        public void VerLikes()
        {
            var Lista = _repo.ObtenerTodos();
            foreach (var item in Lista)
            {
                Console.WriteLine($"id: {item.id_like}  C.C. dador {item.cedula_ciudadania_dador}  C.C. recipiente {item.cedula_ciudadania_recipiente}");
            }
        }

    }
}