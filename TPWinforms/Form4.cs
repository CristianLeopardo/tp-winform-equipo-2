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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            if (rbtAgregar.Checked == true)
            {
                categoria = new Categoria();
                try
                {
                    categoria.Descripcion = tbxNombre.Text;
                    negocio.AgregarCategoria(categoria);
                    MessageBox.Show("Categoria Agregada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            Close();

        }
    }
}
