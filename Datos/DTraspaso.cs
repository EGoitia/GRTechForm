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
    public static class DTraspaso
    {
        /// <summary>
        /// Procedimiento para Restaurar o Anular el Traspaso
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nomtupla"></param>
        /// <param name="estado"></param>
        /// <param name="inmod"></param>
        /// <returns>int</returns>
        public static int DAnulRestauTrasp(string cod, string nomtupla, int estado, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("AnulRestauNota", miCon);
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
        ///  Procedimiento para Insertar o Modificar Datos Traspaso
       /// </summary>
       /// <param name="trasp"></param>
       /// <param name="dtrasp"></param>
       /// <param name="inm"></param>
       /// <returns></returns>
        public static string DInsertModifTrasp(OTraspaso trasp, DataTable inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("InsertModifTrasp", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (trasp.CodTraspaso == string.Empty)
                    miCmd.Parameters.Add("@CodTraspaso", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                else
                    miCmd.Parameters.AddWithValue("@CodTraspaso", trasp.CodTraspaso);
                
                miCmd.Parameters.AddWithValue("@DelAlmacenID", trasp.DelAlmacenID);
                miCmd.Parameters.AddWithValue("@AlAlmacenID", trasp.AlAlmacenID);
                miCmd.Parameters.AddWithValue("@Detalle", trasp.Detalle);
                //Detalle Traspaso
                miCmd.Parameters.AddWithValue("@DetalleTraspaso", trasp.DetalleTraspasoDT);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                try
                {
                    miCon.Open();
                    result = Convert.ToString(miCmd.ExecuteScalar());
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

        public static bool DConfirmarTrasp(string CodTraspaso, DataTable inm)
        {
            bool result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("ConfirmarTrasp", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodTraspaso", CodTraspaso);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();

                    result = true;
                }
                catch (SqlException ex)
                {
                    result = false;
                    throw;
                }
                finally
                {
                    miCon.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// procedimiento para listar los Traspasos
        /// </summary>
        /// <param name="SucID"></param>
        /// <param name="fec"></param>
        /// <returns>Lista Traspasos</returns>
        public static List<OTraspaso> DListarTraspasos(int @SucID, DateTime @fec, char @AMiAlm)
        {
            List<OTraspaso> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarTraspasos", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@AlmID", SucID);
                miCmd.Parameters.AddWithValue("@Fecha", fec);
                miCmd.Parameters.AddWithValue("@AMiAlm", AMiAlm);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OTraspaso>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordTrasp(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para buscar un Traspaso de Almacen
        /// </summary>
        /// <param name="NumTrasp"></param>
        /// <param name="SucursalID"></param>
        /// <returns>Lista Traspaso</returns>
        public static List<OTraspaso> DBuscarTraspaso(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @AlmacenID, char @AMiAlm)
        {
            List<OTraspaso> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarTraspaso", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                miCmd.Parameters.AddWithValue("@TipoBusq", TipoBusq);
                miCmd.Parameters.AddWithValue("@FechaBusq", FechaBusq);
                miCmd.Parameters.AddWithValue("@AlmacenID", AlmacenID);
                miCmd.Parameters.AddWithValue("@AMiAlm", AMiAlm);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OTraspaso>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordTrasp(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }
    
        /// <summary>
        /// Cargamos datos de los Traspasos
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Traspaso</returns>
        private static OTraspaso FillDataRecordTrasp(IDataRecord miRecord)
        {
            OTraspaso trasp = new OTraspaso();

            trasp.CodTraspaso = miRecord.GetString(miRecord.GetOrdinal("CodTraspaso"));
            trasp.DelAlmacenID = miRecord.GetInt32(miRecord.GetOrdinal("DelAlmacenID"));
            trasp.AlAlmacenID = miRecord.GetInt32(miRecord.GetOrdinal("AlAlmacenID"));
            trasp.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            
            return trasp;
        }
    }
}
