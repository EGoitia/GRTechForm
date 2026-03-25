namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepPendienteCompraProd
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
            this.dgvDetCompra = new System.Windows.Forms.DataGridView();
            this.btnAct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotTransito = new System.Windows.Forms.TextBox();
            this.txtTotCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetCompra
            // 
            this.dgvDetCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetCompra.Location = new System.Drawing.Point(9, 51);
            this.dgvDetCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetCompra.MultiSelect = false;
            this.dgvDetCompra.Name = "dgvDetCompra";
            this.dgvDetCompra.ReadOnly = true;
            this.dgvDetCompra.RowTemplate.Height = 24;
            this.dgvDetCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetCompra.Size = new System.Drawing.Size(467, 228);
            this.dgvDetCompra.TabIndex = 0;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(9, 10);
            this.btnAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(68, 37);
            this.btnAct.TabIndex = 1;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotTransito);
            this.groupBox1.Controls.Add(this.txtTotCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 284);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(421, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // txtTotTransito
            // 
            this.txtTotTransito.Location = new System.Drawing.Point(316, 20);
            this.txtTotTransito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotTransito.Name = "txtTotTransito";
            this.txtTotTransito.ReadOnly = true;
            this.txtTotTransito.Size = new System.Drawing.Size(85, 20);
            this.txtTotTransito.TabIndex = 3;
            this.txtTotTransito.Text = "0.00";
            this.txtTotTransito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotCantidad
            // 
            this.txtTotCantidad.Location = new System.Drawing.Point(118, 21);
            this.txtTotCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotCantidad.Name = "txtTotCantidad";
            this.txtTotCantidad.ReadOnly = true;
            this.txtTotCantidad.Size = new System.Drawing.Size(85, 20);
            this.txtTotCantidad.TabIndex = 2;
            this.txtTotCantidad.Text = "0.00";
            this.txtTotCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Transito............";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Cantidad.............";
            // 
            // OpRepPendienteCompraProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.dgvDetCompra);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpRepPendienteCompraProd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material en Transito ";
            this.Load += new System.EventHandler(this.OpRepPendienteCompraProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetCompra;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotTransito;
        private System.Windows.Forms.TextBox txtTotCantidad;
    }
}