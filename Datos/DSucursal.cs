using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

using Objetos;

namespace Datos
{
    public static class DSucursal
    {
        /// <summary>
        /// Procedimiento para listar las Sucursales
        /// </summary>
        /// <returns>Lista Sucursal</returns>
        public static List<OSucursal> DListarSucursales()
        {
            List<OSucursal> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarSuc", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OSucursal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordSuc(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// procedimiento para Insertar y Modificar Datos de Sucursal
        /// </summary>
        /// <param name="suc"></param>
        /// <param name="ubic"></param>
        /// <param name="inm"></param>
        /// <returns>int</returns>
        public static int DInsertModifSucursal(OSucursal suc, OUbicacion ubic, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifSuc", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.CommandTimeout = 500; //tiempo de espera para la consulta es de 5 min

                if (suc.SucursalID == -1)
                    miCmd.Parameters.AddWithValue("@SucursalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucursalID", suc.SucursalID);
                
                miCmd.Parameters.AddWithValue("@NomSuc", suc.NomSuc);
                miCmd.Parameters.AddWithValue("@NomEncSuc", suc.NomEncSuc);
                miCmd.Parameters.AddWithValue("@Telf", suc.Telf);
                //xml Ubicacion
                miCmd.Parameters.AddWithValue("@CodUbicacion", ubic.CodUbicacion);
                miCmd.Parameters.AddWithValue("@PaisID", ubic.PaisID);
                miCmd.Parameters.AddWithValue("@DptoEstado", ubic.DptoEstado);
                miCmd.Parameters.AddWithValue("@Ciudad", ubic.Ciudad);
                miCmd.Parameters.AddWithValue("@Zona", ubic.Zona);
                miCmd.Parameters.AddWithValue("@Barrio", ubic.Barrio);
                miCmd.Parameters.AddWithValue("@Direccion", ubic.Direccion);
                miCmd.Parameters.AddWithValue("@Latitud", ubic.Latitud);
                miCmd.Parameters.AddWithValue("@Longitud", ubic.Longitud);
                miCmd.Parameters.AddWithValue("@Altura", ubic.Altura);
                miCmd.Parameters.AddWithValue("@Exactitud", ubic.Exactitud);
                miCmd.Parameters.AddWithValue("@Escala", ubic.Escala);
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
        /// Cargamos datos de las Sucursales
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Sucursales</returns>
        private static OSucursal FillDataRecordSuc(IDataRecord miRecord)
        {
            OSucursal suc = new OSucursal();

            suc.SucursalID = miRecord.GetInt32(miRecord.GetOrdinal("SucursalID"));
            suc.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            suc.CodUbicacion = miRecord.GetString(miRecord.GetOrdinal("CodUbicacion"));
            suc.NomSuc = miRecord.GetString(miRecord.GetOrdinal("NomSuc"));
            suc.NomEncSuc = miRecord.GetString(miRecord.GetOrdinal("NomEncSuc"));
            suc.Telf = miRecord.GetString(miRecord.GetOrdinal("Telf"));
            //suc.Fax = miRecord.GetString(miRecord.GetOrdinal("Fax"));
            suc.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return suc;
        }
    }
}
