using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.entities;

namespace campuslove.domain.ports
{
    public interface IUsuarioRepository:IGenericRepository<Usuario>
    {
        void Eliminar (string var);
    }
}