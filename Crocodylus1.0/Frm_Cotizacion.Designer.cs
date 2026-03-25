namespace GRTechnology1._0
{
    partial class Frm_Cotizacion
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
            this.cboCodCom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumUpDownValidez = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBusqCondCom = new System.Windows.Forms.Button();
            this.panelSup.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownValidez)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.SeaGreen;
            this.panelSup.Size = new System.Drawing.Size(1247, 40);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1174, 10);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(1221, 7);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(103, 126);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 129);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnBusqCondCom);
            this.gbxDatos.Controls.Add(this.label9);
            this.gbxDatos.Controls.Add(this.NumUpDownValidez);
            this.gbxDatos.Controls.Add(this.label8);
            this.gbxDatos.Controls.Add(this.cboCodCom);
            this.gbxDatos.Controls.Add(this.label4);
            this.gbxDatos.Controls.Add(this.btnBusqClient);
            this.gbxDatos.Controls.Add(this.cboVendedor);
            this.gbxDatos.Controls.Add(this.txtRef);
            this.gbxDatos.Controls.Add(this.cboCliente);
            this.gbxDatos.Controls.Add(this.label7);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Size = new System.Drawing.Size(700, 175);
            this.gbxDatos.Controls.SetChildIndex(this.label6, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtObs, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label3, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label5, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label7, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboCliente, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtRef, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboVendedor, 0);
            this.gbxDatos.Controls.SetChildIndex(this.btnBusqClient, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label4, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboCodCom, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label8, 0);
            this.gbxDatos.Controls.SetChildIndex(this.NumUpDownValidez, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label9, 0);
            this.gbxDatos.Controls.SetChildIndex(this.btnBusqCondCom, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Size = new System.Drawing.Size(1009, 23);
            this.lblFecha.Text = "29/09/2019";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotales);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Size = new System.Drawing.Size(930, 433);
            this.panel3.Controls.SetChildIndex(this.pbxImg, 0);
            this.panel3.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel3.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel3.Controls.SetChildIndex(this.gbxDatos, 0);
            this.panel3.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotales, 0);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Location = new System.Drawing.Point(6, 187);
            this.dgvDetalle.Size = new System.Drawing.Size(937, 170);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(716, 363);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(835, 363);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1247, 433);
            // 
            // btnBusqClient
            // 
            this.btnBusqClient.ImageIndex = 14;
            this.btnBusqClient.Location = new System.Drawing.Point(361, 21);
            this.btnBusqClient.Name = "btnBusqClient";
            this.btnBusqClient.Size = new System.Drawing.Size(33, 23);
            this.btnBusqClient.TabIndex = 66;
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
            this.cboVendedor.TabIndex = 65;
            // 
            // txtRef
            // 
            this.txtRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef.Location = new System.Drawing.Point(498, 24);
            this.txtRef.MaxLength = 50;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(183, 22);
            this.txtRef.TabIndex = 64;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(103, 21);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(252, 24);
            this.cboCliente.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 61;
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
            this.txtTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotales.Location = new System.Drawing.Point(149, 367);
            this.txtTotales.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.ReadOnly = true;
            this.txtTotales.Size = new System.Drawing.Size(270, 53);
            this.txtTotales.TabIndex = 67;
            this.txtTotales.Text = "0.00";
            this.txtTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 39);
            this.label2.TabIndex = 68;
            this.label2.Text = "TOTAL:";
            // 
            // cboCodCom
            // 
            this.cboCodCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCodCom.FormattingEnabled = true;
            this.cboCodCom.Location = new System.Drawing.Point(103, 88);
            this.cboCodCom.Name = "cboCodCom";
            this.cboCodCom.Size = new System.Drawing.Size(540, 24);
            this.cboCodCom.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Condición:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "Validéz:";
            // 
            // NumUpDownValidez
            // 
            this.NumUpDownValidez.Location = new System.Drawing.Point(498, 56);
            this.NumUpDownValidez.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.NumUpDownValidez.Name = "NumUpDownValidez";
            this.NumUpDownValidez.Size = new System.Drawing.Size(60, 22);
            this.NumUpDownValidez.TabIndex = 70;
            this.NumUpDownValidez.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 71;
            this.label9.Text = "días";
            // 
            // btnBusqCondCom
            // 
            this.btnBusqCondCom.ImageIndex = 14;
            this.btnBusqCondCom.Location = new System.Drawing.Point(648, 89);
            this.btnBusqCondCom.Name = "btnBusqCondCom";
            this.btnBusqCondCom.Size = new System.Drawing.Size(33, 23);
            this.btnBusqCondCom.TabIndex = 72;
            this.btnBusqCondCom.Text = "......";
            this.btnBusqCondCom.UseVisualStyleBackColor = true;
            this.btnBusqCondCom.Click += new System.EventHandler(this.btnBusqCondCom_Click);
            // 
            // Frm_Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1247, 473);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Cotizacion";
            this.Text = "COTIZACIÓN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Cotizacion_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Cotizacion_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownValidez)).EndInit();
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
        private System.Windows.Forms.ComboBox cboCodCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NumUpDownValidez;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBusqCondCom;
    }
}
