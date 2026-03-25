namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepSaldoInvFisicoValoradoActivosFijos
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
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.rbFisic = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cboBusqX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.cboBusqEn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOpcionBusq = new System.Windows.Forms.ComboBox();
            this.lblOpcionBusq = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbValor);
            this.groupBox3.Controls.Add(this.rbFisic);
            this.groupBox3.Location = new System.Drawing.Point(8, 102);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(513, 55);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Location = new System.Drawing.Point(244, 23);
            this.rbValor.Margin = new System.Windows.Forms.Padding(4);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(260, 21);
            this.rbValor.TabIndex = 9;
            this.rbValor.TabStop = true;
            this.rbValor.Text = "Saldos de Inventario Fisico-Valorado";
            this.rbValor.UseVisualStyleBackColor = true;
            // 
            // rbFisic
            // 
            this.rbFisic.AutoSize = true;
            this.rbFisic.Checked = true;
            this.rbFisic.Location = new System.Drawing.Point(20, 23);
            this.rbFisic.Margin = new System.Windows.Forms.Padding(4);
            this.rbFisic.Name = "rbFisic";
            this.rbFisic.Size = new System.Drawing.Size(198, 21);
            this.rbFisic.TabIndex = 8;
            this.rbFisic.TabStop = true;
            this.rbFisic.Text = "Saldos de Inventario Fisico";
            this.rbFisic.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboOpcion);
            this.groupBox2.Controls.Add(this.lblOpcion);
            this.groupBox2.Controls.Add(this.cboBusqX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(513, 96);
            this.groupBox2.TabIndex = 16;
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
            this.lblOpcion.Location = new System.Drawing.Point(16, 63);
            this.lblOpcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(108, 17);
            this.lblOpcion.TabIndex = 18;
            this.lblOpcion.Text = "Grupo...............";
            // 
            // cboBusqX
            // 
            this.cboBusqX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqX.FormattingEnabled = true;
            this.cboBusqX.Items.AddRange(new object[] {
            "TIPO ACTIVOS FIJOS",
            "GRUPO ACTIVOS FIJOS",
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
            this.groupBox1.Controls.Add(this.btnAct);
            this.groupBox1.Controls.Add(this.cboBusqEn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboOpcionBusq);
            this.groupBox1.Controls.Add(this.lblOpcionBusq);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Location = new System.Drawing.Point(8, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(513, 165);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(308, 117);
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
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(135, 86);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(300, 22);
            this.dtFecha.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha..................";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(195, 117);
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
            this.btnProcesar.Location = new System.Drawing.Point(81, 117);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(107, 34);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // OpRepSaldoInvFisicoValoradoActivosFijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 331);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 378);
            this.MinimumSize = new System.Drawing.Size(547, 378);
            this.Name = "OpRepSaldoInvFisicoValoradoActivosFijos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldo Inventario Fisico - Valorado de Activos Fijos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepSaldoInvFisicoValoradoActivosFijos_FormClosing);
            this.Load += new System.EventHandler(this.OpRepSaldoInvFisicoValoradoActivosFijos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.RadioButton rbFisic;
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
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcesar;
    }
}