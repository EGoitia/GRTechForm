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
    public static class DAsiento
    {
        /// <summary>
        /// Procedimiento para Buscar el Asiento Contable
        /// </summary>
        /// <param name="CodAsiento"></param>
        /// <returns></returns>
        public static XmlDocument[] DBuscarAsiento(string CodAsiento)
        {
            XmlDocument docasi = null;
            XmlDocument docdasi = null;
            XmlDocument[] doc = new XmlDocument[2];

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarAsiento", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodAsiento", CodAsiento);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.Read())
                    {
                        SqlXml asixml = miLector.GetSqlXml(miLector.GetOrdinal("AsientoXml"));
                        SqlXml dasixml = miLector.GetSqlXml(miLector.GetOrdinal("DetAsientoXml"));

                        docasi = new XmlDocument();
                        docdasi = new XmlDocument();

                        docasi.LoadXml(asixml.Value);
                        docdasi.LoadXml(dasixml.Value);

                        doc[0] = docasi;
                        doc[1] = docdasi;

                        //docven.Save("E:\\Venta.xml");
                        //docdven.Save("E:\\DVenta.xml");
                    }
                }
                miCon.Close();
            }
            return doc;
        }
    }
}
