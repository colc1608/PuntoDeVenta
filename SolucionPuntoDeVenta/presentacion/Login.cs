using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregando librerias
using servicio;
using dominio;


namespace presentacion
{
    public partial class Login : Form
    {
        //variables globales
        private UsuarioServicio servicio = new UsuarioServicio();
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show(this, "Ingrese los campos con (*) ", "VENTAS: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Usuario usuario = Usuario.getInstance();
            usuario.User = txtUser.Text;
            usuario.Clave = txtClave.Text;

            usuario = servicio.iniciarSesion(usuario);

            if(usuario.Id.Equals(0))
                MessageBox.Show(this, "Usuario y/o clave incorrecto ", "VENTAS: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                Admi_Principal frm = new Admi_Principal();
                frm.Show();  
            } 
                
        }
    }
}
