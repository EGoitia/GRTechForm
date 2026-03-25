namespace GRTechPOS
{
    partial class Frm_PagoPos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQR = new System.Windows.Forms.NumericUpDown();
            this.txtTarj = new System.Windows.Forms.NumericUpDown();
            this.txtEfec = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTotPagado = new System.Windows.Forms.NumericUpDown();
            this.txtTotCambio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotImporte = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelTipoPago = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEfec = new System.Windows.Forms.PictureBox();
            this.btnTar = new System.Windows.Forms.PictureBox();
            this.btnQR = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfec)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotPagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotImporte)).BeginInit();
            this.flowLayoutPanelTipoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEfec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQR);
            this.panel1.Controls.Add(this.txtTarj);
            this.panel1.Controls.Add(this.txtEfec);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtTotPagado);
            this.panel1.Controls.Add(this.txtTotCambio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTotImporte);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanelTipoPago);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 391);
            this.panel1.TabIndex = 0;
            // 
            // txtQR
            // 
            this.txtQR.DecimalPlaces = 2;
            this.txtQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQR.Location = new System.Drawing.Point(132, 160);
            this.txtQR.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            131072});
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(381, 49);
            this.txtQR.TabIndex = 26;
            this.txtQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTarj
            // 
            this.txtTarj.DecimalPlaces = 2;
            this.txtTarj.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarj.Location = new System.Drawing.Point(132, 90);
            this.txtTarj.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            131072});
            this.txtTarj.Name = "txtTarj";
            this.txtTarj.Size = new System.Drawing.Size(381, 49);
            this.txtTarj.TabIndex = 23;
            this.txtTarj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEfec
            // 
            this.txtEfec.DecimalPlaces = 2;
            this.txtEfec.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfec.Location = new System.Drawing.Point(132, 23);
            this.txtEfec.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            131072});
            this.txtEfec.Name = "txtEfec";
            this.txtEfec.Size = new System.Drawing.Size(381, 49);
            this.txtEfec.TabIndex = 20;
            this.txtEfec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btnComa);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Location = new System.Drawing.Point(536, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 269);
            this.panel2.TabIndex = 27;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(135, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 60);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "AC";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Gold;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(201, 68);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 192);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Wheat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(3, 200);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Wheat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 134);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btnComa
            // 
            this.btnComa.BackColor = System.Drawing.Color.Wheat;
            this.btnComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComa.Location = new System.Drawing.Point(69, 200);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(60, 60);
            this.btnComa.TabIndex = 10;
            this.btnComa.Text = ".";
            this.btnComa.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Wheat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 68);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Wheat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(201, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(60, 60);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "<<<";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Wheat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(69, 134);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Wheat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Wheat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(135, 134);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Wheat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(69, 68);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Wheat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(135, 68);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Wheat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(69, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Wheat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(135, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(688, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 76);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(569, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 76);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtTotPagado
            // 
            this.txtTotPagado.DecimalPlaces = 2;
            this.txtTotPagado.Enabled = false;
            this.txtTotPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPagado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTotPagado.Location = new System.Drawing.Point(224, 287);
            this.txtTotPagado.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtTotPagado.Name = "txtTotPagado";
            this.txtTotPagado.Size = new System.Drawing.Size(120, 29);
            this.txtTotPagado.TabIndex = 24;
            this.txtTotPagado.TabStop = false;
            this.txtTotPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotCambio
            // 
            this.txtTotCambio.DecimalPlaces = 2;
            this.txtTotCambio.Enabled = false;
            this.txtTotCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotCambio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTotCambio.Location = new System.Drawing.Point(224, 323);
            this.txtTotCambio.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtTotCambio.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.txtTotCambio.Name = "txtTotCambio";
            this.txtTotCambio.Size = new System.Drawing.Size(120, 29);
            this.txtTotCambio.TabIndex = 25;
            this.txtTotCambio.TabStop = false;
            this.txtTotCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "TOTAL PAGADO:";
            // 
            // txtTotImporte
            // 
            this.txtTotImporte.DecimalPlaces = 2;
            this.txtTotImporte.Enabled = false;
            this.txtTotImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTotImporte.Location = new System.Drawing.Point(224, 252);
            this.txtTotImporte.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtTotImporte.Name = "txtTotImporte";
            this.txtTotImporte.Size = new System.Drawing.Size(120, 29);
            this.txtTotImporte.TabIndex = 32;
            this.txtTotImporte.TabStop = false;
            this.txtTotImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "CAMBIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "TOTAL IMPORTE:";
            // 
            // flowLayoutPanelTipoPago
            // 
            this.flowLayoutPanelTipoPago.Controls.Add(this.btnEfec);
            this.flowLayoutPanelTipoPago.Controls.Add(this.btnTar);
            this.flowLayoutPanelTipoPago.Controls.Add(this.btnQR);
            this.flowLayoutPanelTipoPago.Location = new System.Drawing.Point(14, 9);
            this.flowLayoutPanelTipoPago.Name = "flowLayoutPanelTipoPago";
            this.flowLayoutPanelTipoPago.Size = new System.Drawing.Size(102, 219);
            this.flowLayoutPanelTipoPago.TabIndex = 28;
            // 
            // btnEfec
            // 
            this.btnEfec.BackColor = System.Drawing.Color.Gold;
            this.btnEfec.Location = new System.Drawing.Point(3, 3);
            this.btnEfec.Name = "btnEfec";
            this.btnEfec.Size = new System.Drawing.Size(93, 65);
            this.btnEfec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEfec.TabIndex = 0;
            this.btnEfec.TabStop = false;
            // 
            // btnTar
            // 
            this.btnTar.BackColor = System.Drawing.Color.Crimson;
            this.btnTar.Location = new System.Drawing.Point(3, 74);
            this.btnTar.Name = "btnTar";
            this.btnTar.Size = new System.Drawing.Size(93, 65);
            this.btnTar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTar.TabIndex = 1;
            this.btnTar.TabStop = false;
            // 
            // btnQR
            // 
            this.btnQR.BackColor = System.Drawing.Color.Crimson;
            this.btnQR.Location = new System.Drawing.Point(3, 145);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(93, 65);
            this.btnQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQR.TabIndex = 2;
            this.btnQR.TabStop = false;
            // 
            // Frm_PagoPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 391);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_PagoPos";
            this.Text = "PagoPos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfec)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotPagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotImporte)).EndInit();
            this.flowLayoutPanelTipoPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEfec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown txtQR;
        public System.Windows.Forms.NumericUpDown txtTarj;
        public System.Windows.Forms.NumericUpDown txtEfec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.NumericUpDown txtTotPagado;
        public System.Windows.Forms.NumericUpDown txtTotCambio;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown txtTotImporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTipoPago;
        private System.Windows.Forms.PictureBox btnEfec;
        private System.Windows.Forms.PictureBox btnTar;
        private System.Windows.Forms.PictureBox btnQR;
    }
}