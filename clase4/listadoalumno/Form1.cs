using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listadoalumno
{
    enum cursos {
        csharp = 1,
        php = 2,
        java = 3,
        python = 4,
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llenargred();
        }

        private List<Alumno> crearLista()
        {
            List<Alumno> alumnos = new List<Alumno>();
            Alumno a = new Alumno("Manuel", "Fuente", "39115380");
            Alumno b = new Alumno("daniel", "cardone", "26675380");
            Alumno c = new Alumno("gabriel", "Gimenez", "25675380");
            Alumno d = new Alumno("Nicolas", "Bottero", "29266685");

            a.idCurso = (int)cursos.csharp;
            b.idCurso = (int)cursos.java;
            c.idCurso = (int)cursos.php;
            d.idCurso = (int)cursos.python;

            a.Curso = ((cursos)1).ToString();
            b.Curso = ((cursos)2).ToString();
            c.Curso = ((cursos)3).ToString();
            d.Curso = ((cursos)4).ToString();

            alumnos.Add(a);
            alumnos.Add(b);
            alumnos.Add(c);
            alumnos.Add(d);




            return alumnos; 
        }

        private void llenargred()
        {
            //gridAlumnos.Rows.Add("Pedro", "Gonzales""39115390",3,"JAVA");
            List<Alumno> alumnos = crearLista();
            foreach (Alumno alumno in alumnos)
            {
                gridAlumnos.Rows.Add(alumno.Nombre, alumno.Apellido, alumno.Documento, alumno.idCurso, alumno.Curso);

                    }
        }
    }
}
