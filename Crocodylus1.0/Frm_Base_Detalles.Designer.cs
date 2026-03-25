namespace GRTechnology1._0
{
    partial class Frm_Base_Detalles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAnul = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnImpLista = new System.Windows.Forms.Button();
            this.btnImpNota = new System.Windows.Forms.Button();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvDetalle = new GRTechnology1._0.cu_Datagridview();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Location = new System.Drawing.Point(8, 12);
            this.btnAnul.Name = "btnAnul";
            this.btnAnul.Size = new System.Drawing.Size(93, 41);
            this.btnAnul.TabIndex = 0;
            this.btnAnul.Text = "Anular";
            this.btnAnul.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(107, 12);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(93, 41);
            this.btnModif.TabIndex = 0;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistro.Location = new System.Drawing.Point(568, 12);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(93, 41);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpLista.Location = new System.Drawing.Point(667, 12);
            this.btnImpLista.Name = "btnImpLista";
            this.btnImpLista.Size = new System.Drawing.Size(93, 41);
            this.btnImpLista.TabIndex = 0;
            this.btnImpLista.Text = "Imprimir Lista";
            this.btnImpLista.UseVisualStyleBackColor = true;
            // 
            // btnImpNota
            // 
            this.btnImpNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpNota.Location = new System.Drawing.Point(766, 12);
            this.btnImpNota.Name = "btnImpNota";
            this.btnImpNota.Size = new System.Drawing.Size(93, 41);
            this.btnImpNota.TabIndex = 0;
            this.btnImpNota.Text = "Imprimir Nota";
            this.btnImpNota.UseVisualStyleBackColor = true;
            this.btnImpNota.Click += new System.EventHandler(this.btnImpNota_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFiltro.Controls.Add(this.btnBuscar);
            this.gbxFiltro.Location = new System.Drawing.Point(10, 4);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(865, 100);
            this.gbxFiltro.TabIndex = 3;
            this.gbxFiltro.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(752, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 42);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 110);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(865, 220);
            this.dgvDetalle.TabIndex = 5;
            this.dgvDetalle.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDetalle_RowPostPaint);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBotones.Controls.Add(this.btnImpNota);
            this.gbxBotones.Controls.Add(this.btnImpLista);
            this.gbxBotones.Controls.Add(this.btnAnul);
            this.gbxBotones.Controls.Add(this.btnRegistro);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Location = new System.Drawing.Point(10, 336);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(865, 63);
            this.gbxBotones.TabIndex = 8;
            this.gbxBotones.TabStop = false;
            // 
            // Frm_Base_Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 402);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.gbxFiltro);
            this.KeyPreview = true;
            this.Name = "Frm_Base_Detalles";
            this.ShowIcon = false;
            this.Text = "Frm_Base_Detalles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAnul;
        public System.Windows.Forms.Button btnModif;
        public System.Windows.Forms.GroupBox gbxFiltro;
        public System.Windows.Forms.Button btnBuscar;
        public cu_Datagridview dgvDetalle;
        public System.Windows.Forms.Button btnImpNota;
        public System.Windows.Forms.Button btnImpLista;
        public System.Windows.Forms.GroupBox gbxBotones;
        public System.Windows.Forms.Button btnRegistro;
    }
}