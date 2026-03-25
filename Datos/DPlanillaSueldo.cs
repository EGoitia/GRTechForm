using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

using Objetos;

namespace Datos
{
    public static class DPlanillaSueldo
    {
        public static XmlDocument[] DListarPlanillaSueldo(DateTime @Fecha)
        {
            XmlDocument pla = null;
            XmlDocument dpla = null;
            XmlDocument[] doc = new XmlDocument[2];

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarPlanilla", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Fecha", Fecha);

                try
                {
                    miCon.Open();

                    using (SqlDataReader miLector = miCmd.ExecuteReader())
                    {
                        if (miLector.Read())
                        {
                            SqlXml plaxml = miLector.GetSqlXml(miLector.GetOrdinal("PlanillaXml"));
                            SqlXml dplaxml = miLector.GetSqlXml(miLector.GetOrdinal("DPlanillaXml"));

                            pla = new XmlDocument();
                            dpla = new XmlDocument();

                            pla.LoadXml(plaxml.Value);
                            dpla.LoadXml(dplaxml.Value);

                            doc[0] = pla;
                            doc[1] = dpla;
                        }
                    }
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
            return doc;
        }

        public static int DInsertModifPlanillaSueldo(OPlanillaSueldo pla, string dpla, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifPlanilla", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if(pla.CodPlanilla == string.Empty)
                    miCmd.Parameters.AddWithValue("@CodPlanilla", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodPlanilla", pla.CodPlanilla);

                miCmd.Parameters.AddWithValue("@Observacion", pla.Observacion);
                miCmd.Parameters.AddWithValue("@Mes", pla.Mes);
                miCmd.Parameters.AddWithValue("@Gestion", pla.Gestion);
                miCmd.Parameters.AddWithValue("@LiquidoPagable", pla.LiquidoPagable);
                miCmd.Parameters.AddWithValue("@Autorizado", pla.Autorizado);
                miCmd.Parameters.AddWithValue("@Pagado", pla.Pagado);
                //Detalle Planilla
                miCmd.Parameters.AddWithValue("@DPlanilla", dpla);
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
    }
}
