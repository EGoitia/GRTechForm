namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrlUsuFiltroCuentasXCobrar
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
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.chkVendedor = new System.Windows.Forms.CheckBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.cboTipoClien = new System.Windows.Forms.ComboBox();
            this.chkTipoClien = new System.Windows.Forms.CheckBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.cboVendedor);
            this.gbxFiltros.Controls.Add(this.chkVendedor);
            this.gbxFiltros.Controls.Add(this.cboSucursal);
            this.gbxFiltros.Controls.Add(this.chkSucursal);
            this.gbxFiltros.Controls.Add(this.cboTipoClien);
            this.gbxFiltros.Controls.Add(this.chkTipoClien);
            this.gbxFiltros.Controls.Add(this.txtCliente);
            this.gbxFiltros.Controls.Add(this.label1);
            this.gbxFiltros.Location = new System.Drawing.Point(3, 3);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(584, 80);
            this.gbxFiltros.TabIndex = 0;
            this.gbxFiltros.TabStop = false;
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.Enabled = false;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(384, 43);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(182, 21);
            this.cboVendedor.TabIndex = 5;
            // 
            // chkVendedor
            // 
            this.chkVendedor.AutoSize = true;
            this.chkVendedor.Location = new System.Drawing.Point(308, 46);
            this.chkVendedor.Name = "chkVendedor";
            this.chkVendedor.Size = new System.Drawing.Size(75, 17);
            this.chkVendedor.TabIndex = 4;
            this.chkVendedor.Text = "Vendedor:";
            this.chkVendedor.UseVisualStyleBackColor = true;
            this.chkVendedor.CheckedChanged += new System.EventHandler(this.chkVendedor_CheckedChanged);
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.Enabled = false;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(384, 13);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(182, 21);
            this.cboSucursal.TabIndex = 5;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Location = new System.Drawing.Point(308, 16);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 4;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // cboTipoClien
            // 
            this.cboTipoClien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoClien.Enabled = false;
            this.cboTipoClien.FormattingEnabled = true;
            this.cboTipoClien.Location = new System.Drawing.Point(114, 16);
            this.cboTipoClien.Name = "cboTipoClien";
            this.cboTipoClien.Size = new System.Drawing.Size(166, 21);
            this.cboTipoClien.TabIndex = 3;
            // 
            // chkTipoClien
            // 
            this.chkTipoClien.AutoSize = true;
            this.chkTipoClien.Location = new System.Drawing.Point(23, 18);
            this.chkTipoClien.Name = "chkTipoClien";
            this.chkTipoClien.Size = new System.Drawing.Size(85, 17);
            this.chkTipoClien.TabIndex = 2;
            this.chkTipoClien.Text = "Tipo Cliente:";
            this.chkTipoClien.UseVisualStyleBackColor = true;
            this.chkTipoClien.CheckedChanged += new System.EventHandler(this.chkTipoClien_CheckedChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(68, 44);
            this.txtCliente.MaxLength = 20;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(212, 20);
            this.txtCliente.TabIndex = 1;
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
            // CntrlUsuFiltroCuentasXCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxFiltros);
            this.Name = "CntrlUsuFiltroCuentasXCobrar";
            this.Size = new System.Drawing.Size(596, 86);
            this.Load += new System.EventHandler(this.CntrlUsuFiltroCuentasXCobrar_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTipoClien;
        private System.Windows.Forms.ComboBox cboTipoClien;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.CheckBox chkVendedor;
        public System.Windows.Forms.TextBox txtCliente;
    }
}
