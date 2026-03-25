using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DPrestamoProv
    {
        public static List<OPrestamoProv> DListarPresProv(DateTime fecha)
        {
            List<OPrestamoProv> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarPresProv", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Fecha", fecha);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OPrestamoProv>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordPresProv(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifPresProv(OPrestamoProv pres, OPago pag, string dpago, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifPresProv", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (pres.PrestamoID == -1)
                    miCmd.Parameters.AddWithValue("@PrestamoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@PrestamoID", pres.PrestamoID);

                miCmd.Parameters.AddWithValue("@NumContrato", pres.NumContrato);
                miCmd.Parameters.AddWithValue("@PlazoMeses", pres.PlazoMeses);
                miCmd.Parameters.AddWithValue("@ProveedorID", pres.ProveedorID);
                miCmd.Parameters.AddWithValue("@ContratoBs", pres.ContratoBs);
                miCmd.Parameters.AddWithValue("@InteresPorcent", pres.InteresPorcent);
                miCmd.Parameters.AddWithValue("@TotalPrestamoBs", pres.TotalPrestamoBs);
                miCmd.Parameters.AddWithValue("@Detalle", pres.Detalle);
                miCmd.Parameters.AddWithValue("@Documento", pres.Documento);
                //Pago
                miCmd.Parameters.AddWithValue("@CodPago", pag.CodPago);
                miCmd.Parameters.AddWithValue("@TC", pag.TC);
                miCmd.Parameters.AddWithValue("@TotalPagadoBs", pag.TotalPagadoBs);
                //Detalle de Pago
                miCmd.Parameters.AddWithValue("@DPago", dpago);
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

        public static List<OPrestamoProv> DBuscarPresProv(string @Opcion, string @Busqueda, DateTime @Fecha)
        {
            List<OPrestamoProv> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarPresProv", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", @Opcion);
                miCmd.Parameters.AddWithValue("@Busqueda", @Busqueda);
                miCmd.Parameters.AddWithValue("@Fecha", @Fecha);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OPrestamoProv>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordPresProv(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;   
        }

        public static int DAnulRestauPresProv(string cod, string nomtupla, int estado, OInmode inm)
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

        private static OPrestamoProv FillDataRecordPresProv(IDataRecord miRecord)
        {
            OPrestamoProv pres = new OPrestamoProv();

            pres.PrestamoID = miRecord.GetInt32(miRecord.GetOrdinal("PrestamoID"));
            pres.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            pres.CodAsiento = miRecord.GetString(miRecord.GetOrdinal("CodAsiento"));
            pres.CodPago = miRecord.GetString(miRecord.GetOrdinal("CodPago"));
            pres.ProveedorID = miRecord.GetInt32(miRecord.GetOrdinal("ProveedorID"));
            pres.NomProv = miRecord.GetString(miRecord.GetOrdinal("NomProv"));
            pres.NumContrato = miRecord.GetString(miRecord.GetOrdinal("NumContrato"));
            pres.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            pres.ContratoBs = miRecord.GetDecimal(miRecord.GetOrdinal("ContratoBs"));
            pres.InteresPorcent = miRecord.GetDecimal(miRecord.GetOrdinal("InteresPorcent"));
            pres.TotalPrestamoBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalPrestamoBs"));
            pres.PlazoMeses = miRecord.GetInt32(miRecord.GetOrdinal("PlazoMeses"));
            pres.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            pres.Documento = miRecord.GetBoolean(miRecord.GetOrdinal("Documento"));
            pres.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return pres;
        }
    }
}
