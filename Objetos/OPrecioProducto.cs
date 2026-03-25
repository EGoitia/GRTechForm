using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Objetos
{
    public class OPrecioProducto
    {
        public OPrecioProducto()
        { }

        public static string SerializarPrecProd(DataTable dt)
        {
            string PrecProd = string.Empty;
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(List<OPrecioProducto>));

            try
            {
                List<OPrecioProducto> lpprod = new List<OPrecioProducto>();
                foreach (DataRow item in dt.Rows)
                {
                    OPrecioProducto pprod = new OPrecioProducto();
                    pprod.Cantidad = Convert.ToDecimal(item["Cantidad"]);
                    pprod.Costo = Convert.ToDecimal(item["Costo"]);
                    pprod.Producto = item["Producto"].ToString();
                    pprod.ProductoID = -1;
                    pprod.Rubro = item["Rubro"].ToString();
                    pprod.Subrubro = item["Subrubro"].ToString();
                    pprod.UM = item["UM"].ToString();
                    pprod.VentaMayor = Convert.ToDecimal(item["VentaMayor"]);
                    pprod.VentaMenor = Convert.ToDecimal(item["VentaMenor"]);

                    lpprod.Add(pprod);
                }
                
                serializer.Serialize(stringwriter, lpprod);
            }
            catch (System.Xml.XmlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                PrecProd = stringwriter.ToString();
                PrecProd = PrecProd.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            }

            return PrecProd;
        }

        public int ProductoID { get; set; }
        public string Producto { get; set; }
        public string Rubro { get; set; }
        public string Subrubro { get; set; }
        public string UM { get; set; }
        public decimal VentaMayor { get; set; }
        public decimal VentaMenor { get; set; }
        public decimal Costo { get; set; }
        public decimal Cantidad { get; set; }
    }
}
