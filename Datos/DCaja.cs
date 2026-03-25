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
    public static class DCaja
    {
        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos Caja
        /// </summary>
        /// <param name="caj"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static int DInsertModifCaja(OCaja caj, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCaja", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (caj.CajaID == -1)
                    miCmd.Parameters.AddWithValue("@CajaID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CajaID", caj.CajaID);

                miCmd.Parameters.AddWithValue("@NomCaja", caj.NomCaja);
                miCmd.Parameters.AddWithValue("@TipoCajaID", caj.TipoCajaID);
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

        public static bool DVerifCajasCerradas()
        {
            bool result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("VerifCajasCerradas", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                IDataParameter ReturnValue;
                ReturnValue = miCmd.CreateParameter();
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                miCmd.Parameters.Add(ReturnValue);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToBoolean(ReturnValue.Value);
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

    }
}
