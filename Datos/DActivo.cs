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
    public static class DActivo
    {
        /// <summary>
        /// procedimiento para Listar lo Activos
        /// </summary>
        /// <returns>Lista Activos</returns>
        public static List<OActivo> DListarActivos()
        {
            List<OActivo> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarActivos", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OActivo>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordAct(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DInsertarModifActivo(OActivo act, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifActivo", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (act.ActivoID == -1)
                    miCmd.Parameters.AddWithValue("@ActivoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ActivoID", act.ActivoID);

                miCmd.Parameters.AddWithValue("@SucursalID", act.SucursalID);
                miCmd.Parameters.AddWithValue("@ProveedorID", act.ProveedorID);
                miCmd.Parameters.AddWithValue("@TipoActivoID", act.TipoActivoID);
                miCmd.Parameters.AddWithValue("@PersonalRespID", act.PersonalRespID);
                miCmd.Parameters.AddWithValue("@Serial", act.Serial);
                miCmd.Parameters.AddWithValue("@NomActivo", act.NomActivo);
                miCmd.Parameters.AddWithValue("@FormaAdquisicion", act.FormaAdquisicion);
                miCmd.Parameters.AddWithValue("@FechaAdquisicion", act.FechaAdquisicion);
                miCmd.Parameters.AddWithValue("@Documento", act.Documento);
                miCmd.Parameters.AddWithValue("@Marca", act.Marca);
                miCmd.Parameters.AddWithValue("@Modelo", act.Modelo);
                miCmd.Parameters.AddWithValue("@Costo", act.Costo);
                miCmd.Parameters.AddWithValue("@CostoDeprec", act.CostoDeprec);
                miCmd.Parameters.AddWithValue("@MesesGarantia", act.MesesGarantia);
                miCmd.Parameters.AddWithValue("@MesesRestantes", act.MesesRestantes);
                miCmd.Parameters.AddWithValue("@MesesVidaUtil", act.MesesVidaUtil);
                miCmd.Parameters.AddWithValue("@ValResidual", act.ValResidual);
                miCmd.Parameters.AddWithValue("@Descripcion", act.Descripcion);
                miCmd.Parameters.AddWithValue("@Observacion", act.Observacion);
                miCmd.Parameters.AddWithValue("@Garantia", act.Garantia);
                miCmd.Parameters.AddWithValue("@Depreciable", act.Depreciable);
                miCmd.Parameters.AddWithValue("@Contabilizado", act.Contabilizado);
                //Imagen
                miCmd.Parameters.AddWithValue("@Img", act.Img);
                miCmd.Parameters.AddWithValue("@ImgQR", act.ImgQR);
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

        public static int DAnulRestauActivo(string cod, string nomtupla, int estado, OInmode inm)
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
        /// Cargamos datos de los Aactivos
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Activos</returns>
        private static OActivo FillDataRecordAct(IDataRecord miRecord)
        {
            OActivo act = new OActivo();

            act.ActivoID = miRecord.GetInt32(miRecord.GetOrdinal("ActivoID"));
            act.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            act.CodImagen = miRecord.GetString(miRecord.GetOrdinal("CodImagen"));
            act.CodImagenQR = miRecord.GetString(miRecord.GetOrdinal("CodImagenQR"));
            act.TipoActivoID = miRecord.GetInt32(miRecord.GetOrdinal("TipoActivoID"));
            act.NomTipoActivo = miRecord.GetString(miRecord.GetOrdinal("NomTipoActivo"));
            act.SucursalID = miRecord.GetInt32(miRecord.GetOrdinal("SucursalID"));
            act.NomSuc = miRecord.GetString(miRecord.GetOrdinal("NomSuc"));
            act.PersonalRespID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalRespID"));
            act.NomPersonalResp = miRecord.GetString(miRecord.GetOrdinal("NomPersonalResp"));
            act.ProveedorID = miRecord.GetInt32(miRecord.GetOrdinal("ProveedorID"));
            act.NomProv = miRecord.GetString(miRecord.GetOrdinal("NomProv"));
            act.Serial = miRecord.GetString(miRecord.GetOrdinal("Serial"));
            act.NomActivo = miRecord.GetString(miRecord.GetOrdinal("NomActivo"));
            act.FormaAdquisicion = miRecord.GetString(miRecord.GetOrdinal("FormaAdquisicion"));
            act.FechaAdquisicion = miRecord.GetDateTime(miRecord.GetOrdinal("FechaAdquisicion"));
            act.Documento = miRecord.GetString(miRecord.GetOrdinal("Documento"));
            act.Marca = miRecord.GetString(miRecord.GetOrdinal("Marca"));
            act.Modelo = miRecord.GetString(miRecord.GetOrdinal("Modelo"));
            act.Costo = miRecord.GetDecimal(miRecord.GetOrdinal("Costo"));
            act.CostoDeprec = miRecord.GetDecimal(miRecord.GetOrdinal("CostoDeprec"));
            act.MesesVidaUtil = miRecord.GetDecimal(miRecord.GetOrdinal("MesesVidaUtil"));
            act.MesesRestantes = miRecord.GetDecimal(miRecord.GetOrdinal("MesesRestantes"));
            act.MesesGarantia = miRecord.GetDecimal(miRecord.GetOrdinal("MesesGarantia"));
            act.ValResidual = miRecord.GetDecimal(miRecord.GetOrdinal("ValResidual"));
            act.Descripcion = miRecord.GetString(miRecord.GetOrdinal("Descripcion"));
            act.Observacion = miRecord.GetString(miRecord.GetOrdinal("Observacion"));
            act.Depreciable = miRecord.GetBoolean(miRecord.GetOrdinal("Depreciable"));
            act.Garantia = miRecord.GetBoolean(miRecord.GetOrdinal("Garantia"));
            act.Contabilizado = miRecord.GetBoolean(miRecord.GetOrdinal("Contabilizado"));
            act.Estado = miRecord.GetString(miRecord.GetOrdinal("Estado"));

            try
            {
                act.ImgQR = (byte[])miRecord["ImgQR"];
                act.Img = (byte[])miRecord["Img"];
            }
            catch
            { }

            return act;
        }
    }
}
