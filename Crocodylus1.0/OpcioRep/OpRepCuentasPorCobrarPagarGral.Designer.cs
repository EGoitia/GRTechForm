namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepCuentasPorCobrarPagarGral
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
            this.btnAct = new System.Windows.Forms.Button();
            this.cboBusqEn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOpcionBusq = new System.Windows.Forms.ComboBox();
            this.lblOpcionBusq = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 165);
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
            this.cboBusqEn.Location = new System.Drawing.Point(135, 22);
            this.cboBusqEn.Margin = new System.Windows.Forms.Padding(4);
            this.cboBusqEn.Name = "cboBusqEn";
            this.cboBusqEn.Size = new System.Drawing.Size(300, 24);
            this.cboBusqEn.TabIndex = 8;
            this.cboBusqEn.SelectedValueChanged += new System.EventHandler(this.cboBusqEn_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
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
            this.lblOpcionBusq.Location = new System.Drawing.Point(41, 64);
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
            // OpRepCuentasPorCobrarGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 179);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(505, 226);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(505, 226);
            this.Name = "OpRepCuentasPorCobrarGral";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas Por Cobrar ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepCuentasPorCobrarGral_FormClosing);
            this.Load += new System.EventHandler(this.OpRepCuentasPorCobrarGral_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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