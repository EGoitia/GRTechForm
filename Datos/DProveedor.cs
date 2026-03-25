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
    public static class DProveedor
    {
        
        /// <summary>
        /// procedimiento para Listar los datos de los Proveedores
        /// </summary>
        /// <returns>Lista de los Proveedores</returns>
        public static List<OProveedor> DListarProveedores()
        {
            List<OProveedor> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("SELECT * FROM Vista_Proveedores", miCon);
                miCmd.CommandType = CommandType.Text;
                //miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OProveedor>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordProv(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos de los Proveedores
        /// </summary>
        /// <param name="prov"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static int DInsertModifProveedor(OProveedor prov, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifProv", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                if(prov.ProveedorID == -1)
                    miCmd.Parameters.AddWithValue("@ProveedorID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ProveedorID", prov.ProveedorID);

                miCmd.Parameters.AddWithValue("@NomProv", prov.NomProv);
                miCmd.Parameters.AddWithValue("@TipoProvID", prov.TipoProvID);
                miCmd.Parameters.AddWithValue("@Nota", prov.Nota);
                miCmd.Parameters.AddWithValue("@Telf", prov.Telf);
                miCmd.Parameters.AddWithValue("@Fax", prov.Fax);
                miCmd.Parameters.AddWithValue("@PagWeb", prov.PagWeb);
                miCmd.Parameters.AddWithValue("@Correo", prov.Correo);
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
        /// Cargamos datos de los Proveedores
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Proveedores</returns>
        private static OProveedor FillDataRecordProv(IDataRecord miRecord)
        {
            OProveedor prov = new OProveedor();

            prov.ProveedorID = miRecord.GetInt32(miRecord.GetOrdinal("ProveedorID"));
            prov.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            prov.NomProv = miRecord.GetString(miRecord.GetOrdinal("NomProv"));
            prov.TipoProv = miRecord.GetString(miRecord.GetOrdinal("TipoProv"));
            prov.Nota = miRecord.GetString(miRecord.GetOrdinal("Nota"));
            prov.Telf = miRecord.GetString(miRecord.GetOrdinal("Telf"));
            prov.Fax = miRecord.GetString(miRecord.GetOrdinal("Fax"));
            prov.PagWeb = miRecord.GetString(miRecord.GetOrdinal("PagWeb"));
            prov.Correo = miRecord.GetString(miRecord.GetOrdinal("Correo"));
            prov.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return prov;
        }
    }
}
