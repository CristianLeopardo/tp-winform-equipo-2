using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TPWinforms
{
    public partial class frmCategorias : Form
    {
        private Categoria categoria = null;
        public frmCategorias()
        {
            InitializeComponent();
        }
        public frmCategorias(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void rbtAgregar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Text = "Agregar";
            cmbCategorias.Visible = false;
            lblSeleccion.Visible = false;
            lblNombre.Visible = true;
            tbxNombre.Visible = true;
        }

        private void rbtModificar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Text = "Modificar";
            cmbCategorias.Visible = true;
            lblSeleccion.Visible = true;
            lblNombre.Visible = true;
            tbxNombre.Visible = true;
        }

        private void rbtEliminar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Text = "Eliminar";
            cmbCategorias.Visible = true;
            lblSeleccion.Visible = true;
            lblNombre.Visible = false;
            tbxNombre.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cmbCategorias.DataSource = categoria.ListarMarcas();
                cmbCategorias.ValueMember = "Id";
                cmbCategorias.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validar()
        {
            if  (string.IsNullOrEmpty(tbxNombre.Text))
            {
                MessageBox.Show("Debes ingresar un Nombre para la categoría...");
                return true;
            }
            return false;
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            if (rbtAgregar.Checked == true)
            {
                categoria = new Categoria();
                try
                {
                    if (validar())
                        return;
                    categoria.Descripcion = tbxNombre.Text;
                    negocio.AgregarCategoria(categoria);
                    MessageBox.Show("Categoria Agregada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (rbtEliminar.Checked == true) 
            {
                CategoriaNegocio cate = new CategoriaNegocio();
                int seleccionado;
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (int)cmbCategorias.SelectedValue;
                    cate.EliminarCat(seleccionado);
                    MessageBox.Show("Eliminado exitosamente...");
                }
            }
            if (rbtModificar.Checked  == true)
            {
                if (validar())
                    return;
                CategoriaNegocio cate = new CategoriaNegocio();
                Categoria seleccionado = new Categoria();
                seleccionado.Id = (int)cmbCategorias.SelectedValue;
                seleccionado.Descripcion = tbxNombre.Text;
                cate.ModificarCat(seleccionado);
                MessageBox.Show("Modificado exitosamente...");
            }
            Close();

        }
    }
}
