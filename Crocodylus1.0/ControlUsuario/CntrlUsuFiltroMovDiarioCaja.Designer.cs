namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrlUsuFiltroMovDiarioCaja
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
            this.chkTipoPago = new System.Windows.Forms.CheckBox();
            this.cboTipoPgo = new System.Windows.Forms.ComboBox();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTipoPago);
            this.groupBox1.Controls.Add(this.cboTipoPgo);
            this.groupBox1.Controls.Add(this.chkUsuario);
            this.groupBox1.Controls.Add(this.cboUsuario);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.dtFechaIni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkSucursal);
            this.groupBox1.Controls.Add(this.cboSucursal);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(625, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkTipoPago
            // 
            this.chkTipoPago.AutoSize = true;
            this.chkTipoPago.Checked = true;
            this.chkTipoPago.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTipoPago.Location = new System.Drawing.Point(323, 47);
            this.chkTipoPago.Name = "chkTipoPago";
            this.chkTipoPago.Size = new System.Drawing.Size(78, 17);
            this.chkTipoPago.TabIndex = 14;
            this.chkTipoPago.Text = "Tipo Pago:";
            this.chkTipoPago.UseVisualStyleBackColor = true;
            this.chkTipoPago.CheckedChanged += new System.EventHandler(this.chkTipoPago_CheckedChanged);
            // 
            // cboTipoPgo
            // 
            this.cboTipoPgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPgo.FormattingEnabled = true;
            this.cboTipoPgo.Location = new System.Drawing.Point(406, 44);
            this.cboTipoPgo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoPgo.Name = "cboTipoPgo";
            this.cboTipoPgo.Size = new System.Drawing.Size(193, 21);
            this.cboTipoPgo.TabIndex = 13;
            // 
            // chkUsuario
            // 
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.Location = new System.Drawing.Point(19, 48);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(70, 17);
            this.chkUsuario.TabIndex = 12;
            this.chkUsuario.Text = "Ususario:";
            this.chkUsuario.UseVisualStyleBackColor = true;
            this.chkUsuario.CheckedChanged += new System.EventHandler(this.chkUsuario_CheckedChanged);
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.Enabled = false;
            this.cboUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(94, 45);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(201, 21);
            this.cboUsuario.TabIndex = 11;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(497, 14);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(102, 20);
            this.dtFechaFin.TabIndex = 9;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(352, 14);
            this.dtFechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(102, 20);
            this.dtFechaIni.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Al:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Del:";
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Checked = true;
            this.chkSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSucursal.Location = new System.Drawing.Point(19, 18);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 2;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkCaja_CheckedChanged);
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(94, 16);
            this.cboSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(201, 21);
            this.cboSucursal.TabIndex = 1;
            // 
            // CntrlUsuFiltroMovDiarioCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CntrlUsuFiltroMovDiarioCaja";
            this.Size = new System.Drawing.Size(642, 92);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.CheckBox chkUsuario;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTipoPago;
        private System.Windows.Forms.ComboBox cboTipoPgo;
    }
}
