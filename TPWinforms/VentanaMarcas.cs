using Dominio;
using Negocio;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinforms
{
    public partial class frmMarcas : Form
    {
        private Marca marca = null;

        public frmMarcas()
        {
            InitializeComponent();
        }
        public frmMarcas(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }


        private void rbtAgregar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Text = "Agregar";
            cmbMarcas.Visible = false;
            lblSeleccion.Visible = false;
            lblNombre.Visible = true;
            tbxNombre.Visible = true;
        }

        private void rbtModificar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Text = "Modificar";
            cmbMarcas.Visible = true;
            lblSeleccion.Visible = true;
            lblNombre.Visible = true;
            tbxNombre.Visible = true;
        }

        private void rbtEliminar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Text = "Eliminar";
            cmbMarcas.Visible = true;
            lblSeleccion.Visible = true;
            lblNombre.Visible = false;
            tbxNombre.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            try
            {
                cmbMarcas.DataSource = marca.ListarMarcas();
                cmbMarcas.ValueMember = "Id";
                cmbMarcas.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            if  (rbtAgregar.Checked == true) 
            {
                if (validar())
                    return;
                marca = new Marca();
                try
                {
                    marca.Descripcion = tbxNombre.Text;
                    negocio.AgregarMarca(marca);
                    MessageBox.Show("Marca Agregada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (rbtEliminar.Checked == true) 
            {
                MarcaNegocio marca = new MarcaNegocio();
                int seleccionado;
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (int)cmbMarcas.SelectedValue;
                    marca.EliminarMarca(seleccionado);
                    MessageBox.Show("Eliminado exitosamente...");
                }
            }
            if (rbtModificar.Checked == true) 
            {
                if (validar())
                    return;
                MarcaNegocio marca = new MarcaNegocio();
                Marca seleccionado = new Marca();
                seleccionado.Id = (int)cmbMarcas.SelectedValue;
                seleccionado.Descripcion = tbxNombre.Text;
                marca.ModificarMarca(seleccionado);
                MessageBox.Show("Modificado exitosamente...");
            }

            Close();

        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(tbxNombre.Text))
            {
                MessageBox.Show("Debes ingresar un Nombre para la marca...");
                return true;
            }
            return false;
        }
    }
}
