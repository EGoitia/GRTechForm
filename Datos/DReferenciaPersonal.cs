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
    public static class DReferenciaPersonal
    {
        /// <summary>
        /// Procedimiento para Anular o Restaurar la Referencia del Personal
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nomtupla"></param>
        /// <param name="estado"></param>
        /// <param name="inmod"></param>
        /// <returns>int</returns>
        public static int DAnulRestauReferPer(string cod, string nomtupla, int estado, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("AnulRestau", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Codigo", cod);
                miCmd.Parameters.AddWithValue("@NomTupla", nomtupla);
                miCmd.Parameters.AddWithValue("@Estado", estado);
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
                    miCon.Close();
                }
                catch(Exception ex)
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
        /// procedimiento para Listar las Referencias del Personal
        /// </summary>
        /// <returns>Lista de los Proveedores</returns>
        public static List<OReferenciaPersonal> DListarReferPer(int personalid)
        {
            List<OReferenciaPersonal> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarReferPer", miCon);
                miCmd.Parameters.AddWithValue("@PersonalID", personalid);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OReferenciaPersonal>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRPer(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        ///  Procedimiento para Insertar o Modificar Datos de las Referencias del Personal
        /// </summary>
        /// <param name="rper"></param>
        /// <param name="ubic"></param>
        /// <param name="inm"></param>
        /// <returns>int</returns>
        public static int DInsertModifReferPer(OReferenciaPersonal rper, OUbicacion ubic, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifReferPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                if (rper.RefPersonalID == -1)
                {
                    miCmd.Parameters.AddWithValue("@RefPersonalID", DBNull.Value);
                }
                else
                {
                    miCmd.Parameters.AddWithValue("@RefPersonalID", rper.RefPersonalID);
                }
                
                miCmd.Parameters.AddWithValue("@PersonalID", rper.PersonalID);
                miCmd.Parameters.AddWithValue("@NomRefer", rper.NomRefer);
                miCmd.Parameters.AddWithValue("@ParentescoRefer", rper.ParentescoRefer);
                miCmd.Parameters.AddWithValue("@TelfRefer", rper.TelfRefer);
                miCmd.Parameters.AddWithValue("@CelRefer", rper.CelRefer);
                //CodUbicacion
                miCmd.Parameters.AddWithValue("@CodUbicacion", ubic.CodUbicacion);
                miCmd.Parameters.AddWithValue("@PaisID", ubic.PaisID);
                miCmd.Parameters.AddWithValue("@Ciudad", ubic.Ciudad);
                miCmd.Parameters.AddWithValue("@Zona", ubic.Zona);
                miCmd.Parameters.AddWithValue("@Barrio", ubic.Barrio);
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
                    miCon.Close();
                }
                catch(Exception ex)
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
        /// Cargamos datos de las Referencias del Personal
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos ReferenciaPersonal</returns>
        private static OReferenciaPersonal FillDataRecordRPer(IDataRecord miRecord)
        {
            OReferenciaPersonal rper = new OReferenciaPersonal();

            rper.RefPersonalID = miRecord.GetInt32(miRecord.GetOrdinal("RefPersonalID"));
            rper.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            rper.CodUbicacion = miRecord.GetString(miRecord.GetOrdinal("CodUbicacion"));
            rper.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            rper.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            rper.NomRefer = miRecord.GetString(miRecord.GetOrdinal("NomRefer"));
            rper.ParentescoRefer = miRecord.GetString(miRecord.GetOrdinal("ParentescoRefer"));
            rper.TelfRefer = miRecord.GetString(miRecord.GetOrdinal("TelfRefer"));
            rper.CelRefer = miRecord.GetString(miRecord.GetOrdinal("CelRefer"));
            rper.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            //Ubicacion
            rper.NomPais = miRecord.GetString(miRecord.GetOrdinal("NomPais"));
            rper.Ciudad = miRecord.GetString(miRecord.GetOrdinal("Ciudad"));
            rper.Zona = miRecord.GetString(miRecord.GetOrdinal("Zona"));
            rper.Barrio = miRecord.GetString(miRecord.GetOrdinal("Barrio"));
            rper.Direccion = miRecord.GetString(miRecord.GetOrdinal("Direccion"));
            rper.Latitud = miRecord.GetString(miRecord.GetOrdinal("Latitud"));
            rper.Longitud = miRecord.GetString(miRecord.GetOrdinal("Longitud"));

            return rper;
        }
    }
}
