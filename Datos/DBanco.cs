using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Datos
{
    public class DBanco
    {
        /// <summary>
        /// Procedimiento para Anular o Restaurar Banco
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="inmod"></param>
        /// <returns>1 ó -1</returns>
        public static int DAnulRestauBanco(string cod, string nomtupla, int estado, OInmode inm)
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
        /// Procedimiento para Insertar o Modificar Datos del Banco
        /// </summary>
        /// <returns>int</returns>
        public static int DInsertModifBanco(OBanco ban, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifBan", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (ban.BancoID == -1)
                {
                    miCmd.Parameters.AddWithValue("@BancoID", DBNull.Value);
                }
                else
                {
                    miCmd.Parameters.AddWithValue("@BancoID", ban.BancoID);
                }

                miCmd.Parameters.AddWithValue("@NumCuenta", ban.NumCuenta);
                miCmd.Parameters.AddWithValue("@TipoCuenta", ban.TipoCuenta);
                miCmd.Parameters.AddWithValue("@Moneda", ban.Moneda);
                miCmd.Parameters.AddWithValue("@NomBanco", ban.NomBanco);
                miCmd.Parameters.AddWithValue("@Detalle", ban.Detalle);
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
        /// procedimiento para Listar los Bancos
        /// </summary>
        /// <returns>Lista Bancos</returns>
        public static List<OBanco> DListarBancos()
        {
            List<OBanco> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarBancos", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OBanco>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordBan(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos de los Bancos
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Banco</returns>
        private static OBanco FillDataRecordBan(IDataRecord miRecord)
        {
            OBanco ban = new OBanco();

            ban.BancoID = miRecord.GetInt32(miRecord.GetOrdinal("BancoID"));
            ban.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            ban.NumCuenta = miRecord.GetString(miRecord.GetOrdinal("NumCuenta"));
            ban.TipoCuenta = miRecord.GetString(miRecord.GetOrdinal("TipoCuenta"));
            ban.Moneda = miRecord.GetString(miRecord.GetOrdinal("Moneda"));
            ban.NomBanco = miRecord.GetString(miRecord.GetOrdinal("NomBanco"));
            ban.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            ban.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return ban;
        }
    }
}
