using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDepreciacionActivo
    {
        public static List<ODepreciacionActivo> DListarDepreciacionActivo(int ActivoID)
        {
            List<ODepreciacionActivo> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarDepreciacionActivo", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (ActivoID == -1)
                    miCmd.Parameters.AddWithValue("@ActivoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ActivoID", ActivoID);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODepreciacionActivo>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDeprecAct(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertarDepreciacionActivo(string dact, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertarDepreciacionActivo", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@DAct", dact);
                //Inmode
                miCmd.Parameters.AddWithValue("@CodInmode", inm.CodInmode);
                miCmd.Parameters.AddWithValue("@UsuarioID", inm.UsuarioID);
                miCmd.Parameters.AddWithValue("@TipoInmode", inm.TipoInmode);
                miCmd.Parameters.AddWithValue("@NomInmode", inm.NomInmode);
                miCmd.Parameters.AddWithValue("@IPInmode", inm.IPInmode);
                miCmd.Parameters.AddWithValue("@MacInmode", inm.MacInmode);
                miCmd.Parameters.AddWithValue("@MaquinaInmode", inm.MaquinaInmode);
                miCmd.Parameters.AddWithValue("@SistOperInmode", inm.SistOperInmode);
                miCmd.Parameters.AddWithValue("@NavegInmode", inm.NavegInmode);
                miCmd.Parameters.AddWithValue("@DetalleInmode", inm.DetalleInmode);

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

        private static ODepreciacionActivo FillDataRecordDeprecAct(IDataRecord miRecord)
        {
            ODepreciacionActivo dact = new ODepreciacionActivo();

            dact.ActivoID = miRecord.GetInt32(miRecord.GetOrdinal("ActivoID"));
            dact.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            dact.NomActivo = miRecord.GetString(miRecord.GetOrdinal("NomActivo"));

            dact.DeprecAcumActual = miRecord.GetDecimal(miRecord.GetOrdinal("DeprecAcumActual"));
            dact.DeprecAcumAnt = miRecord.GetDecimal(miRecord.GetOrdinal("DeprecAcumAnt"));
            dact.DeprecPeriodo = miRecord.GetDecimal(miRecord.GetOrdinal("DeprecPeriodo"));
            dact.FactorActualizado = miRecord.GetDecimal(miRecord.GetOrdinal("FactorActualizado"));
            dact.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            dact.IncremenDeprecAcum = miRecord.GetDecimal(miRecord.GetOrdinal("IncremenDeprecAcum"));
            dact.IncrementoActualizado = miRecord.GetDecimal(miRecord.GetOrdinal("IncrementoActualizado"));
            dact.ValorActualizado = miRecord.GetDecimal(miRecord.GetOrdinal("ValorActualizado"));
            dact.ValorContabilizado = miRecord.GetDecimal(miRecord.GetOrdinal("ValorContabilizado"));
            dact.ValorNetoBs = miRecord.GetDecimal(miRecord.GetOrdinal("ValorNetoBs"));
            dact.VidaUtilRest = miRecord.GetDecimal(miRecord.GetOrdinal("VidaUtilRest"));
            
            return dact;
        }
    }
}
