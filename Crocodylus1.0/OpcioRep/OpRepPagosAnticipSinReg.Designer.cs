namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepPagosAnticipSinReg
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
            this.dgvPagAnticSinReg = new System.Windows.Forms.DataGridView();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRef = new System.Windows.Forms.RadioButton();
            this.rbNumNota = new System.Windows.Forms.RadioButton();
            this.btnImpNota = new System.Windows.Forms.Button();
            this.btnVerItems = new System.Windows.Forms.Button();
            this.btnImpLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagAnticSinReg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagAnticSinReg
            // 
            this.dgvPagAnticSinReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagAnticSinReg.Location = new System.Drawing.Point(7, 37);
            this.dgvPagAnticSinReg.MultiSelect = false;
            this.dgvPagAnticSinReg.Name = "dgvPagAnticSinReg";
            this.dgvPagAnticSinReg.ReadOnly = true;
            this.dgvPagAnticSinReg.RowTemplate.Height = 24;
            this.dgvPagAnticSinReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagAnticSinReg.Size = new System.Drawing.Size(960, 534);
            this.dgvPagAnticSinReg.TabIndex = 2;
            this.dgvPagAnticSinReg.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagAnticSinReg_RowEnter);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(72, 7);
            this.txtBuscador.MaxLength = 30;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(174, 22);
            this.txtBuscador.TabIndex = 3;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar.......";
            // 
            // rbRef
            // 
            this.rbRef.AutoSize = true;
            this.rbRef.Checked = true;
            this.rbRef.Location = new System.Drawing.Point(273, 8);
            this.rbRef.Name = "rbRef";
            this.rbRef.Size = new System.Drawing.Size(98, 21);
            this.rbRef.TabIndex = 5;
            this.rbRef.TabStop = true;
            this.rbRef.Text = "Referencia";
            this.rbRef.UseVisualStyleBackColor = true;
            // 
            // rbNumNota
            // 
            this.rbNumNota.AutoSize = true;
            this.rbNumNota.Location = new System.Drawing.Point(377, 7);
            this.rbNumNota.Name = "rbNumNota";
            this.rbNumNota.Size = new System.Drawing.Size(96, 21);
            this.rbNumNota.TabIndex = 6;
            this.rbNumNota.TabStop = true;
            this.rbNumNota.Text = "Num. Nota";
            this.rbNumNota.UseVisualStyleBackColor = true;
            // 
            // btnImpNota
            // 
            this.btnImpNota.Location = new System.Drawing.Point(736, 4);
            this.btnImpNota.Name = "btnImpNota";
            this.btnImpNota.Size = new System.Drawing.Size(115, 30);
            this.btnImpNota.TabIndex = 7;
            this.btnImpNota.Text = "Imp. Nota";
            this.btnImpNota.UseVisualStyleBackColor = true;
            this.btnImpNota.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnVerItems
            // 
            this.btnVerItems.Location = new System.Drawing.Point(620, 4);
            this.btnVerItems.Name = "btnVerItems";
            this.btnVerItems.Size = new System.Drawing.Size(115, 30);
            this.btnVerItems.TabIndex = 8;
            this.btnVerItems.Text = "Ver Producto";
            this.btnVerItems.UseVisualStyleBackColor = true;
            this.btnVerItems.Click += new System.EventHandler(this.btnVerItems_Click);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Location = new System.Drawing.Point(852, 4);
            this.btnImpLista.Name = "btnImpLista";
            this.btnImpLista.Size = new System.Drawing.Size(115, 30);
            this.btnImpLista.TabIndex = 9;
            this.btnImpLista.Text = "Imp. Lista";
            this.btnImpLista.UseVisualStyleBackColor = true;
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // OpRepPagosAnticipSinReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(973, 577);
            this.Controls.Add(this.btnImpLista);
            this.Controls.Add(this.btnVerItems);
            this.Controls.Add(this.btnImpNota);
            this.Controls.Add(this.rbNumNota);
            this.Controls.Add(this.rbRef);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPagAnticSinReg);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(991, 624);
            this.MinimumSize = new System.Drawing.Size(991, 624);
            this.Name = "OpRepPagosAnticipSinReg";
            this.ShowIcon = false;
            this.Text = "Pagos Anticipados sin Regularizar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepPagosAnticipSinReg_FormClosing);
            this.Load += new System.EventHandler(this.OpRepPagosAnticipSinReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagAnticSinReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagAnticSinReg;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRef;
        private System.Windows.Forms.RadioButton rbNumNota;
        private System.Windows.Forms.Button btnImpNota;
        private System.Windows.Forms.Button btnVerItems;
        private System.Windows.Forms.Button btnImpLista;
    }
}