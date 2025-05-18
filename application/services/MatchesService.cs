using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using campuslove.domain.entities;
using campuslove.domain.ports;
using campusLove.domain.ports;

namespace campusLove.application.services
{
    public class MatchesService
    {
        private readonly IMatchesRepository _repo;

        public MatchesService(IMatchesRepository repo)
        {
            _repo = repo;
        }


        public void CreatMatch(Matches match)
        {
            _repo.Crear(match);
        }

        public void ElimnarMatch(int idMatch)
        {
            _repo.Eliminar(idMatch);
        }

        public void VerMatches()
        {
            var lista = _repo.ObtenerTodos();
            foreach (var item in lista)
            {

                Console.WriteLine($"ID match: {item.id_match}   cedula1: {item.cedula_ciudadania_1}   cedula2 {item.cedula_ciudadania_2}");
            }
        }

        public List<Matches> MostrarMatchesUsuario(string cedula)
        {
            var lista = _repo.ObtenerTodos();
            List<Matches> ListaFiltrada = new List<Matches>();
            foreach (var item in lista)
            {
                if (item.cedula_ciudadania_1 == cedula || item.cedula_ciudadania_2 == cedula)
                {
                    ListaFiltrada.Add(item);
                }
            }
            return ListaFiltrada;
        }

        public List<Matches> RetornarTodosMatches()
        {
            var lista = _repo.ObtenerTodos();
            return lista;
        }

    }
}