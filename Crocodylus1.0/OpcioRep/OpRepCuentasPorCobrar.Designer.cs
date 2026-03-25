namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepCuentasPorCobrar
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboRepEn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrdenado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSuc = new System.Windows.Forms.ComboBox();
            this.lblDescOpcion = new System.Windows.Forms.Label();
            this.cboRepPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotDevol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotSal = new System.Windows.Forms.TextBox();
            this.txtTotPag = new System.Windows.Forms.TextBox();
            this.txtTotDscto = new System.Windows.Forms.TextBox();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnProcesar);
            this.groupBox3.Location = new System.Drawing.Point(8, 215);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(232, 75);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(113, 23);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(15, 23);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(100, 36);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboRepEn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboCli);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboOrdenado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtFecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboSuc);
            this.groupBox2.Controls.Add(this.lblDescOpcion);
            this.groupBox2.Controls.Add(this.cboRepPor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(433, 209);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // cboRepEn
            // 
            this.cboRepEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRepEn.FormattingEnabled = true;
            this.cboRepEn.Items.AddRange(new object[] {
            "Empresa",
            "Sucursal"});
            this.cboRepEn.Location = new System.Drawing.Point(136, 83);
            this.cboRepEn.Name = "cboRepEn";
            this.cboRepEn.Size = new System.Drawing.Size(279, 24);
            this.cboRepEn.TabIndex = 18;
            this.cboRepEn.SelectedValueChanged += new System.EventHandler(this.cboRepEn_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Buscar en.............";
            // 
            // cboCli
            // 
            this.cboCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCli.FormattingEnabled = true;
            this.cboCli.Location = new System.Drawing.Point(136, 53);
            this.cboCli.Name = "cboCli";
            this.cboCli.Size = new System.Drawing.Size(279, 24);
            this.cboCli.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente.....................";
            // 
            // cboOrdenado
            // 
            this.cboOrdenado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrdenado.FormattingEnabled = true;
            this.cboOrdenado.Items.AddRange(new object[] {
            "Razon Social",
            "Saldo por Cobrar"});
            this.cboOrdenado.Location = new System.Drawing.Point(136, 169);
            this.cboOrdenado.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrdenado.Name = "cboOrdenado";
            this.cboOrdenado.Size = new System.Drawing.Size(279, 24);
            this.cboOrdenado.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ordenado por.......";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(136, 142);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(279, 22);
            this.dtFecha.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha..................";
            // 
            // cboSuc
            // 
            this.cboSuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSuc.FormattingEnabled = true;
            this.cboSuc.Location = new System.Drawing.Point(136, 113);
            this.cboSuc.Margin = new System.Windows.Forms.Padding(4);
            this.cboSuc.Name = "cboSuc";
            this.cboSuc.Size = new System.Drawing.Size(279, 24);
            this.cboSuc.TabIndex = 5;
            // 
            // lblDescOpcion
            // 
            this.lblDescOpcion.AutoSize = true;
            this.lblDescOpcion.Location = new System.Drawing.Point(23, 124);
            this.lblDescOpcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescOpcion.Name = "lblDescOpcion";
            this.lblDescOpcion.Size = new System.Drawing.Size(119, 17);
            this.lblDescOpcion.TabIndex = 4;
            this.lblDescOpcion.Text = "Sucursal..............";
            // 
            // cboRepPor
            // 
            this.cboRepPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRepPor.FormattingEnabled = true;
            this.cboRepPor.Items.AddRange(new object[] {
            "Cliente",
            "Totales"});
            this.cboRepPor.Location = new System.Drawing.Point(136, 22);
            this.cboRepPor.Margin = new System.Windows.Forms.Padding(4);
            this.cboRepPor.Name = "cboRepPor";
            this.cboRepPor.Size = new System.Drawing.Size(279, 24);
            this.cboRepPor.TabIndex = 0;
            this.cboRepPor.SelectedValueChanged += new System.EventHandler(this.cboRepPor_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte por..........";
            // 
            // dgvDeudas
            // 
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Location = new System.Drawing.Point(448, 37);
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.RowTemplate.Height = 24;
            this.dgvDeudas.Size = new System.Drawing.Size(1122, 306);
            this.dgvDeudas.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1305, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "BUSCADOR: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1407, 7);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(163, 22);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(448, 4);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(87, 29);
            this.btnImp.TabIndex = 11;
            this.btnImp.Text = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(538, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(87, 29);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "Registro";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotDevol);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTotSal);
            this.groupBox1.Controls.Add(this.txtTotPag);
            this.groupBox1.Controls.Add(this.txtTotDscto);
            this.groupBox1.Controls.Add(this.txtTot);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(448, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 58);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales Global";
            // 
            // txtTotDevol
            // 
            this.txtTotDevol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotDevol.Location = new System.Drawing.Point(721, 22);
            this.txtTotDevol.Name = "txtTotDevol";
            this.txtTotDevol.ReadOnly = true;
            this.txtTotDevol.Size = new System.Drawing.Size(145, 22);
            this.txtTotDevol.TabIndex = 21;
            this.txtTotDevol.Text = "0.00";
            this.txtTotDevol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(655, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Devol. ......";
            // 
            // txtTotSal
            // 
            this.txtTotSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSal.Location = new System.Drawing.Point(959, 22);
            this.txtTotSal.Name = "txtTotSal";
            this.txtTotSal.ReadOnly = true;
            this.txtTotSal.Size = new System.Drawing.Size(145, 22);
            this.txtTotSal.TabIndex = 19;
            this.txtTotSal.Text = "0.00";
            this.txtTotSal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotPag
            // 
            this.txtTotPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPag.Location = new System.Drawing.Point(493, 22);
            this.txtTotPag.Name = "txtTotPag";
            this.txtTotPag.ReadOnly = true;
            this.txtTotPag.Size = new System.Drawing.Size(145, 22);
            this.txtTotPag.TabIndex = 18;
            this.txtTotPag.Text = "0.00";
            this.txtTotPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotDscto
            // 
            this.txtTotDscto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotDscto.Location = new System.Drawing.Point(296, 22);
            this.txtTotDscto.Name = "txtTotDscto";
            this.txtTotDscto.ReadOnly = true;
            this.txtTotDscto.Size = new System.Drawing.Size(100, 22);
            this.txtTotDscto.TabIndex = 17;
            this.txtTotDscto.Text = "0.00";
            this.txtTotDscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTot
            // 
            this.txtTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTot.Location = new System.Drawing.Point(78, 22);
            this.txtTot.Name = "txtTot";
            this.txtTot.ReadOnly = true;
            this.txtTot.Size = new System.Drawing.Size(145, 22);
            this.txtTot.TabIndex = 16;
            this.txtTot.Text = "0.00";
            this.txtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(890, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Saldo........";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(414, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Pagado.......";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Dscto.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total......";
            // 
            // OpRepCuentasPorCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1582, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDeudas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Location = new System.Drawing.Point(1600, 461);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 461);
            this.MinimizeBox = false;
            this.Name = "OpRepCuentasPorCobrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepCuentasPorCobrar_FormClosing);
            this.Load += new System.EventHandler(this.OpRepCuentasPorCobrar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboOrdenado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSuc;
        private System.Windows.Forms.Label lblDescOpcion;
        private System.Windows.Forms.ComboBox cboRepPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRepEn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDeudas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotSal;
        private System.Windows.Forms.TextBox txtTotPag;
        private System.Windows.Forms.TextBox txtTotDscto;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotDevol;
        private System.Windows.Forms.Label label7;
    }
}