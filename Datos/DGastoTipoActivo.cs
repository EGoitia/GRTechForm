using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public class DGastoTipoActivo
    {
        public static int DAnulRestauGastoTipoAct(string @cod, string @nomtupla, int @estado, OInmode @inm)
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

        public static int DInsertModifGastoTipoAct(OGastoTipoActivo @gtact, OInmode @inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifGastoTipoAct", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (@gtact.GastosTipoActivoID == -1)
                    miCmd.Parameters.AddWithValue("@GastosTipoActivoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@GastosTipoActivoID", @gtact.GastosTipoActivoID);

                miCmd.Parameters.AddWithValue("@CodCuenta", @gtact.CodCuenta);
                miCmd.Parameters.AddWithValue("@TipoActivoID", @gtact.TipoActivoID);
                miCmd.Parameters.AddWithValue("@NomGastoTipoActivo", @gtact.NomGastoTipoActivo);
                miCmd.Parameters.AddWithValue("@Detalle", @gtact.Detalle);
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

        public static List<OGastoTipoActivo> DListarGastoTipoAct(int TipoActivoID)
        {
            List<OGastoTipoActivo> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarGastoTipoAct", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@TipoActivoID", TipoActivoID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OGastoTipoActivo>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordGastoTipoAct(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OGastoTipoActivo FillDataRecordGastoTipoAct(IDataRecord miRecord)
        {
            OGastoTipoActivo gtact = new OGastoTipoActivo();

            gtact.GastosTipoActivoID = miRecord.GetInt32(miRecord.GetOrdinal("GastosTipoActivoID"));
            gtact.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            gtact.NomGastoTipoActivo = miRecord.GetString(miRecord.GetOrdinal("NomGastoTipoActivo"));
            gtact.CodCuenta = miRecord.GetString(miRecord.GetOrdinal("CodCuenta"));
            gtact.NomCuenta = miRecord.GetString(miRecord.GetOrdinal("NomCuenta"));
            gtact.TipoActivoID = miRecord.GetInt32(miRecord.GetOrdinal("TipoActivoID"));
            gtact.NomTipoActivo = miRecord.GetString(miRecord.GetOrdinal("NomTipoActivo"));
            gtact.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            gtact.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return gtact;
        }
    }
}
