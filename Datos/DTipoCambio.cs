using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DTipoCambio
    {
        public static decimal ObtenerTC(string opc)
        {
            decimal tc = (decimal)6.96;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("SELECT TOP 1 " + opc + " FROM Tipo_Cambio ORDER BY Fecha DESC", miCon);
                miCmd.CommandType = CommandType.Text;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                        if (miLector.Read())
                            tc = miLector.GetDecimal(miLector.GetOrdinal("TCCompra"));
                    
                    miLector.Close();
                }
                miCon.Close();
            }

            return tc;
        }

        public static List<OTipoCambio> DListarTC(int mes, bool xmes)
        {
            List<OTipoCambio> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("SELECT TOP 50 * FROM Tipo_Cambio " + (xmes ? "WHERE MONTH(Fecha)=" + mes : "") + 
                    " ORDER BY Fecha DESC", miCon);
                miCmd.CommandType = CommandType.Text;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OTipoCambio>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordTC(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifTC(bool nuevo, OTipoCambio tc, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifTC", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                //miCmd.CommandTimeout = 500; //tiempo de espera para la consulta es de 5 min

                miCmd.Parameters.AddWithValue("@Nuevo", nuevo);
                miCmd.Parameters.AddWithValue("@Fecha", tc.Fecha);
                miCmd.Parameters.AddWithValue("@TCCompra", tc.TCCompra);
                miCmd.Parameters.AddWithValue("@TCVenta", tc.TCVenta);
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

        private static OTipoCambio FillDataRecordTC(IDataRecord miRecord)
        {
            OTipoCambio tc = new OTipoCambio();

            tc.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            tc.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            tc.TCCompra = miRecord.GetDecimal(miRecord.GetOrdinal("TCCompra"));
            tc.TCVenta = miRecord.GetDecimal(miRecord.GetOrdinal("TCVenta"));
            
            return tc;
        }
    }
}
