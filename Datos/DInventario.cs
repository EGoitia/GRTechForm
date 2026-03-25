using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objetos;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class DInventario
    {
        public static int DInsertModifInventario(OInventario inv, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifInventario", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (inv.InventarioID == -1)
                    miCmd.Parameters.AddWithValue("@InventarioID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@InventarioID", inv.InventarioID);

                miCmd.Parameters.AddWithValue("@AlmacenID", inv.SucursalID);
                miCmd.Parameters.AddWithValue("@SucursalID", inv.SucursalID);
                miCmd.Parameters.AddWithValue("@Observacion", inv.Observacion);
                miCmd.Parameters.AddWithValue("@DetalleInventario", inv.DetalleInventarioDT);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);
                IDataParameter ReturnValue;
                ReturnValue = miCmd.CreateParameter();
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                miCmd.Parameters.Add(ReturnValue);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToInt32(ReturnValue.Value);
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

        public static int DAjustarInventario(int inventarioid, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertAjusteInventarioAut", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@InventarioID", inventarioid);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                IDataParameter ReturnValue;
                ReturnValue = miCmd.CreateParameter();
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                miCmd.Parameters.Add(ReturnValue);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToInt32(ReturnValue.Value);
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
