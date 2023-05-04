﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    img = new Imagen();
                    img.Id = (int)cmbArticulos.SelectedValue;
                    img.URLImagen = tbxUrl.Text;
                    imagen.Agregar(img);
                    MessageBox.Show("Agregado exitosamente...");
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
                    img = new Imagen();
                    seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                    seleccionado.URLImagen = tbxUrl.Text;
                    imagen.Modificar(seleccionado);
                    MessageBox.Show("Modificado exitosamente...");
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
    }
}