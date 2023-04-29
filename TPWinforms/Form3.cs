using System;
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
        public frmMarcas()
        {
            InitializeComponent();
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
    }
}
