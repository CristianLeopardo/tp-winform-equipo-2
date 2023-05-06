using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinforms
{
    public partial class frmImagenes : Form
    {
        private Imagen img = null;
        public List<Imagen> ListaImagenes;
        private OpenFileDialog archivo = null;
        public List <Imagen> ImagenSeleccionada;

        public frmImagenes()
        {
            InitializeComponent();
        }

        private void frmImagenes_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                cmbArticulos.DataSource = articuloNegocio.ListarRes();
                cmbArticulos.ValueMember = "ID";
                cmbArticulos.DisplayMember = "Codigo";
                cmbArticulos.SelectedText = "Nombre";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cargarInfo();
        }



        private void cargarInfo()
        {
            ImagenNegocio img = new ImagenNegocio();
            ListaImagenes = img.listarimagenes((int)cmbArticulos.SelectedValue);
            dgvImagenes.DataSource = ListaImagenes;
            ocultarcolumnas();
        }

        private void ocultarcolumnas()
        {
            dgvImagenes.Columns["Id"].Visible = false;
            dgvImagenes.Columns["Idarticulo"].Visible = false;
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagen = new ImagenNegocio();
            Imagen seleccionado;
            try
            {
                if (rbtAgregar.Checked)
                {
                    if(tbxUrl.Text != "")
                    {
                        img = new Imagen();
                        img.Id = (int)cmbArticulos.SelectedValue;
                        if (archivo != null)
                        {
                            if (archivo != null && !(tbxUrl.Text.ToUpper().Contains("HTTP")))
                                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes"] + archivo.SafeFileName);
                            img.URLImagen = ConfigurationManager.AppSettings["Imagenes"] + archivo.SafeFileName;

                        }
                        else
                        {
                            img.URLImagen = tbxUrl.Text;
                        }
                        imagen.Agregar(img);
                        MessageBox.Show("Agregado exitosamente...");
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un archivo o una URL");
                        return;
                    }
                    

                }
                if (rbtEliminar.Checked)
                {
                    DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                        imagen.Eliminar(seleccionado.Id);
                        MessageBox.Show("Eliminado exitosamente...");
                    }
                }
                if(rbtModificar.Checked)
                {
                    if(tbxUrl.Text != "")
                    {
                        img = new Imagen();
                        seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                        if (archivo != null)
                        {
                            if (archivo != null && !(tbxUrl.Text.ToUpper().Contains("HTTP")))
                                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes"] + archivo.SafeFileName);
                                seleccionado.URLImagen = ConfigurationManager.AppSettings["Imagenes"] + archivo.SafeFileName;

                        }
                        else
                        {
                            seleccionado.URLImagen = tbxUrl.Text;
                        }
                        
                        imagen.Modificar(seleccionado);
                        MessageBox.Show("Modificado exitosamente...");
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un archivo o una URL");
                        return;
                    }

                }
                

                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rbtAgregar_CheckedChanged_1(object sender, EventArgs e)
        {
            btnAceptar.Text = "Agregar";
            tbxUrl.Visible = true;
            lblUrl.Visible = true;
            dgvImagenes.Visible = false;
        }

        private void rbtModificar_CheckedChanged_1(object sender, EventArgs e)
        {
            btnAceptar.Text = "Modificar";
            tbxUrl.Visible = true;
            lblUrl.Visible = true;
            dgvImagenes.Visible = true;
        }

        private void rbtEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            btnAceptar.Text = "Eliminar";
            tbxUrl.Visible = false;
            lblUrl.Visible = false;
            dgvImagenes.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbArticulos_SelectionChangeCommitted(object sender, EventArgs e)
        {
              cargarInfo();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbxUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
                
            }
        }

        private void cargarImagen(string filename)
        {
            try
            {
                ptbImagen.Load(filename);
            }
            catch (Exception)
            {
                ptbImagen.Load("https://librerialadorita.com/uploads/product_default.jpg");
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if  (dgvImagenes.CurrentRow != null) 
            {
                Imagen ImagenSeleccionada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                cargarImagen(ImagenSeleccionada.URLImagen);

            }
            
        }

        private void tbxUrl_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(tbxUrl.Text.ToString());
        }
    }
}
