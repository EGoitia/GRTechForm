namespace GRTechnology1._0
{
    partial class Frm_Detalle_Pedidos
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
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.txtNroVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtMontoSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoAnticipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoTot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegul = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImpListaDetallada = new System.Windows.Forms.Button();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.gbxTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnModif
            // 
            this.btnModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.label9);
            this.gbxFiltro.Controls.Add(this.label8);
            this.gbxFiltro.Controls.Add(this.chkAnulado);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.txtNroVenta);
            this.gbxFiltro.Controls.Add(this.label7);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.txtVendedor);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.txtCliente);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Size = new System.Drawing.Size(899, 80);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtCliente, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtVendedor, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label7, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNroVenta, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAnulado, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label8, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label9, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(745, 25);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 92);
            this.dgvDetalle.Size = new System.Drawing.Size(899, 228);
            // 
            // btnImpNota
            // 
            this.btnImpNota.Location = new System.Drawing.Point(800, 12);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Location = new System.Drawing.Point(701, 12);
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnImpListaDetallada);
            this.gbxBotones.Controls.Add(this.btnRegul);
            this.gbxBotones.Location = new System.Drawing.Point(10, 369);
            this.gbxBotones.Size = new System.Drawing.Size(899, 63);
            this.gbxBotones.Controls.SetChildIndex(this.btnModif, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnRegistro, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnAnul, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpLista, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpNota, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnRegul, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpListaDetallada, 0);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(504, 12);
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(651, 49);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(65, 17);
            this.chkAnulado.TabIndex = 66;
            this.chkAnulado.Text = "Anulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(320, 46);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(228, 21);
            this.cboSucursal.TabIndex = 59;
            // 
            // txtNroVenta
            // 
            this.txtNroVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroVenta.Location = new System.Drawing.Point(633, 20);
            this.txtNroVenta.MaxLength = 50;
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.Size = new System.Drawing.Size(85, 20);
            this.txtNroVenta.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Nro. Pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Al";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(451, 19);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 56;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(320, 19);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 55;
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(76, 46);
            this.txtVendedor.MaxLength = 50;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(150, 20);
            this.txtVendedor.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Vendedor:";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(76, 20);
            this.txtCliente.MaxLength = 50;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(150, 20);
            this.txtCliente.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cliente:";
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotales.Controls.Add(this.txtMontoSaldo);
            this.gbxTotales.Controls.Add(this.label5);
            this.gbxTotales.Controls.Add(this.txtMontoAnticipo);
            this.gbxTotales.Controls.Add(this.label6);
            this.gbxTotales.Controls.Add(this.txtMontoTot);
            this.gbxTotales.Controls.Add(this.label4);
            this.gbxTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotales.Location = new System.Drawing.Point(11, 322);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(899, 45);
            this.gbxTotales.TabIndex = 9;
            this.gbxTotales.TabStop = false;
            // 
            // txtMontoSaldo
            // 
            this.txtMontoSaldo.Location = new System.Drawing.Point(599, 14);
            this.txtMontoSaldo.MaxLength = 50;
            this.txtMontoSaldo.Name = "txtMontoSaldo";
            this.txtMontoSaldo.ReadOnly = true;
            this.txtMontoSaldo.Size = new System.Drawing.Size(110, 22);
            this.txtMontoSaldo.TabIndex = 4;
            this.txtMontoSaldo.Text = "0.00";
            this.txtMontoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Saldo:";
            // 
            // txtMontoAnticipo
            // 
            this.txtMontoAnticipo.Location = new System.Drawing.Point(367, 15);
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
            this.label6.Location = new System.Drawing.Point(246, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Anticipos:";
            // 
            // txtMontoTot
            // 
            this.txtMontoTot.Location = new System.Drawing.Point(115, 15);
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
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto Total:";
            // 
            // btnRegul
            // 
            this.btnRegul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegul.Location = new System.Drawing.Point(206, 12);
            this.btnRegul.Name = "btnRegul";
            this.btnRegul.Size = new System.Drawing.Size(93, 41);
            this.btnRegul.TabIndex = 1;
            this.btnRegul.Text = "Convertir en Venta";
            this.btnRegul.UseVisualStyleBackColor = true;
            this.btnRegul.Click += new System.EventHandler(this.btnRegul_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Sucursal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Fecha del:";
            // 
            // btnImpListaDetallada
            // 
            this.btnImpListaDetallada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpListaDetallada.Location = new System.Drawing.Point(602, 12);
            this.btnImpListaDetallada.Name = "btnImpListaDetallada";
            this.btnImpListaDetallada.Size = new System.Drawing.Size(93, 41);
            this.btnImpListaDetallada.TabIndex = 2;
            this.btnImpListaDetallada.Text = "Imprimir Lista Detallada";
            this.btnImpListaDetallada.UseVisualStyleBackColor = true;
            this.btnImpListaDetallada.Click += new System.EventHandler(this.btnImpListaDetallada_Click);
            // 
            // Frm_Detalle_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(918, 435);
            this.Controls.Add(this.gbxTotales);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Pedidos";
            this.Text = "DETALLE DE PEDIDOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDetalle_Pedidos_FormClosing);
            this.Load += new System.EventHandler(this.FrmDetalle_Pedidos_Load);
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

        private System.Windows.Forms.CheckBox chkAnulado;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtMontoAnticipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoTot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnImpListaDetallada;
    }
}
