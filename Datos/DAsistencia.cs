using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DAsistencia
    {
        public static List<OAsistencia> DListarAsistencia(int PersonalID, int Mes, int Gestion)
        {
            List<OAsistencia> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarAsistencia", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if(PersonalID == -1)
                    miCmd.Parameters.AddWithValue("@PersonalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@PersonalID", PersonalID);

                miCmd.Parameters.AddWithValue("@Mes", Mes);
                miCmd.Parameters.AddWithValue("@Gestion", Gestion);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OAsistencia>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordAsis(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertarModifAsistencia(OAsistencia asis, string dasis, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifAsistencia", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (asis.CodAsistencia == string.Empty)
                    miCmd.Parameters.AddWithValue("@CodAsistencia", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodAsistencia", asis.CodAsistencia);

                miCmd.Parameters.AddWithValue("@PersonalID", asis.PersonalID);
                miCmd.Parameters.AddWithValue("@Mes", asis.Mes);
                miCmd.Parameters.AddWithValue("@Gestion", asis.Gestion);
                miCmd.Parameters.AddWithValue("@TotDiasExtras", asis.TotDiasExtras);
                miCmd.Parameters.AddWithValue("@TotDiasFalta", asis.TotDiasFalta);
                miCmd.Parameters.AddWithValue("@TotDiasPermiso", asis.TotDiasPermiso);
                miCmd.Parameters.AddWithValue("@TotDiasTarde", asis.TotDiasTarde);
                miCmd.Parameters.AddWithValue("@TotHrsExtras", asis.TotHrsExtras);
                miCmd.Parameters.AddWithValue("@TotHrsFalta", asis.TotHrsFalta);
                miCmd.Parameters.AddWithValue("@TotHrsPermiso", asis.TotHrsPermiso);
                miCmd.Parameters.AddWithValue("@TotHrsTarde", asis.TotHrsTarde);
                //Detalle Asistencia
                miCmd.Parameters.AddWithValue("@DAsis", dasis);
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

        private static OAsistencia FillDataRecordAsis(IDataRecord miRecord)
        {
            OAsistencia asis = new OAsistencia();

            asis.CodAsistencia = miRecord.GetString(miRecord.GetOrdinal("CodAsistencia"));
            asis.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            asis.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            asis.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            asis.TotDiasExtras = miRecord.GetInt32(miRecord.GetOrdinal("TotDiasExtras"));
            asis.TotDiasFalta = miRecord.GetInt32(miRecord.GetOrdinal("TotDiasFalta"));
            asis.TotDiasPermiso = miRecord.GetInt32(miRecord.GetOrdinal("TotDiasPermiso"));
            asis.TotDiasTarde = miRecord.GetInt32(miRecord.GetOrdinal("TotDiasTarde"));
            asis.TotDiasVacacion = miRecord.GetInt32(miRecord.GetOrdinal("TotDiasVacacion"));
            asis.TotHrsExtras = miRecord.GetDecimal(miRecord.GetOrdinal("TotHrsExtras"));
            asis.TotHrsFalta = miRecord.GetDecimal(miRecord.GetOrdinal("TotHrsFalta"));
            asis.TotHrsPermiso = miRecord.GetDecimal(miRecord.GetOrdinal("TotHrsPermiso"));
            asis.TotHrsTarde = miRecord.GetDecimal(miRecord.GetOrdinal("TotHrsTarde"));
           
            return asis;
        }
    }
}
