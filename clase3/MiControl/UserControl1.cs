using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiControl
{
    public partial class UserControl1: UserControl
    {
        public EventHandler cambiocomboselect;
        public UserControl1()
        {
            InitializeComponent();
            this.Load += new EventHandler(inicontrol);
        }

        private void inicontrol(object sender, EventArgs e)
        {
            this.bindearcolumnas();
            cmb_lenguajes.SelectedIndexChanged += new EventHandler(cmbcambio);
        }

        private void cmbcambio(object sender, EventArgs e)
        {
            cambiocomboselect(sender, e); 
        }

        private void bindearcolumnas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("textPart");
            dt.Columns.Add("valuePart");

            dt.Rows.Add("c#", "2");
            dt.Rows.Add("PHP", "1");
            dt.Rows.Add("java", "3");
            dt.Rows.Add("python", "4");

            cmb_lenguajes.DataSource = dt;
            cmb_lenguajes.DisplayMember = "textPart";
            cmb_lenguajes.ValueMember = "valuePart";
        }


        public string selectedText { get { return cmb_lenguajes.Text; } }
        public string selectedvalue { get { return cmb_lenguajes.SelectedValue.ToString(); } }
    }
}

   


