using System;
using System.Data;
using Objetos;
using System.Data.SqlClient;

namespace Datos
{
    public class DRol_Usuario
    {
        public static int InsertModif_RolUsu(ORol_Usuario rol, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {                
                try
                {
                    SqlCommand miCmd;
                    miCmd = new SqlCommand("InsertModifDRolUsu", miCon);
                    miCmd.CommandType = CommandType.StoredProcedure;
                    if (rol.RolID == -1)
                        miCmd.Parameters.AddWithValue("@RolID", DBNull.Value);
                    else
                        miCmd.Parameters.AddWithValue("@RolID", rol.RolID);

                    miCmd.Parameters.AddWithValue("@NomRol", rol.NomRol);
                    miCmd.Parameters.AddWithValue("@TipoSistema", rol.TipoSistema);
                    miCmd.Parameters.AddWithValue("@DetalleRol", rol.DetalleRolDT);
                    //Inmode
                    miCmd.Parameters.AddWithValue("@Inmode", inm);

                    IDataParameter ReturnValue;
                    ReturnValue = miCmd.CreateParameter();
                    ReturnValue.Direction = ParameterDirection.ReturnValue;
                    miCmd.Parameters.Add(ReturnValue);

                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToInt32(ReturnValue.Value);
                }
                catch (Exception ex)
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
