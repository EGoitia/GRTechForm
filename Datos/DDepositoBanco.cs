using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDepositoBanco
    {
        public static List<ODepositoBanco> DListarDepBanco(int @cajaid, DateTime fecha)
        {
            List<ODepositoBanco> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarDepBanco", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (@cajaid == -1)
                    miCmd.Parameters.AddWithValue("@CajaID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CajaID", cajaid);

                miCmd.Parameters.AddWithValue("@Fecha", fecha);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODepositoBanco>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDepBanco(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifDepBanco(ODepositoBanco dban, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifDepBanco", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (dban.DepBancoID == -1)
                    miCmd.Parameters.AddWithValue("@DepBancoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@DepBancoID", dban.DepBancoID);

                miCmd.Parameters.AddWithValue("@BancoID", dban.BancoID);
                miCmd.Parameters.AddWithValue("@CajaSalID", dban.CajaSalID);
                miCmd.Parameters.AddWithValue("@Detalle", dban.Detalle);
                miCmd.Parameters.AddWithValue("@NumComprobante", dban.NumComprobante);
                miCmd.Parameters.AddWithValue("@Depositante", dban.Depositante);
                miCmd.Parameters.AddWithValue("@MontoBs", dban.MontoBs);
                miCmd.Parameters.AddWithValue("@MontoSus", dban.MontoSus);
                miCmd.Parameters.AddWithValue("@TC", dban.TC);
                miCmd.Parameters.AddWithValue("@Img", dban.Img);
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

        public static List<ODepositoBanco> DBuscarDepBanco(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @CajaID)
        {
            List<ODepositoBanco> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDepBanco", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                miCmd.Parameters.AddWithValue("@TipoBusq", TipoBusq);
                miCmd.Parameters.AddWithValue("@FechaBusq", FechaBusq);
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODepositoBanco>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDepBanco(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<ODepositoBanco> DBuscarDepBancoxFecha(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            List<ODepositoBanco> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDepBancoxFechas", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODepositoBanco>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDepBancoXFechas(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DAnulRestauDepBanco(string cod, string nomtupla, int estado, OInmode inm)
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

        private static ODepositoBanco FillDataRecordDepBanco(IDataRecord miRecord)
        {
            ODepositoBanco dban = new ODepositoBanco();

            dban.DepBancoID = miRecord.GetInt32(miRecord.GetOrdinal("DepBancoID"));
            dban.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            dban.CodAsiento = miRecord.GetString(miRecord.GetOrdinal("CodAsiento"));
            dban.CodImagen = miRecord.GetString(miRecord.GetOrdinal("CodImagen"));
            dban.BancoID = miRecord.GetInt32(miRecord.GetOrdinal("BancoID"));
            dban.NomBanco = miRecord.GetString(miRecord.GetOrdinal("NomBanco"));
            dban.NumCuenta = miRecord.GetString(miRecord.GetOrdinal("NumCuenta"));
            dban.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            dban.TipoCuenta = miRecord.GetString(miRecord.GetOrdinal("TipoCuenta"));
            dban.Moneda = miRecord.GetString(miRecord.GetOrdinal("Moneda"));
            dban.CajaSalID = miRecord.GetInt32(miRecord.GetOrdinal("CajaID"));
            dban.NomCajaSal = miRecord.GetString(miRecord.GetOrdinal("NomCaja"));
            dban.NumComprobante = miRecord.GetString(miRecord.GetOrdinal("NumComprobante"));
            dban.Depositante = miRecord.GetString(miRecord.GetOrdinal("Depositante"));
            dban.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            dban.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            dban.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));
            dban.TC = miRecord.GetDecimal(miRecord.GetOrdinal("TC"));
            dban.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            try
            {
                dban.Img = (byte[])miRecord["Img"];
            }
            catch (Exception)
            {    }
            
            return dban;
        }

        private static ODepositoBanco FillDataRecordDepBancoXFechas(IDataRecord miRecord)
        {
            ODepositoBanco dban = new ODepositoBanco();

            dban.DepBancoID = miRecord.GetInt32(miRecord.GetOrdinal("DepBancoID"));
            dban.NomBanco = miRecord.GetString(miRecord.GetOrdinal("NomBanco"));
            dban.NumCuenta = miRecord.GetString(miRecord.GetOrdinal("NumCuenta"));
            dban.TipoCuenta = miRecord.GetString(miRecord.GetOrdinal("TipoCuenta"));
            dban.Moneda = miRecord.GetString(miRecord.GetOrdinal("Moneda"));
            dban.CajaSalID = miRecord.GetInt32(miRecord.GetOrdinal("CajaID"));
            dban.NomCajaSal = miRecord.GetString(miRecord.GetOrdinal("NomCaja"));
            dban.NumComprobante = miRecord.GetString(miRecord.GetOrdinal("NumComprobante"));
            dban.Depositante = miRecord.GetString(miRecord.GetOrdinal("Depositante"));
            dban.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            dban.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            dban.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));
            
            return dban;
        }
    }
}
