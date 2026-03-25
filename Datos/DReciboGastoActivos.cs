using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DReciboGastoActivos
    {
        public static List<OReciboGastoActivo> DListarReciboGastoActivo(int @CajaID, DateTime @fec)
        {
            List<OReciboGastoActivo> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarReciboGastoActivo", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@Fecha", fec);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OReciboGastoActivo>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordReciboGastoActivo(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DAnulRestauReciboGastoActivo(string cod, string nomtupla, int estado, OInmode inm)
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

        public static int DInsertModifReciboGastoActivo(OReciboGastoActivo recgasact, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifReciboGastoActivo", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                if (recgasact.CodRecGastoActivo == string.Empty)
                    miCmd.Parameters.AddWithValue("@CodRecGastoActivo", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodRecGastoActivo", recgasact.CodRecGastoActivo);

                miCmd.Parameters.AddWithValue("@CajaID", recgasact.CajaID);
                miCmd.Parameters.AddWithValue("@ActivoID", recgasact.ActivoID);
                miCmd.Parameters.AddWithValue("@GastosTipoActivoID", recgasact.GastosTipoActivoID);
                miCmd.Parameters.AddWithValue("@Concepto", recgasact.Concepto);
                miCmd.Parameters.AddWithValue("@Detalle", recgasact.Detalle);
                miCmd.Parameters.AddWithValue("@Suma", recgasact.Suma);
                miCmd.Parameters.AddWithValue("@MontoBs", recgasact.MontoBs);
                miCmd.Parameters.AddWithValue("@MontoSus", recgasact.MontoSus);
                miCmd.Parameters.AddWithValue("@TC", recgasact.TC);
                //Inmode
                miCmd.Parameters.AddWithValue("@CodInmode", inm.CodInmode);
                miCmd.Parameters.AddWithValue("@TipoInmode", inm.TipoInmode);
                miCmd.Parameters.AddWithValue("@UsuarioID", inm.UsuarioID);
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

        public static List<OReciboGastoActivo> DBuscarReciboGastoActivo(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @CajaID)
        {
            List<OReciboGastoActivo> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarReciboGastoActivo", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", Busqueda);
                miCmd.Parameters.AddWithValue("@Busqueda", TipoBusq);
                miCmd.Parameters.AddWithValue("@FechaBusq", FechaBusq);
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OReciboGastoActivo>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordReciboGastoActivo(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OReciboGastoActivo> DKardexActivo(int @ActivoID, DateTime @FecIni, DateTime @FecFin)
        {
            List<OReciboGastoActivo> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarKardexActivo", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@ActivoID", ActivoID);
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OReciboGastoActivo>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordReciboGastoActivo(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos de los Recibos
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Recibo</returns>
        private static OReciboGastoActivo FillDataRecordReciboGastoActivo(IDataRecord miRecord)
        {
            OReciboGastoActivo rec = new OReciboGastoActivo();

            rec.CodRecGastoActivo = miRecord.GetString(miRecord.GetOrdinal("CodRecGastoActivo"));
            rec.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            rec.CodAsiento = miRecord.GetString(miRecord.GetOrdinal("CodAsiento"));
            rec.NumRecGastoActivo = miRecord.GetString(miRecord.GetOrdinal("NumRecGastoActivo"));
            rec.CajaID = miRecord.GetInt32(miRecord.GetOrdinal("CajaID"));
            rec.NomCaja = miRecord.GetString(miRecord.GetOrdinal("NomCaja"));
            rec.ActivoID = miRecord.GetInt32(miRecord.GetOrdinal("ActivoID"));
            rec.NomActivo = miRecord.GetString(miRecord.GetOrdinal("NomActivo"));
            rec.TipoActivoID = miRecord.GetInt32(miRecord.GetOrdinal("TipoActivoID"));
            rec.NomTipoActivo = miRecord.GetString(miRecord.GetOrdinal("NomTipoActivo"));
            rec.GastosTipoActivoID = miRecord.GetInt32(miRecord.GetOrdinal("GastosTipoActivoID"));
            rec.NomGastoTipoActivo = miRecord.GetString(miRecord.GetOrdinal("NomGastoTipoActivo"));
            rec.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            rec.Concepto = miRecord.GetString(miRecord.GetOrdinal("Concepto"));
            rec.Suma = miRecord.GetString(miRecord.GetOrdinal("Suma"));
            rec.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            rec.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            rec.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));
            rec.TC = miRecord.GetDecimal(miRecord.GetOrdinal("TC"));
            rec.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return rec;
        }
    }
}
