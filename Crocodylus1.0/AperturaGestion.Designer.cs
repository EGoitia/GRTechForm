namespace GRTechnology1._0
{
    partial class AperturaGestion
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
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblNomRep = new System.Windows.Forms.Label();
            this.lblDatosEmp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvBalIni = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalIni)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoneda
            // 
            this.lblMoneda.Location = new System.Drawing.Point(231, 32);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(538, 23);
            this.lblMoneda.TabIndex = 6;
            this.lblMoneda.Text = "(Expresado en Bolivianos)";
            this.lblMoneda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomRep
            // 
            this.lblNomRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRep.Location = new System.Drawing.Point(231, 9);
            this.lblNomRep.Name = "lblNomRep";
            this.lblNomRep.Size = new System.Drawing.Size(538, 23);
            this.lblNomRep.TabIndex = 5;
            this.lblNomRep.Text = "BALANCE INICIAL AL 2 DE ENERO DE 2016";
            this.lblNomRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatosEmp
            // 
            this.lblDatosEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEmp.Location = new System.Drawing.Point(12, 9);
            this.lblDatosEmp.Name = "lblDatosEmp";
            this.lblDatosEmp.Size = new System.Drawing.Size(276, 94);
            this.lblDatosEmp.TabIndex = 7;
            this.lblDatosEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(12, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 67);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(629, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(523, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 36);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvBalIni
            // 
            this.dgvBalIni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalIni.Location = new System.Drawing.Point(5, 109);
            this.dgvBalIni.Name = "dgvBalIni";
            this.dgvBalIni.RowTemplate.Height = 24;
            this.dgvBalIni.Size = new System.Drawing.Size(764, 332);
            this.dgvBalIni.TabIndex = 8;
            // 
            // AperturaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBalIni);
            this.Controls.Add(this.lblDatosEmp);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblNomRep);
            this.MaximizeBox = false;
            this.Name = "AperturaGestion";
            this.ShowIcon = false;
            this.Text = "Apertura de Gestion";
            this.Load += new System.EventHandler(this.AperturaGestion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalIni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblNomRep;
        private System.Windows.Forms.Label lblDatosEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvBalIni;
    }
}