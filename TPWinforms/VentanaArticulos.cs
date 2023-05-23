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
using static System.Net.Mime.MediaTypeNames;

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
            ArticuloNegocio articuloNeg = new ArticuloNegocio();
            try
            {
                if (validar())
                    return;
                if (articulo == null)
                    articulo = new Articulos();


                articulo.Codigo = txbCodigo.Text;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDesc.Text;
                articulo.marca = (Marca)cmbMarca.SelectedItem;
                articulo.categoria = (Categoria)cmbCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.id != 0)
                {
                    articuloNeg.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente...");
                }
                else
                {
                    bool valCod = ValidarCodigo();
                    if (valCod == false)
                    {
                        articuloNeg.Agregar(articulo);
                        MessageBox.Show("Agregado exitosamente...");
                    }
                    else
                    {
                        MessageBox.Show("El codigo ya existe en el sistema...");
                        return;
                    }
                    
                }
                DialogResult respuesta = MessageBox.Show("¿Quieres agregar o editar imagenes para este artículo?", "Imagenes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    frmImagenes nuevo = new frmImagenes();
                    nuevo.ShowDialog();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txbCodigo.Text))
            {
                MessageBox.Show("Debes ingresar un código de artículo..");
                return true;
            }
            if (string.IsNullOrEmpty(txbNombre.Text))
            {
                MessageBox.Show("Debes ingresar un nombre de artículo..");
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debes ingresar un precio de artículo..");
                return true;
            }
            if (!(soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Ingrese solo numeros para el campo Precio");
                return true;
            }
            if (string.IsNullOrEmpty(txbDesc.Text))
            {
                DialogResult respuesta = MessageBox.Show("Estas ingresando un artículo sin descripción,¿De verdad querés ingresarlo?", "Descripcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    MessageBox.Show("Ingresado exitosamente...");
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            int coma = 0;
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    if (!(caracter == ',' && coma == 0))
                    {
                        coma++;
                        return false;
                    }
                }
            }
            return true;
        }

        private void lblMDFArt_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCodigo()
        {
            ArticuloNegocio validarArt = new ArticuloNegocio();
            int artValidado = validarArt.Validacion(txbCodigo.Text);
            if(artValidado == 1)
            {
                return true;
            }
            return false;

        }
    }

}
