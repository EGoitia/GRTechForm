namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepProductos
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
            this.cboOpRep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbxImg = new System.Windows.Forms.CheckBox();
            this.ckbxQR = new System.Windows.Forms.CheckBox();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cboBusqX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboOpRep
            // 
            this.cboOpRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpRep.FormattingEnabled = true;
            this.cboOpRep.Items.AddRange(new object[] {
            "Catalogo de Items",
            "Catalogo de Items Habilitados",
            "Catalogo de Items Desabilitados",
            "Catalogo de Items Fuera de Linea"});
            this.cboOpRep.Location = new System.Drawing.Point(115, 83);
            this.cboOpRep.Name = "cboOpRep";
            this.cboOpRep.Size = new System.Drawing.Size(320, 24);
            this.cboOpRep.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte...............";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbxImg);
            this.groupBox2.Controls.Add(this.ckbxQR);
            this.groupBox2.Controls.Add(this.cboOpRep);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboOpcion);
            this.groupBox2.Controls.Add(this.lblOpcion);
            this.groupBox2.Controls.Add(this.cboBusqX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(460, 164);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // ckbxImg
            // 
            this.ckbxImg.AutoSize = true;
            this.ckbxImg.Location = new System.Drawing.Point(280, 125);
            this.ckbxImg.Name = "ckbxImg";
            this.ckbxImg.Size = new System.Drawing.Size(106, 21);
            this.ckbxImg.TabIndex = 21;
            this.ckbxImg.Text = "Imp. Imagen";
            this.ckbxImg.UseVisualStyleBackColor = true;
            // 
            // ckbxQR
            // 
            this.ckbxQR.AutoSize = true;
            this.ckbxQR.Location = new System.Drawing.Point(115, 125);
            this.ckbxQR.Name = "ckbxQR";
            this.ckbxQR.Size = new System.Drawing.Size(129, 21);
            this.ckbxQR.TabIndex = 20;
            this.ckbxQR.Text = "Imp. Codigo QR";
            this.ckbxQR.UseVisualStyleBackColor = true;
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
            this.lblOpcion.Location = new System.Drawing.Point(17, 63);
            this.lblOpcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(107, 17);
            this.lblOpcion.TabIndex = 18;
            this.lblOpcion.Text = "Rubro...............";
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
            this.label3.Location = new System.Drawing.Point(68, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Imprimir por............";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAct);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnImp);
            this.groupBox4.Location = new System.Drawing.Point(13, 181);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(460, 72);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(289, 23);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(107, 34);
            this.btnAct.TabIndex = 12;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 23);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(59, 23);
            this.btnImp.Margin = new System.Windows.Forms.Padding(4);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(107, 34);
            this.btnImp.TabIndex = 10;
            this.btnImp.Text = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // OpRepProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(505, 311);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(505, 311);
            this.Name = "OpRepProductos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepProductos_FormClosing);
            this.Load += new System.EventHandler(this.OpRepProductos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOpRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboOpcion;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cboBusqX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.CheckBox ckbxImg;
        private System.Windows.Forms.CheckBox ckbxQR;
    }
}