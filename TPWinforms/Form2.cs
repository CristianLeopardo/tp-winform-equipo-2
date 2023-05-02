using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinforms
{
    public partial class frmArticulos : Form
    {
        private Articulos articulo = null;
        public string Texto { get; set; }


        public frmArticulos()
        {

            InitializeComponent();
           
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            if (Texto == "") 
            { 
                lblUno.Visible = false;
                lblMDFArt.Visible = false;
            }
            else 
            { 
                lblUno.Visible = true;
                lblMDFArt.Visible = true;
                lblUno.Text = Texto;
            }
            MarcaNegocio marca = new MarcaNegocio();
            try
            {
                cmbMarca.DataSource = marca.ListarMarcas();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cmbCategoria.DataSource = categoria.ListarMarcas();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           ArticuloNegocio articuloNeg =  new ArticuloNegocio();
           try
           {
               if (articulo == null)
                   articulo = new Articulos();

               articulo.Codigo = txbCodigo.Text;
               articulo.Nombre = txbNombre.Text;
               articulo.Descripcion = txbDesc.Text;
               articulo.marca = (Marca)cmbMarca.SelectedItem;
               articulo.categoria = (Categoria)cmbCategoria.SelectedItem;
               //articulo.imagen = (Imagen)txbImagen.Text;
               articulo.Precio = decimal.Parse(txtPrecio.Text);

               if(articulo.id != 0)
               {
                   //articuloNeg.modificado(articulo);
                   MessageBox.Show("Modifiado exitosamente...");
               }
               else
               {
                   articuloNeg.Agregar(articulo);
                   MessageBox.Show("Agregado exitosamente...");
               }

               Close();


           }
           catch (Exception ex)
           {

               MessageBox.Show(ex.ToString());
           }

        }

    }

}
