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
    public static class DFeriados
    {
        /// <summary>
        /// procedimiento para Listar los Feriados
        /// </summary>
        /// <returns>ListaFeriados</returns>
        public static List<OFeriados> DListarFeriados()
        {
            List<OFeriados> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarFeriados", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OFeriados>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordFeriados(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para Buscar Feriados
        /// </summary>
        /// <param name="fecini"></param>
        /// <param name="fecfin"></param>
        /// <returns></returns>
        public static List<OFeriados> DBuscarFeriados(DateTime fecini, DateTime fecfin)
        {
            List<OFeriados> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarFeriados", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@fecini", fecini);
                miCmd.Parameters.AddWithValue("@fecfin", fecfin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OFeriados>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordFeriados(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// procedimiento para Insertar y Modificar los Datos de los Feriados
        /// </summary>
        /// <param name="fer"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static int DInsertModifFeriados(OFeriados fer, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifFeriado", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (fer.FeriadoID == -1)
                    miCmd.Parameters.AddWithValue("@FeriadoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@FeriadoID", fer.FeriadoID);
                
                miCmd.Parameters.AddWithValue("@NomFeriado", fer.NomFeriado);
                miCmd.Parameters.AddWithValue("@Descripcion", fer.Descripcion);
                miCmd.Parameters.AddWithValue("@Fecha", fer.Fecha);
                miCmd.Parameters.AddWithValue("@Duracion", fer.Duracion);
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
        /// Procedimiento para Anular o Restaurar los Feriados
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nomtupla"></param>
        /// <param name="estado"></param>
        /// <param name="inmod"></param>
        /// <returns>int</returns>
        public static int DAnulRestauFeriado(string cod, string nomtupla, int estado, OInmode inm)
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
        /// Cargamos datos de los Feriados
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Feriados</returns>
        private static OFeriados FillDataRecordFeriados(IDataRecord miRecord)
        {
            OFeriados fer = new OFeriados();

            fer.FeriadoID = miRecord.GetInt32(miRecord.GetOrdinal("FeriadoID"));
            fer.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            fer.NomFeriado = miRecord.GetString(miRecord.GetOrdinal("NomFeriado"));
            fer.Descripcion = miRecord.GetString(miRecord.GetOrdinal("Descripcion"));
            fer.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            fer.Duracion = miRecord.GetDecimal(miRecord.GetOrdinal("Duracion"));
            fer.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return fer;
        }
    }
}
