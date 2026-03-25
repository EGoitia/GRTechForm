using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class DMenu
    {
        public static bool DInsertModifMenu(DataTable _menu)
        {
            bool resp;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                
                try
                {
                    miCmd = new SqlCommand("InsertModifMenu", miCon);
                    miCmd.CommandType = CommandType.StoredProcedure;
                    miCmd.Parameters.AddWithValue("@Menu", _menu);

                    IDataParameter ReturnValue;
                    ReturnValue = miCmd.CreateParameter();
                    ReturnValue.Direction = ParameterDirection.ReturnValue;
                    miCmd.Parameters.Add(ReturnValue);

                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    resp = Convert.ToBoolean(ReturnValue.Value);
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
            return true;
        }
        
    }
}
