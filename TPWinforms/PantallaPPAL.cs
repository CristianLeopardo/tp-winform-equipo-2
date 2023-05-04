using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using static System.Net.Mime.MediaTypeNames;

namespace TPWinforms
{
    public partial class frmInicio : Form
    {
        
        public frmInicio()
        {
            InitializeComponent();
        }

        private List<Articulos> ListaArticulos;

        public List<Imagen> ListaImagenes { get; set; }

        public List<Imagen> ImagenFiltrada;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           frmArticulos iniciar = new frmArticulos();
            iniciar.Texto = "";
            iniciar.ShowDialog();
            cargarInfo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                frmArticulos modificar = new frmArticulos(Seleccionado);
                modificar.ShowDialog();
                cargarInfo();
            }
            
            
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas iniciar = new frmMarcas();
            iniciar.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            cargarInfo();
            cmbFiltrar.Items.Add("Nombre");
            cmbFiltrar.Items.Add("Marca");
            cmbFiltrar.Items.Add("Categoria");
        }

        private void cargarInfo()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.Listar();
            dgvArticulos.DataSource = ListaArticulos;
            ocultarColumnas();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias iniciar = new frmCategorias();
            iniciar.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(Seleccionado.id);
            }
            
        }
        private void cargarImagen(int imagen)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            ListaImagenes = imagenNegocio.listarimagenes();

            System.Collections.IList list = ListaImagenes;
            for (int i1 = 0; i1 < list.Count; i1++)
            {
                if (ListaImagenes[i1].Id == imagen)
                {
                    try
                    {
                        ptbArticulos.Load(ListaImagenes[i1].URLImagen);
                    }
                    catch
                    {
                        ptbArticulos.Load("https://librerialadorita.com/uploads/product_default.jpg");
                    }
                }
            }
        }




        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Imagen2"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["idImagen"].Visible = false;
        }

        private bool validarSeleccion()
        {
            if(cmbFiltrar.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un tipo de filtro.");
                return true;
            }
            return false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artneg = new ArticuloNegocio();
            try
            {
                string seleccion = cmbFiltrar.SelectedItem.ToString();
                string filtro = tbxBuscar.Text;
                dgvArticulos.DataSource = artneg.filtrado(seleccion, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> filtrolista;
            string filtro = txbBusqueda.Text;

            if (filtro.Length > 1)
            {
                filtrolista = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().Contains(filtro.ToUpper()) || x.categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                filtrolista = ListaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = filtrolista;
            ocultarColumnas();
        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            frmImagenes frmImagenes = new frmImagenes();
            frmImagenes.ShowDialog();
            cargarInfo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            Articulos seleccionado;
            DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                articulo.Eliminar(seleccionado.id);
                MessageBox.Show("Eliminado exitosamente...");
            }
            cargarInfo();
        }
    }
}
