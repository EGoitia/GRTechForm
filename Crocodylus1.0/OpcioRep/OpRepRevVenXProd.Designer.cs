namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepRevVenXProd
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboOrdenado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFFin = new System.Windows.Forms.DateTimePicker();
            this.dtFIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBusqEn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOpcionBusq = new System.Windows.Forms.ComboBox();
            this.lblOpcionBusq = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cboBusqX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnProcesar);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Location = new System.Drawing.Point(6, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 52);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(11, 16);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(80, 28);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(92, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOrdenado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtFFin);
            this.groupBox1.Controls.Add(this.dtFIni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboBusqEn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboOpcionBusq);
            this.groupBox1.Controls.Add(this.lblOpcionBusq);
            this.groupBox1.Location = new System.Drawing.Point(6, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 139);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // cboOrdenado
            // 
            this.cboOrdenado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrdenado.FormattingEnabled = true;
            this.cboOrdenado.Items.AddRange(new object[] {
            "Nombre",
            "Cantidad",
            "Utilidad"});
            this.cboOrdenado.Location = new System.Drawing.Point(86, 101);
            this.cboOrdenado.Name = "cboOrdenado";
            this.cboOrdenado.Size = new System.Drawing.Size(226, 21);
            this.cboOrdenado.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ordenado por:";
            // 
            // dtFFin
            // 
            this.dtFFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFFin.Location = new System.Drawing.Point(214, 70);
            this.dtFFin.Name = "dtFFin";
            this.dtFFin.Size = new System.Drawing.Size(98, 20);
            this.dtFFin.TabIndex = 20;
            // 
            // dtFIni
            // 
            this.dtFIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFIni.Location = new System.Drawing.Point(86, 70);
            this.dtFIni.Name = "dtFIni";
            this.dtFIni.Size = new System.Drawing.Size(98, 20);
            this.dtFIni.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fechas:";
            // 
            // cboBusqEn
            // 
            this.cboBusqEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqEn.FormattingEnabled = true;
            this.cboBusqEn.Items.AddRange(new object[] {
            "Sucursal",
            "Empresa"});
            this.cboBusqEn.Location = new System.Drawing.Point(86, 19);
            this.cboBusqEn.Name = "cboBusqEn";
            this.cboBusqEn.Size = new System.Drawing.Size(226, 21);
            this.cboBusqEn.TabIndex = 8;
            this.cboBusqEn.SelectedValueChanged += new System.EventHandler(this.cboBusqEn_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Buscar en:";
            // 
            // cboOpcionBusq
            // 
            this.cboOpcionBusq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBusq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpcionBusq.FormattingEnabled = true;
            this.cboOpcionBusq.Location = new System.Drawing.Point(86, 44);
            this.cboOpcionBusq.Name = "cboOpcionBusq";
            this.cboOpcionBusq.Size = new System.Drawing.Size(226, 21);
            this.cboOpcionBusq.TabIndex = 15;
            // 
            // lblOpcionBusq
            // 
            this.lblOpcionBusq.AutoSize = true;
            this.lblOpcionBusq.Location = new System.Drawing.Point(22, 52);
            this.lblOpcionBusq.Name = "lblOpcionBusq";
            this.lblOpcionBusq.Size = new System.Drawing.Size(51, 13);
            this.lblOpcionBusq.TabIndex = 14;
            this.lblOpcionBusq.Text = "Sucursal:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboOpcion);
            this.groupBox2.Controls.Add(this.lblOpcion);
            this.groupBox2.Controls.Add(this.cboBusqX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 78);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // cboOpcion
            // 
            this.cboOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpcion.FormattingEnabled = true;
            this.cboOpcion.Location = new System.Drawing.Point(86, 42);
            this.cboOpcion.Name = "cboOpcion";
            this.cboOpcion.Size = new System.Drawing.Size(226, 21);
            this.cboOpcion.TabIndex = 19;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(12, 50);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(39, 13);
            this.lblOpcion.TabIndex = 18;
            this.lblOpcion.Text = "Rubro:";
            // 
            // cboBusqX
            // 
            this.cboBusqX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqX.FormattingEnabled = true;
            this.cboBusqX.Items.AddRange(new object[] {
            "SUB-RUBRO",
            "RUBRO",
            "TOTALES"});
            this.cboBusqX.Location = new System.Drawing.Point(86, 15);
            this.cboBusqX.Name = "cboBusqX";
            this.cboBusqX.Size = new System.Drawing.Size(155, 21);
            this.cboBusqX.TabIndex = 16;
            this.cboBusqX.SelectedValueChanged += new System.EventHandler(this.cboBusqX_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buscar por:";
            // 
            // OpRepRevVenXProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 284);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 323);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 323);
            this.Name = "OpRepRevVenXProd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento de ventas por producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepRevVenXProd_FormClosing);
            this.Load += new System.EventHandler(this.OpRepRevVenXProd_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOrdenado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFFin;
        private System.Windows.Forms.DateTimePicker dtFIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBusqEn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOpcionBusq;
        private System.Windows.Forms.Label lblOpcionBusq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboOpcion;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cboBusqX;
        private System.Windows.Forms.Label label3;
    }
}