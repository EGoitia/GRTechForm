using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


using Objetos;

namespace Datos
{
    public static class DRegistroAsistencia
    {
        public static List<ORegistroAsistencia> DListarRegAsis(int PersonalID, DateTime Fecha)
        {
            List<ORegistroAsistencia> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarRegAsis", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (PersonalID == -1)
                    miCmd.Parameters.AddWithValue("@PersonalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@PersonalID", PersonalID);

                miCmd.Parameters.AddWithValue("@Fecha", Fecha);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ORegistroAsistencia>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRegAsis(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifRegAsis(string rasis, string cod, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifRegAsis", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (cod == string.Empty)
                    miCmd.Parameters.AddWithValue("@CodRegAsistencia", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodRegAsistencia", cod);

                miCmd.Parameters.AddWithValue("@RAsis", rasis);
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

        private static ORegistroAsistencia FillDataRecordRegAsis(IDataRecord miRecord)
        {
            ORegistroAsistencia alm = new ORegistroAsistencia();

            alm.CodRegAsistencia = miRecord.GetString(miRecord.GetOrdinal("CodRegAsistencia"));
            alm.Marcacion = miRecord.GetDateTime(miRecord.GetOrdinal("Marcacion"));
            alm.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            alm.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            alm.TipoMarcacion = miRecord.GetString(miRecord.GetOrdinal("TipoMarcacion"));
            alm.Observacion = miRecord.GetString(miRecord.GetOrdinal("Observacion"));
            alm.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            alm.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return alm;
        }
    }
}
