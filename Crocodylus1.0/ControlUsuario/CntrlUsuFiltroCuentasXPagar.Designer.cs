namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrlUsuFiltroCuentasXPagar
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
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.cboTipoProv = new System.Windows.Forms.ComboBox();
            this.chkTipoProv = new System.Windows.Forms.CheckBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.chkSucursal);
            this.gbxFiltro.Controls.Add(this.cboTipoProv);
            this.gbxFiltro.Controls.Add(this.chkTipoProv);
            this.gbxFiltro.Controls.Add(this.txtProv);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Location = new System.Drawing.Point(3, 3);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(645, 79);
            this.gbxFiltro.TabIndex = 0;
            this.gbxFiltro.TabStop = false;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.Enabled = false;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(436, 19);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(182, 21);
            this.cboSucursal.TabIndex = 11;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Location = new System.Drawing.Point(360, 21);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 10;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // cboTipoProv
            // 
            this.cboTipoProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProv.Enabled = false;
            this.cboTipoProv.FormattingEnabled = true;
            this.cboTipoProv.Location = new System.Drawing.Point(117, 19);
            this.cboTipoProv.Name = "cboTipoProv";
            this.cboTipoProv.Size = new System.Drawing.Size(212, 21);
            this.cboTipoProv.TabIndex = 9;
            // 
            // chkTipoProv
            // 
            this.chkTipoProv.AutoSize = true;
            this.chkTipoProv.Location = new System.Drawing.Point(12, 21);
            this.chkTipoProv.Name = "chkTipoProv";
            this.chkTipoProv.Size = new System.Drawing.Size(102, 17);
            this.chkTipoProv.TabIndex = 8;
            this.chkTipoProv.Text = "Tipo Proveedor:";
            this.chkTipoProv.UseVisualStyleBackColor = true;
            this.chkTipoProv.CheckedChanged += new System.EventHandler(this.chkTipoProv_CheckedChanged);
            // 
            // txtProv
            // 
            this.txtProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProv.Location = new System.Drawing.Point(117, 46);
            this.txtProv.MaxLength = 20;
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(212, 20);
            this.txtProv.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proveedor:";
            // 
            // CntrlUsuFiltroCuentasXPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxFiltro);
            this.Name = "CntrlUsuFiltroCuentasXPagar";
            this.Size = new System.Drawing.Size(659, 89);
            this.Load += new System.EventHandler(this.CntrlUsuFiltroCuentasXPagar_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.ComboBox cboTipoProv;
        private System.Windows.Forms.CheckBox chkTipoProv;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProv;
    }
}
