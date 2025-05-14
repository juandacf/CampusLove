using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;

namespace campuslove.application.services
{
    public class InteresService
    {
        private readonly IInteresRepository _repo;

         public InteresService(IInteresRepository repo){
            _repo =repo;
        }

        public void CrearInteres(Interes interes){
            _repo.Crear(interes);
        }

        public void EliminarInteres(int idInteres){
            _repo.Eliminar(idInteres);
        }

        public void VerInteres (){
            var lista = _repo.ObtenerTodos();
            foreach (var a in lista) {
                Console.WriteLine($"id: {a.id_interes}    nombre: {a.nombre_interes}");
            }
        }
    }
}