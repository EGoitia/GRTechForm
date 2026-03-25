namespace GRTechnology1._0
{
    partial class Frm_Condicion_Comercial
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
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CondComID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxBotones.SuspendLayout();
            this.gbxBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Size = new System.Drawing.Size(589, 54);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 13);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(438, 13);
            // 
            // btnAnular
            // 
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Location = new System.Drawing.Point(8, 254);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CondComID,
            this.Titulo});
            this.dgvDatos.Location = new System.Drawing.Point(8, 311);
            this.dgvDatos.Size = new System.Drawing.Size(589, 155);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.button1);
            this.gbxDatos.Controls.Add(this.txtDesc);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Location = new System.Drawing.Point(8, 62);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(589, 188);
            this.gbxDatos.TabIndex = 6;
            this.gbxDatos.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 29);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(88, 43);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(447, 128);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Location = new System.Drawing.Point(88, 17);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(491, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // CondComID
            // 
            this.CondComID.FillWeight = 50F;
            this.CondComID.HeaderText = "ID";
            this.CondComID.Name = "CondComID";
            this.CondComID.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.FillWeight = 300F;
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Frm_Condicion_Comercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 472);
            this.Controls.Add(this.gbxDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Condicion_Comercial";
            this.Text = "Condición Comercial";
            this.Load += new System.EventHandler(this.Frm_Condicion_Comercial_Load);
            this.Controls.SetChildIndex(this.gbxBuscador, 0);
            this.Controls.SetChildIndex(this.gbxBotones, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.Controls.SetChildIndex(this.gbxDatos, 0);
            this.gbxBotones.ResumeLayout(false);
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondComID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;

    }
}