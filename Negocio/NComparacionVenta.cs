using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NComparacionVenta
    {
        public static List<OComparacionVentasCompras> DBuscarRepComparCompraVentas(string opcion, int anio, string tipoventa, int sucid, 
                                                                                   bool busqesp, string tipobusq, int id)
        {
            return DComparacionVentas.DBuscarRepComparCompraVentas(opcion, anio, tipoventa, sucid, busqesp, tipobusq, id);
        }

        public static List<OComparacionVentasCompras> NBuscarRepComparVentasVendedores(string _consulta)
        {
            return DComparacionVentas.DBuscarRepComparVentasVendedores(_consulta);
        }
    }
}
