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
    public static class DDetallePersonal
    {
        /// <summary>
        /// procedimiento para Listar los datos del Detalle del Personal
        /// </summary>
        /// <returns>Lista DetallePersonal</returns>
        public static ODetallePersonal DBuscarDetPer(int personalid)
        {
            ODetallePersonal Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetPer", miCon);
                miCmd.Parameters.AddWithValue("@PersonalID", personalid);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new ODetallePersonal();

                        if(miLector.Read())
                        {
                            Temp = FillDataRecordDPer(miLector);
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos del Detalle del Personal
        /// </summary>
        /// <param name="dper"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static int DInsertModifDetPer(ODetallePersonal dper, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifDetPer", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@PersonalID", dper.PersonalID);
                miCmd.Parameters.AddWithValue("@AFPID", dper.AFPID);
                miCmd.Parameters.AddWithValue("@DiasTrabSemanal", dper.DiasTrabSemanal);
                miCmd.Parameters.AddWithValue("@FechaFiniquito", dper.FechaFiniquito);
                miCmd.Parameters.AddWithValue("@CausalFiniquito", dper.CausalFiniquito);
                miCmd.Parameters.AddWithValue("@TipoTrabajador", dper.TipoTrabajador);
                miCmd.Parameters.AddWithValue("@TipoContrato", dper.TipoContrato);
                miCmd.Parameters.AddWithValue("@NumContrato", dper.NumContrato);
                miCmd.Parameters.AddWithValue("@NomSeguro", dper.NomSeguro);
                miCmd.Parameters.AddWithValue("@CodAfiliacion", dper.CodAfiliacion);
                miCmd.Parameters.AddWithValue("@ExCodAfiliacion", dper.ExCodAfiliacion);
                miCmd.Parameters.AddWithValue("@SeguroSimples", dper.SeguroSimples);
                miCmd.Parameters.AddWithValue("@SeguroMaternales", dper.SeguroMaternales);
                miCmd.Parameters.AddWithValue("@SeguroInvalidez", dper.SeguroInvalidez);
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
        /// Cargamos datos del Detalle del Personal
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos DetallePersonal</returns>
        private static ODetallePersonal FillDataRecordDPer(IDataRecord miRecord)
        {
            ODetallePersonal dper = new ODetallePersonal();

            dper.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            dper.AFPID = miRecord.GetInt32(miRecord.GetOrdinal("AFPID"));
            dper.NomAFP = miRecord.GetString(miRecord.GetOrdinal("NomAFP"));
            dper.DiasTrabSemanal = miRecord.GetDecimal(miRecord.GetOrdinal("DiasTrabSemanal"));
            dper.FechaFiniquito = miRecord.GetDateTime(miRecord.GetOrdinal("FechaFiniquito"));
            dper.CausalFiniquito = miRecord.GetString(miRecord.GetOrdinal("CausalFiniquito"));
            dper.TipoTrabajador = miRecord.GetString(miRecord.GetOrdinal("TipoTrabajador"));
            dper.TipoContrato = miRecord.GetString(miRecord.GetOrdinal("TipoContrato"));
            dper.NumContrato = miRecord.GetString(miRecord.GetOrdinal("NumContrato"));
            dper.NomSeguro = miRecord.GetString(miRecord.GetOrdinal("NomSeguro"));
            dper.CodAfiliacion = miRecord.GetString(miRecord.GetOrdinal("CodAfiliacion"));
            dper.ExCodAfiliacion = miRecord.GetString(miRecord.GetOrdinal("ExCodAfiliacion"));
            dper.SeguroSimples = miRecord.GetInt32(miRecord.GetOrdinal("SeguroSimples"));
            dper.SeguroMaternales = miRecord.GetInt32(miRecord.GetOrdinal("SeguroMaternales"));
            dper.SeguroInvalidez = miRecord.GetInt32(miRecord.GetOrdinal("SeguroInvalidez"));

            return dper;
        }
    }
}
