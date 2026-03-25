using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DTurnoPersonal
    {
        public static int DInsertModifTurPer(OTurnoPersonal tper, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifTurnoPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@PersonalID", tper.PersonalID);
                miCmd.Parameters.AddWithValue("@TurnoID", tper.TurnoID);
                miCmd.Parameters.AddWithValue("@FecInicial", tper.FecInicial);
                miCmd.Parameters.AddWithValue("@FecFinal", tper.FecFinal);
                miCmd.Parameters.AddWithValue("@HrsExt", tper.HrsExt);
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

        public static int DAnulTurPer(int perid, int turid, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("AnulRestauTurPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@PersonalID", perid);
                miCmd.Parameters.AddWithValue("@TurnoID", turid);
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

        public static List<OTurnoPersonal> DListarTurPer(int PersonalID)
        {
            List<OTurnoPersonal> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarTurnoPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                
                if(PersonalID == -1)
                    miCmd.Parameters.AddWithValue("@PersonalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@PersonalID", PersonalID);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OTurnoPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordTurPer(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OTurnoPersonal FillDataRecordTurPer(IDataRecord miRecord)
        {
            OTurnoPersonal tper = new OTurnoPersonal();

            tper.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            tper.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            tper.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            tper.TurnoID = miRecord.GetInt32(miRecord.GetOrdinal("TurnoID"));
            tper.NomTurno = miRecord.GetString(miRecord.GetOrdinal("NomTurno"));
            tper.FecInicial = miRecord.GetDateTime(miRecord.GetOrdinal("FecInicial"));
            tper.FecFinal = miRecord.GetDateTime(miRecord.GetOrdinal("FecFinal"));
            tper.HrsExt = miRecord.GetBoolean(miRecord.GetOrdinal("HrsExt"));

            return tper;
        }
    }
}
