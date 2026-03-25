namespace GRTechnology1._0
{
    partial class Frm_Detalle_Abonos
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
            this.cbxSucursal = new System.Windows.Forms.CheckBox();
            this.txtNroNota = new System.Windows.Forms.TextBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.cbxFechas = new System.Windows.Forms.CheckBox();
            this.cbxTipoPago = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.CheckBox();
            this.cbxAnuladas = new System.Windows.Forms.CheckBox();
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
            this.gbxFiltro.Controls.Add(this.cboCliente);
            this.gbxFiltro.Controls.Add(this.cbxAnuladas);
            this.gbxFiltro.Controls.Add(this.cbxSucursal);
            this.gbxFiltro.Controls.Add(this.cbxCliente);
            this.gbxFiltro.Controls.Add(this.txtReferencia);
            this.gbxFiltro.Controls.Add(this.txtNroNota);
            this.gbxFiltro.Controls.Add(this.cboTipoPago);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.cbxFechas);
            this.gbxFiltro.Controls.Add(this.lblRef);
            this.gbxFiltro.Controls.Add(this.cbxTipoPago);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Size = new System.Drawing.Size(865, 105);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cbxTipoPago, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.lblRef, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cbxFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboTipoPago, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNroNota, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtReferencia, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cbxCliente, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cbxSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cbxAnuladas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboCliente, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(702, 35);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 115);
            this.dgvDetalle.Size = new System.Drawing.Size(865, 171);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // cbxSucursal
            // 
            this.cbxSucursal.AutoSize = true;
            this.cbxSucursal.Checked = true;
            this.cbxSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSucursal.Location = new System.Drawing.Point(21, 79);
            this.cbxSucursal.Name = "cbxSucursal";
            this.cbxSucursal.Size = new System.Drawing.Size(70, 17);
            this.cbxSucursal.TabIndex = 344;
            this.cbxSucursal.Text = "Sucursal:";
            this.cbxSucursal.UseVisualStyleBackColor = true;
            this.cbxSucursal.CheckedChanged += new System.EventHandler(this.cbxSucursal_CheckedChanged);
            // 
            // txtNroNota
            // 
            this.txtNroNota.Location = new System.Drawing.Point(442, 17);
            this.txtNroNota.Name = "txtNroNota";
            this.txtNroNota.Size = new System.Drawing.Size(100, 20);
            this.txtNroNota.TabIndex = 343;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Enabled = false;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "TRANSFERENCIA",
            "TARJETA"});
            this.cboTipoPago.Location = new System.Drawing.Point(102, 16);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(230, 21);
            this.cboTipoPago.TabIndex = 342;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 341;
            this.label3.Text = "Al:";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(231, 46);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(101, 20);
            this.dtFecFin.TabIndex = 339;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(102, 46);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(101, 20);
            this.dtFecIni.TabIndex = 340;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.Enabled = false;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(102, 77);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(230, 21);
            this.cboSucursal.TabIndex = 335;
            // 
            // cbxFechas
            // 
            this.cbxFechas.AutoSize = true;
            this.cbxFechas.Checked = true;
            this.cbxFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFechas.Location = new System.Drawing.Point(21, 48);
            this.cbxFechas.Name = "cbxFechas";
            this.cbxFechas.Size = new System.Drawing.Size(76, 17);
            this.cbxFechas.TabIndex = 338;
            this.cbxFechas.Text = "Fecha del:";
            this.cbxFechas.UseVisualStyleBackColor = true;
            this.cbxFechas.CheckedChanged += new System.EventHandler(this.cbxFechas_CheckedChanged);
            // 
            // cbxTipoPago
            // 
            this.cbxTipoPago.AutoSize = true;
            this.cbxTipoPago.Location = new System.Drawing.Point(21, 19);
            this.cbxTipoPago.Name = "cbxTipoPago";
            this.cbxTipoPago.Size = new System.Drawing.Size(78, 17);
            this.cbxTipoPago.TabIndex = 334;
            this.cbxTipoPago.Text = "Tipo Pago:";
            this.cbxTipoPago.UseVisualStyleBackColor = true;
            this.cbxTipoPago.CheckedChanged += new System.EventHandler(this.cbxTipoPago_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 333;
            this.label1.Text = "Nro. Nota:";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(370, 82);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(62, 13);
            this.lblRef.TabIndex = 333;
            this.lblRef.Text = "Referencia:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(442, 76);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(225, 20);
            this.txtReferencia.TabIndex = 343;
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotales.Controls.Add(this.txtTotal);
            this.gbxTotales.Controls.Add(this.label4);
            this.gbxTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.gbxTotales.Location = new System.Drawing.Point(10, 290);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(865, 48);
            this.gbxTotales.TabIndex = 6;
            this.gbxTotales.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(118, 17);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(112, 21);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Abonado:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Enabled = false;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(442, 45);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(225, 21);
            this.cboCliente.TabIndex = 337;
            // 
            // cbxCliente
            // 
            this.cbxCliente.AutoSize = true;
            this.cbxCliente.Location = new System.Drawing.Point(370, 48);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(61, 17);
            this.cbxCliente.TabIndex = 346;
            this.cbxCliente.Text = "Cliente:";
            this.cbxCliente.UseVisualStyleBackColor = true;
            this.cbxCliente.CheckedChanged += new System.EventHandler(this.cbxCliente_CheckedChanged);
            // 
            // cbxAnuladas
            // 
            this.cbxAnuladas.AutoSize = true;
            this.cbxAnuladas.Location = new System.Drawing.Point(596, 20);
            this.cbxAnuladas.Name = "cbxAnuladas";
            this.cbxAnuladas.Size = new System.Drawing.Size(70, 17);
            this.cbxAnuladas.TabIndex = 347;
            this.cbxAnuladas.Text = "Anuladas";
            this.cbxAnuladas.UseVisualStyleBackColor = true;
            // 
            // Frm_Detalle_Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 408);
            this.Controls.Add(this.gbxTotales);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Abonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE DE ABONOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Abonos_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Abonos_Load);
            this.Controls.SetChildIndex(this.gbxTotales, 0);
            this.Controls.SetChildIndex(this.gbxBotones, 0);
            this.Controls.SetChildIndex(this.gbxFiltro, 0);
            this.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxSucursal;
        private System.Windows.Forms.TextBox txtNroNota;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.CheckBox cbxFechas;
        private System.Windows.Forms.CheckBox cbxTipoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.CheckBox cbxAnuladas;
    }
}