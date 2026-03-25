using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Data.SqlTypes;

using Objetos;

namespace Datos
{
    public static class DPago
    {
       /// <summary>
        /// procedimiento para Buscar el Pago
       /// </summary>
       /// <param name="CodPago"></param>
       /// <returns>bjet Pago</returns>
        public static XmlDocument[] DBuscarPago(string CodPago)
        {
            XmlDocument pago = null;
            XmlDocument pago_ef = null;
            XmlDocument pago_che = null;
            XmlDocument[] doc = new XmlDocument[3];

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarPago", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodPago", CodPago);

                try
                {
                    miCon.Open();

                    using (SqlDataReader miLector = miCmd.ExecuteReader())
                    {
                        if (miLector.Read())
                        {
                            SqlXml pagxml = miLector.GetSqlXml(miLector.GetOrdinal("PagoXml"));
                            SqlXml pagefxml = miLector.GetSqlXml(miLector.GetOrdinal("Pago_EfXml"));
                            SqlXml pagchexml = miLector.GetSqlXml(miLector.GetOrdinal("Pago_CheXml"));

                            pago = new XmlDocument();
                            pago_ef = new XmlDocument();
                            pago_che = new XmlDocument();

                            pago.LoadXml(pagxml.Value);
                            doc[0] = pago;
                            
                            try
                            {
                                pago_ef.LoadXml(pagefxml.Value);
                                doc[1] = pago_ef;
                            }
                            catch(Exception)
                            {  }
                            
                            try 
	                        {
                                pago_che.LoadXml(pagchexml.Value);
		                        doc[2] = pago_che;
	                        }
	                        catch (Exception)
	                        {}

                            //docven.Save("E:\\Venta.xml");
                            //docdven.Save("E:\\DVenta.xml");
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
