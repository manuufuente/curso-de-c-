using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /* entities.Persona persona = new entities.Persona();
             persona.setNombre(txtNombre.Text);
             persona.setApellido(txtApellido.Text);
             int edad = Convert.ToInt32(txtEdad.Text);

             lbl_Datos.Text = "Nombre: " + persona.getNombre() + " , Apellido: " + persona.getApellido() + "Edad" + persona.getEdad();
 */
            //------------------------------------------------------------------------------
            /*

                        entities.Alumno alumno = new entities.Alumno( Convert.ToInt32(txtEdad.Text));

                        alumno.Nombre = txtNombre.Text;
                        //alumno.Apellido = txtApellido.Text;
                        //alumno.Edad = Convert.ToInt32(txtEdad.Text);

                        lbl_Datos.Text = "Nombre: " + alumno.Nombre + " Apellido: " + alumno.Apellido + " Edad: " + alumno.Edad;
                        */
            //------------------------------------------------------------------------------------
           /* string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);

            entities.Alumno alumno = new entities.Alumno(nombre, apellido, edad);
           lbl_Datos.Text = "Nombre: " + alumno.Nombre + " Apellido: " + alumno.Apellido + " Edad: " + alumno.Edad;
           */
            //--------------------------------------------------------------------------

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string curso = txt_curso.Text;
            entities.Alumno alumno = new entities.Alumno(nombre,apellido,edad);

           alumno.setNombre(nombre);
            alumno.setApellido(apellido);
            alumno.setEdad(edad);
            alumno.curso = "C sharp";

            //ME falta poner un messajeBox
            MessageBox.Show(alumno.ToString());
            //lbl_Datos.Text = alumno;

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
