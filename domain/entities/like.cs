using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace campuslove.domain.entities
{
    public class like
    {
        public int id_like {get;set;}

        public string cedula_ciudadania_dador {get;set;}

        public string cedula_ciudadania_recipiente {get;set;}
    }
}