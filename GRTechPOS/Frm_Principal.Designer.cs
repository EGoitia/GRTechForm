namespace GRTechPOS
{
    partial class Frm_Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPrin = new System.Windows.Forms.Panel();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.flowLayoutPanelGrupo = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProd = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrin.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrin
            // 
            this.panelPrin.Controls.Add(this.panelVenta);
            this.panelPrin.Controls.Add(this.panelIzq);
            this.panelPrin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrin.Location = new System.Drawing.Point(0, 0);
            this.panelPrin.Name = "panelPrin";
            this.panelPrin.Size = new System.Drawing.Size(838, 359);
            this.panelPrin.TabIndex = 0;
            // 
            // panelIzq
            // 
            this.panelIzq.Controls.Add(this.flowLayoutPanelProd);
            this.panelIzq.Controls.Add(this.flowLayoutPanelGrupo);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 0);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(398, 359);
            this.panelIzq.TabIndex = 0;
            // 
            // panelVenta
            // 
            this.panelVenta.Controls.Add(this.dgvPedido);
            this.panelVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVenta.Location = new System.Drawing.Point(398, 0);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(440, 359);
            this.panelVenta.TabIndex = 1;
            // 
            // flowLayoutPanelGrupo
            // 
            this.flowLayoutPanelGrupo.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelGrupo.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGrupo.Name = "flowLayoutPanelGrupo";
            this.flowLayoutPanelGrupo.Size = new System.Drawing.Size(114, 359);
            this.flowLayoutPanelGrupo.TabIndex = 0;
            // 
            // flowLayoutPanelProd
            // 
            this.flowLayoutPanelProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProd.Location = new System.Drawing.Point(114, 0);
            this.flowLayoutPanelProd.Name = "flowLayoutPanelProd";
            this.flowLayoutPanelProd.Size = new System.Drawing.Size(284, 359);
            this.flowLayoutPanelProd.TabIndex = 1;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedido.Location = new System.Drawing.Point(8, 149);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.RowHeadersWidth = 20;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(424, 162);
            this.dgvPedido.TabIndex = 11;
            // 
            // c1
            // 
            this.c1.HeaderText = "ProdID";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Visible = false;
            // 
            // c2
            // 
            this.c2.FillWeight = 200F;
            this.c2.HeaderText = "Descripcion";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // c3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.c3.DefaultCellStyle = dataGridViewCellStyle2;
            this.c3.FillWeight = 70F;
            this.c3.HeaderText = "Cantidad";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            // 
            // c4
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.c4.DefaultCellStyle = dataGridViewCellStyle3;
            this.c4.FillWeight = 70F;
            this.c4.HeaderText = "Precio";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            // 
            // c5
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.c5.DefaultCellStyle = dataGridViewCellStyle4;
            this.c5.FillWeight = 70F;
            this.c5.HeaderText = "P. Total";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            // 
            // c6
            // 
            this.c6.FillWeight = 70F;
            this.c6.HeaderText = "Stock";
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            this.c6.Visible = false;
            // 
            // c7
            // 
            this.c7.HeaderText = "ImpCaja";
            this.c7.Name = "c7";
            this.c7.ReadOnly = true;
            this.c7.Visible = false;
            // 
            // c8
            // 
            this.c8.HeaderText = "NomComanda";
            this.c8.Name = "c8";
            this.c8.ReadOnly = true;
            this.c8.Visible = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 359);
            this.Controls.Add(this.panelPrin);
            this.Name = "Frm_Principal";
            this.ShowIcon = false;
            this.Text = "Ventas POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panelPrin.ResumeLayout(false);
            this.panelIzq.ResumeLayout(false);
            this.panelVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrin;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGrupo;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
    }
}

