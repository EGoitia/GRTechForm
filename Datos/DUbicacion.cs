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
    public static class DUbicacion
    {
        /// <summary>
        /// Procedimiento para buscar la ubicacion por Codigo
       /// </summary>
       /// <param name="codigo"></param>
       /// <returns></returns>
        public static OUbicacion DBuscarUbicacion(string @codigo, string @opcion)
        {
            OUbicacion Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarUbic", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Codigo", codigo);
                miCmd.Parameters.AddWithValue("@Opcion", opcion);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new OUbicacion();
                        if(miLector.Read())
                        {
                            Temp = FillDataRecordUbic(miLector);
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para ver la ubicacion del Proveedor
        /// </summary>
        /// <param name="proveedorid"></param>
        /// <returns>Lista Ubicacion</returns>
        public static List<OUbicacion> DListarUbicaciones(string @codigo, string @tupla)
        {
            List<OUbicacion> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarUbic", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Codigo", codigo);
                miCmd.Parameters.AddWithValue("@Tupla", tupla);
                
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OUbicacion>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordUbic(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para Insertar Modificar Ubicacion
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="tupla"></param>
        /// <param name="ubic"></param>
        /// <param name="inm"></param>
        /// <returns>int</returns>
        public static int DInsertModifUbic(Int32 codigo, string tupla, OUbicacion ubic, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifUbic", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@Codigo", codigo);
                miCmd.Parameters.AddWithValue("@Tupla", tupla);
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
        /// Cargamos datos de la Ubicacion
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos ubicacion</returns>
        private static OUbicacion FillDataRecordUbic(IDataRecord miRecord)
        {
            OUbicacion ubic = new OUbicacion();

            ubic.CodUbicacion = miRecord.GetString(miRecord.GetOrdinal("CodUbicacion"));
            ubic.CodInmodeUbic = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            ubic.PaisID = miRecord.GetInt32(miRecord.GetOrdinal("PaisID"));
            ubic.NomPais = miRecord.GetString(miRecord.GetOrdinal("NomPais"));
            ubic.DptoEstado = miRecord.GetString(miRecord.GetOrdinal("DptoEstado"));
            ubic.Ciudad = miRecord.GetString(miRecord.GetOrdinal("Ciudad"));
            ubic.Zona = miRecord.GetString(miRecord.GetOrdinal("Zona"));
            ubic.Barrio = miRecord.GetString(miRecord.GetOrdinal("Barrio"));
            ubic.Direccion = miRecord.GetString(miRecord.GetOrdinal("Direccion"));
            ubic.Latitud = miRecord.GetString(miRecord.GetOrdinal("Latitud"));
            ubic.Longitud = miRecord.GetString(miRecord.GetOrdinal("Longitud"));
            ubic.Altura = miRecord.GetString(miRecord.GetOrdinal("Altura"));
            ubic.Exactitud = miRecord.GetString(miRecord.GetOrdinal("Exactitud"));
            ubic.Escala = miRecord.GetString(miRecord.GetOrdinal("Escala"));
            ubic.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return ubic;
        }
    }
}
