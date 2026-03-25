namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrlUsuFiltroTipoPagoVentas
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
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.chkTipoPago = new System.Windows.Forms.CheckBox();
            this.txtCliProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCaja = new System.Windows.Forms.CheckBox();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.dtFechaFin);
            this.gbxFiltros.Controls.Add(this.dtFechaIni);
            this.gbxFiltros.Controls.Add(this.label4);
            this.gbxFiltros.Controls.Add(this.label2);
            this.gbxFiltros.Controls.Add(this.cmbUsuario);
            this.gbxFiltros.Controls.Add(this.checkBox1);
            this.gbxFiltros.Controls.Add(this.cmbCaja);
            this.gbxFiltros.Controls.Add(this.chkCaja);
            this.gbxFiltros.Controls.Add(this.cboSucursal);
            this.gbxFiltros.Controls.Add(this.chkSucursal);
            this.gbxFiltros.Controls.Add(this.cboTipoPago);
            this.gbxFiltros.Controls.Add(this.chkTipoPago);
            this.gbxFiltros.Controls.Add(this.txtCliProv);
            this.gbxFiltros.Controls.Add(this.label1);
            this.gbxFiltros.Location = new System.Drawing.Point(7, 6);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(681, 111);
            this.gbxFiltros.TabIndex = 1;
            this.gbxFiltros.TabStop = false;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(226, 73);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(102, 20);
            this.dtFechaFin.TabIndex = 13;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(85, 73);
            this.dtFechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(102, 20);
            this.dtFechaIni.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Al:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Del:";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.Enabled = false;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(437, 14);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(224, 21);
            this.cboSucursal.TabIndex = 5;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Location = new System.Drawing.Point(361, 17);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 4;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Enabled = false;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(107, 16);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(221, 21);
            this.cboTipoPago.TabIndex = 3;
            // 
            // chkTipoPago
            // 
            this.chkTipoPago.AutoSize = true;
            this.chkTipoPago.Location = new System.Drawing.Point(23, 18);
            this.chkTipoPago.Name = "chkTipoPago";
            this.chkTipoPago.Size = new System.Drawing.Size(78, 17);
            this.chkTipoPago.TabIndex = 2;
            this.chkTipoPago.Text = "Tipo Pago:";
            this.chkTipoPago.UseVisualStyleBackColor = true;
            this.chkTipoPago.CheckedChanged += new System.EventHandler(this.chkTipoPago_CheckedChanged);
            // 
            // txtCliProv
            // 
            this.txtCliProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliProv.Location = new System.Drawing.Point(85, 44);
            this.txtCliProv.MaxLength = 20;
            this.txtCliProv.Name = "txtCliProv";
            this.txtCliProv.Size = new System.Drawing.Size(243, 20);
            this.txtCliProv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // chkCaja
            // 
            this.chkCaja.AutoSize = true;
            this.chkCaja.Location = new System.Drawing.Point(361, 48);
            this.chkCaja.Name = "chkCaja";
            this.chkCaja.Size = new System.Drawing.Size(50, 17);
            this.chkCaja.TabIndex = 4;
            this.chkCaja.Text = "Caja:";
            this.chkCaja.UseVisualStyleBackColor = true;
            // 
            // cmbCaja
            // 
            this.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaja.Enabled = false;
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(437, 45);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(224, 21);
            this.cmbCaja.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(361, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Usuario:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Enabled = false;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(437, 76);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(224, 21);
            this.cmbUsuario.TabIndex = 5;
            // 
            // CntrlUsuFiltroTipoPagoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxFiltros);
            this.Name = "CntrlUsuFiltroTipoPagoVentas";
            this.Size = new System.Drawing.Size(700, 125);
            this.Load += new System.EventHandler(this.CntrlUsuFiltroCuentasXCobrar_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        public System.Windows.Forms.DateTimePicker dtFechaFin;
        public System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSucursal;
        public System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.CheckBox chkTipoPago;
        public System.Windows.Forms.TextBox txtCliProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCaja;
        public System.Windows.Forms.CheckBox chkCaja;
        private System.Windows.Forms.ComboBox cmbUsuario;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}
