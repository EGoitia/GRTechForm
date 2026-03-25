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
    public static class DCliente
    {
        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos de Cliente
        /// </summary>
        /// <returns>int</returns>
        public static int DInsertModifCli(OCliente cli, OUbicacion ubic, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCli", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (cli.ClienteID == -1)
                    miCmd.Parameters.AddWithValue("@ClienteID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ClienteID", cli.ClienteID);

                if (cli.VendedorID == -1)
                    miCmd.Parameters.AddWithValue("@VendedorID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@VendedorID", cli.VendedorID);
                
                miCmd.Parameters.AddWithValue("@NomClien", cli.NomClien);
                miCmd.Parameters.AddWithValue("@TipoClienteID", cli.TipoClienteID);
                miCmd.Parameters.AddWithValue("@Telf", cli.Telf);
                miCmd.Parameters.AddWithValue("@PagWeb", cli.PagWeb);
                miCmd.Parameters.AddWithValue("@Correo", cli.Correo);
                miCmd.Parameters.AddWithValue("@LimiteCredito", cli.LimiteCredito);
                miCmd.Parameters.AddWithValue("@PlazoPago", cli.PlazoPago);
                miCmd.Parameters.AddWithValue("@EstadoLimCredit", cli.EstadoLimCredit);
                miCmd.Parameters.AddWithValue("@EstadoFactMorosas", cli.EstadoFactMorosas);
                //Ubicacion
                miCmd.Parameters.AddWithValue("@PaisID", ubic.PaisID);
                miCmd.Parameters.AddWithValue("@DptoEstado", ubic.DptoEstado);
                miCmd.Parameters.AddWithValue("@Ciudad", ubic.Ciudad);
                miCmd.Parameters.AddWithValue("@Barrio", ubic.Barrio);
                miCmd.Parameters.AddWithValue("@Direccion", ubic.Direccion);
                miCmd.Parameters.AddWithValue("@Zona", ubic.Zona);
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

        /// <summary>
        /// procedimiento para Listar los datos de los Clientes
        /// </summary>
        /// <returns>Lista Clientes</returns>
        public static List<OCliente> DListarClientes(int @SucursalID)
        {
            List<OCliente> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarClientes", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                if (SucursalID == -1)
                    miCmd.Parameters.AddWithValue("@SucursalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucursalID", SucursalID);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCliente>();

                        while (miLector.Read())
                        {
                            if (SucursalID == -1)
                                Temp.Add(FillDataRecordCli(miLector));
                            else
                                Temp.Add(FillDataRecordCli2(miLector));
                            
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
        private static OCliente FillDataRecordCli(IDataRecord miRecord)
        {
            OCliente cli = new OCliente();

            cli.ClienteID = miRecord.GetInt32(miRecord.GetOrdinal("ClienteID"));
            cli.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            cli.VendedorID = miRecord.GetInt32(miRecord.GetOrdinal("VendedorID"));
            cli.NomVendedor = miRecord.GetString(miRecord.GetOrdinal("NomVendedor"));
            cli.NomClien = miRecord.GetString(miRecord.GetOrdinal("NomClien"));
            cli.TipoClienteID = miRecord.GetInt32(miRecord.GetOrdinal("TipoClienteID"));
            cli.Telf = miRecord.GetString(miRecord.GetOrdinal("Telf"));
            cli.PagWeb = miRecord.GetString(miRecord.GetOrdinal("PagWeb"));
            cli.Correo = miRecord.GetString(miRecord.GetOrdinal("Correo"));
            cli.LimiteCredito = miRecord.GetDecimal(miRecord.GetOrdinal("LimiteCredito"));
            cli.PlazoPago = miRecord.GetInt32(miRecord.GetOrdinal("PlazoPago"));
            cli.EstadoLimCredit = miRecord.GetBoolean(miRecord.GetOrdinal("EstadoLimCredit"));
            cli.EstadoFactMorosas = miRecord.GetBoolean(miRecord.GetOrdinal("EstadoFactMorosas"));
            cli.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return cli;
        }

        /// <summary>
        /// Cargamos el Codigo y Nombre de los Clientes
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Cliente</returns>
        private static OCliente FillDataRecordCli2(IDataRecord miRecord)
        {
            OCliente cli = new OCliente();

            cli.ClienteID = miRecord.GetInt32(miRecord.GetOrdinal("ClienteID"));
            cli.NomClien = miRecord.GetString(miRecord.GetOrdinal("NomClien"));
            cli.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return cli;
        }
    }
}
