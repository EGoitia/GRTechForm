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
    public static class DPersonal
    {
        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos del Personal
        /// </summary>
        /// <returns>int</returns>
        public static int DInsertModifPer(OPersonal per, OUbicacion ubic, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (per.PersonalID == -1)
                    miCmd.Parameters.AddWithValue("@PersonalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@PersonalID", per.PersonalID);
                
                miCmd.Parameters.AddWithValue("@NomPer", per.NomPer);
                miCmd.Parameters.AddWithValue("@CI", per.CI);
                miCmd.Parameters.AddWithValue("@CargoID", per.CargoID);
                miCmd.Parameters.AddWithValue("@SucursalID", per.SucursalID);
                miCmd.Parameters.AddWithValue("@Telf", per.Telf);
                miCmd.Parameters.AddWithValue("@FecIngreso", per.FecIngreso);
                miCmd.Parameters.AddWithValue("@Email", per.Email);
                miCmd.Parameters.AddWithValue("@EstCivil", per.EstCivil);
                miCmd.Parameters.AddWithValue("@Sexo", per.Sexo);
                miCmd.Parameters.AddWithValue("@Nacionalidad", per.Nacionalidad);
                miCmd.Parameters.AddWithValue("@HaberBasico", per.HaberBasico);
                miCmd.Parameters.AddWithValue("@FecNac", per.FecNac);
                //Imagen
                miCmd.Parameters.AddWithValue("@Img", per.Img);
                //Ubicacion
                miCmd.Parameters.AddWithValue("@CodUbicacion", ubic.CodUbicacion);
                miCmd.Parameters.AddWithValue("@PaisID", ubic.PaisID);
                miCmd.Parameters.AddWithValue("@Ciudad", ubic.Ciudad);
                miCmd.Parameters.AddWithValue("@Direccion", ubic.Direccion);
                miCmd.Parameters.AddWithValue("@Latitud", ubic.Latitud);
                miCmd.Parameters.AddWithValue("@Longitud", ubic.Longitud);
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
        /// Procedimiento para Insertar o Modificar Datos del Personal 
        /// </summary>
        /// <returns>int</returns>
        public static int DInsertModifPerLocal(DataTable lstper)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexionLocal))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifPer_Local", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@LstPer", lstper);
               
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
        /// Procedimiento para Listar el Personal
        /// </summary>
        /// <param name="proveedorid"></param>
        /// <returns>Lista Personal</returns>
        public static List<OPersonal> DListarPersonales(string @Opcion, int @SucursalID)
        {
            List<OPersonal> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarPersonal", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCmd.Parameters.AddWithValue("@SucursalID", SucursalID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordPersonal(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para Listar los Cumpleaños del Personal
        /// </summary>
        /// <param name="proveedorid"></param>
        /// <returns>Lista Cumpleaños del Personal</returns>
        public static List<OPersonal> DListarCumplePerson(string @Mes)
        {
            List<OPersonal> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarCumple", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Mes", @Mes);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordPersonal(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static byte[] DBuscarImgPer(int perid)
        {
            byte[] Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarImgPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@PersonalID", perid);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        if(miLector.Read())
                        {
                            Temp = FillDataRecordImgPersonal(miLector);
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos del Personal
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Personal</returns>
        private static OPersonal FillDataRecordPersonal(IDataRecord miRecord)
        {
            OPersonal per = new OPersonal();

            per.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            per.CargoID = miRecord.GetInt32(miRecord.GetOrdinal("CargoID"));
            per.NomCargo = miRecord.GetString(miRecord.GetOrdinal("NomCargo"));
            per.SucursalID = miRecord.GetInt32(miRecord.GetOrdinal("SucursalID"));
            per.NomSuc = miRecord.GetString(miRecord.GetOrdinal("NomSuc"));
            per.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));            
            per.CodUbicacion = miRecord.GetString(miRecord.GetOrdinal("CodUbicacion"));
            per.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            per.Nacionalidad = miRecord.GetString(miRecord.GetOrdinal("Nacionalidad"));
            per.CI = miRecord.GetString(miRecord.GetOrdinal("CI"));
            per.EstCivil = miRecord.GetString(miRecord.GetOrdinal("EstCivil"));
            per.Sexo = miRecord.GetString(miRecord.GetOrdinal("Sexo"));
            per.Telf = miRecord.GetString(miRecord.GetOrdinal("Telf"));
            per.Email = miRecord.GetString(miRecord.GetOrdinal("Email"));
            per.HaberBasico = miRecord.GetDecimal(miRecord.GetOrdinal("HaberBasico"));
            per.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            try
            {
                per.FecIngreso = miRecord.GetDateTime(miRecord.GetOrdinal("FecIngreso"));
            }
            catch (Exception)
            {
                per.FecIngreso = DateTime.Now;
            }

            try
            {
                per.FecNac = miRecord.GetDateTime(miRecord.GetOrdinal("FecNac"));
            }
            catch (Exception)
            {
                per.FecNac = DateTime.Now;
            }

            try
            {
                per.CodImagen = miRecord.GetString(miRecord.GetOrdinal("CodImagen"));
                per.Img = (byte[])miRecord["Img"];
            }
            catch (Exception)
            {     }
            
            return per;
        }

        private static byte[] FillDataRecordImgPersonal(IDataRecord miRecord)
        {
            byte[] Img = null;
            try
            {
                Img = (byte[])miRecord["Img"];
            }
            catch (Exception)
            { }

            return Img;
        }
    }
}
