using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace campuslove.domain.entities
{
    public class Usuario
    {
        public string cedula_ciudadania {get;set;} 
        public string nombre {get;set;}
        public string apellido {get;set;}
        public bool genero {get;set;}  //true: masculino   false: femenino
        public int id_carrera {get;set;}
    }
}