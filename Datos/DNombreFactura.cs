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
    public static class DNombreFactura
    {
        /// <summary>
        /// Procedimiento para Restaurar o Anular el Nombre de la Factura
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nomtupla"></param>
        /// <param name="estado"></param>
        /// <param name="inmod"></param>
        /// <returns>int</returns>
        public static int DAnulRestauNomFact(string @cod, string @nomtupla, int @estado, OInmode @inm)
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
                catch(Exception ex)
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
        /// Procedimiento para Insertar o Modificar Nombre de Factura
        /// </summary>
        /// <param name="nfact"></param>
        /// <param name="inm"></param>
        /// <returns>int</returns>
        public static int DInsertModifNomFact(ONombreFactura @nfact, DataTable @inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifNomFact", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (nfact.NomFactID == -1)
                {
                    miCmd.Parameters.AddWithValue("@NomFactID", DBNull.Value);
                }
                else
                {
                    miCmd.Parameters.AddWithValue("@NomFactID", nfact.NomFactID);
                }

                miCmd.Parameters.AddWithValue("@NomFact", nfact.NomFact);
                miCmd.Parameters.AddWithValue("@NIT", nfact.NIT);
                miCmd.Parameters.AddWithValue("@ProveedorID", nfact.ProveedorID);
                miCmd.Parameters.AddWithValue("@ClienteID", nfact.ClienteID);
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
        /// procedimiento para listar los Nombres de las Facturas
        /// </summary>
        /// <param name="Opcion"></param>
        /// <param name="ID"></param>
        /// <param name="fec"></param>
        /// <returns></returns>
        public static List<ONombreFactura> DListarNomFact(string @Opcion, int @ID)
        {
            List<ONombreFactura> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarNomFact", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCmd.Parameters.AddWithValue("@ID", ID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ONombreFactura>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordNomFact(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos de los Nombres de las Facturas
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Nombre_Facturas</returns>
        private static ONombreFactura FillDataRecordNomFact(IDataRecord miRecord)
        {
            ONombreFactura nomfact = new ONombreFactura();

            nomfact.NomFactID = miRecord.GetInt32(miRecord.GetOrdinal("NomFactID"));
            nomfact.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            nomfact.NomFact = miRecord.GetString(miRecord.GetOrdinal("NomFact"));
            nomfact.NIT = miRecord.GetString(miRecord.GetOrdinal("NIT"));
            nomfact.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return nomfact;
        }
    }
}
