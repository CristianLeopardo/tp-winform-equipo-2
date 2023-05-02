namespace TPWinforms
{
    partial class frmArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.lblUno = new System.Windows.Forms.Label();
            this.lblMDFArt = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.txbImagen = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Location = new System.Drawing.Point(132, 45);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(34, 17);
            this.lblUno.TabIndex = 0;
            this.lblUno.Text = "--------";
            this.lblUno.UseCompatibleTextRendering = true;
            // 
            // lblMDFArt
            // 
            this.lblMDFArt.AutoSize = true;
            this.lblMDFArt.Location = new System.Drawing.Point(29, 45);
            this.lblMDFArt.Name = "lblMDFArt";
            this.lblMDFArt.Size = new System.Drawing.Size(97, 13);
            this.lblMDFArt.TabIndex = 1;
            this.lblMDFArt.Text = "Articulo a Modificar";
            this.lblMDFArt.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(29, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo Artículo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(29, 122);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Descripción";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(29, 148);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(29, 177);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(54, 13);
            this.lblCat.TabIndex = 6;
            this.lblCat.Text = "Categoría";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(29, 208);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(67, 13);
            this.lblImagen.TabIndex = 7;
            this.lblImagen.Text = "URL Imagen";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(29, 238);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCodigo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbCodigo.Location = new System.Drawing.Point(132, 67);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(233, 20);
            this.txbCodigo.TabIndex = 9;
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbNombre.Location = new System.Drawing.Point(132, 93);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(233, 20);
            this.txbNombre.TabIndex = 10;
            // 
            // txbDesc
            // 
            this.txbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDesc.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbDesc.Location = new System.Drawing.Point(132, 119);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(233, 20);
            this.txbDesc.TabIndex = 11;
            // 
            // txbImagen
            // 
            this.txbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbImagen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txbImagen.Location = new System.Drawing.Point(132, 205);
            this.txbImagen.Name = "txbImagen";
            this.txbImagen.Size = new System.Drawing.Size(233, 20);
            this.txbImagen.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPrecio.Location = new System.Drawing.Point(132, 235);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(233, 20);
            this.txtPrecio.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAceptar.Location = new System.Drawing.Point(256, 299);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 24);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar.Location = new System.Drawing.Point(32, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 24);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(132, 147);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(233, 21);
            this.cmbMarca.TabIndex = 18;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(132, 178);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(233, 21);
            this.cmbCategoria.TabIndex = 19;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txbImagen);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblMDFArt);
            this.Controls.Add(this.lblUno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(420, 400);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Label lblMDFArt;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.TextBox txbImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}