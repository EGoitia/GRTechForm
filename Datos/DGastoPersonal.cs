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
    public static class DGastoPersonal
    {
        /// <summary>
        /// Procedimiento para Restaurar o Anular los Gastos del Personal
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nomtupla"></param>
        /// <param name="estado"></param>
        /// <param name="inmod"></param>
        /// <returns>int</returns>
        public static int DAnulRestauGastoPer(string @cod, string @nomtupla, int @estado, OInmode @inm)
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
                    miCon.Close();
                }
                catch(SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// Procedimiento para Insertar o Modificar los Gastos del Personal
       /// </summary>
       /// <param name="gper"></param>
       /// <param name="inm"></param>
       /// <returns>int</returns>
        public static int DInsertModifGastoPer(OGastoPersonal @gper, OInmode @inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifGastoPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (gper.CodGastoPer == string.Empty)
                {
                    miCmd.Parameters.AddWithValue("@CodGastoPer", DBNull.Value);
                }
                else
                {
                    miCmd.Parameters.AddWithValue("@CodGastoPer", @gper.CodGastoPer);
                }

                miCmd.Parameters.AddWithValue("@CajaID", gper.CajaID);
                miCmd.Parameters.AddWithValue("@PersonalID", gper.PersonalID);
                miCmd.Parameters.AddWithValue("@Opcion", gper.Opcion);
                miCmd.Parameters.AddWithValue("@Concepto", gper.Concepto);
                miCmd.Parameters.AddWithValue("@Detalle", gper.Detalle);
                miCmd.Parameters.AddWithValue("@MontoBs", gper.MontoBs);
                miCmd.Parameters.AddWithValue("@MontoSus", gper.MontoSus);
                miCmd.Parameters.AddWithValue("@TC", gper.TC);
                miCmd.Parameters.AddWithValue("@Suma", gper.Suma);
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
                catch(SqlException ex)
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
        /// procedimiento para listar los Gastos del Personal
        /// </summary>
        /// <param name="CajaID"></param>
        /// <param name="fec"></param>
        /// <returns>int</returns>
        public static List<OGastoPersonal> DListarGastoPer(int @CajaID, DateTime @fec)
        {
            List<OGastoPersonal> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarGastoPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@Fecha", fec);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OGastoPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordGastoPer(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OGastoPersonal> DListarRevGastoXPersonal(int @SucID, int @PerID, string @Opcion, DateTime @FIni, DateTime @FFin)
        {
            List<OGastoPersonal> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarRevGastoXPersonal", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (SucID == -1)
                    miCmd.Parameters.AddWithValue("@SucID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucID", SucID);

                miCmd.Parameters.AddWithValue("@PerID", PerID);
                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCmd.Parameters.AddWithValue("@FecIni", FIni);
                miCmd.Parameters.AddWithValue("@FecFin", FFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OGastoPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRegulGastoPer(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OGastoPersonal> DListarGastoPerXFecha(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            List<OGastoPersonal> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarGastoPerXFecha", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OGastoPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordGastoPer(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para buscar los Gastos del Personal
        /// </summary>
        /// <param name="Tipo"></param>
        /// <param name="Opcion"></param>
        /// <param name="Busqueda"></param>
        /// <param name="SucursalID"></param>
        /// <param name="Fecha"></param>
        /// <returns></returns>
        public static List<OGastoPersonal> DBuscarGastoPer(string @Opcion, string @Busqueda, int @CajaID, DateTime @Fecha)
        {
            List<OGastoPersonal> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarGastoPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@Fecha", Fecha);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OGastoPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordGastoPer(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OGastoPersonal> DBuscarDeudasPer(int @PersonalID)
        {
            List<OGastoPersonal> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDeudasPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@PersonalID", PersonalID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OGastoPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRegulGastoPer(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos de los Gastos del Personal
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos GastoPersonal</returns>
        private static OGastoPersonal FillDataRecordGastoPer(IDataRecord miRecord)
        {
            OGastoPersonal gper = new OGastoPersonal();

            gper.CodGastoPer = miRecord.GetString(miRecord.GetOrdinal("CodGastoPer"));
            gper.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            gper.CodAsiento = miRecord.GetString(miRecord.GetOrdinal("CodAsiento"));
            gper.NumGastoPer = miRecord.GetString(miRecord.GetOrdinal("NumGastoPer"));
            gper.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            gper.Opcion = miRecord.GetString(miRecord.GetOrdinal("Opcion"));
            gper.CajaID = miRecord.GetInt32(miRecord.GetOrdinal("CajaID"));
            gper.NomCaja = miRecord.GetString(miRecord.GetOrdinal("NomCaja"));
            gper.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            gper.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            gper.Concepto = miRecord.GetString(miRecord.GetOrdinal("Concepto"));
            gper.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            gper.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            gper.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));
            gper.TC = miRecord.GetDecimal(miRecord.GetOrdinal("TC"));
            gper.Suma = miRecord.GetString(miRecord.GetOrdinal("Suma"));
            gper.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return gper;
        }

        private static OGastoPersonal FillDataRecordRegulGastoPer(IDataRecord miRecord)
        {
            OGastoPersonal gper = new OGastoPersonal();

            gper.CodGastoPer = miRecord.GetString(miRecord.GetOrdinal("CodGastoPer"));
            gper.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            gper.CodAsiento = miRecord.GetString(miRecord.GetOrdinal("CodAsiento"));
            gper.NumGastoPer = miRecord.GetString(miRecord.GetOrdinal("NumGastoPer"));
            gper.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            gper.Opcion = miRecord.GetString(miRecord.GetOrdinal("Opcion"));
            gper.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            gper.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            gper.CajaID = miRecord.GetInt32(miRecord.GetOrdinal("CajaID"));
            gper.NomCaja = miRecord.GetString(miRecord.GetOrdinal("NomCaja"));
            gper.Concepto = miRecord.GetString(miRecord.GetOrdinal("Concepto"));
            gper.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            gper.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            gper.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));
            gper.TC = miRecord.GetDecimal(miRecord.GetOrdinal("TC"));
            gper.Suma = miRecord.GetString(miRecord.GetOrdinal("Suma"));
            gper.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            try
            {
                //totales
                gper.TotalDsctoBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalDsctoBs"));
                gper.TotalPagadoBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalPagadoBs"));
                gper.TotalSaldoBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalSaldoBs"));
            }
            catch (Exception)
            {      }
            
            return gper;
        }
    }
}
