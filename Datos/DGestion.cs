using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DGestion
    {
        public static List<OGestion> DListarGestion()
        {
            List<OGestion> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarGestion", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OGestion>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordGestion(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }
 
        public static int DInsertModifGestion(OGestion ges, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifGestion", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@AnioGestion", ges.AnioGestion);
                miCmd.Parameters.AddWithValue("@Observacion", ges.Observacion);
                //Inmode
                miCmd.Parameters.AddWithValue("@CodInmode", inm.CodInmode);
                miCmd.Parameters.AddWithValue("@NomInmode", inm.NomInmode);
                miCmd.Parameters.AddWithValue("@IPInmode", inm.IPInmode);
                miCmd.Parameters.AddWithValue("@MacInmode", inm.MacInmode);
                miCmd.Parameters.AddWithValue("@MaquinaInmode", inm.MaquinaInmode);
                miCmd.Parameters.AddWithValue("@SistOperInmode", inm.SistOperInmode);
                miCmd.Parameters.AddWithValue("@NavegInmode", inm.NavegInmode);
                miCmd.Parameters.AddWithValue("@DetaInmode", inm.DetalleInmode);
                IDataParameter ReturnValue;
                ReturnValue = miCmd.CreateParameter();
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                miCmd.Parameters.Add(ReturnValue);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToInt32(ReturnValue.Value);
                    miCon.Close();
                }
                catch(SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return result;
        }

        private static OGestion FillDataRecordGestion(IDataRecord miRecord)
        {
            OGestion ges = new OGestion();

            ges.AnioGestion = miRecord.GetInt32(miRecord.GetOrdinal("AnioGestion"));
            ges.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            ges.CodAsiento = miRecord.GetString(miRecord.GetOrdinal("CodAsiento"));
            ges.Observacion = miRecord.GetString(miRecord.GetOrdinal("Observacion"));

            return ges;
        }
    }
}
