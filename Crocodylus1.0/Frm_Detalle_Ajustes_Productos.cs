using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Ajustes_Productos : Form
    {
        private int InvID = -1;
        public bool Regularizado = false;

        public Frm_Detalle_Ajustes_Productos(int InventarioID)
        {
            InitializeComponent();

            InvID = InventarioID;
            Listar_Detalle_Inventario(InventarioID);
        }

        private void Listar_Detalle_Inventario(int ID)
        {
            try
            {
                DataTable DT = DListarPersonalizado.ConsultarDT("SELECT * FROM Vista_Detalle_Inventario " +
                    "WHERE Stock<>Inventario AND InventarioID=" + ID.ToString());

                foreach (DataRow item in DT.Rows)
                {
                    if ((decimal)item["Stock"] < (decimal)item["Inventario"])
                        dgvDetalleIngreso.Rows.Add(item["ProductoID"], item["Marca"], item["NomGrupo"], item["NomSubGrupo"],
                            item["NomProd"], item["UnidMedida"], item["Stock"], item["Inventario"],
                            (decimal)item["Inventario"] - (decimal)item["Stock"]);
                    else
                        dgvDetalleSalida.Rows.Add(item["ProductoID"], item["Marca"], item["NomGrupo"], item["NomSubGrupo"],
                            item["NomProd"], item["UnidMedida"], item["Stock"], item["Inventario"],
                            (decimal)item["Inventario"] - (decimal)item["Stock"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void btnRealizarAjuste_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA REALIZAR EL AJUSTE DE INGRESO Y SALIDA?",
                "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                try
                {
                    int resp = DInventario.DAjustarInventario(InvID, OInmode.DTInmode("", "NUEVO", ""));
                    if (resp > 0)
                    {
                        MessageBox.Show("EL AJUSTE DE INVENTARIO SE REALIZO CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Regularizado = true;
                        btnRealizarAjuste.Visible = false;
                        
                        this.Close();
                    }
                    else
                        throw new Exception("Error al regularizar el inventario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImpNotaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnImpNotaSalida_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Detalle_Ajustes_Productos_Load(object sender, EventArgs e)
        {

        }

    }
}
