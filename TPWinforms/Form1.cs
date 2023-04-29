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
            Articulos Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            if  (Seleccionado.Nombre == "")
            {
                MessageBox.Show("Seleccione un articulo");
            }
            else
            {
                iniciar.Texto = Seleccionado.Nombre;
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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias iniciar = new frmCategorias();
            iniciar.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulos Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(Seleccionado.imagen.URLImagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                ptbArticulos.Load(imagen);
            }
            catch
            {
                ptbArticulos.Load("https://librerialadorita.com/uploads/product_default.jpg");
            }
        }
    }
}
