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
    public static class DCuentaCont
    {
        /// <summary>
        /// procedimiento para Listar las Cuentas Contables
        /// </summary>
        /// <returns>Lista Cuentas Contables</returns>
        public static List<OCuentaCont> DListarCuentasCont()
        {
            List<OCuentaCont> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarCuentasCont", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCuentaCont>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordCuent(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertModifCuentaCont(OCuentaCont ccont, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCuentaCont", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (ccont.CuentaContID == -1)
                    miCmd.Parameters.AddWithValue("@CuentaContID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CuentaContID", ccont.CuentaContID);

                miCmd.Parameters.AddWithValue("@PadreCuenta", ccont.PadreCuenta);
                miCmd.Parameters.AddWithValue("@NomCuenta", ccont.NomCuenta);
                miCmd.Parameters.AddWithValue("@Moneda", ccont.Moneda);
                miCmd.Parameters.AddWithValue("@TipoCuenta", ccont.TipoCuenta);
                miCmd.Parameters.AddWithValue("@Detalle", ccont.Detalle);
                //Inmode
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
        /// Cargamos datos de las Cuentas Contables
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Cuentas Contables</returns>
        private static OCuentaCont FillDataRecordCuent(IDataRecord miRecord)
        {
            OCuentaCont cuent = new OCuentaCont();

            cuent.CuentaContID = miRecord.GetInt32(miRecord.GetOrdinal("CuentaContID"));
            cuent.CodCuenta = miRecord.GetString(miRecord.GetOrdinal("CodCuenta"));
            cuent.PadreCuenta = miRecord.GetString(miRecord.GetOrdinal("PadreCuenta"));
            cuent.NomCuenta = miRecord.GetString(miRecord.GetOrdinal("NomCuenta"));
            cuent.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            cuent.Moneda = miRecord.GetString(miRecord.GetOrdinal("Moneda"));
            cuent.TipoCuenta = miRecord.GetString(miRecord.GetOrdinal("TipoCuenta"));
            cuent.Borrar = miRecord.GetBoolean(miRecord.GetOrdinal("Borrar"));
            cuent.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));
            
            return cuent;
        }
    }
}
