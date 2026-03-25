namespace GRTechnology1._0
{
    partial class Frm_Traspaso
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboAlmacenAl = new System.Windows.Forms.ComboBox();
            this.cboAlmacenDe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelSup.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.Orange;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1073, 10);
            this.label1.Visible = false;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(1120, 7);
            this.txtTC.Visible = false;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cboAlmacenAl);
            this.gbxDatos.Controls.Add(this.cboAlmacenDe);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.label4);
            this.gbxDatos.Controls.SetChildIndex(this.label6, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtObs, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label4, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label2, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboAlmacenDe, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboAlmacenAl, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Size = new System.Drawing.Size(915, 23);
            this.lblFecha.Text = "21/09/2019";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel3.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel3.Controls.SetChildIndex(this.gbxDatos, 0);
            this.panel3.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.panel3.Controls.SetChildIndex(this.label8, 0);
            this.panel3.Controls.SetChildIndex(this.txtCantidad, 0);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Size = new System.Drawing.Size(880, 213);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(656, 374);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(777, 374);
            // 
            // btnAbriCerrarPanel
            // 
            this.btnAbriCerrarPanel.BackColor = System.Drawing.Color.Orange;
            this.btnAbriCerrarPanel.UseVisualStyleBackColor = false;
            // 
            // cboAlmacenAl
            // 
            this.cboAlmacenAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlmacenAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAlmacenAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboAlmacenAl.FormattingEnabled = true;
            this.cboAlmacenAl.Location = new System.Drawing.Point(103, 57);
            this.cboAlmacenAl.Name = "cboAlmacenAl";
            this.cboAlmacenAl.Size = new System.Drawing.Size(305, 24);
            this.cboAlmacenAl.TabIndex = 49;
            // 
            // cboAlmacenDe
            // 
            this.cboAlmacenDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlmacenDe.Enabled = false;
            this.cboAlmacenDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAlmacenDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboAlmacenDe.FormattingEnabled = true;
            this.cboAlmacenDe.Location = new System.Drawing.Point(103, 21);
            this.cboAlmacenDe.Name = "cboAlmacenDe";
            this.cboAlmacenDe.Size = new System.Drawing.Size(305, 24);
            this.cboAlmacenDe.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(27, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Orígen:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(96, 384);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(98, 26);
            this.txtCantidad.TabIndex = 62;
            this.txtCantidad.TabStop = false;
            this.txtCantidad.Text = "0.00";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(17, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Cantidad:";
            // 
            // Frm_Traspaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1220, 473);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Traspaso";
            this.Text = "Traspasos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Traspaso_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Traspaso_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAlmacenAl;
        private System.Windows.Forms.ComboBox cboAlmacenDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
    }
}
