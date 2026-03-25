namespace GRTechnology1._0
{
    partial class CierreCaja
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
            this.txtTarjeta = new System.Windows.Forms.NumericUpDown();
            this.txtQR = new System.Windows.Forms.NumericUpDown();
            this.txtEfectivo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEfectivo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEfectivoSus = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDeposito = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.NumericUpDown();
            this.panelTarjeta = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTransferencia = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelEfectivo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivoSus)).BeginInit();
            this.panelDeposito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito)).BeginInit();
            this.panelTarjeta.SuspendLayout();
            this.panelTransferencia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.DecimalPlaces = 2;
            this.txtTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTarjeta.Location = new System.Drawing.Point(186, 10);
            this.txtTarjeta.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(156, 29);
            this.txtTarjeta.TabIndex = 9;
            this.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQR
            // 
            this.txtQR.DecimalPlaces = 2;
            this.txtQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtQR.Location = new System.Drawing.Point(186, 10);
            this.txtQR.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtQR.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(156, 29);
            this.txtQR.TabIndex = 10;
            this.txtQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.DecimalPlaces = 2;
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEfectivo.Location = new System.Drawing.Point(186, 10);
            this.txtEfectivo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(156, 29);
            this.txtEfectivo.TabIndex = 12;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "EFECTIVO Bs.:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelEfectivo);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panelDeposito);
            this.flowLayoutPanel1.Controls.Add(this.panelTarjeta);
            this.flowLayoutPanel1.Controls.Add(this.panelTransferencia);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(495, 494);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panelEfectivo
            // 
            this.panelEfectivo.Controls.Add(this.txtEfectivo);
            this.panelEfectivo.Controls.Add(this.label1);
            this.panelEfectivo.Location = new System.Drawing.Point(3, 3);
            this.panelEfectivo.Name = "panelEfectivo";
            this.panelEfectivo.Size = new System.Drawing.Size(479, 49);
            this.panelEfectivo.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEfectivoSus);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 49);
            this.panel3.TabIndex = 5;
            // 
            // txtEfectivoSus
            // 
            this.txtEfectivoSus.DecimalPlaces = 2;
            this.txtEfectivoSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivoSus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEfectivoSus.Location = new System.Drawing.Point(186, 10);
            this.txtEfectivoSus.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtEfectivoSus.Name = "txtEfectivoSus";
            this.txtEfectivoSus.Size = new System.Drawing.Size(156, 29);
            this.txtEfectivoSus.TabIndex = 12;
            this.txtEfectivoSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "EFECTIVO $us.:";
            // 
            // panelDeposito
            // 
            this.panelDeposito.Controls.Add(this.label3);
            this.panelDeposito.Controls.Add(this.txtDeposito);
            this.panelDeposito.Location = new System.Drawing.Point(3, 113);
            this.panelDeposito.Name = "panelDeposito";
            this.panelDeposito.Size = new System.Drawing.Size(479, 51);
            this.panelDeposito.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "DEPOSITO:";
            // 
            // txtDeposito
            // 
            this.txtDeposito.DecimalPlaces = 2;
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDeposito.Location = new System.Drawing.Point(186, 10);
            this.txtDeposito.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtDeposito.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(156, 29);
            this.txtDeposito.TabIndex = 10;
            this.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelTarjeta
            // 
            this.panelTarjeta.Controls.Add(this.label5);
            this.panelTarjeta.Controls.Add(this.txtTarjeta);
            this.panelTarjeta.Location = new System.Drawing.Point(3, 170);
            this.panelTarjeta.Name = "panelTarjeta";
            this.panelTarjeta.Size = new System.Drawing.Size(479, 51);
            this.panelTarjeta.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "TARJETA:";
            // 
            // panelTransferencia
            // 
            this.panelTransferencia.Controls.Add(this.label2);
            this.panelTransferencia.Controls.Add(this.txtQR);
            this.panelTransferencia.Location = new System.Drawing.Point(3, 227);
            this.panelTransferencia.Name = "panelTransferencia";
            this.panelTransferencia.Size = new System.Drawing.Size(479, 51);
            this.panelTransferencia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "TRANSF./QR:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(3, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 204);
            this.panel1.TabIndex = 3;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(20, 42);
            this.txtObs.MaxLength = 100;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(448, 92);
            this.txtObs.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "OBSERVACIÓN:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(314, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 52);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(512, 506);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CierreCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Caja";
            this.Load += new System.EventHandler(this.frm_CierreCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelEfectivo.ResumeLayout(false);
            this.panelEfectivo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivoSus)).EndInit();
            this.panelDeposito.ResumeLayout(false);
            this.panelDeposito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito)).EndInit();
            this.panelTarjeta.ResumeLayout(false);
            this.panelTarjeta.PerformLayout();
            this.panelTransferencia.ResumeLayout(false);
            this.panelTransferencia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtTarjeta;
        private System.Windows.Forms.NumericUpDown txtQR;
        public System.Windows.Forms.NumericUpDown txtEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelEfectivo;
        private System.Windows.Forms.Panel panelTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtDeposito;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.NumericUpDown txtEfectivoSus;
        private System.Windows.Forms.Label label6;

    }
}