namespace GRTechnology1._0
{
    partial class Frm_Pedidos
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
            this.btnBusqClient = new System.Windows.Forms.Button();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSup.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.LightPink;
            this.panelSup.Size = new System.Drawing.Size(1220, 40);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1096, 10);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(1143, 7);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnBusqClient);
            this.gbxDatos.Controls.Add(this.cboVendedor);
            this.gbxDatos.Controls.Add(this.txtRef);
            this.gbxDatos.Controls.Add(this.cboCliente);
            this.gbxDatos.Controls.Add(this.label7);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.SetChildIndex(this.label6, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtObs, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label3, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label5, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label7, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboCliente, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtRef, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboVendedor, 0);
            this.gbxDatos.Controls.SetChildIndex(this.btnBusqClient, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Size = new System.Drawing.Size(938, 23);
            this.lblFecha.Text = "03/12/2019";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDscto);
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtTotales);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(41, 0);
            this.panel3.Size = new System.Drawing.Size(1179, 433);
            this.panel3.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel3.Controls.SetChildIndex(this.pbxImg, 0);
            this.panel3.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel3.Controls.SetChildIndex(this.gbxDatos, 0);
            this.panel3.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotales, 0);
            this.panel3.Controls.SetChildIndex(this.label10, 0);
            this.panel3.Controls.SetChildIndex(this.label16, 0);
            this.panel3.Controls.SetChildIndex(this.txtSubtotal, 0);
            this.panel3.Controls.SetChildIndex(this.txtDscto, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(667, 373);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(786, 373);
            // 
            // lblNomBusqProd
            // 
            this.lblNomBusqProd.Size = new System.Drawing.Size(0, 34);
            // 
            // btnAbriCerrarPanel
            // 
            this.btnAbriCerrarPanel.BackColor = System.Drawing.Color.LightPink;
            this.btnAbriCerrarPanel.Location = new System.Drawing.Point(-2, 0);
            this.btnAbriCerrarPanel.UseVisualStyleBackColor = false;
            // 
            // panelBusqProd
            // 
            this.panelBusqProd.BackColor = System.Drawing.Color.DimGray;
            this.panelBusqProd.Size = new System.Drawing.Size(41, 433);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1220, 433);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Size = new System.Drawing.Size(1169, 135);
            // 
            // btnBusqClient
            // 
            this.btnBusqClient.ImageIndex = 14;
            this.btnBusqClient.Location = new System.Drawing.Point(361, 21);
            this.btnBusqClient.Name = "btnBusqClient";
            this.btnBusqClient.Size = new System.Drawing.Size(33, 23);
            this.btnBusqClient.TabIndex = 68;
            this.btnBusqClient.Text = "......";
            this.btnBusqClient.UseVisualStyleBackColor = true;
            this.btnBusqClient.Click += new System.EventHandler(this.btnBusqClient_Click);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(103, 54);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(291, 24);
            this.cboVendedor.TabIndex = 67;
            // 
            // txtRef
            // 
            this.txtRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef.Location = new System.Drawing.Point(498, 24);
            this.txtRef.MaxLength = 50;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(183, 22);
            this.txtRef.TabIndex = 66;
            this.txtRef.Text = "S/N";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(103, 21);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(252, 24);
            this.cboCliente.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Referencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cliente:";
            // 
            // txtTotales
            // 
            this.txtTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold);
            this.txtTotales.Location = new System.Drawing.Point(178, 380);
            this.txtTotales.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.ReadOnly = true;
            this.txtTotales.Size = new System.Drawing.Size(200, 45);
            this.txtTotales.TabIndex = 67;
            this.txtTotales.Text = "0.00";
            this.txtTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(9, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 68;
            this.label2.Text = "TOTAL:";
            // 
            // txtDscto
            // 
            this.txtDscto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDscto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDscto.Location = new System.Drawing.Point(177, 338);
            this.txtDscto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDscto.MaxLength = 7;
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.Size = new System.Drawing.Size(200, 38);
            this.txtDscto.TabIndex = 71;
            this.txtDscto.Text = "0.00";
            this.txtDscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDscto.TextChanged += new System.EventHandler(this.txtDscto_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(177, 296);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(200, 38);
            this.txtSubtotal.TabIndex = 72;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 31);
            this.label16.TabIndex = 69;
            this.label16.Text = "DSCTO.:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 31);
            this.label10.TabIndex = 70;
            this.label10.Text = "SUBTOTAL:";
            // 
            // Frm_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 473);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedidos_FormClosing);
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusqClient;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDscto;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
    }
}
