namespace GRTechnology1._0
{
    partial class Frm_ValidacionFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidacionFactura));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.txtCodigoControl = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblAutorizacion = new System.Windows.Forms.Label();
            this.LblFactura = new System.Windows.Forms.Label();
            this.LblNit = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.LblMonto = new System.Windows.Forms.Label();
            this.LblLlave = new System.Windows.Forms.Label();
            this.txtAutorizacion = new System.Windows.Forms.NumericUpDown();
            this.txtNumFactura = new System.Windows.Forms.NumericUpDown();
            this.txtNIT = new System.Windows.Forms.NumericUpDown();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutorizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtMonto);
            this.GroupBox1.Controls.Add(this.txtNIT);
            this.GroupBox1.Controls.Add(this.txtNumFactura);
            this.GroupBox1.Controls.Add(this.txtAutorizacion);
            this.GroupBox1.Controls.Add(this.BtnGenerar);
            this.GroupBox1.Controls.Add(this.BtnLimpiar);
            this.GroupBox1.Controls.Add(this.txtLlave);
            this.GroupBox1.Controls.Add(this.txtCodigoControl);
            this.GroupBox1.Controls.Add(this.LblCodigo);
            this.GroupBox1.Controls.Add(this.LblAutorizacion);
            this.GroupBox1.Controls.Add(this.LblFactura);
            this.GroupBox1.Controls.Add(this.LblNit);
            this.GroupBox1.Controls.Add(this.LblFecha);
            this.GroupBox1.Controls.Add(this.dtFecha);
            this.GroupBox1.Controls.Add(this.LblMonto);
            this.GroupBox1.Controls.Add(this.LblLlave);
            this.GroupBox1.Location = new System.Drawing.Point(7, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(632, 304);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.White;
            this.BtnGenerar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerar.Image")));
            this.BtnGenerar.Location = new System.Drawing.Point(128, 216);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(80, 30);
            this.BtnGenerar.TabIndex = 6;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.White;
            this.BtnLimpiar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(224, 216);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(80, 30);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtLlave
            // 
            this.txtLlave.Font = new System.Drawing.Font("Calisto MT", 8.25F);
            this.txtLlave.Location = new System.Drawing.Point(128, 24);
            this.txtLlave.MaxLength = 200;
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(488, 20);
            this.txtLlave.TabIndex = 0;
            // 
            // txtCodigoControl
            // 
            this.txtCodigoControl.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoControl.Location = new System.Drawing.Point(128, 256);
            this.txtCodigoControl.Name = "txtCodigoControl";
            this.txtCodigoControl.ReadOnly = true;
            this.txtCodigoControl.Size = new System.Drawing.Size(240, 29);
            this.txtCodigoControl.TabIndex = 8;
            this.txtCodigoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCodigo
            // 
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodigo.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.LblCodigo.Location = new System.Drawing.Point(16, 256);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(104, 32);
            this.LblCodigo.TabIndex = 13;
            this.LblCodigo.Text = "Codigo de Control:";
            this.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAutorizacion
            // 
            this.LblAutorizacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAutorizacion.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.LblAutorizacion.Location = new System.Drawing.Point(16, 56);
            this.LblAutorizacion.Name = "LblAutorizacion";
            this.LblAutorizacion.Size = new System.Drawing.Size(104, 20);
            this.LblAutorizacion.TabIndex = 1;
            this.LblAutorizacion.Text = "Autorización:";
            this.LblAutorizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFactura
            // 
            this.LblFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFactura.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.LblFactura.Location = new System.Drawing.Point(16, 88);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(104, 20);
            this.LblFactura.TabIndex = 3;
            this.LblFactura.Text = "Nro. de Factura:";
            this.LblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblNit
            // 
            this.LblNit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNit.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.LblNit.Location = new System.Drawing.Point(16, 120);
            this.LblNit.Name = "LblNit";
            this.LblNit.Size = new System.Drawing.Size(104, 20);
            this.LblNit.TabIndex = 5;
            this.LblNit.Text = "Nit:";
            this.LblNit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFecha
            // 
            this.LblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFecha.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.LblFecha.Location = new System.Drawing.Point(16, 152);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(104, 20);
            this.LblFecha.TabIndex = 6;
            this.LblFecha.Text = "Fecha:";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Calisto MT", 8.25F);
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(128, 152);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(108, 20);
            this.dtFecha.TabIndex = 4;
            // 
            // LblMonto
            // 
            this.LblMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMonto.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.LblMonto.Location = new System.Drawing.Point(16, 184);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(104, 20);
            this.LblMonto.TabIndex = 8;
            this.LblMonto.Text = "Monto:";
            this.LblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLlave
            // 
            this.LblLlave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLlave.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.LblLlave.Location = new System.Drawing.Point(16, 24);
            this.LblLlave.Name = "LblLlave";
            this.LblLlave.Size = new System.Drawing.Size(104, 20);
            this.LblLlave.TabIndex = 10;
            this.LblLlave.Text = "Llave:";
            this.LblLlave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAutorizacion
            // 
            this.txtAutorizacion.Location = new System.Drawing.Point(128, 56);
            this.txtAutorizacion.Name = "txtAutorizacion";
            this.txtAutorizacion.Size = new System.Drawing.Size(255, 20);
            this.txtAutorizacion.TabIndex = 1;
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(128, 88);
            this.txtNumFactura.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(108, 20);
            this.txtNumFactura.TabIndex = 2;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(128, 120);
            this.txtNIT.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(108, 20);
            this.txtNIT.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.DecimalPlaces = 2;
            this.txtMonto.Location = new System.Drawing.Point(128, 184);
            this.txtMonto.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(108, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // Frm_ValidacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 315);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ValidacionFactura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validación Factura";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutorizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button BtnGenerar;
        internal System.Windows.Forms.Button BtnLimpiar;
        internal System.Windows.Forms.TextBox txtLlave;
        internal System.Windows.Forms.TextBox txtCodigoControl;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label LblAutorizacion;
        internal System.Windows.Forms.Label LblFactura;
        internal System.Windows.Forms.Label LblNit;
        internal System.Windows.Forms.Label LblFecha;
        internal System.Windows.Forms.DateTimePicker dtFecha;
        internal System.Windows.Forms.Label LblMonto;
        internal System.Windows.Forms.Label LblLlave;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.NumericUpDown txtNIT;
        private System.Windows.Forms.NumericUpDown txtNumFactura;
        private System.Windows.Forms.NumericUpDown txtAutorizacion;
    }
}