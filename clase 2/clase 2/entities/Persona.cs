using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2.entities
{
    class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        public Persona(string nombre,string apellido, int edad)
        { this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
