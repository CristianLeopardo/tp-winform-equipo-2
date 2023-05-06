using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private bool press = false;
        int posicion = 0;

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
            cmbFiltrar.Items.Add("Codigo");
            cmbFiltrar.Items.Add("Nombre");
            cmbFiltrar.Items.Add("Descripcion");
            cmbFiltrar.Items.Add("Marca");
            cmbFiltrar.Items.Add("Categoria");
            cmbFiltrar.Items.Add("Precio");
            cmbPrecio.Items.Add("Igual a");
            cmbPrecio.Items.Add("Mayor a");
            cmbPrecio.Items.Add("Menor a");
            
        }

        private void cargarInfo()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.Listar();
            dgvArticulos.DataSource = ListaArticulos;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            if  (press == false)
            {
                ocultarColumnas();
            }
            else
            {
                ocultarColumnasdetalle();
            }
            
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
                posicion = 0;
                cargarImagen(Seleccionado.id);
            }
            
        }
        private void cargarImagen(int imagen)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            ListaImagenes = imagenNegocio.listarimagenes(imagen);
                    try
                    {
                        ptbArticulos.Load(ListaImagenes[posicion].URLImagen);
                    }
                    catch
                    {
                        ptbArticulos.Load("https://librerialadorita.com/uploads/product_default.jpg");
                    }
           if (ListaImagenes.Count -1 == posicion)
            {
                btnSiguiente.Enabled = false;
            }
           else
            {
                btnSiguiente.Enabled = true;
            }
            
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            if (dgvArticulos.CurrentRow != null)
            {
                posicion++;
                Articulos Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(Seleccionado.id);
                btnAnterior.Enabled = true;
                
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            
            if (dgvArticulos.CurrentRow != null)
            {
                posicion--;
                Articulos Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(Seleccionado.id);
                if (posicion <= 0)
                {
                    btnAnterior.Enabled = false;
                }
                else
                {
                    btnAnterior.Enabled = true;
                }
            }
            
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Imagen2"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["descripcion"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["categoria"].Visible = false;
            dgvArticulos.Columns["idImagen"].Visible = false;
        }


        private void ocultarColumnasdetalle()
        {
            dgvArticulos.Columns["Imagen2"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["idImagen"].Visible = false;
            dgvArticulos.Columns["descripcion"].Visible = true;
            dgvArticulos.Columns["Marca"].Visible = true;
            dgvArticulos.Columns["categoria"].Visible = true;

        }

        private bool validarSeleccion()
        {
            if(cmbFiltrar.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un tipo de filtro.");
                return true;
            }
            if (cmbFiltrar.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(tbxBuscar.Text))
                {
                    MessageBox.Show("Debes ingresar un precio...");
                    return true;
                }
                if (!(soloNumeros(tbxBuscar.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }

            }


            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artneg = new ArticuloNegocio();
            string criterio = "";
            try
            {
                if (validarSeleccion())
                    return;
                string seleccion = cmbFiltrar.SelectedItem.ToString();
                string filtro = tbxBuscar.Text;
                if (cmbFiltrar.SelectedItem.ToString() == "Precio")
                {
                    criterio = cmbPrecio.SelectedItem.ToString();
                }
                
                dgvArticulos.DataSource = artneg.filtrado(seleccion, filtro, criterio);
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

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (cmbFiltrar.SelectedItem.ToString() == "Precio")
            {
                cmbPrecio.Visible = true;
                lblNum.Visible = true;
            }
            else
            {
                cmbPrecio.Visible = false;
                lblNum.Visible = false;
            }
            press = true;
            btnDetalle.Text = "Ocultar detalle";
            ocultarColumnasdetalle();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if  (press==false) 
            {
                btnDetalle.Text = "Ocultar detalle";
                press = true;
                cargarInfo();
            }
            else
            {
                btnDetalle.Text = "Mostrar detalle";
                press = false;
                cargarInfo();
            }
        }

        
    }
}
