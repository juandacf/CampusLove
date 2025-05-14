using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.ports;

namespace campuslove.domain.factory
{
    public interface IDbFactory
    {
        IInteresRepository CreateInteresRepository();

        ICarreraRepository CreateCarreraRepository();

        IUsuarioRepository CreateUsuarioRepository();
    }
}