using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;
using System.Xml;
using System.Data.SqlTypes;

namespace Datos
{
    public static class DBalanceGeneral
    {
        public static XmlDocument[] DCargarCuentBalanceInicial()
        {
            XmlDocument asiento = null;
            XmlDocument[] doc = new XmlDocument[1];

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("CargarCuentBalanceInicial", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    miCon.Open();

                    using (SqlDataReader miLector = miCmd.ExecuteReader())
                    {
                        if (miLector.Read())
                        {
                            SqlXml asientoxml = miLector.GetSqlXml(miLector.GetOrdinal("CuentasXML"));

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

        public static string InsertBalance()
        {
            return "";
        }
    }
}
