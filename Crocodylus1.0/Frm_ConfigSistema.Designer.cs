namespace GRTechnology1._0
{
    partial class Frm_ConfigSistema
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
            this.gbxVentas = new System.Windows.Forms.GroupBox();
            this.btnGuardarConfigVenta = new System.Windows.Forms.Button();
            this.chkImpAutNotaVenta = new System.Windows.Forms.CheckBox();
            this.cboImprNotaVenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarActualizador = new System.Windows.Forms.Button();
            this.txtUbicActualizador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxVentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxVentas
            // 
            this.gbxVentas.Controls.Add(this.btnGuardarConfigVenta);
            this.gbxVentas.Controls.Add(this.chkImpAutNotaVenta);
            this.gbxVentas.Controls.Add(this.cboImprNotaVenta);
            this.gbxVentas.Controls.Add(this.label1);
            this.gbxVentas.Location = new System.Drawing.Point(7, 3);
            this.gbxVentas.Name = "gbxVentas";
            this.gbxVentas.Size = new System.Drawing.Size(466, 94);
            this.gbxVentas.TabIndex = 0;
            this.gbxVentas.TabStop = false;
            this.gbxVentas.Text = "Config. Ventas";
            // 
            // btnGuardarConfigVenta
            // 
            this.btnGuardarConfigVenta.Location = new System.Drawing.Point(357, 30);
            this.btnGuardarConfigVenta.Name = "btnGuardarConfigVenta";
            this.btnGuardarConfigVenta.Size = new System.Drawing.Size(94, 48);
            this.btnGuardarConfigVenta.TabIndex = 3;
            this.btnGuardarConfigVenta.Text = "Guardar";
            this.btnGuardarConfigVenta.UseVisualStyleBackColor = true;
            this.btnGuardarConfigVenta.Click += new System.EventHandler(this.btnGuardarConfigVenta_Click);
            // 
            // chkImpAutNotaVenta
            // 
            this.chkImpAutNotaVenta.AutoSize = true;
            this.chkImpAutNotaVenta.Location = new System.Drawing.Point(103, 61);
            this.chkImpAutNotaVenta.Name = "chkImpAutNotaVenta";
            this.chkImpAutNotaVenta.Size = new System.Drawing.Size(226, 17);
            this.chkImpAutNotaVenta.TabIndex = 2;
            this.chkImpAutNotaVenta.Text = "Imprimir Automáicamente la Nota de Venta";
            this.chkImpAutNotaVenta.UseVisualStyleBackColor = true;
            // 
            // cboImprNotaVenta
            // 
            this.cboImprNotaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImprNotaVenta.FormattingEnabled = true;
            this.cboImprNotaVenta.Items.AddRange(new object[] {
            "MEDIA CARTA",
            "ROLLO"});
            this.cboImprNotaVenta.Location = new System.Drawing.Point(103, 30);
            this.cboImprNotaVenta.Name = "cboImprNotaVenta";
            this.cboImprNotaVenta.Size = new System.Drawing.Size(235, 21);
            this.cboImprNotaVenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formato Impr. Nota de Venta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarActualizador);
            this.groupBox1.Controls.Add(this.txtUbicActualizador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config. Actualizador";
            // 
            // btnGuardarActualizador
            // 
            this.btnGuardarActualizador.Location = new System.Drawing.Point(357, 18);
            this.btnGuardarActualizador.Name = "btnGuardarActualizador";
            this.btnGuardarActualizador.Size = new System.Drawing.Size(94, 48);
            this.btnGuardarActualizador.TabIndex = 4;
            this.btnGuardarActualizador.Text = "Guardar";
            this.btnGuardarActualizador.UseVisualStyleBackColor = true;
            this.btnGuardarActualizador.Click += new System.EventHandler(this.btnGuardarActualizador_Click);
            // 
            // txtUbicActualizador
            // 
            this.txtUbicActualizador.Location = new System.Drawing.Point(103, 19);
            this.txtUbicActualizador.Multiline = true;
            this.txtUbicActualizador.Name = "txtUbicActualizador";
            this.txtUbicActualizador.Size = new System.Drawing.Size(235, 47);
            this.txtUbicActualizador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ubicación Sistem. Actualizador";
            // 
            // Frm_ConfigSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 189);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxVentas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ConfigSistema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración Sistema";
            this.Load += new System.EventHandler(this.Frm_ConfigSistema_Load);
            this.gbxVentas.ResumeLayout(false);
            this.gbxVentas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxVentas;
        private System.Windows.Forms.ComboBox cboImprNotaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUbicActualizador;
        private System.Windows.Forms.CheckBox chkImpAutNotaVenta;
        private System.Windows.Forms.Button btnGuardarConfigVenta;
        private System.Windows.Forms.Button btnGuardarActualizador;
    }
}