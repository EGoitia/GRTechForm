namespace GRTechnology1._0
{
    partial class Frm_Detalle_VentaPOS
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
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.chkTipoPago = new System.Windows.Forms.CheckBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.txtNroVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkTipoVenta = new System.Windows.Forms.CheckBox();
            this.cboTipoVenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtMontoAnticipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoTot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxTotales.SuspendLayout();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.cboTipoPago);
            this.gbxFiltro.Controls.Add(this.chkTipoPago);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.txtNroVenta);
            this.gbxFiltro.Controls.Add(this.label7);
            this.gbxFiltro.Controls.Add(this.chkSucursal);
            this.gbxFiltro.Controls.Add(this.btnBuscar);
            this.gbxFiltro.Controls.Add(this.chkTipoVenta);
            this.gbxFiltro.Controls.Add(this.cboTipoVenta);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.chkFechas);
            this.gbxFiltro.Controls.Add(this.txtVendedor);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.txtCliente);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Location = new System.Drawing.Point(5, 3);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(646, 133);
            this.gbxFiltro.TabIndex = 0;
            this.gbxFiltro.TabStop = false;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Enabled = false;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(319, 99);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(210, 21);
            this.cboTipoPago.TabIndex = 64;
            // 
            // chkTipoPago
            // 
            this.chkTipoPago.AutoSize = true;
            this.chkTipoPago.Location = new System.Drawing.Point(244, 101);
            this.chkTipoPago.Name = "chkTipoPago";
            this.chkTipoPago.Size = new System.Drawing.Size(78, 17);
            this.chkTipoPago.TabIndex = 65;
            this.chkTipoPago.Text = "Tipo Pago:";
            this.chkTipoPago.UseVisualStyleBackColor = true;
            this.chkTipoPago.CheckedChanged += new System.EventHandler(this.chkTipoPago_CheckedChanged);
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(319, 72);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(210, 21);
            this.cboSucursal.TabIndex = 58;
            // 
            // txtNroVenta
            // 
            this.txtNroVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroVenta.Location = new System.Drawing.Point(74, 72);
            this.txtNroVenta.MaxLength = 50;
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.Size = new System.Drawing.Size(85, 20);
            this.txtNroVenta.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nro. Venta:";
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Checked = true;
            this.chkSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSucursal.Location = new System.Drawing.Point(244, 74);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 59;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.Location = new System.Drawing.Point(551, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 39);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkTipoVenta
            // 
            this.chkTipoVenta.AutoSize = true;
            this.chkTipoVenta.Location = new System.Drawing.Point(244, 48);
            this.chkTipoVenta.Name = "chkTipoVenta";
            this.chkTipoVenta.Size = new System.Drawing.Size(96, 17);
            this.chkTipoVenta.TabIndex = 56;
            this.chkTipoVenta.Text = "Tipo de Venta:";
            this.chkTipoVenta.UseVisualStyleBackColor = true;
            this.chkTipoVenta.CheckedChanged += new System.EventHandler(this.chkTipoVenta_CheckedChanged);
            // 
            // cboTipoVenta
            // 
            this.cboTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVenta.Enabled = false;
            this.cboTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoVenta.FormattingEnabled = true;
            this.cboTipoVenta.Location = new System.Drawing.Point(359, 46);
            this.cboTipoVenta.Name = "cboTipoVenta";
            this.cboTipoVenta.Size = new System.Drawing.Size(170, 21);
            this.cboTipoVenta.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Al";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(432, 18);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 52;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(307, 18);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 53;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(244, 19);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(59, 17);
            this.chkFechas.TabIndex = 51;
            this.chkFechas.Text = "Fecha:";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(74, 45);
            this.txtVendedor.MaxLength = 50;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(150, 20);
            this.txtVendedor.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Vendedor:";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(74, 19);
            this.txtCliente.MaxLength = 50;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(150, 20);
            this.txtCliente.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cliente:";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(5, 142);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(761, 115);
            this.dgvDetalle.TabIndex = 1;
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotales.Controls.Add(this.txtMontoAnticipo);
            this.gbxTotales.Controls.Add(this.label6);
            this.gbxTotales.Controls.Add(this.txtMontoTot);
            this.gbxTotales.Controls.Add(this.label4);
            this.gbxTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotales.Location = new System.Drawing.Point(5, 260);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(761, 45);
            this.gbxTotales.TabIndex = 7;
            this.gbxTotales.TabStop = false;
            // 
            // txtMontoAnticipo
            // 
            this.txtMontoAnticipo.Location = new System.Drawing.Point(370, 15);
            this.txtMontoAnticipo.MaxLength = 50;
            this.txtMontoAnticipo.Name = "txtMontoAnticipo";
            this.txtMontoAnticipo.ReadOnly = true;
            this.txtMontoAnticipo.Size = new System.Drawing.Size(110, 22);
            this.txtMontoAnticipo.TabIndex = 4;
            this.txtMontoAnticipo.Text = "0.00";
            this.txtMontoAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Anticipos:";
            // 
            // txtMontoTot
            // 
            this.txtMontoTot.Location = new System.Drawing.Point(118, 15);
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
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Ventas:";
            // 
            // gbxBotones
            // 
            this.gbxBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBotones.Controls.Add(this.btnPagar);
            this.gbxBotones.Controls.Add(this.btnSalir);
            this.gbxBotones.Controls.Add(this.btnDescargar);
            this.gbxBotones.Controls.Add(this.btnImp);
            this.gbxBotones.Location = new System.Drawing.Point(5, 308);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(761, 60);
            this.gbxBotones.TabIndex = 8;
            this.gbxBotones.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.Location = new System.Drawing.Point(9, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(63, 41);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargar.BackgroundImage = global::GRTechnology1._0.Properties.Resources.descargar_pdf;
            this.btnDescargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDescargar.Location = new System.Drawing.Point(632, 11);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(58, 41);
            this.btnDescargar.TabIndex = 3;
            this.btnDescargar.Tag = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnImp
            // 
            this.btnImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImp.BackgroundImage = global::GRTechnology1._0.Properties.Resources.impresora;
            this.btnImp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImp.Location = new System.Drawing.Point(695, 11);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(58, 41);
            this.btnImp.TabIndex = 2;
            this.btnImp.Tag = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.BackgroundImage = global::GRTechnology1._0.Properties.Resources.trabajadores_por_cuenta_propia;
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagar.Location = new System.Drawing.Point(571, 11);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(58, 41);
            this.btnPagar.TabIndex = 10;
            this.btnPagar.Tag = "Pagar Saldo";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Frm_Detalle_VentaPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 372);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.gbxTotales);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.gbxFiltro);
            this.Name = "Frm_Detalle_VentaPOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas del Día";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_VentaPOS_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_VentaPOS_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.CheckBox chkTipoVenta;
        private System.Windows.Forms.ComboBox cboTipoVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtMontoAnticipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoTot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.CheckBox chkTipoPago;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPagar;
    }
}