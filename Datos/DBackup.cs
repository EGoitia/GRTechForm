using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DBackup
    {
        public static int DCrearBackup(string tipo, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;

                if(tipo == "Backup completo")
                    miCmd = new SqlCommand("CrearBackup", miCon);
                else if(tipo == "Backup diferencial")
                    miCmd = new SqlCommand("CrearBackup", miCon);
                else // Backup incremental
                    miCmd = new SqlCommand("CrearBackup", miCon);

                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.CommandTimeout = 1000; //tiempo de espera para la consulta es de 10 min

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
    }
}
