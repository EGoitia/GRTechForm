using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DControlTransporte
    {
        /// <summary>
        /// procedimiento para Listar datos del Control del Transporte
        /// </summary>
        /// <returns>Lista Control Transporte</returns>
        public static List<OControlTransporte> DListarContTransp(string ciudad)
        {
            List<OControlTransporte> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarContTransp", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if(ciudad == string.Empty)
                    miCmd.Parameters.AddWithValue("@Ciudad", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@Ciudad", ciudad);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OControlTransporte>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordContTransp(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifContTransp(OControlTransporte ctrans, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifContTransp", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (ctrans.ContTransporteID == -1)
                    miCmd.Parameters.AddWithValue("@ContTransporteID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ContTransporteID", ctrans.ContTransporteID);

                miCmd.Parameters.AddWithValue("@NomContTransporte", ctrans.NomContTransporte);
                miCmd.Parameters.AddWithValue("@Ciudad", ctrans.Ciudad);
                miCmd.Parameters.AddWithValue("@Valor", ctrans.Valor);
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

        public static int DAnulRestauAlm(string cod, string nomtupla, int estado, OInmode inm)
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

        /// <summary>
        /// Cargamos datos del Control de Transporte
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Control Transporte</returns>
        private static OControlTransporte FillDataRecordContTransp(IDataRecord miRecord)
        {
            OControlTransporte ctransp = new OControlTransporte();

            ctransp.ContTransporteID = miRecord.GetInt32(miRecord.GetOrdinal("ContTransporteID"));
            ctransp.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            ctransp.NomContTransporte = miRecord.GetString(miRecord.GetOrdinal("NomContTransporte"));
            ctransp.Ciudad = miRecord.GetString(miRecord.GetOrdinal("Ciudad"));
            ctransp.Valor = miRecord.GetInt32(miRecord.GetOrdinal("Valor"));
            ctransp.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return ctransp;
        }
    }
}
