using System;
using Objetos;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DCondicion_Comercial
    {
        public static int DInsertModifCondComercial(OCondicion_Comercial condcom, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCondicComer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (condcom.CondComID == -1)
                    miCmd.Parameters.AddWithValue("@CondComID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CondComID", condcom.CondComID);

                miCmd.Parameters.AddWithValue("@Titulo", condcom.Titulo);
                miCmd.Parameters.AddWithValue("@Descripcion", condcom.Descripcion);
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
    }
}
