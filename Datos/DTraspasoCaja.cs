using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DTraspasoCaja
    {
        public static List<OTraspasoCaja> DListarTraspCaja(int @cajaid, DateTime @fecha, bool amicaja)
        {
            List<OTraspasoCaja> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarTraspCaja", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (@cajaid == -1)
                    miCmd.Parameters.AddWithValue("@CajaID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CajaID", @cajaid);

                miCmd.Parameters.AddWithValue("@Fecha", @fecha);
                miCmd.Parameters.AddWithValue("@AMiCaja", @amicaja);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OTraspasoCaja>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordTraspCaja(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OTraspasoCaja> DBuscarTraspCaja(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @CajaID, bool @AMiCaja)
        {
            List<OTraspasoCaja> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarTraspCaja", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Busqueda", @Busqueda);
                miCmd.Parameters.AddWithValue("@TipoBusq", @TipoBusq);
                miCmd.Parameters.AddWithValue("@FechaBusq", @FechaBusq);
                miCmd.Parameters.AddWithValue("@CajaID", @CajaID);
                miCmd.Parameters.AddWithValue("@AMiCaja", @AMiCaja);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OTraspasoCaja>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordTraspCaja(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OTraspasoCaja> DBuscarTraspCajaXFechas(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            List<OTraspasoCaja> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarTraspCajaXFechas", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaID", @CajaID);
                miCmd.Parameters.AddWithValue("@FecIni", @FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", @FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OTraspasoCaja>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordTraspCajaXFechas(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifTraspCaja(OTraspasoCaja tcaj, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifTraspCaja", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (tcaj.TraspasoCajaID == -1)
                    miCmd.Parameters.AddWithValue("@TraspasoCajaID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@TraspasoCajaID", tcaj.TraspasoCajaID);

                miCmd.Parameters.AddWithValue("@CajaIDDel", tcaj.CajaIDDel);
                miCmd.Parameters.AddWithValue("@CajaIDAl", tcaj.CajaIDAl);
                miCmd.Parameters.AddWithValue("@Detalle", tcaj.Detalle);
                miCmd.Parameters.AddWithValue("@MontoBs", tcaj.MontoBs);
                miCmd.Parameters.AddWithValue("@MontoSus", tcaj.MontoSus);
                miCmd.Parameters.AddWithValue("@TC", tcaj.TC);
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

        public static int DAnulRestauTraspCaja(string cod, string nomtupla, int estado, OInmode inm)
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

        private static OTraspasoCaja FillDataRecordTraspCaja(IDataRecord miRecord)
        {
            OTraspasoCaja tcaja = new OTraspasoCaja();

            tcaja.TraspasoCajaID = miRecord.GetInt32(miRecord.GetOrdinal("TraspasoCajaID"));
            tcaja.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            tcaja.NumTraspCaja = miRecord.GetString(miRecord.GetOrdinal("NumTraspCaja"));
            tcaja.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            tcaja.CajaIDDel = miRecord.GetInt32(miRecord.GetOrdinal("CajaIDDel"));
            tcaja.NomCajaDel = miRecord.GetString(miRecord.GetOrdinal("NomCajaDel"));
            tcaja.CajaIDAl = miRecord.GetInt32(miRecord.GetOrdinal("CajaIDAl"));
            tcaja.NomCajaAl = miRecord.GetString(miRecord.GetOrdinal("NomCajaAl"));
            tcaja.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            tcaja.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            tcaja.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));
            tcaja.TC = miRecord.GetDecimal(miRecord.GetOrdinal("TC"));
            tcaja.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return tcaja;
        }

        private static OTraspasoCaja FillDataRecordTraspCajaXFechas(IDataRecord miRecord)
        {
            OTraspasoCaja tcaja = new OTraspasoCaja();

            tcaja.NumTraspCaja = miRecord.GetString(miRecord.GetOrdinal("NumTraspCaja"));
            tcaja.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            tcaja.NomCajaDel = miRecord.GetString(miRecord.GetOrdinal("NomCajaDel"));
            tcaja.NomCajaAl = miRecord.GetString(miRecord.GetOrdinal("NomCajaAl"));
            tcaja.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            tcaja.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));

            return tcaja;
        }
    }
}
