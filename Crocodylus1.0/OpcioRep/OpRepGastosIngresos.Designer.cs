namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepGastosIngresos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscaGastoIngre = new System.Windows.Forms.Button();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cboBusqX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAct = new System.Windows.Forms.Button();
            this.cboBusqEn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOpcionBusq = new System.Windows.Forms.ComboBox();
            this.lblOpcionBusq = new System.Windows.Forms.Label();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscaGastoIngre);
            this.groupBox2.Controls.Add(this.cboOpcion);
            this.groupBox2.Controls.Add(this.lblOpcion);
            this.groupBox2.Controls.Add(this.cboBusqX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(513, 96);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnBuscaGastoIngre
            // 
            this.btnBuscaGastoIngre.ImageIndex = 14;
            this.btnBuscaGastoIngre.Location = new System.Drawing.Point(443, 52);
            this.btnBuscaGastoIngre.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaGastoIngre.Name = "btnBuscaGastoIngre";
            this.btnBuscaGastoIngre.Size = new System.Drawing.Size(47, 24);
            this.btnBuscaGastoIngre.TabIndex = 20;
            this.btnBuscaGastoIngre.Text = ".......";
            this.btnBuscaGastoIngre.UseVisualStyleBackColor = true;
            this.btnBuscaGastoIngre.Click += new System.EventHandler(this.btnBuscaGastoIngre_Click);
            // 
            // cboOpcion
            // 
            this.cboOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpcion.FormattingEnabled = true;
            this.cboOpcion.Location = new System.Drawing.Point(115, 52);
            this.cboOpcion.Margin = new System.Windows.Forms.Padding(4);
            this.cboOpcion.Name = "cboOpcion";
            this.cboOpcion.Size = new System.Drawing.Size(320, 24);
            this.cboOpcion.TabIndex = 19;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(16, 62);
            this.lblOpcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(112, 17);
            this.lblOpcion.TabIndex = 18;
            this.lblOpcion.Text = "Egresos.............";
            // 
            // cboBusqX
            // 
            this.cboBusqX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqX.FormattingEnabled = true;
            this.cboBusqX.Items.AddRange(new object[] {
            "INGRESO",
            "EGRESO",
            "TOTALES"});
            this.cboBusqX.Location = new System.Drawing.Point(172, 22);
            this.cboBusqX.Margin = new System.Windows.Forms.Padding(4);
            this.cboBusqX.Name = "cboBusqX";
            this.cboBusqX.Size = new System.Drawing.Size(205, 24);
            this.cboBusqX.TabIndex = 16;
            this.cboBusqX.SelectedValueChanged += new System.EventHandler(this.cboBusqX_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buscar por............";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFecFin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAct);
            this.groupBox1.Controls.Add(this.cboBusqEn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboOpcionBusq);
            this.groupBox1.Controls.Add(this.lblOpcionBusq);
            this.groupBox1.Controls.Add(this.dtFecIni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Location = new System.Drawing.Point(7, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(513, 196);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dtFecFin
            // 
            this.dtFecFin.Location = new System.Drawing.Point(135, 114);
            this.dtFecFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(300, 22);
            this.dtFecFin.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fec. Final.....";
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(308, 151);
            this.btnAct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(107, 34);
            this.btnAct.TabIndex = 17;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // cboBusqEn
            // 
            this.cboBusqEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqEn.FormattingEnabled = true;
            this.cboBusqEn.Items.AddRange(new object[] {
            "CAJA",
            "CAJA CHICA",
            "SUCURSAL",
            "EMPRESA"});
            this.cboBusqEn.Location = new System.Drawing.Point(135, 23);
            this.cboBusqEn.Margin = new System.Windows.Forms.Padding(4);
            this.cboBusqEn.Name = "cboBusqEn";
            this.cboBusqEn.Size = new System.Drawing.Size(300, 24);
            this.cboBusqEn.TabIndex = 8;
            this.cboBusqEn.SelectedValueChanged += new System.EventHandler(this.cboBusqEn_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar en..........";
            // 
            // cboOpcionBusq
            // 
            this.cboOpcionBusq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBusq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpcionBusq.FormattingEnabled = true;
            this.cboOpcionBusq.Location = new System.Drawing.Point(135, 54);
            this.cboOpcionBusq.Margin = new System.Windows.Forms.Padding(4);
            this.cboOpcionBusq.Name = "cboOpcionBusq";
            this.cboOpcionBusq.Size = new System.Drawing.Size(300, 24);
            this.cboOpcionBusq.TabIndex = 15;
            // 
            // lblOpcionBusq
            // 
            this.lblOpcionBusq.AutoSize = true;
            this.lblOpcionBusq.Location = new System.Drawing.Point(41, 63);
            this.lblOpcionBusq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpcionBusq.Name = "lblOpcionBusq";
            this.lblOpcionBusq.Size = new System.Drawing.Size(96, 17);
            this.lblOpcionBusq.TabIndex = 14;
            this.lblOpcionBusq.Text = "Caja...............";
            // 
            // dtFecIni
            // 
            this.dtFecIni.Location = new System.Drawing.Point(135, 86);
            this.dtFecIni.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(300, 22);
            this.dtFecIni.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fec. Inicial......";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(195, 151);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(81, 151);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(107, 34);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // OpRepGastosIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 352);
            this.MinimumSize = new System.Drawing.Size(547, 352);
            this.Name = "OpRepGastosIngresos";
            this.ShowIcon = false;
            this.Text = "Reporte Gastos-Ingresos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepGastosIngresos_FormClosing);
            this.Load += new System.EventHandler(this.OpRepGastosIngresos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboOpcion;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cboBusqX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.ComboBox cboBusqEn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOpcionBusq;
        private System.Windows.Forms.Label lblOpcionBusq;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscaGastoIngre;

    }
}