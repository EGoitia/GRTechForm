using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

using Objetos;

namespace Datos
{
    public static class DConformidad
    {
        /// <summary>
        /// Procedimiento para Insertar o Modificar Notas de Conformidad
        /// </summary>
        /// <param name="conf"></param>
        /// <param name="ubic"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static int DInsertarModifConf(OConformidad conf, string dconf, OUbicacion ubic, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifConf", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (conf.CodConformidad == string.Empty)
                    miCmd.Parameters.AddWithValue("@CodConformidad", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodConformidad", conf.CodConformidad);
                
                miCmd.Parameters.AddWithValue("@SucursalID", conf.SucursalID);
                miCmd.Parameters.AddWithValue("@DestinoID", conf.DestinoID);
                miCmd.Parameters.AddWithValue("@ChoferID", conf.ChoferID);
                miCmd.Parameters.AddWithValue("@NotSalida", conf.NotSalida);
                miCmd.Parameters.AddWithValue("@Valor", conf.Valor);
                miCmd.Parameters.AddWithValue("@Placa", conf.Placa);
                miCmd.Parameters.AddWithValue("@Referencia", conf.Referencia);
                miCmd.Parameters.AddWithValue("@Totalm2", conf.Totalm2);
                miCmd.Parameters.AddWithValue("@TotalBolsa", conf.TotalBolsa);
                miCmd.Parameters.AddWithValue("@TotalPzas", conf.TotalPzas);
                miCmd.Parameters.AddWithValue("@Detalle", conf.Detalle);
                //Detalle Conformidad
                miCmd.Parameters.AddWithValue("@DConf", dconf);
                //Ubicacion
                miCmd.Parameters.AddWithValue("@CodUbicacion", ubic.CodUbicacion);
                miCmd.Parameters.AddWithValue("@PaisID", ubic.PaisID);
                miCmd.Parameters.AddWithValue("@DptoEstado", ubic.DptoEstado);
                miCmd.Parameters.AddWithValue("@Ciudad", ubic.Ciudad);
                miCmd.Parameters.AddWithValue("@Zona", ubic.Zona);
                miCmd.Parameters.AddWithValue("@Barrio", ubic.Barrio);
                miCmd.Parameters.AddWithValue("@Direccion", ubic.Direccion);
                miCmd.Parameters.AddWithValue("@Latitud", ubic.Latitud);
                miCmd.Parameters.AddWithValue("@Longitud", ubic.Longitud);
                miCmd.Parameters.AddWithValue("@Altura", ubic.Altura);
                miCmd.Parameters.AddWithValue("@Exactitud", ubic.Exactitud);
                miCmd.Parameters.AddWithValue("@Escala", ubic.Escala);
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
        /// Procedimiento para Anular o Restaurar Notas de Conformidad
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nomtupla"></param>
        /// <param name="estado"></param>
        /// <param name="inmod"></param>
        /// <returns>int</returns>
        public static int DAnulRestauConf(string cod, string nomtupla, int estado, OInmode inm)
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
        /// procedimiento para Listar las Notas de Conformidad
        /// </summary>
        /// <param name="SucID"></param>
        /// <param name="fec"></param>
        /// <returns>Lista Conformidad</returns>
        public static List<OConformidad> DListarConformidad(int @SucID, DateTime @fec)
        {
            List<OConformidad> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarConformidad", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@SucursalID", SucID);
                miCmd.Parameters.AddWithValue("@Fecha", fec);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OConformidad>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordConf(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para Buscar las Notas de Conformidad
        /// </summary>
        /// <param name="Opcion"></param>
        /// <param name="Busqueda"></param>
        /// <param name="SucursalID"></param>
        /// <param name="Fecha"></param>
        /// <returns>Lista Conformidad</returns>
        public static List<OConformidad> DBuscarConf(string @Opcion, string @Busqueda, int @SucursalID, DateTime @Fecha)
        {
            List<OConformidad> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarConf", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                miCmd.Parameters.AddWithValue("@SucursalID", SucursalID);
                miCmd.Parameters.AddWithValue("@Fecha", Fecha);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OConformidad>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordConf(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OConformidad> DBuscarConfXChofer(int @ChoferID, int @SucursalID, DateTime @FecIni, DateTime @FecFin)
        {
            List<OConformidad> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarConfXChofer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                //si es -1 el choferid mandamos nulo
                if(ChoferID == -1)
                    miCmd.Parameters.AddWithValue("@ChoferID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ChoferID", ChoferID);
                //si es -1 la sucursal, mandamos nulo
                if(SucursalID == -1)
                    miCmd.Parameters.AddWithValue("@SucursalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucursalID", SucursalID);
                
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OConformidad>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordConf(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static OValorConformidad DValorConformidad(string @CodConformidad)
        {
            OValorConformidad Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ValorConf", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodConformidad", CodConformidad);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new OValorConformidad();

                        while (miLector.Read())
                        {
                            Temp = FillDataRecordValConf(miLector);
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifValorConformidad(string dvalconf, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifValConf", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                //Detalle Valor Conformidad
                miCmd.Parameters.AddWithValue("@DValConf", dvalconf);
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
        /// Cargamos datos de las Notas de Conformidad
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Conformidad</returns>
        private static OConformidad FillDataRecordConf(IDataRecord miRecord)
        {
            OConformidad conf = new OConformidad();
            conf.CodConformidad = miRecord.GetString(miRecord.GetOrdinal("CodConformidad"));
            conf.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            conf.CodUbicacion = miRecord.GetString(miRecord.GetOrdinal("CodUbicacion"));
            conf.SucursalID = miRecord.GetInt32(miRecord.GetOrdinal("SucursalID"));
            conf.NomSuc = miRecord.GetString(miRecord.GetOrdinal("NomSuc"));
            conf.DestinoID = miRecord.GetInt32(miRecord.GetOrdinal("DestinoID"));
            conf.NomContTransporte = miRecord.GetString(miRecord.GetOrdinal("NomContTransporte"));
            conf.ChoferID = miRecord.GetInt32(miRecord.GetOrdinal("ChoferID"));
            conf.NomChofer = miRecord.GetString(miRecord.GetOrdinal("NomChofer"));
            conf.NumConform = miRecord.GetString(miRecord.GetOrdinal("NumConform"));
            conf.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            conf.NotSalida = miRecord.GetString(miRecord.GetOrdinal("NotSalida"));
            conf.Valor = miRecord.GetInt32(miRecord.GetOrdinal("Valor"));
            conf.Placa = miRecord.GetString(miRecord.GetOrdinal("Placa"));
            conf.Referencia = miRecord.GetString(miRecord.GetOrdinal("Referencia"));
            conf.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            conf.Totalm2 = miRecord.GetDecimal(miRecord.GetOrdinal("Totalm2"));
            conf.TotalBolsa = miRecord.GetDecimal(miRecord.GetOrdinal("TotalBolsa"));
            conf.TotalPzas = miRecord.GetDecimal(miRecord.GetOrdinal("TotalPzas"));
            conf.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            conf.CodUbicacion = miRecord.GetString(miRecord.GetOrdinal("CodUbicacion"));
            conf.Ciudad = miRecord.GetString(miRecord.GetOrdinal("Ciudad"));
            conf.Zona = miRecord.GetString(miRecord.GetOrdinal("Zona"));
            conf.Barrio = miRecord.GetString(miRecord.GetOrdinal("Barrio"));
            conf.Direccion = miRecord.GetString(miRecord.GetOrdinal("Direccion"));
            conf.Latitud = miRecord.GetString(miRecord.GetOrdinal("Latitud"));
            conf.Longitud = miRecord.GetString(miRecord.GetOrdinal("Longitud"));

            return conf;
        }

        private static OValorConformidad FillDataRecordValConf(IDataRecord miRecord)
        {
            OValorConformidad vconf = new OValorConformidad();

            vconf.CodConformidad = miRecord.GetString(miRecord.GetOrdinal("CodConformidad"));
            vconf.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            vconf.ComxMetro = miRecord.GetDecimal(miRecord.GetOrdinal("ComxMetro"));
            vconf.ComxPza = miRecord.GetDecimal(miRecord.GetOrdinal("ComxPza"));
            vconf.ComxBolsa = miRecord.GetDecimal(miRecord.GetOrdinal("ComxBolsa"));
                       
            return vconf;
        }
    }
}
