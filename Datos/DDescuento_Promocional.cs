using Objetos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DDescuento_Promocional
    {
        public static bool DInsertDescuentoProm(ODescuento_Promocional dscto, DataTable detalle, DataTable inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("InsertDescuentoProm", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if(dscto.SucursalID == -1)
                    miCmd.Parameters.AddWithValue("@SucursalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucursalID", dscto.SucursalID);
                
                miCmd.Parameters.AddWithValue("@Porcentaje", dscto.Porcentaje);
                miCmd.Parameters.AddWithValue("@Fecha_Ini", dscto.Fecha_Ini);
                miCmd.Parameters.AddWithValue("@Fecha_Fin", dscto.Fecha_Fin);
                //Detalle Productos
                miCmd.Parameters.AddWithValue("@Detalle", detalle);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                try
                {
                    miCon.Open();
                    result = Convert.ToString(miCmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    miCon.Close();
                }
            }

            return true;
        }
    }
}
