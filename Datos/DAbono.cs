using System;
using System.Data;
using System.Data.SqlClient;
using Objetos;

namespace Datos
{
    public static class DAbono
    {
        
        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos Abono
        /// </summary>
        /// <param name="abon"></param>
        /// <param name="dabon"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static string DInsertModifAbono(OAbono @abon, DataTable @inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                try
                {
                    
                    SqlCommand miCmd = new SqlCommand("InsertModifAbono", miCon);
                    miCmd.CommandType = CommandType.StoredProcedure;
                    miCmd.CommandTimeout = 300;

                    if (@abon.CodAbono == string.Empty)
                        miCmd.Parameters.AddWithValue("@CodAbono", DBNull.Value);
                    else
                        miCmd.Parameters.AddWithValue("@CodAbono", @abon.CodAbono);

                    miCmd.Parameters.AddWithValue("@TipoAbono", @abon.TipoAbono);
                    miCmd.Parameters.AddWithValue("@CajaID", @abon.CajaID);
                    miCmd.Parameters.AddWithValue("@SucursalID", @abon.SucursalID);
                    miCmd.Parameters.AddWithValue("@CliProvPerID", @abon.ClienteID);
                    miCmd.Parameters.AddWithValue("@Referencia", @abon.Referencia);
                    miCmd.Parameters.AddWithValue("@Detalle", @abon.Detalle);
                    miCmd.Parameters.AddWithValue("@TC", @abon.TC);
                    miCmd.Parameters.AddWithValue("@TotalDsctoBs", @abon.Dscto);
                    miCmd.Parameters.AddWithValue("@MontoTotalBs", @abon.Monto);
                    miCmd.Parameters.AddWithValue("@PagarConCaja", @abon.PagarConCaja);
                    //Detalle Abono
                    miCmd.Parameters.AddWithValue("@Detalle_Abon", abon.DetalleAbonoDT);
                    //Detalle Pagos
                    miCmd.Parameters.AddWithValue("@Detalle_Pago", abon.DetallePagoDT);
                    //Inmode
                    miCmd.Parameters.AddWithValue("@Inmode", inm);
                    miCon.Open();
                    result = Convert.ToString(miCmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    miCon.Close();
                }
            }
            return result;
        }

    }
}
