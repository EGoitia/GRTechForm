namespace GRTechnology1._0
{
    partial class Frm_Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBusqClient = new System.Windows.Forms.Button();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.cboTipoVenta = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.panelSup.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panelSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            this.panelSup.Size = new System.Drawing.Size(1220, 40);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1114, 10);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(1161, 7);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnBusqClient);
            this.gbxDatos.Controls.Add(this.cboVendedor);
            this.gbxDatos.Controls.Add(this.txtRef);
            this.gbxDatos.Controls.Add(this.cboTipoVenta);
            this.gbxDatos.Controls.Add(this.cboCliente);
            this.gbxDatos.Controls.Add(this.label7);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.label4);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.SetChildIndex(this.label6, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtObs, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label3, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label4, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label5, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label7, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboCliente, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboTipoVenta, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtRef, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboVendedor, 0);
            this.gbxDatos.Controls.SetChildIndex(this.btnBusqClient, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Size = new System.Drawing.Size(956, 23);
            this.lblFecha.Text = "19/09/2019";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDscto);
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtTotales);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panelSaldo);
            this.panel3.Location = new System.Drawing.Point(41, 0);
            this.panel3.Size = new System.Drawing.Size(1179, 433);
            this.panel3.Controls.SetChildIndex(this.panelSaldo, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotales, 0);
            this.panel3.Controls.SetChildIndex(this.label10, 0);
            this.panel3.Controls.SetChildIndex(this.label16, 0);
            this.panel3.Controls.SetChildIndex(this.txtSubtotal, 0);
            this.panel3.Controls.SetChildIndex(this.txtDscto, 0);
            this.panel3.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel3.Controls.SetChildIndex(this.pbxImg, 0);
            this.panel3.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel3.Controls.SetChildIndex(this.gbxDatos, 0);
            this.panel3.Controls.SetChildIndex(this.dgvDetalle, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(685, 370);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(804, 370);
            // 
            // lblNomBusqProd
            // 
            this.lblNomBusqProd.Size = new System.Drawing.Size(0, 34);
            // 
            // btnAbriCerrarPanel
            // 
            this.btnAbriCerrarPanel.Location = new System.Drawing.Point(-2, 0);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeight = 46;
            this.dgvDetalle.Size = new System.Drawing.Size(1178, 135);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // btnBusqClient
            // 
            this.btnBusqClient.ImageIndex = 14;
            this.btnBusqClient.Location = new System.Drawing.Point(361, 24);
            this.btnBusqClient.Name = "btnBusqClient";
            this.btnBusqClient.Size = new System.Drawing.Size(33, 23);
            this.btnBusqClient.TabIndex = 59;
            this.btnBusqClient.Text = "......";
            this.btnBusqClient.UseVisualStyleBackColor = true;
            this.btnBusqClient.Click += new System.EventHandler(this.btnBusqClient_Click);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(103, 57);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(291, 24);
            this.cboVendedor.TabIndex = 58;
            // 
            // txtRef
            // 
            this.txtRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef.Location = new System.Drawing.Point(498, 27);
            this.txtRef.MaxLength = 50;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(183, 22);
            this.txtRef.TabIndex = 57;
            this.txtRef.Text = "S/N";
            // 
            // cboTipoVenta
            // 
            this.cboTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoVenta.FormattingEnabled = true;
            this.cboTipoVenta.Location = new System.Drawing.Point(518, 57);
            this.cboTipoVenta.Name = "cboTipoVenta";
            this.cboTipoVenta.Size = new System.Drawing.Size(163, 24);
            this.cboTipoVenta.TabIndex = 56;
            this.cboTipoVenta.SelectedIndexChanged += new System.EventHandler(this.cboTipoVenta_SelectedIndexChanged);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(103, 24);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(252, 24);
            this.cboCliente.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Referencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tipo de Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Cliente:";
            // 
            // panelSaldo
            // 
            this.panelSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSaldo.Controls.Add(this.txtSaldo);
            this.panelSaldo.Controls.Add(this.txtAnticipo);
            this.panelSaldo.Controls.Add(this.label9);
            this.panelSaldo.Controls.Add(this.label8);
            this.panelSaldo.Location = new System.Drawing.Point(407, 366);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(208, 58);
            this.panelSaldo.TabIndex = 64;
            this.panelSaldo.Visible = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(111, 30);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(94, 26);
            this.txtSaldo.TabIndex = 63;
            this.txtSaldo.Text = "0.00";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnticipo.Location = new System.Drawing.Point(111, 1);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.ReadOnly = true;
            this.txtAnticipo.Size = new System.Drawing.Size(94, 26);
            this.txtAnticipo.TabIndex = 63;
            this.txtAnticipo.Text = "0.00";
            this.txtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 62;
            this.label9.Text = "SALDO:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 62;
            this.label8.Text = "ANTICIPO:";
            // 
            // txtTotales
            // 
            this.txtTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotales.Location = new System.Drawing.Point(178, 379);
            this.txtTotales.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.ReadOnly = true;
            this.txtTotales.Size = new System.Drawing.Size(200, 45);
            this.txtTotales.TabIndex = 65;
            this.txtTotales.Text = "0.00";
            this.txtTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 66;
            this.label2.Text = "TOTAL:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 31);
            this.label10.TabIndex = 67;
            this.label10.Text = "SUBTOTAL:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(178, 295);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(200, 38);
            this.txtSubtotal.TabIndex = 68;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 31);
            this.label16.TabIndex = 67;
            this.label16.Text = "DSCTO.:";
            // 
            // txtDscto
            // 
            this.txtDscto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDscto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDscto.Location = new System.Drawing.Point(178, 337);
            this.txtDscto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDscto.MaxLength = 7;
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.Size = new System.Drawing.Size(200, 38);
            this.txtDscto.TabIndex = 68;
            this.txtDscto.Text = "0.00";
            this.txtDscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDscto.TextChanged += new System.EventHandler(this.txtDscto_TextChanged);
            // 
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 473);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Venta";
            this.Text = "VENTA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Venta_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Venta_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusqClient;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.ComboBox cboTipoVenta;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDscto;
    }
}
