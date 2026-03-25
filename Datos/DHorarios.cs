using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DHorarios
    {
        public static int DAnulRestauHorario(string cod, string nomtupla, int estado, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("AnulRestau", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Codigo", cod);
                miCmd.Parameters.AddWithValue("@NomTupla", nomtupla);
                miCmd.Parameters.AddWithValue("@Estado", estado);
                //Inmode
                miCmd.Parameters.AddWithValue("@CodInmode", inm.CodInmode);
                miCmd.Parameters.AddWithValue("@UsuarioID", inm.UsuarioID);
                miCmd.Parameters.AddWithValue("@TipoInmode", inm.TipoInmode);
                miCmd.Parameters.AddWithValue("@NomInmode", inm.NomInmode);
                miCmd.Parameters.AddWithValue("@IPInmode", inm.IPInmode);
                miCmd.Parameters.AddWithValue("@MacInmode", inm.MacInmode);
                miCmd.Parameters.AddWithValue("@MaquinaInmode", inm.MaquinaInmode);
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

        public static int DInsertModifHorario(OHorario hor, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifHorario", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (hor.HorarioID == -1)
                    miCmd.Parameters.AddWithValue("@HorarioID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@HorarioID", hor.HorarioID);

                miCmd.Parameters.AddWithValue("@NomHorario", hor.NomHorario);
                miCmd.Parameters.AddWithValue("@HrEntrada", hor.HrEntrada);
                miCmd.Parameters.AddWithValue("@HrSalida", hor.HrSalida);
                miCmd.Parameters.AddWithValue("@MinTolerEnt", hor.MinTolerEnt);
                miCmd.Parameters.AddWithValue("@MinTolerSal", hor.MinTolerSal);
                miCmd.Parameters.AddWithValue("@InicioEntr", hor.InicioEntr);
                miCmd.Parameters.AddWithValue("@FinEntr", hor.FinEntr);
                miCmd.Parameters.AddWithValue("@InicioSal", hor.InicioSal);
                miCmd.Parameters.AddWithValue("@FinSal", hor.FinSal);
                miCmd.Parameters.AddWithValue("@ValorDiaTrab", hor.ValorDiaTrab);
                miCmd.Parameters.AddWithValue("@Color", hor.Color);
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

        public static List<OHorario> DListarHorario()
        {
            List<OHorario> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarHorario", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OHorario>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordHorario(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OHorario FillDataRecordHorario(IDataRecord miRecord)
        {
            OHorario hor = new OHorario();

            hor.HorarioID = miRecord.GetInt32(miRecord.GetOrdinal("HorarioID"));
            hor.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodImnode"));
            hor.NomHorario = miRecord.GetString(miRecord.GetOrdinal("NomHorario"));
            hor.HrEntrada = miRecord.GetDateTime(miRecord.GetOrdinal("HrEntrada"));
            hor.HrSalida = miRecord.GetDateTime(miRecord.GetOrdinal("HrSalida"));
            hor.InicioEntr = miRecord.GetDateTime(miRecord.GetOrdinal("InicioEntr"));
            hor.FinEntr = miRecord.GetDateTime(miRecord.GetOrdinal("FinEntr"));
            hor.InicioSal = miRecord.GetDateTime(miRecord.GetOrdinal("InicioSal"));
            hor.FinSal = miRecord.GetDateTime(miRecord.GetOrdinal("FinSal"));
            hor.MinTolerEnt = miRecord.GetInt32(miRecord.GetOrdinal("MinTolerEnt"));
            hor.MinTolerSal = miRecord.GetInt32(miRecord.GetOrdinal("MinTolerSal"));
            hor.ValorDiaTrab = miRecord.GetInt32(miRecord.GetOrdinal("ValorDiaTrab"));
            hor.Color = miRecord.GetString(miRecord.GetOrdinal("Color"));
            hor.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return hor;
        }
    }
}
