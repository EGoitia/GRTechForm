using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDocumento
    {
        /// <summary>
        /// Procedimiento para insertar o modificar el documento
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="opc"></param>
        /// <param name="cod"></param>
        /// <param name="inm"></param>
        /// <returns>int</returns>
        public static int DInsertModifDoc(ODocumento doc, string opc, string cod, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifDoc", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (doc.CodDocumento == string.Empty)
                {
                    miCmd.Parameters.AddWithValue("@CodDocumento", DBNull.Value);
                }
                else
                {
                    miCmd.Parameters.AddWithValue("@CodDocumento", doc.CodDocumento);
                }

                miCmd.Parameters.AddWithValue("@NomDcto", doc.NomDcto);
                miCmd.Parameters.AddWithValue("@PalClave", doc.PalClave);
                miCmd.Parameters.AddWithValue("@TipoDcto", doc.TipoDcto);
                miCmd.Parameters.AddWithValue("@Formato", doc.Formato);
                miCmd.Parameters.AddWithValue("@Descripcion", doc.Descripcion);
                miCmd.Parameters.AddWithValue("@Dcto", SqlDbType.VarBinary).Value = doc.Doc;
                //Opcion
                miCmd.Parameters.AddWithValue("@Opcion", opc);
                miCmd.Parameters.AddWithValue("@Codigo", cod);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);
                
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
        /// Procedimiento para Anular o Restaurar los Documentos
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nomtupla"></param>
        /// <param name="estado"></param>
        /// <param name="inmod"></param>
        /// <returns></returns>
        public static int DAnulRestauDoc(string cod, string nomtupla, int estado, OInmode inm)
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

        /// <summary>
        /// Procedimiento para listar los documentos
        /// </summary>
        /// <param name="opc"></param>
        /// <param name="cod"></param>
        /// <returns>objeto doc</returns>
        public static List<ODocumento> DListarDoc(string opc, string cod)
        {
            List<ODocumento> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarDoc", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", opc);
                miCmd.Parameters.AddWithValue("@Codigo", cod);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODocumento>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecorddoc(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para buscar un documento
        /// </summary>
        /// <param name="CodDocumento"></param>
        /// <returns></returns>
        public static byte[] DBuscarDoc(string CodDocumento)
        {
            byte[] Doc = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDoc", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodDocumento", CodDocumento);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        if (miLector.Read())
                        {
                            //IDataRecord miRecord = miLector;
                            Doc = (byte[])miLector["Doc"];
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Doc;
        }

        /// <summary>
        /// Cargamos datos de los Documentos
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Documentos</returns>
        private static ODocumento FillDataRecorddoc(IDataRecord miRecord)
        {
            ODocumento doc = new ODocumento();

            doc.CodDocumento = miRecord.GetString(miRecord.GetOrdinal("CodDocumento"));
            doc.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            doc.NomDcto = miRecord.GetString(miRecord.GetOrdinal("NomDcto"));
            doc.PalClave = miRecord.GetString(miRecord.GetOrdinal("PalClave"));
            doc.TipoDcto = miRecord.GetString(miRecord.GetOrdinal("TipoDcto"));
            doc.Descripcion = miRecord.GetString(miRecord.GetOrdinal("Descripcion"));
            doc.Formato = miRecord.GetString(miRecord.GetOrdinal("Formato"));
            doc.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return doc;
        }
    }
}
