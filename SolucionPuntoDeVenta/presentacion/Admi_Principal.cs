using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Admi_Principal : Form
    {
        public Admi_Principal()
        {
            InitializeComponent();
        }

        private void cerrarVentana(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemArea_Click(object sender, EventArgs e)
        {
            Admi_buscarArea frm = new Admi_buscarArea();
            frm.Show();
        }

        
    }
}
