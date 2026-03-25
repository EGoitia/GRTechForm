namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrlUsuFiltroVentas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cboTipVenta = new System.Windows.Forms.ComboBox();
            this.chkTipoVenta = new System.Windows.Forms.CheckBox();
            this.chkVendedor = new System.Windows.Forms.CheckBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.cboTipoRep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFFin = new System.Windows.Forms.DateTimePicker();
            this.dtFIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTotales = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.cboTipVenta);
            this.groupBox1.Controls.Add(this.chkTipoVenta);
            this.groupBox1.Controls.Add(this.chkVendedor);
            this.groupBox1.Controls.Add(this.chkSucursal);
            this.groupBox1.Controls.Add(this.cboVendedor);
            this.groupBox1.Controls.Add(this.cboSucursal);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 136);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cliente (F2):";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(97, 103);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(226, 20);
            this.txtCliente.TabIndex = 24;
            // 
            // cboTipVenta
            // 
            this.cboTipVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipVenta.Enabled = false;
            this.cboTipVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipVenta.FormattingEnabled = true;
            this.cboTipVenta.Location = new System.Drawing.Point(97, 73);
            this.cboTipVenta.Name = "cboTipVenta";
            this.cboTipVenta.Size = new System.Drawing.Size(226, 21);
            this.cboTipVenta.TabIndex = 15;
            // 
            // chkTipoVenta
            // 
            this.chkTipoVenta.AutoSize = true;
            this.chkTipoVenta.Location = new System.Drawing.Point(18, 76);
            this.chkTipoVenta.Name = "chkTipoVenta";
            this.chkTipoVenta.Size = new System.Drawing.Size(78, 17);
            this.chkTipoVenta.TabIndex = 23;
            this.chkTipoVenta.Text = "Tipo Venta";
            this.chkTipoVenta.UseVisualStyleBackColor = true;
            this.chkTipoVenta.CheckedChanged += new System.EventHandler(this.chkTipoVenta_CheckedChanged);
            // 
            // chkVendedor
            // 
            this.chkVendedor.AutoSize = true;
            this.chkVendedor.Location = new System.Drawing.Point(18, 47);
            this.chkVendedor.Name = "chkVendedor";
            this.chkVendedor.Size = new System.Drawing.Size(72, 17);
            this.chkVendedor.TabIndex = 23;
            this.chkVendedor.Text = "Vendedor";
            this.chkVendedor.UseVisualStyleBackColor = true;
            this.chkVendedor.CheckedChanged += new System.EventHandler(this.chkVendedor_CheckedChanged);
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Checked = true;
            this.chkSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSucursal.Location = new System.Drawing.Point(18, 19);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(67, 17);
            this.chkSucursal.TabIndex = 23;
            this.chkSucursal.Text = "Sucursal";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.Enabled = false;
            this.cboVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(97, 44);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(226, 21);
            this.cboVendedor.TabIndex = 15;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(97, 15);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(226, 21);
            this.cboSucursal.TabIndex = 15;
            // 
            // cboTipoRep
            // 
            this.cboTipoRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoRep.FormattingEnabled = true;
            this.cboTipoRep.Items.AddRange(new object[] {
            "Nombre",
            "Cantidad",
            "Utilidad"});
            this.cboTipoRep.Location = new System.Drawing.Point(99, 59);
            this.cboTipoRep.Name = "cboTipoRep";
            this.cboTipoRep.Size = new System.Drawing.Size(226, 21);
            this.cboTipoRep.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tipo Reporte:";
            // 
            // dtFFin
            // 
            this.dtFFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFFin.Location = new System.Drawing.Point(227, 27);
            this.dtFFin.Name = "dtFFin";
            this.dtFFin.Size = new System.Drawing.Size(98, 20);
            this.dtFFin.TabIndex = 20;
            // 
            // dtFIni
            // 
            this.dtFIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFIni.Location = new System.Drawing.Point(99, 27);
            this.dtFIni.Name = "dtFIni";
            this.dtFIni.Size = new System.Drawing.Size(98, 20);
            this.dtFIni.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fechas:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTotales);
            this.groupBox3.Controls.Add(this.dtFFin);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtFIni);
            this.groupBox3.Controls.Add(this.cboTipoRep);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(350, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 136);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // chkTotales
            // 
            this.chkTotales.AutoSize = true;
            this.chkTotales.Location = new System.Drawing.Point(19, 102);
            this.chkTotales.Name = "chkTotales";
            this.chkTotales.Size = new System.Drawing.Size(85, 17);
            this.chkTotales.TabIndex = 24;
            this.chkTotales.Text = "Solo Totales";
            this.chkTotales.UseVisualStyleBackColor = true;
            // 
            // CntrlUsuFiltroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CntrlUsuFiltroVentas";
            this.Size = new System.Drawing.Size(699, 147);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.CheckBox chkVendedor;
        private System.Windows.Forms.ComboBox cboVendedor;
        public System.Windows.Forms.ComboBox cboTipoRep;
        public System.Windows.Forms.DateTimePicker dtFFin;
        public System.Windows.Forms.DateTimePicker dtFIni;
        private System.Windows.Forms.ComboBox cboTipVenta;
        private System.Windows.Forms.CheckBox chkTipoVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkTotales;
    }
}
