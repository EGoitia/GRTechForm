namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrUsuClasificCombo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUpDwnValCom = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.chkModifPrec = new System.Windows.Forms.CheckBox();
            this.btnBusqTProd = new System.Windows.Forms.Button();
            this.btnBusqProv = new System.Windows.Forms.Button();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.cboSubRubro = new System.Windows.Forms.ComboBox();
            this.cboRubro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDwnValCom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NUpDwnValCom);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.chkModifPrec);
            this.groupBox1.Controls.Add(this.btnBusqTProd);
            this.groupBox1.Controls.Add(this.btnBusqProv);
            this.groupBox1.Controls.Add(this.txtMoneda);
            this.groupBox1.Controls.Add(this.cboSubRubro);
            this.groupBox1.Controls.Add(this.cboRubro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // NUpDwnValCom
            // 
            this.NUpDwnValCom.DecimalPlaces = 2;
            this.NUpDwnValCom.Location = new System.Drawing.Point(395, 50);
            this.NUpDwnValCom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUpDwnValCom.Name = "NUpDwnValCom";
            this.NUpDwnValCom.Size = new System.Drawing.Size(117, 20);
            this.NUpDwnValCom.TabIndex = 56;
            this.NUpDwnValCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUpDwnValCom.ThousandsSeparator = true;
            this.NUpDwnValCom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(316, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 13);
            this.label26.TabIndex = 55;
            this.label26.Text = "Valor Comision:";
            // 
            // chkModifPrec
            // 
            this.chkModifPrec.AutoSize = true;
            this.chkModifPrec.Checked = true;
            this.chkModifPrec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModifPrec.Location = new System.Drawing.Point(14, 84);
            this.chkModifPrec.Name = "chkModifPrec";
            this.chkModifPrec.Size = new System.Drawing.Size(88, 17);
            this.chkModifPrec.TabIndex = 53;
            this.chkModifPrec.Text = "Modif. Precio";
            this.chkModifPrec.UseVisualStyleBackColor = true;
            // 
            // btnBusqTProd
            // 
            this.btnBusqTProd.ImageIndex = 14;
            this.btnBusqTProd.Location = new System.Drawing.Point(260, 49);
            this.btnBusqTProd.Name = "btnBusqTProd";
            this.btnBusqTProd.Size = new System.Drawing.Size(31, 23);
            this.btnBusqTProd.TabIndex = 51;
            this.btnBusqTProd.Text = "......";
            this.btnBusqTProd.UseVisualStyleBackColor = true;
            // 
            // btnBusqProv
            // 
            this.btnBusqProv.ImageIndex = 14;
            this.btnBusqProv.Location = new System.Drawing.Point(260, 19);
            this.btnBusqProv.Name = "btnBusqProv";
            this.btnBusqProv.Size = new System.Drawing.Size(31, 23);
            this.btnBusqProv.TabIndex = 50;
            this.btnBusqProv.Text = ".....";
            this.btnBusqProv.UseVisualStyleBackColor = true;
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(395, 19);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.ReadOnly = true;
            this.txtMoneda.Size = new System.Drawing.Size(117, 20);
            this.txtMoneda.TabIndex = 49;
            this.txtMoneda.TabStop = false;
            this.txtMoneda.Text = "BOB";
            this.txtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboSubRubro
            // 
            this.cboSubRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSubRubro.FormattingEnabled = true;
            this.cboSubRubro.Location = new System.Drawing.Point(70, 49);
            this.cboSubRubro.Name = "cboSubRubro";
            this.cboSubRubro.Size = new System.Drawing.Size(184, 21);
            this.cboSubRubro.TabIndex = 48;
            // 
            // cboRubro
            // 
            this.cboRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRubro.FormattingEnabled = true;
            this.cboRubro.Location = new System.Drawing.Point(70, 19);
            this.cboRubro.Name = "cboRubro";
            this.cboRubro.Size = new System.Drawing.Size(184, 21);
            this.cboRubro.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Moneda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Subgrupo..........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Grupo..........";
            // 
            // CntrUsuClasificCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CntrUsuClasificCombo";
            this.Size = new System.Drawing.Size(545, 126);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDwnValCom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUpDwnValCom;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox chkModifPrec;
        private System.Windows.Forms.Button btnBusqTProd;
        private System.Windows.Forms.Button btnBusqProv;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.ComboBox cboSubRubro;
        private System.Windows.Forms.ComboBox cboRubro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
