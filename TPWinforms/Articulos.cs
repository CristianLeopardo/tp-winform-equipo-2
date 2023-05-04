using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
            Text = "Articulo Nuevo";
           
        }

        public frmArticulos(Articulos Articulo)
        {
            InitializeComponent();
            this.articulo = Articulo;
            Text = "Modificar Articulo";

        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            Imagen imagen = new Imagen();
            try
            {
                cmbMarca.DataSource = marca.ListarMarcas();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";

                cmbCategoria.DataSource = categoria.ListarMarcas();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txbCodigo.Text = articulo.Codigo;
                    txbNombre.Text = articulo.Nombre;
                    txbDesc.Text = articulo.Descripcion;
                    cmbMarca.SelectedValue = articulo.marca.Id;
                    cmbCategoria.SelectedValue = articulo.categoria.Id;
                    txbImagen.Text = articulo.Imagen2;
                    txtPrecio.Text = articulo.Precio.ToString();
                    

            }
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
               //articulo.imagen.URLImagen = txbImagen.Text;
               articulo.Precio = decimal.Parse(txtPrecio.Text);

               if(articulo.id != 0)
               {
                   articuloNeg.modificar(articulo);
                   MessageBox.Show("Modificado exitosamente...");
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
