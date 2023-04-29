using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinforms
{
    public partial class frmInicio : Form
    {
        
        public frmInicio()
        {
            InitializeComponent();
        }

        private List<Articulos> ListaArticulos;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           frmArticulos iniciar = new frmArticulos();
            iniciar.Texto = "";
            iniciar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmArticulos iniciar = new frmArticulos();
            if  (tbxBuscar.Text =="")
            {
                MessageBox.Show("Seleccione un articulo");
            }
            else
            {
                iniciar.Texto = tbxBuscar.Text;
                iniciar.ShowDialog();
            }
            
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas iniciar = new frmMarcas();
            iniciar.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.Listar();
            dgvArticulos.DataSource = ListaArticulos;
        }
    }
}
