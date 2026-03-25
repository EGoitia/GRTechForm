namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepAbonos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBusqEn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOpcionBusq = new System.Windows.Forms.ComboBox();
            this.lblOpcionBusq = new System.Windows.Forms.Label();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cboBusqX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.ckbxGrafica = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxGrafica);
            this.groupBox1.Controls.Add(this.dtFecFin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboBusqEn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboOpcionBusq);
            this.groupBox1.Controls.Add(this.lblOpcionBusq);
            this.groupBox1.Controls.Add(this.dtFecIni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 173);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // dtFecFin
            // 
            this.dtFecFin.Location = new System.Drawing.Point(134, 114);
            this.dtFecFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(300, 22);
            this.dtFecFin.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha Final...........";
            // 
            // cboBusqEn
            // 
            this.cboBusqEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqEn.FormattingEnabled = true;
            this.cboBusqEn.Items.AddRange(new object[] {
            "Caja",
            "Sucursal",
            "Empresa"});
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
            this.lblOpcionBusq.Size = new System.Drawing.Size(103, 17);
            this.lblOpcionBusq.TabIndex = 14;
            this.lblOpcionBusq.Text = "Sucursal..........";
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
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha Inicial.............";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboOpcion);
            this.groupBox2.Controls.Add(this.lblOpcion);
            this.groupBox2.Controls.Add(this.cboBusqX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(469, 96);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
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
            this.lblOpcion.Size = new System.Drawing.Size(107, 17);
            this.lblOpcion.TabIndex = 18;
            this.lblOpcion.Text = "Cliente..............";
            // 
            // cboBusqX
            // 
            this.cboBusqX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqX.FormattingEnabled = true;
            this.cboBusqX.Items.AddRange(new object[] {
            "CLIENTE",
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAct);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnProcesar);
            this.groupBox3.Location = new System.Drawing.Point(14, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 68);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(285, 22);
            this.btnAct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(107, 34);
            this.btnAct.TabIndex = 20;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(172, 22);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(58, 22);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(107, 34);
            this.btnProcesar.TabIndex = 18;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // ckbxGrafica
            // 
            this.ckbxGrafica.AutoSize = true;
            this.ckbxGrafica.Location = new System.Drawing.Point(134, 142);
            this.ckbxGrafica.Name = "ckbxGrafica";
            this.ckbxGrafica.Size = new System.Drawing.Size(76, 21);
            this.ckbxGrafica.TabIndex = 20;
            this.ckbxGrafica.Text = "Grafica";
            this.ckbxGrafica.UseVisualStyleBackColor = true;
            // 
            // OpRepAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 368);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "OpRepAbonos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Abonos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepAbonos_FormClosing);
            this.Load += new System.EventHandler(this.OpRepAbonos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBusqEn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOpcionBusq;
        private System.Windows.Forms.Label lblOpcionBusq;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboOpcion;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cboBusqX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbxGrafica;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcesar;
    }
}