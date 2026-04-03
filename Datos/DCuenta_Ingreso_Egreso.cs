using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DCuenta_Ingreso_Egreso
    {
        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos de GastosIngreso
        /// </summary>
        /// <param name="cueningregre"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static int DInsertModifCuentaIngrEgre(OCuenta_Ingresos_Egresos cueningregre, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCuentaIngrEgre", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (cueningregre.Cuenta_Ingreso_EgresoID == -1)
                    miCmd.Parameters.AddWithValue("@Cuenta_Ingreso_EgresoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@Cuenta_Ingreso_EgresoID", cueningregre.Cuenta_Ingreso_EgresoID);

                miCmd.Parameters.AddWithValue("@TipoIngresoEgreso", cueningregre.TipoIngresoEgreso);
                miCmd.Parameters.AddWithValue("@TipoCuentaID", cueningregre.TipoCuentaID);
                miCmd.Parameters.AddWithValue("@Nombre", cueningregre.Nombre);
                miCmd.Parameters.AddWithValue("@Descripcion", cueningregre.Descripcion);
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
                catch (SqlException)
                {
                    throw;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    miCon.Close();
                }
            }
            return result;
        }

        public static void DInsertModifCuentaIngrEgreLocal(DataTable dtCuentas)
        {
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexionLocal))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCuentaIngrEgre_Local", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@LstCuentas", dtCuentas);

                IDataParameter ReturnValue;
                ReturnValue = miCmd.CreateParameter();
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                miCmd.Parameters.Add(ReturnValue);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();
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
        }
    }
}
