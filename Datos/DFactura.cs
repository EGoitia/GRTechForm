using System;
using System.Data;
using System.Data.SqlClient;
using Objetos;

namespace Datos
{
    public static class DFactura
    {
        public static bool InsertModifFactura(OFactura @fact, DataTable @inm)
        {
            bool result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifFactura", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (fact.FacturaID == -1)
                    miCmd.Parameters.AddWithValue("@FacturaID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@FacturaID", fact.FacturaID);

                miCmd.Parameters.AddWithValue("@Numero", fact.Numero);
                miCmd.Parameters.AddWithValue("@ActividadID", fact.ActividadID);
                miCmd.Parameters.AddWithValue("@Autorizacion", fact.Autorizacion);
                miCmd.Parameters.AddWithValue("@Codigo_Control", fact.Codigo_Control);

                if (fact.Tupla == "VENTA")
                    miCmd.Parameters.AddWithValue("@CodVenta", fact.CodNota);

                miCmd.Parameters.AddWithValue("@Descripcion", fact.Descripcion);
                miCmd.Parameters.AddWithValue("@DosificacionID", fact.DosificacionID);
                miCmd.Parameters.AddWithValue("@Dscto", fact.Dscto);
                miCmd.Parameters.AddWithValue("@Estado", fact.Estado);
                miCmd.Parameters.AddWithValue("@Exentos", fact.Exentos);
                miCmd.Parameters.AddWithValue("@Fecha", fact.Fecha);
                miCmd.Parameters.AddWithValue("@ICE", fact.ICE);
                miCmd.Parameters.AddWithValue("@NIT", fact.NIT);
                miCmd.Parameters.AddWithValue("@Monto", fact.Monto);
                miCmd.Parameters.AddWithValue("@RazonSocial", fact.RazonSocial);
                miCmd.Parameters.AddWithValue("@SucursalID", fact.SucursalID);
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
                    result = Convert.ToBoolean(ReturnValue.Value);
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
