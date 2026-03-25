namespace GRTechnology1._0
{
    partial class Frm_Detalle_Ingresos_Egresos
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
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.chkTipo = new System.Windows.Forms.CheckBox();
            this.cboCaja = new System.Windows.Forms.ComboBox();
            this.chkCaja = new System.Windows.Forms.CheckBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.chkTipoPago = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtTotalEgreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalIngreso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.gbxTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnModif
            // 
            this.btnModif.Visible = false;
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.chkAnulado);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.chkFechas);
            this.gbxFiltro.Controls.Add(this.chkTipoPago);
            this.gbxFiltro.Controls.Add(this.cboTipoPago);
            this.gbxFiltro.Controls.Add(this.chkSucursal);
            this.gbxFiltro.Controls.Add(this.chkCaja);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.cboCaja);
            this.gbxFiltro.Controls.Add(this.chkTipo);
            this.gbxFiltro.Controls.Add(this.cboTipo);
            this.gbxFiltro.Size = new System.Drawing.Size(898, 100);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboTipo, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkTipo, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboCaja, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkCaja, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboTipoPago, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkTipoPago, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAnulado, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(784, 36);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Size = new System.Drawing.Size(898, 175);
            // 
            // btnImpNota
            // 
            this.btnImpNota.Location = new System.Drawing.Point(799, 12);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Location = new System.Drawing.Point(700, 12);
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Size = new System.Drawing.Size(898, 63);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(601, 12);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Enabled = false;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "INGRESO",
            "EGRESO"});
            this.cboTipo.Location = new System.Drawing.Point(96, 15);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(150, 21);
            this.cboTipo.TabIndex = 6;
            // 
            // chkTipo
            // 
            this.chkTipo.AutoSize = true;
            this.chkTipo.Location = new System.Drawing.Point(21, 20);
            this.chkTipo.Name = "chkTipo";
            this.chkTipo.Size = new System.Drawing.Size(50, 17);
            this.chkTipo.TabIndex = 7;
            this.chkTipo.Text = "Tipo:";
            this.chkTipo.UseVisualStyleBackColor = true;
            this.chkTipo.CheckedChanged += new System.EventHandler(this.chkTipo_CheckedChanged);
            // 
            // cboCaja
            // 
            this.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaja.Enabled = false;
            this.cboCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(96, 43);
            this.cboCaja.Margin = new System.Windows.Forms.Padding(2);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.Size = new System.Drawing.Size(320, 21);
            this.cboCaja.TabIndex = 43;
            // 
            // chkCaja
            // 
            this.chkCaja.AutoSize = true;
            this.chkCaja.Location = new System.Drawing.Point(21, 49);
            this.chkCaja.Name = "chkCaja";
            this.chkCaja.Size = new System.Drawing.Size(50, 17);
            this.chkCaja.TabIndex = 44;
            this.chkCaja.Text = "Caja:";
            this.chkCaja.UseVisualStyleBackColor = true;
            this.chkCaja.CheckedChanged += new System.EventHandler(this.chkCaja_CheckedChanged);
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Enabled = false;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "INGRESO",
            "EGRESO"});
            this.cboTipoPago.Location = new System.Drawing.Point(524, 19);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(220, 21);
            this.cboTipoPago.TabIndex = 46;
            // 
            // chkTipoPago
            // 
            this.chkTipoPago.AutoSize = true;
            this.chkTipoPago.Location = new System.Drawing.Point(442, 21);
            this.chkTipoPago.Name = "chkTipoPago";
            this.chkTipoPago.Size = new System.Drawing.Size(78, 17);
            this.chkTipoPago.TabIndex = 47;
            this.chkTipoPago.Text = "Tipo Pago:";
            this.chkTipoPago.UseVisualStyleBackColor = true;
            this.chkTipoPago.CheckedChanged += new System.EventHandler(this.chkTipoPago_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Al";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(647, 45);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 54;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(524, 46);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 55;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(442, 50);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(59, 17);
            this.chkFechas.TabIndex = 53;
            this.chkFechas.Text = "Fecha:";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(96, 71);
            this.cboSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(320, 21);
            this.cboSucursal.TabIndex = 43;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Checked = true;
            this.chkSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSucursal.Location = new System.Drawing.Point(21, 75);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 44;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(442, 75);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(65, 17);
            this.chkAnulado.TabIndex = 57;
            this.chkAnulado.Text = "Anulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotales.Controls.Add(this.txtTotalEgreso);
            this.gbxTotales.Controls.Add(this.label6);
            this.gbxTotales.Controls.Add(this.txtTotalIngreso);
            this.gbxTotales.Controls.Add(this.label4);
            this.gbxTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotales.Location = new System.Drawing.Point(10, 286);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(898, 45);
            this.gbxTotales.TabIndex = 9;
            this.gbxTotales.TabStop = false;
            // 
            // txtTotalEgreso
            // 
            this.txtTotalEgreso.Location = new System.Drawing.Point(370, 15);
            this.txtTotalEgreso.MaxLength = 50;
            this.txtTotalEgreso.Name = "txtTotalEgreso";
            this.txtTotalEgreso.ReadOnly = true;
            this.txtTotalEgreso.Size = new System.Drawing.Size(110, 22);
            this.txtTotalEgreso.TabIndex = 4;
            this.txtTotalEgreso.Text = "0.00";
            this.txtTotalEgreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Egresos:";
            // 
            // txtTotalIngreso
            // 
            this.txtTotalIngreso.Location = new System.Drawing.Point(129, 15);
            this.txtTotalIngreso.MaxLength = 50;
            this.txtTotalIngreso.Name = "txtTotalIngreso";
            this.txtTotalIngreso.ReadOnly = true;
            this.txtTotalIngreso.Size = new System.Drawing.Size(110, 22);
            this.txtTotalIngreso.TabIndex = 4;
            this.txtTotalIngreso.Text = "0.00";
            this.txtTotalIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Ingresos:";
            // 
            // Frm_Detalle_Ingresos_Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(917, 402);
            this.Controls.Add(this.gbxTotales);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Ingresos_Egresos";
            this.Text = "DETALLE INGRESOS/EGRESOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Gastos_Ingresos_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Gastos_Ingresos_Load);
            this.Controls.SetChildIndex(this.gbxFiltro, 0);
            this.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.Controls.SetChildIndex(this.gbxBotones, 0);
            this.Controls.SetChildIndex(this.gbxTotales, 0);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.CheckBox chkTipo;
        private System.Windows.Forms.CheckBox chkCaja;
        private System.Windows.Forms.ComboBox cboCaja;
        private System.Windows.Forms.CheckBox chkTipoPago;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.CheckBox chkAnulado;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtTotalEgreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalIngreso;
        private System.Windows.Forms.Label label4;
    }
}
