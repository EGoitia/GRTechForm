namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrlUsuFiltroPagosProveedor
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
            this.cboTipoProv = new System.Windows.Forms.ComboBox();
            this.chkTipoProv = new System.Windows.Forms.CheckBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.dtFechaFin);
            this.gbxFiltros.Controls.Add(this.dtFechaIni);
            this.gbxFiltros.Controls.Add(this.label4);
            this.gbxFiltros.Controls.Add(this.label2);
            this.gbxFiltros.Controls.Add(this.cboSucursal);
            this.gbxFiltros.Controls.Add(this.chkSucursal);
            this.gbxFiltros.Controls.Add(this.cboTipoProv);
            this.gbxFiltros.Controls.Add(this.chkTipoProv);
            this.gbxFiltros.Controls.Add(this.txtProveedor);
            this.gbxFiltros.Controls.Add(this.label1);
            this.gbxFiltros.Location = new System.Drawing.Point(3, 3);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(621, 80);
            this.gbxFiltros.TabIndex = 0;
            this.gbxFiltros.TabStop = false;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(507, 44);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(102, 20);
            this.dtFechaFin.TabIndex = 13;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(366, 44);
            this.dtFechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(102, 20);
            this.dtFechaIni.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Al:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 48);
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
            this.cboSucursal.Location = new System.Drawing.Point(414, 13);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(195, 21);
            this.cboSucursal.TabIndex = 5;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Location = new System.Drawing.Point(338, 16);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 4;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // cboTipoProv
            // 
            this.cboTipoProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProv.Enabled = false;
            this.cboTipoProv.FormattingEnabled = true;
            this.cboTipoProv.Location = new System.Drawing.Point(123, 16);
            this.cboTipoProv.Name = "cboTipoProv";
            this.cboTipoProv.Size = new System.Drawing.Size(192, 21);
            this.cboTipoProv.TabIndex = 3;
            // 
            // chkTipoProv
            // 
            this.chkTipoProv.AutoSize = true;
            this.chkTipoProv.Location = new System.Drawing.Point(23, 18);
            this.chkTipoProv.Name = "chkTipoProv";
            this.chkTipoProv.Size = new System.Drawing.Size(102, 17);
            this.chkTipoProv.TabIndex = 2;
            this.chkTipoProv.Text = "Tipo Proveedor:";
            this.chkTipoProv.UseVisualStyleBackColor = true;
            this.chkTipoProv.CheckedChanged += new System.EventHandler(this.chkTipoClien_CheckedChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProveedor.Location = new System.Drawing.Point(85, 44);
            this.txtProveedor.MaxLength = 20;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(230, 20);
            this.txtProveedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor:";
            // 
            // CntrlUsuFiltroPagosProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxFiltros);
            this.Name = "CntrlUsuFiltroPagosProveedor";
            this.Size = new System.Drawing.Size(637, 86);
            this.Load += new System.EventHandler(this.CntrlUsuFiltroCuentasXCobrar_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTipoProv;
        private System.Windows.Forms.ComboBox cboTipoProv;
        private System.Windows.Forms.ComboBox cboSucursal;
        public System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtFechaFin;
        public System.Windows.Forms.DateTimePicker dtFechaIni;
        public System.Windows.Forms.CheckBox chkSucursal;
    }
}
