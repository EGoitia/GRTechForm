namespace GRTechnology1._0
{
    partial class Frm_Detalle_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoVenta = new System.Windows.Forms.ComboBox();
            this.chkTipoVenta = new System.Windows.Forms.CheckBox();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtMontoAnticipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoTot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.btnFactura = new System.Windows.Forms.Button();
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.btnImpListaDetallada = new System.Windows.Forms.Button();
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
            this.btnModif.Location = new System.Drawing.Point(364, 12);
            this.btnModif.Text = "Regularizar";
            this.btnModif.Visible = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.chkAnulado);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.txtNroFactura);
            this.gbxFiltro.Controls.Add(this.label5);
            this.gbxFiltro.Controls.Add(this.txtNroVenta);
            this.gbxFiltro.Controls.Add(this.label7);
            this.gbxFiltro.Controls.Add(this.chkSucursal);
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
            this.gbxFiltro.Size = new System.Drawing.Size(1071, 80);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtCliente, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtVendedor, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboTipoVenta, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkTipoVenta, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label7, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNroVenta, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label5, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNroFactura, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAnulado, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(965, 21);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeight = 46;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 89);
            this.dgvDetalle.RowHeadersWidth = 82;
            this.dgvDetalle.Size = new System.Drawing.Size(1071, 205);
            // 
            // btnImpNota
            // 
            this.btnImpNota.Location = new System.Drawing.Point(972, 12);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Location = new System.Drawing.Point(873, 12);
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnImpListaDetallada);
            this.gbxBotones.Controls.Add(this.btnFactura);
            this.gbxBotones.Size = new System.Drawing.Size(1071, 63);
            this.gbxBotones.Controls.SetChildIndex(this.btnModif, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnRegistro, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnAnul, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpLista, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpNota, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnFactura, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpListaDetallada, 0);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(675, 12);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(82, 20);
            this.txtCliente.MaxLength = 50;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(150, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(82, 46);
            this.txtVendedor.MaxLength = 50;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(150, 20);
            this.txtVendedor.TabIndex = 2;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(253, 20);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(59, 17);
            this.chkFechas.TabIndex = 3;
            this.chkFechas.Text = "Fecha:";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(315, 19);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 4;
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(440, 19);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Al";
            // 
            // cboTipoVenta
            // 
            this.cboTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVenta.Enabled = false;
            this.cboTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoVenta.FormattingEnabled = true;
            this.cboTipoVenta.Location = new System.Drawing.Point(367, 47);
            this.cboTipoVenta.Name = "cboTipoVenta";
            this.cboTipoVenta.Size = new System.Drawing.Size(170, 21);
            this.cboTipoVenta.TabIndex = 45;
            // 
            // chkTipoVenta
            // 
            this.chkTipoVenta.AutoSize = true;
            this.chkTipoVenta.Location = new System.Drawing.Point(253, 49);
            this.chkTipoVenta.Name = "chkTipoVenta";
            this.chkTipoVenta.Size = new System.Drawing.Size(96, 17);
            this.chkTipoVenta.TabIndex = 46;
            this.chkTipoVenta.Text = "Tipo de Venta:";
            this.chkTipoVenta.UseVisualStyleBackColor = true;
            this.chkTipoVenta.CheckedChanged += new System.EventHandler(this.chkTipoVenta_CheckedChanged);
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
            this.gbxTotales.Location = new System.Drawing.Point(10, 297);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(1071, 45);
            this.gbxTotales.TabIndex = 6;
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
            // txtNroVenta
            // 
            this.txtNroVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroVenta.Location = new System.Drawing.Point(637, 20);
            this.txtNroVenta.MaxLength = 50;
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.Size = new System.Drawing.Size(85, 20);
            this.txtNroVenta.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nro. Venta:";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(637, 47);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(228, 21);
            this.cboSucursal.TabIndex = 45;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Checked = true;
            this.chkSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSucursal.Location = new System.Drawing.Point(564, 50);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 46;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // btnFactura
            // 
            this.btnFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFactura.Location = new System.Drawing.Point(103, 12);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(93, 41);
            this.btnFactura.TabIndex = 1;
            this.btnFactura.Text = "Factura Manual";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(891, 48);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(65, 17);
            this.chkAnulado.TabIndex = 49;
            this.chkAnulado.Text = "Anulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nro. Factura:";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroFactura.Location = new System.Drawing.Point(805, 19);
            this.txtNroFactura.MaxLength = 50;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(60, 20);
            this.txtNroFactura.TabIndex = 48;
            // 
            // btnImpListaDetallada
            // 
            this.btnImpListaDetallada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpListaDetallada.Location = new System.Drawing.Point(774, 12);
            this.btnImpListaDetallada.Name = "btnImpListaDetallada";
            this.btnImpListaDetallada.Size = new System.Drawing.Size(93, 41);
            this.btnImpListaDetallada.TabIndex = 2;
            this.btnImpListaDetallada.Text = "Imprimir Lista Detallada";
            this.btnImpListaDetallada.UseVisualStyleBackColor = true;
            this.btnImpListaDetallada.Click += new System.EventHandler(this.btnImpListaDetallada_Click);
            // 
            // Frm_Detalle_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 402);
            this.Controls.Add(this.gbxTotales);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Ventas";
            this.Text = "DETALLE DE VENTAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Ventas_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Ventas_Load);
            this.Controls.SetChildIndex(this.gbxBotones, 0);
            this.Controls.SetChildIndex(this.gbxFiltro, 0);
            this.Controls.SetChildIndex(this.dgvDetalle, 0);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.CheckBox chkTipoVenta;
        private System.Windows.Forms.ComboBox cboTipoVenta;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtMontoTot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoAnticipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.CheckBox chkAnulado;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImpListaDetallada;
    }
}