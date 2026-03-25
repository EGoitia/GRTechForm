using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class NMovVentasXProd
    {
        public static List<OMovVentasXProd> DListarMovVenXProd(string opcion, int descopcion, string lugar, int desclugar,
                                                              DateTime fecini, DateTime fecfin, string ordenado)
        {
            return DMovVentasXProd.DListarMovVenXProd(opcion, descopcion, lugar, desclugar, fecini, fecfin, ordenado);
        }
    }
}
