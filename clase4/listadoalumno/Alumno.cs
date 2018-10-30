using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadoalumno
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Curso { get; set; }
        public int idCurso { get; set; }

        public Alumno(string nombre,string apellido,string documento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;

        }


    }
}
