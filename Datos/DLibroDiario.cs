using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Data.SqlTypes;

namespace Datos
{
    public static class DLibroDiario
    {
        public static XmlDocument[] DListarLibroDiario(DateTime Fecha)
        {
            XmlDocument asiento = null;
            XmlDocument[] doc = new XmlDocument[1];

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarLibroDiario", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Fecha", Fecha);

                try
                {
                    miCon.Open();

                    using (SqlDataReader miLector = miCmd.ExecuteReader())
                    {
                        if (miLector.Read())
                        {
                            SqlXml asientoxml = miLector.GetSqlXml(miLector.GetOrdinal("LibroXML"));

                            asiento = new XmlDocument();

                            asiento.LoadXml(asientoxml.Value);

                            doc[0] = asiento;
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

        public static XmlDocument[] DListarLibroMayor(string CodCuenta, DateTime FecIni, DateTime FecFin)
        {
            XmlDocument asiento = null;
            XmlDocument[] doc = new XmlDocument[1];

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarLibroMayor", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if(CodCuenta == string.Empty)
                    miCmd.Parameters.AddWithValue("@CodCuenta", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodCuenta", CodCuenta);

                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);

                try
                {
                    miCon.Open();

                    using (SqlDataReader miLector = miCmd.ExecuteReader())
                    {
                        if (miLector.Read())
                        {
                            SqlXml asientoxml = miLector.GetSqlXml(miLector.GetOrdinal("LibroXML"));

                            asiento = new XmlDocument();

                            asiento.LoadXml(asientoxml.Value);

                            doc[0] = asiento;
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
    }
}
