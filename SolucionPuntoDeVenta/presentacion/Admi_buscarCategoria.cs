using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importar
using servicio;
using dominio;

namespace presentacion
{
    public partial class Admi_buscarCategoria : Form
    {
        private CategoriaServicio servicio = new CategoriaServicio();
        private List<Categoria> listaDeCategorias;
        private Categoria categoriaSeleccionada = new Categoria();

        public Admi_buscarCategoria()
        {
            InitializeComponent();
            listarCategorias();
            activaBotones(true, true, false, false);
        }
        private void activaBotones(bool a, bool b, bool c, bool d)
        {
            btnBuscar.Enabled = a;
            btnNuevo.Enabled = b;
            btnGuardar.Enabled = c;
            btnActualizar.Enabled = d;
            btnEliminar.Enabled = d;
        }


        private void listarCategorias()
        {
            try
            {
                listaDeCategorias = servicio.listarTodo();
                dataAreas.Rows.Clear();
                foreach (Categoria categoria in listaDeCategorias)
                {
                    Object[] fila = { categoria.Descripcion };
                    dataAreas.Rows.Add(fila);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al Listar :( \n\n Intentelo otra vez o comuniquelo a Sistemas.", "Mensaje: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> presentacion -> Admi_buscarCategoria -> listaCategorias " + err);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(this, "Debe ingresar una descripcion", "Mensaje: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Categoria categoria = new Categoria();
            categoria.Descripcion = txtDescripcion.Text;

            try
            {
                if (servicio.registrarCategoria(categoria))
                {
                    MessageBox.Show("Registro satisfactorio", "Mensaje: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarCategorias();
                    btnNuevo.Text = "Nuevo";
                }

                else
                    MessageBox.Show("No se pudo completar la operacion.", "Mensaje: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                activaBotones(true, true, false, false);
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al registar. \n\n Intentelo otra vez o comuniquelo a Sistemas.", "Mensaje: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("ERROR -> presentacion -> Admi_buscarCategoria -> btnGuardar  " + err);
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

        private void dataAreas_MouseClick(object sender, MouseEventArgs e)
        {
            categoriaSeleccionada = listaDeCategorias[int.Parse(dataAreas.CurrentRow.Index.ToString())];
            txtDescripcion.Text = categoriaSeleccionada.Descripcion;
            activaBotones(false, true, false, true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaDeCategorias = servicio.buscarCategoria(txtDescripcion.Text);
            dataAreas.Rows.Clear();
            foreach (Categoria categoria in listaDeCategorias)
            {
                Object[] fila = { categoria.Descripcion };
                dataAreas.Rows.Add(fila);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(this, "Debe ingresar una descripcion", "Mensaje: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            categoriaSeleccionada.Descripcion = txtDescripcion.Text;

            if (servicio.actualizarCategoria(categoriaSeleccionada))
            {
                listarCategorias();
                activaBotones(true, true, false, false);
                MessageBox.Show("Actualizacion satisfactoria", "Mensaje: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show(this, "Ocurrio un problema al actualizar. \n\n Intentelo otra vez o comuniquelo a Sistemas.", "Mensaje: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (servicio.eliminarCategoria(categoriaSeleccionada))
            {
                listarCategorias();
                MessageBox.Show("Eliminacion satisfactoria", "Mensaje: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(this, "Ocurrio un problema al eliminar. \n\n Intentelo otra vez o comuniquelo a Sistemas.", "Mensaje: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            activaBotones(true, true, false, false);
        }


















    }
}
