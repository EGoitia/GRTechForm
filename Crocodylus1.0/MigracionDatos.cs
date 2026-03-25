using Objetos;
using Datos;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class MigracionDatos : Form
    {
        private DataTable data = new DataTable();

        public MigracionDatos()
        {
            InitializeComponent();
        }

        private void ImportarExcel()
        {
            ImportarExcel imp = new ImportarExcel();
            imp.ShowDialog();


            if (!imp.Cancelado) // 'si le da cancelar salimos de la funcion
            {
                OleDbConnection con = null;
                try
                {
                    string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + imp.txtDireccion.Text.Trim() + "; Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
                    con = new OleDbConnection(constr);
                    OleDbCommand oconn = new OleDbCommand("Select * From [" + imp.txtHoja.Text.Trim() + "$]", con);
                    con.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                    sda.Fill(data);

                    dgvDatos.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void MigrarInf()
        {
            DialogResult dialog = MessageBox.Show("se va a importar datos de excel y puede ser que se creen nuevos registro en la base de datos, " +
                                                      "¿Desea guardar los datos del documento excel?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    DataSet dsresp = new DataSet();
                    dsresp = DProducto.DVerifInsertProdDT(data, OInmode.DTInmode("", "Nuevo", "Importacion desde Excel"));
                    if (dsresp.Tables[0].Rows.Count > 0)
                    {
                        DialogResult dialogo = MessageBox.Show("Hay nuevos items creados, ¿quiere ver el detalle de los nuevos items?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            NuevosProdCreados nuevprod = new NuevosProdCreados(dsresp.Tables[0]);
                            nuevprod.ShowDialog();
                        }
                        else
                            MessageBox.Show("No se registraron nuevos items", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }           
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            ImportarExcel();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MigrarInf();
        }
    }
}
