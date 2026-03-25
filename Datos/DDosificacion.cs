using Objetos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DDosificacion
    {
        public static int DInsertDosificacion(ODosificacion dosific, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertDosific", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (dosific.DosificacionID == -1)
                    miCmd.Parameters.AddWithValue("@DosificacionID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@DosificacionID", dosific.DosificacionID);

                miCmd.Parameters.AddWithValue("@ActividadID", dosific.ActividadID);
                miCmd.Parameters.AddWithValue("@SucursalID", dosific.SucursalID);
                miCmd.Parameters.AddWithValue("@TipoDosificacionID", dosific.TipoDosificacionID);
                miCmd.Parameters.AddWithValue("@Autorizacion", dosific.Autorizacion);
                miCmd.Parameters.AddWithValue("@Descripcion", dosific.Descripcion);
                miCmd.Parameters.AddWithValue("@Fecha_Ini", dosific.Fecha_Ini);
                miCmd.Parameters.AddWithValue("@Fecha_Lim", dosific.Fecha_Lim);
                miCmd.Parameters.AddWithValue("@Leyenda", dosific.Leyenda);
                miCmd.Parameters.AddWithValue("@Llave", dosific.Llave);
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
