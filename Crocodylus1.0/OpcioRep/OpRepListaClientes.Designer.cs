namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepListaClientes
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
            this.btnImp = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnHabil = new System.Windows.Forms.Button();
            this.btnAnul = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(16, 9);
            this.btnImp.Margin = new System.Windows.Forms.Padding(4);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(81, 28);
            this.btnImp.TabIndex = 4;
            this.btnImp.Text = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(16, 44);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(535, 310);
            this.dgvClientes.TabIndex = 3;
            // 
            // btnHabil
            // 
            this.btnHabil.Location = new System.Drawing.Point(451, 8);
            this.btnHabil.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabil.Name = "btnHabil";
            this.btnHabil.Size = new System.Drawing.Size(100, 28);
            this.btnHabil.TabIndex = 5;
            this.btnHabil.Text = "Habilitados";
            this.btnHabil.UseVisualStyleBackColor = true;
            this.btnHabil.Click += new System.EventHandler(this.btnHabil_Click);
            // 
            // btnAnul
            // 
            this.btnAnul.Location = new System.Drawing.Point(350, 8);
            this.btnAnul.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnul.Name = "btnAnul";
            this.btnAnul.Size = new System.Drawing.Size(100, 28);
            this.btnAnul.TabIndex = 6;
            this.btnAnul.Text = "Anulados";
            this.btnAnul.UseVisualStyleBackColor = true;
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(249, 8);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(100, 28);
            this.btnTodos.TabIndex = 7;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // OpRepListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 374);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnAnul);
            this.Controls.Add(this.btnHabil);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.dgvClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpRepListaClientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.OpRepListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnHabil;
        private System.Windows.Forms.Button btnAnul;
        private System.Windows.Forms.Button btnTodos;
    }
}