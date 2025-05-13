using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace campuslove.domain.entities
{
    public class Sesion
    {
       public int id_sesion {get;set;}
       public string cedula_ciudadania_ciudadania {get;set;}

       public DateTime fecha_ultimo_like {get;set;}
       public int cantidad_likes {get;set;}

       public bool usuario_habilitado {get;set;}
    }
}