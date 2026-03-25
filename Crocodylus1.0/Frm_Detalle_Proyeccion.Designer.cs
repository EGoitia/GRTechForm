namespace GRTechnology1._0
{
    partial class Frm_Detalle_Proyeccion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.chkVendedor = new System.Windows.Forms.CheckBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.numUpDownProyectado = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownProyectado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnModif
            // 
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.numUpDownProyectado);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.chkAnulado);
            this.gbxFiltro.Controls.Add(this.cboVendedor);
            this.gbxFiltro.Controls.Add(this.chkVendedor);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.chkSucursal);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.chkFechas);
            this.gbxFiltro.Controls.Add(this.txtNombre);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNombre, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkVendedor, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboVendedor, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAnulado, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.numUpDownProyectado, 0);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // btnImpLista
            // 
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Al";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(209, 49);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 7;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(84, 49);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 8;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(22, 50);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(59, 17);
            this.chkFechas.TabIndex = 6;
            this.chkFechas.Text = "Fecha:";
            this.chkFechas.UseVisualStyleBackColor = true;
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(664, 36);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(65, 17);
            this.chkAnulado.TabIndex = 52;
            this.chkAnulado.Text = "Anulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.Enabled = false;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(412, 21);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(228, 21);
            this.cboSucursal.TabIndex = 50;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Location = new System.Drawing.Point(339, 24);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 51;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // chkVendedor
            // 
            this.chkVendedor.AutoSize = true;
            this.chkVendedor.Location = new System.Drawing.Point(339, 56);
            this.chkVendedor.Name = "chkVendedor";
            this.chkVendedor.Size = new System.Drawing.Size(75, 17);
            this.chkVendedor.TabIndex = 51;
            this.chkVendedor.Text = "Vendedor:";
            this.chkVendedor.UseVisualStyleBackColor = true;
            this.chkVendedor.CheckedChanged += new System.EventHandler(this.chkVendedor_CheckedChanged);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.Enabled = false;
            this.cboVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(412, 53);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(228, 21);
            this.cboVendedor.TabIndex = 50;
            // 
            // numUpDownProyectado
            // 
            this.numUpDownProyectado.DecimalPlaces = 2;
            this.numUpDownProyectado.Location = new System.Drawing.Point(217, 74);
            this.numUpDownProyectado.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDownProyectado.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDownProyectado.Name = "numUpDownProyectado";
            this.numUpDownProyectado.Size = new System.Drawing.Size(90, 20);
            this.numUpDownProyectado.TabIndex = 54;
            this.numUpDownProyectado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownProyectado.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Proyectado:";
            // 
            // Frm_Detalle_Proyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 402);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Proyeccion";
            this.Text = "DETALLE DE PROYECCIÓN DE VENTAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Proyeccion_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Proyeccion_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownProyectado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.CheckBox chkAnulado;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.CheckBox chkVendedor;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.NumericUpDown numUpDownProyectado;
        private System.Windows.Forms.Label label2;
    }
}
