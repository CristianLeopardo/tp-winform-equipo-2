﻿namespace TPWinforms
{
    partial class frmImagenes
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
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtAgregar = new System.Windows.Forms.RadioButton();
            this.rbtModificar = new System.Windows.Forms.RadioButton();
            this.rbtEliminar = new System.Windows.Forms.RadioButton();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(12, 20);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(162, 13);
            this.lblArticulo.TabIndex = 1;
            this.lblArticulo.Text = "Seleccione el Codigo del Articulo";
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(180, 17);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(212, 21);
            this.cmbArticulos.TabIndex = 19;
            this.cmbArticulos.SelectedIndexChanged += new System.EventHandler(this.cmbArticulos_SelectedIndexChanged);
            this.cmbArticulos.SelectionChangeCommitted += new System.EventHandler(this.cmbArticulos_SelectionChangeCommitted);
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(79, 47);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(95, 13);
            this.lblAccion.TabIndex = 20;
            this.lblAccion.Text = "Usted seleccionó: ";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(180, 47);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(0, 13);
            this.lblSeleccion.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtEliminar);
            this.groupBox1.Controls.Add(this.rbtModificar);
            this.groupBox1.Controls.Add(this.rbtAgregar);
            this.groupBox1.Location = new System.Drawing.Point(34, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 37);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // rbtAgregar
            // 
            this.rbtAgregar.AutoSize = true;
            this.rbtAgregar.Checked = true;
            this.rbtAgregar.Location = new System.Drawing.Point(6, 14);
            this.rbtAgregar.Name = "rbtAgregar";
            this.rbtAgregar.Size = new System.Drawing.Size(62, 17);
            this.rbtAgregar.TabIndex = 0;
            this.rbtAgregar.TabStop = true;
            this.rbtAgregar.Text = "Agregar";
            this.rbtAgregar.UseVisualStyleBackColor = true;
            this.rbtAgregar.CheckedChanged += new System.EventHandler(this.rbtAgregar_CheckedChanged_1);
            // 
            // rbtModificar
            // 
            this.rbtModificar.AutoSize = true;
            this.rbtModificar.Location = new System.Drawing.Point(116, 14);
            this.rbtModificar.Name = "rbtModificar";
            this.rbtModificar.Size = new System.Drawing.Size(68, 17);
            this.rbtModificar.TabIndex = 1;
            this.rbtModificar.Text = "Modificar";
            this.rbtModificar.UseVisualStyleBackColor = true;
            this.rbtModificar.CheckedChanged += new System.EventHandler(this.rbtModificar_CheckedChanged_1);
            // 
            // rbtEliminar
            // 
            this.rbtEliminar.AutoSize = true;
            this.rbtEliminar.Location = new System.Drawing.Point(222, 14);
            this.rbtEliminar.Name = "rbtEliminar";
            this.rbtEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbtEliminar.TabIndex = 2;
            this.rbtEliminar.Text = "Eliminar";
            this.rbtEliminar.UseVisualStyleBackColor = true;
            this.rbtEliminar.CheckedChanged += new System.EventHandler(this.rbtEliminar_CheckedChanged_1);
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(150, 128);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(251, 20);
            this.tbxUrl.TabIndex = 23;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(37, 131);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(78, 13);
            this.lblUrl.TabIndex = 24;
            this.lblUrl.Text = "Ingrese la URL";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(299, 326);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvImagenes.Location = new System.Drawing.Point(35, 167);
            this.dgvImagenes.MultiSelect = false;
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImagenes.Size = new System.Drawing.Size(339, 127);
            this.dgvImagenes.TabIndex = 26;
            this.dgvImagenes.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(38, 325);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(63, 23);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvImagenes);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.cmbArticulos);
            this.Controls.Add(this.lblArticulo);
            this.MinimumSize = new System.Drawing.Size(420, 400);
            this.Name = "frmImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaImagenes";
            this.Load += new System.EventHandler(this.frmImagenes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtEliminar;
        private System.Windows.Forms.RadioButton rbtModificar;
        private System.Windows.Forms.RadioButton rbtAgregar;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.Button btnCerrar;
    }
}