using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            micontrol.cambiocomboselect += new EventHandler(mostrartext);
            micontrol.cambiocomboselect += new EventHandler(mostrarvalor);
        }

        public void mostrartext(object sender , EventArgs e)
        {
            MessageBox.Show(micontrol.selectedText); 
        }

        public void mostrarvalor(object sender, EventArgs e)
        {
            MessageBox.Show(micontrol.selectedvalue);
        }
    }
}
