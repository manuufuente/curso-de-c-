using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_2.entities
{
    class Alumno:Persona
    {/*
        public string Nombre { get; set; } 
        public string Apellido { get; set; } //= "Rodriguez";
        public int Edad { get; }//= 20;
        

        public Alumno(int parametroEdad)
        {
            Nombre = "Jose";
            Apellido = "Fuente";
            Edad = parametroEdad;
        }

        public Alumno(string parametroNombre,string paramApellido, int paramEdad)
        {
            Nombre = parametroNombre;
            Apellido = paramApellido;
            Edad = paramEdad;
        }

        */
        public string curso { get; set; }


        public Alumno(string nombre,string apellido,int edad):base(nombre,apellido,edad) { }

        public override string ToString()
        {
            return "Datos del alumno: " + this.nombre + " " + this.apellido + " " + this.edad + " " + this.curso;
        }
    }
}
