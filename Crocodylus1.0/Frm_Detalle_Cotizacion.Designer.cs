namespace GRTechnology1._0
{
    partial class Frm_Detalle_Cotizacion
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
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.txtNroVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtMontoTot = new System.Windows.Forms.TextBox();
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
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.txtNroVenta);
            this.gbxFiltro.Controls.Add(this.label7);
            this.gbxFiltro.Controls.Add(this.chkSucursal);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.chkFechas);
            this.gbxFiltro.Controls.Add(this.txtVendedor);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.txtCliente);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Size = new System.Drawing.Size(916, 80);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtCliente, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtVendedor, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label7, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNroVenta, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(802, 20);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 93);
            this.dgvDetalle.Size = new System.Drawing.Size(916, 190);
            // 
            // btnImpNota
            // 
            this.btnImpNota.Location = new System.Drawing.Point(817, 12);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Location = new System.Drawing.Point(718, 12);
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Size = new System.Drawing.Size(916, 63);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(619, 12);
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(316, 44);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(210, 21);
            this.cboSucursal.TabIndex = 57;
            // 
            // txtNroVenta
            // 
            this.txtNroVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroVenta.Location = new System.Drawing.Point(627, 19);
            this.txtNroVenta.MaxLength = 50;
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.Size = new System.Drawing.Size(85, 20);
            this.txtNroVenta.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nro. Nota:";
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Checked = true;
            this.chkSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSucursal.Location = new System.Drawing.Point(243, 47);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 59;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Al";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(430, 18);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 54;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(305, 18);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 55;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(243, 19);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(59, 17);
            this.chkFechas.TabIndex = 53;
            this.chkFechas.Text = "Fecha:";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(72, 45);
            this.txtVendedor.MaxLength = 50;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(150, 20);
            this.txtVendedor.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Vendedor:";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(72, 19);
            this.txtCliente.MaxLength = 50;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(150, 20);
            this.txtCliente.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cliente:";
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotales.Controls.Add(this.txtMontoTot);
            this.gbxTotales.Controls.Add(this.label4);
            this.gbxTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotales.Location = new System.Drawing.Point(10, 287);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(916, 45);
            this.gbxTotales.TabIndex = 9;
            this.gbxTotales.TabStop = false;
            // 
            // txtMontoTot
            // 
            this.txtMontoTot.Location = new System.Drawing.Point(67, 15);
            this.txtMontoTot.MaxLength = 50;
            this.txtMontoTot.Name = "txtMontoTot";
            this.txtMontoTot.ReadOnly = true;
            this.txtMontoTot.Size = new System.Drawing.Size(110, 22);
            this.txtMontoTot.TabIndex = 4;
            this.txtMontoTot.Text = "0.00";
            this.txtMontoTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // Frm_Detalle_Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(935, 402);
            this.Controls.Add(this.gbxTotales);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Cotizacion";
            this.Text = "DETALLE COTIZACIÓN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Cotizacion_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Cotizacion_Load);
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

        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtMontoTot;
        private System.Windows.Forms.Label label4;
    }
}
