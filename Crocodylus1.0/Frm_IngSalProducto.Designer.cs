namespace GRTechnology1._0
{
    partial class Frm_IngSalProducto
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
            this.btnBusqProv = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.cboTipoIng = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtImporteTot = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtCodCompraProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroRegul = new System.Windows.Forms.TextBox();
            this.panelSup.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoNota
            // 
            this.txtCodigoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtCodigoNota.Location = new System.Drawing.Point(52, 7);
            this.txtCodigoNota.Size = new System.Drawing.Size(32, 26);
            // 
            // txtNumNota
            // 
            this.txtNumNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNumNota.Location = new System.Drawing.Point(52, 7);
            this.txtNumNota.Size = new System.Drawing.Size(87, 26);
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelSup.Controls.Add(this.txtCodCompraProd);
            this.panelSup.Controls.Add(this.txtNroRegul);
            this.panelSup.Controls.Add(this.label2);
            this.panelSup.Controls.SetChildIndex(this.label2, 0);
            this.panelSup.Controls.SetChildIndex(this.txtNumNota, 0);
            this.panelSup.Controls.SetChildIndex(this.lblNro, 0);
            this.panelSup.Controls.SetChildIndex(this.lblFecha, 0);
            this.panelSup.Controls.SetChildIndex(this.txtTC, 0);
            this.panelSup.Controls.SetChildIndex(this.label1, 0);
            this.panelSup.Controls.SetChildIndex(this.txtCodigoNota, 0);
            this.panelSup.Controls.SetChildIndex(this.txtNroRegul, 0);
            this.panelSup.Controls.SetChildIndex(this.txtCodCompraProd, 0);
            // 
            // label1
            // 
            this.label1.Visible = false;
            // 
            // txtTC
            // 
            this.txtTC.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(115, 109);
            this.txtObs.Size = new System.Drawing.Size(568, 40);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 112);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnBusqProv);
            this.gbxDatos.Controls.Add(this.cboProveedor);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.txtRecibido);
            this.gbxDatos.Controls.Add(this.lblRef);
            this.gbxDatos.Controls.Add(this.cboTipoIng);
            this.gbxDatos.Controls.Add(this.lblTipo);
            this.gbxDatos.Size = new System.Drawing.Size(700, 160);
            this.gbxDatos.Controls.SetChildIndex(this.label6, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtObs, 0);
            this.gbxDatos.Controls.SetChildIndex(this.lblTipo, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboTipoIng, 0);
            this.gbxDatos.Controls.SetChildIndex(this.lblRef, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtRecibido, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label5, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboProveedor, 0);
            this.gbxDatos.Controls.SetChildIndex(this.btnBusqProv, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(403, 9);
            this.lblFecha.Size = new System.Drawing.Size(650, 23);
            this.lblFecha.Text = "19/09/2019";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtImporteTot);
            this.panel3.Controls.Add(this.lblImporte);
            this.panel3.Controls.SetChildIndex(this.pbxImg, 0);
            this.panel3.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel3.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel3.Controls.SetChildIndex(this.gbxDatos, 0);
            this.panel3.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.panel3.Controls.SetChildIndex(this.lblImporte, 0);
            this.panel3.Controls.SetChildIndex(this.txtImporteTot, 0);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Location = new System.Drawing.Point(6, 168);
            // 
            // lblNro
            // 
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNro.Size = new System.Drawing.Size(28, 20);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(661, 375);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(780, 375);
            // 
            // panelBusqProd
            // 
            //this.panelBusqProd.BackColor = System.Drawing.Color.DimGray;
            // 
            // btnBusqProv
            // 
            this.btnBusqProv.Location = new System.Drawing.Point(485, 42);
            this.btnBusqProv.Name = "btnBusqProv";
            this.btnBusqProv.Size = new System.Drawing.Size(43, 29);
            this.btnBusqProv.TabIndex = 52;
            this.btnBusqProv.Text = ".....";
            this.btnBusqProv.UseVisualStyleBackColor = true;
            this.btnBusqProv.Click += new System.EventHandler(this.btnBusqProv_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(115, 44);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(364, 24);
            this.cboProveedor.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Proveedor:";
            // 
            // txtRecibido
            // 
            this.txtRecibido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRecibido.Location = new System.Drawing.Point(115, 79);
            this.txtRecibido.MaxLength = 50;
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(413, 22);
            this.txtRecibido.TabIndex = 49;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(13, 78);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(85, 16);
            this.lblRef.TabIndex = 48;
            this.lblRef.Text = "Recibido de:";
            // 
            // cboTipoIng
            // 
            this.cboTipoIng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoIng.FormattingEnabled = true;
            this.cboTipoIng.Items.AddRange(new object[] {
            "INVENTARIO INICIAL",
            "AJUSTES",
            "COMPRA"});
            this.cboTipoIng.Location = new System.Drawing.Point(115, 12);
            this.cboTipoIng.Name = "cboTipoIng";
            this.cboTipoIng.Size = new System.Drawing.Size(413, 24);
            this.cboTipoIng.TabIndex = 47;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(13, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(87, 16);
            this.lblTipo.TabIndex = 46;
            this.lblTipo.Text = "Tipo Ingreso:";
            // 
            // txtImporteTot
            // 
            this.txtImporteTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtImporteTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtImporteTot.Location = new System.Drawing.Point(75, 378);
            this.txtImporteTot.Margin = new System.Windows.Forms.Padding(2);
            this.txtImporteTot.Name = "txtImporteTot";
            this.txtImporteTot.ReadOnly = true;
            this.txtImporteTot.Size = new System.Drawing.Size(154, 26);
            this.txtImporteTot.TabIndex = 62;
            this.txtImporteTot.TabStop = false;
            this.txtImporteTot.Text = "0.00";
            this.txtImporteTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblImporte
            // 
            this.lblImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblImporte.Location = new System.Drawing.Point(5, 381);
            this.lblImporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(68, 20);
            this.lblImporte.TabIndex = 63;
            this.lblImporte.Text = "Importe:";
            // 
            // txtCodCompraProd
            // 
            this.txtCodCompraProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtCodCompraProd.Location = new System.Drawing.Point(124, 7);
            this.txtCodCompraProd.Name = "txtCodCompraProd";
            this.txtCodCompraProd.ReadOnly = true;
            this.txtCodCompraProd.Size = new System.Drawing.Size(50, 26);
            this.txtCodCompraProd.TabIndex = 50;
            this.txtCodCompraProd.TabStop = false;
            this.txtCodCompraProd.Text = "-1";
            this.txtCodCompraProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodCompraProd.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nº Compra :";
            this.label2.Visible = false;
            // 
            // txtNroRegul
            // 
            this.txtNroRegul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNroRegul.Location = new System.Drawing.Point(126, 7);
            this.txtNroRegul.MaxLength = 10;
            this.txtNroRegul.Name = "txtNroRegul";
            this.txtNroRegul.ReadOnly = true;
            this.txtNroRegul.Size = new System.Drawing.Size(117, 26);
            this.txtNroRegul.TabIndex = 49;
            this.txtNroRegul.TabStop = false;
            this.txtNroRegul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroRegul.Visible = false;
            // 
            // Frm_IngSalProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 473);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_IngSalProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_IngSalProducto_FormClosing);
            this.Load += new System.EventHandler(this.Frm_IngSalProducto_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusqProv;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.ComboBox cboTipoIng;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtImporteTot;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroRegul;
        public System.Windows.Forms.TextBox txtCodCompraProd;
    }
}
