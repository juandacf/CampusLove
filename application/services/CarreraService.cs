using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;

namespace campuslove.application.services
{
    public class CarreraService
    {
        private readonly ICarreraRepository _repo;

        public CarreraService(ICarreraRepository repo)
        {
            _repo = repo;
        }

        public void CrearCarrera(Carrera carrera)
        {
            _repo.Crear(carrera);
        }

        public void EliminarCarrera(int idCarrera)
        {
            _repo.Eliminar(idCarrera);
        }

        public void VerCarrera()
        {
            var lista = _repo.ObtenerTodos();
            foreach (var a in lista)
            {
                Console.WriteLine($"id: {a.id_carrera}    nombre: {a.nombre_carrera}");
            }
        }

        public void EditarCarrera(Carrera carrera)
        {
            _repo.Actualizar(carrera);
        }

        public List<Carrera> RetornarCarreras()
        {
            var lista = _repo.ObtenerTodos();
            return lista;
        }
    }
}