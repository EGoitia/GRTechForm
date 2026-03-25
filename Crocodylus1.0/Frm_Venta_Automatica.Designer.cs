namespace GRTechnology1._0
{
    partial class Frm_Venta_Automatica
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
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxEjecucion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTiempoEjec = new System.Windows.Forms.ComboBox();
            this.panelSup.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.gbxEjecucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(114, 53);
            this.txtObs.Size = new System.Drawing.Size(573, 40);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 56);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnBusqClient);
            this.gbxDatos.Controls.Add(this.cboCliente);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Size = new System.Drawing.Size(700, 100);
            this.gbxDatos.Controls.SetChildIndex(this.label6, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtObs, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label3, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboCliente, 0);
            this.gbxDatos.Controls.SetChildIndex(this.btnBusqClient, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Text = "06/01/2021";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbxEjecucion);
            this.panel3.Controls.Add(this.txtDscto);
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtTotales);
            this.panel3.Controls.Add(this.label2);
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
            this.panel3.Controls.SetChildIndex(this.gbxEjecucion, 0);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Location = new System.Drawing.Point(6, 173);
            this.dgvDetalle.Size = new System.Drawing.Size(883, 120);
            // 
            // btnBusqClient
            // 
            this.btnBusqClient.ImageIndex = 14;
            this.btnBusqClient.Location = new System.Drawing.Point(420, 22);
            this.btnBusqClient.Name = "btnBusqClient";
            this.btnBusqClient.Size = new System.Drawing.Size(33, 23);
            this.btnBusqClient.TabIndex = 62;
            this.btnBusqClient.Text = "......";
            this.btnBusqClient.UseVisualStyleBackColor = true;
            this.btnBusqClient.Click += new System.EventHandler(this.btnBusqClient_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(114, 22);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(300, 24);
            this.cboCliente.TabIndex = 61;
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
            // txtDscto
            // 
            this.txtDscto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDscto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDscto.Location = new System.Drawing.Point(186, 341);
            this.txtDscto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDscto.MaxLength = 7;
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.Size = new System.Drawing.Size(200, 38);
            this.txtDscto.TabIndex = 73;
            this.txtDscto.Text = "0.00";
            this.txtDscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDscto.TextChanged += new System.EventHandler(this.txtDscto_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(186, 299);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(200, 38);
            this.txtSubtotal.TabIndex = 74;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 31);
            this.label16.TabIndex = 71;
            this.label16.Text = "DSCTO.:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 31);
            this.label10.TabIndex = 72;
            this.label10.Text = "SUBTOTAL:";
            // 
            // txtTotales
            // 
            this.txtTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotales.Location = new System.Drawing.Point(186, 383);
            this.txtTotales.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.ReadOnly = true;
            this.txtTotales.Size = new System.Drawing.Size(200, 45);
            this.txtTotales.TabIndex = 69;
            this.txtTotales.Text = "0.00";
            this.txtTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 70;
            this.label2.Text = "TOTAL:";
            // 
            // gbxEjecucion
            // 
            this.gbxEjecucion.Controls.Add(this.cboTiempoEjec);
            this.gbxEjecucion.Controls.Add(this.label4);
            this.gbxEjecucion.Location = new System.Drawing.Point(6, 105);
            this.gbxEjecucion.Name = "gbxEjecucion";
            this.gbxEjecucion.Size = new System.Drawing.Size(700, 63);
            this.gbxEjecucion.TabIndex = 75;
            this.gbxEjecucion.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Ejecutar cada:";
            // 
            // cboTiempoEjec
            // 
            this.cboTiempoEjec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiempoEjec.FormattingEnabled = true;
            this.cboTiempoEjec.Items.AddRange(new object[] {
            "DÍA",
            "15 DÍAS",
            "MES",
            "AÑO"});
            this.cboTiempoEjec.Location = new System.Drawing.Point(114, 16);
            this.cboTiempoEjec.Name = "cboTiempoEjec";
            this.cboTiempoEjec.Size = new System.Drawing.Size(121, 21);
            this.cboTiempoEjec.TabIndex = 61;
            // 
            // Frm_Venta_Automatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 473);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Venta_Automatica";
            this.Text = "VENTA AUTOMÁTICA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Venta_Automatica_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Venta_Automatica_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.gbxEjecucion.ResumeLayout(false);
            this.gbxEjecucion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusqClient;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDscto;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxEjecucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTiempoEjec;

    }
}
