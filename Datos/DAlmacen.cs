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
    public static class DAlmacen
    {
        /// <summary>
        /// procedimiento para Listar lo Almacenes
        /// </summary>
        /// <returns>Lista Almacenes</returns>
        public static List<OAlmacen> DListarAlmacenes(int @sucid)
        {
            List<OAlmacen> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarAlmacen", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                
                if(sucid == -1)
                    miCmd.Parameters.AddWithValue("@SucursalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucursalID", sucid);
                
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OAlmacen>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordAlm(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// procedimiento para Modificar los Datos del Almacen
        /// </summary>
        /// <returns>Modificar Almacen</returns>
        /// 
        public static int DInsertModifAlmacen(OAlmacen alm, OUbicacion ubic, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifAlmacen", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                
                if(alm.AlmacenID == -1)
                    miCmd.Parameters.AddWithValue("@AlmacenID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@AlmacenID", alm.AlmacenID);

                miCmd.Parameters.AddWithValue("@SucursalID", alm.SucursalID);
                miCmd.Parameters.AddWithValue("@NomAlmacen", alm.NomAlmacen);
                miCmd.Parameters.AddWithValue("@NomEncAlmacen", alm.NomEncAlmacen);
                //ubicacion
                miCmd.Parameters.AddWithValue("@CodUbicacion", ubic.CodUbicacion);
                miCmd.Parameters.AddWithValue("@Zona", ubic.Zona);
                miCmd.Parameters.AddWithValue("@Barrio", ubic.Barrio);
                miCmd.Parameters.AddWithValue("@Direccion", ubic.Direccion);
                miCmd.Parameters.AddWithValue("@Latitud", ubic.Latitud);
                miCmd.Parameters.AddWithValue("@Longitud", ubic.Longitud);
                miCmd.Parameters.AddWithValue("@Altura", ubic.Altura);
                miCmd.Parameters.AddWithValue("@Exactitud", ubic.Exactitud);
                miCmd.Parameters.AddWithValue("@Escala", ubic.Escala);
                //Inmode
                miCmd.Parameters.AddWithValue("@CodInmode", inm.CodInmode);
                miCmd.Parameters.AddWithValue("@UsuarioID", inm.UsuarioID);
                miCmd.Parameters.AddWithValue("@TipoInmode", inm.TipoInmode);
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
        /// Cargamos datos de los Almacenes
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Almacen</returns>
        private static OAlmacen FillDataRecordAlm(IDataRecord miRecord)
        {
            OAlmacen alm = new OAlmacen();

            alm.AlmacenID = miRecord.GetInt32(miRecord.GetOrdinal("AlmacenID"));
            alm.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            alm.CodUbicacion = miRecord.GetString(miRecord.GetOrdinal("CodUbicacion"));
            alm.SucursalID = miRecord.GetInt32(miRecord.GetOrdinal("SucursalID"));
            alm.NomSuc = miRecord.GetString(miRecord.GetOrdinal("NomSuc"));
            alm.NomAlmacen = miRecord.GetString(miRecord.GetOrdinal("NomAlmacen"));
            alm.NomEncAlmacen = miRecord.GetString(miRecord.GetOrdinal("NomEncAlmacen"));
            alm.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return alm;
        }
    }
}
