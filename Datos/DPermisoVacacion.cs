using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DPermisoVacacion
    {
        public static List<OPermisoVacacion> DListarPermisoVacacion(DateTime @Fecha)
        {
            List<OPermisoVacacion> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarPermisoVacacion", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Fecha", Fecha);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OPermisoVacacion>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordPermVac(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifPermisoVacacion(OPermisoVacacion pervac, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifPermisoVacacion", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (pervac.PermVacaID == -1)
                    miCmd.Parameters.AddWithValue("@PermVacaID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@PermVacaID", pervac.PermVacaID);

                miCmd.Parameters.AddWithValue("@TipoPermisoID", pervac.TipoPermisoID);
                miCmd.Parameters.AddWithValue("@PersonalID", pervac.PersonalID);
                miCmd.Parameters.AddWithValue("@Observacion", pervac.Observacion);
                miCmd.Parameters.AddWithValue("@FechaPermisoInic", pervac.FechaPermisoInic);
                miCmd.Parameters.AddWithValue("@FechaPermisoFin", pervac.FechaPermisoFin);
                miCmd.Parameters.AddWithValue("@TotDias", pervac.TotDias);
                miCmd.Parameters.AddWithValue("@TotHrs", pervac.TotHrs);
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

        public static List<OPermisoVacacion> DBuscarPermisoVacacion(string @Busqueda, string @TipoBusq, DateTime @FechaBusq)
        {
            List<OPermisoVacacion> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarPermisoVacacion", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                miCmd.Parameters.AddWithValue("@TipoBusq", TipoBusq);
                miCmd.Parameters.AddWithValue("@FechaBusq", FechaBusq);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OPermisoVacacion>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordPermVac(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DAnulRestauPermisoVacacion(string cod, string nomtupla, int estado, OInmode inm)
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

        private static OPermisoVacacion FillDataRecordPermVac(IDataRecord miRecord)
        {
            OPermisoVacacion pervac = new OPermisoVacacion();

            pervac.PermVacaID = miRecord.GetInt32(miRecord.GetOrdinal("PermVacaID"));
            pervac.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            pervac.NomTipoPermiso = miRecord.GetString(miRecord.GetOrdinal("NomTipoPermiso"));
            pervac.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            pervac.Observacion = miRecord.GetString(miRecord.GetOrdinal("Observacion"));
            pervac.FechaPermisoInic = miRecord.GetDateTime(miRecord.GetOrdinal("FechaPermisoInic"));
            pervac.FechaPermisoFin = miRecord.GetDateTime(miRecord.GetOrdinal("FechaPermisoFin"));
            pervac.TotDias = miRecord.GetInt32(miRecord.GetOrdinal("TotDias"));
            pervac.TotHrs = miRecord.GetDecimal(miRecord.GetOrdinal("TotHrs"));
            pervac.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return pervac;
        }
    }
}
