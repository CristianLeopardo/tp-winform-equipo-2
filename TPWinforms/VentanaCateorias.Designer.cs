namespace TPWinforms
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.grbSelec = new System.Windows.Forms.GroupBox();
            this.rbtEliminar = new System.Windows.Forms.RadioButton();
            this.rbtModificar = new System.Windows.Forms.RadioButton();
            this.rbtAgregar = new System.Windows.Forms.RadioButton();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.grbSelec.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar.Location = new System.Drawing.Point(17, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAceptar.Location = new System.Drawing.Point(182, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 33);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbxNombre.Location = new System.Drawing.Point(140, 132);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(160, 20);
            this.tbxNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(14, 100);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(120, 13);
            this.lblSeleccion.TabIndex = 9;
            this.lblSeleccion.Text = "Seleccione la categoría";
            this.lblSeleccion.Visible = false;
            // 
            // grbSelec
            // 
            this.grbSelec.Controls.Add(this.rbtEliminar);
            this.grbSelec.Controls.Add(this.rbtModificar);
            this.grbSelec.Controls.Add(this.rbtAgregar);
            this.grbSelec.Location = new System.Drawing.Point(17, 18);
            this.grbSelec.Name = "grbSelec";
            this.grbSelec.Size = new System.Drawing.Size(283, 68);
            this.grbSelec.TabIndex = 8;
            this.grbSelec.TabStop = false;
            this.grbSelec.Text = "Elija una opción";
            // 
            // rbtEliminar
            // 
            this.rbtEliminar.AutoSize = true;
            this.rbtEliminar.Location = new System.Drawing.Point(216, 30);
            this.rbtEliminar.Name = "rbtEliminar";
            this.rbtEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbtEliminar.TabIndex = 2;
            this.rbtEliminar.Text = "Eliminar";
            this.rbtEliminar.UseVisualStyleBackColor = true;
            this.rbtEliminar.CheckedChanged += new System.EventHandler(this.rbtEliminar_CheckedChanged);
            // 
            // rbtModificar
            // 
            this.rbtModificar.AutoSize = true;
            this.rbtModificar.Location = new System.Drawing.Point(106, 30);
            this.rbtModificar.Name = "rbtModificar";
            this.rbtModificar.Size = new System.Drawing.Size(68, 17);
            this.rbtModificar.TabIndex = 1;
            this.rbtModificar.Text = "Modificar";
            this.rbtModificar.UseVisualStyleBackColor = true;
            this.rbtModificar.CheckedChanged += new System.EventHandler(this.rbtModificar_CheckedChanged);
            // 
            // rbtAgregar
            // 
            this.rbtAgregar.AutoSize = true;
            this.rbtAgregar.Checked = true;
            this.rbtAgregar.Location = new System.Drawing.Point(6, 30);
            this.rbtAgregar.Name = "rbtAgregar";
            this.rbtAgregar.Size = new System.Drawing.Size(62, 17);
            this.rbtAgregar.TabIndex = 0;
            this.rbtAgregar.TabStop = true;
            this.rbtAgregar.Text = "Agregar";
            this.rbtAgregar.UseVisualStyleBackColor = true;
            this.rbtAgregar.CheckedChanged += new System.EventHandler(this.rbtAgregar_CheckedChanged);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Items.AddRange(new object[] {
            "Celulares",
            "Televisores",
            "Media",
            "Audio"});
            this.cmbCategorias.Location = new System.Drawing.Point(140, 97);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(160, 21);
            this.cmbCategorias.TabIndex = 7;
            this.cmbCategorias.Visible = false;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(314, 221);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.grbSelec);
            this.Controls.Add(this.cmbCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(330, 260);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.grbSelec.ResumeLayout(false);
            this.grbSelec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.GroupBox grbSelec;
        private System.Windows.Forms.RadioButton rbtEliminar;
        private System.Windows.Forms.RadioButton rbtModificar;
        private System.Windows.Forms.RadioButton rbtAgregar;
        private System.Windows.Forms.ComboBox cmbCategorias;
    }
}