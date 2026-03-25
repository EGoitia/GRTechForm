using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class DClienteUsuario
    {
        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos de Cliente
        /// </summary>
        /// <returns>int</returns>
        public static int DInsertModifCliUsu(OClienteUsuario cliusu, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCliUsu", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (cliusu.ClienteUsuarioID == -1)
                    miCmd.Parameters.AddWithValue("@ClienteUsuarioID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ClienteUsuarioID", cliusu.ClienteUsuarioID);

                miCmd.Parameters.AddWithValue("@ClienteID", cliusu.ClienteID);
                miCmd.Parameters.AddWithValue("@NomUsuCli", cliusu.NomUsuCli);
                miCmd.Parameters.AddWithValue("@Contrasenia", cliusu.Contrasenia);
                miCmd.Parameters.AddWithValue("@Estado", cliusu.Estado);                
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

        /// <summary>
        /// procedimiento para Listar los datos de los Usuarios Clientes
        /// </summary>
        /// <returns>Lista Clientes</returns>
        public static List<OClienteUsuario> DListarCliUsu(int ClienteID)
        {
            List<OClienteUsuario> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarClienteUsuario", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OClienteUsuario>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordCli(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos de los Clientes
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Cliente</returns>
        private static OClienteUsuario FillDataRecordCli(IDataRecord miRecord)
        {
            OClienteUsuario cli = new OClienteUsuario();

            cli.ClienteID = miRecord.GetInt32(miRecord.GetOrdinal("ClienteID"));
            cli.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            cli.ClienteUsuarioID = miRecord.GetInt32(miRecord.GetOrdinal("ClienteUsuarioID"));
            cli.NomUsuCli = miRecord.GetString(miRecord.GetOrdinal("NomUsuCli"));
            cli.Contrasenia = miRecord.GetString(miRecord.GetOrdinal("Contrasenia"));           
            cli.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return cli;
        }
        
    }
}
