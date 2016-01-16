using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importar librerias
using servicio;
using dominio;

namespace presentacion
{
    public partial class Admi_buscarArea : Form
    {
        private AreaServicio servicio = new AreaServicio();
        private List<Area> listaDeAreas = new List<Area>();
        private Area areaSeleccionada = new Area();


        public Admi_buscarArea()
        {
            InitializeComponent();
            listarAreas();
            activaBotones(true,true,false, false);
        }

        private void activaBotones(bool a, bool b, bool c, bool d)
        {
            btnBuscar.Enabled = a;
            btnNuevo.Enabled = b;
            btnGuardar.Enabled = c;
            btnActualizar.Enabled = d;
            btnEliminar.Enabled = d;
        }


        private void listarAreas()
        {
            try
            {
                listaDeAreas = servicio.listarAreas();
                dataAreas.Rows.Clear();
                foreach (Area area in listaDeAreas)
                {
                    Object[] fila = { area.Descripcion };
                    dataAreas.Rows.Add(fila);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al Listar :( \n\n Intentelo otra vez o comuniquelo a Sistemas.", "Mensaje: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> presentacion -> Admi_buscarArea -> ListarAreas " + err);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(this, "Debe ingresar una descripcion", "Mensaje: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Area area = new Area();
            area.Descripcion = txtDescripcion.Text;

            try
            {
                if(servicio.registrarArea(area)){
                    MessageBox.Show("Registro satisfactorio", "Mensaje: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                    
                else
                    MessageBox.Show("No se pudo completar la operacion.", "Mensaje: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listarAreas();
                activaBotones(true, true, false, false);
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al registar. \n\n Intentelo otra vez o comuniquelo a Sistemas.", "Mensaje: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> presentacion -> Admi_buscarArea -> btnGuardar  " + err);
            }
        }

        private void dataAreas_MouseClick(object sender, MouseEventArgs e)
        {
            areaSeleccionada = listaDeAreas[int.Parse(dataAreas.CurrentRow.Index.ToString())];
            txtDescripcion.Text = areaSeleccionada.Descripcion;
            activaBotones(false, true, false, true);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaDeAreas = servicio.buscarArea(txtDescripcion.Text);
            dataAreas.Rows.Clear();
            foreach (Area area in listaDeAreas)
            {
                Object[] fila = { area.Descripcion };
                dataAreas.Rows.Add(fila);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                btnNuevo.Text = "Cancelar";
                activaBotones(false, true, true, false);
            }
            else
            {
                btnNuevo.Text = "Nuevo";
                activaBotones(true, true, false, false);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(this, "Debe ingresar una descripcion", "Mensaje: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            areaSeleccionada.Descripcion = txtDescripcion.Text;

            if(servicio.actualizarArea(areaSeleccionada)){
                listarAreas();
                activaBotones(true,true,false,false);
                MessageBox.Show("Actualizacion satisfactoria", "Mensaje: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            else
                MessageBox.Show(this, "Ocurrio un problema al actualizar. \n\n Intentelo otra vez o comuniquelo a Sistemas.", "Mensaje: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (servicio.eliminarArea(areaSeleccionada))
            {
                listarAreas();
                activaBotones(true, true, false, false);
                MessageBox.Show("Eliminacion satisfactoria", "Mensaje: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show(this, "Ocurrio un problema al eliminar. \n\n Intentelo otra vez o comuniquelo a Sistemas.", "Mensaje: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }














    }// no borrar estas llaves
}
