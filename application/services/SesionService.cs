using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;

namespace campuslove.application.services
{
    public class SesionService
    {
        private readonly ISesionRepository _repo;

        public SesionService(ISesionRepository repo){
            _repo = repo;
        }

        public void CrearSesion (Sesion sesion){
            _repo.Crear(sesion);
        }

        public void EliminarSesion(int IdSesion){
            _repo.Eliminar(IdSesion);
        }

        public void EditarSesion(Sesion sesion){
            _repo.Actualizar(sesion);
        }

        public void verSesion (){
            var lista = _repo.ObtenerTodos();
            foreach (var item in lista)
            {
                Console.WriteLine($"idSesion: {item.id_sesion}  CC: {item.cedula_ciudadania_ciudadania}  fecha ultimo like: {item.fecha_ultimo_like}  cantidad likes:  {item.cantidad_likes}  usuario habilitado: {item.usuario_habilitado}");
            }
        }
    }
}