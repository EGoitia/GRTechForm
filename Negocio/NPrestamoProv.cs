using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NPrestamoProv
    {
        public static List<OPrestamoProv> NListarPresProv(DateTime fecha)
        {
            return DPrestamoProv.DListarPresProv(fecha);
        }

        public static int NInsertModifPresProv(OPrestamoProv pres, OPago pag, string dpago, OInmode inm)
        {
            return DPrestamoProv.DInsertModifPresProv(pres, pag, dpago, inm);
        }

        public static List<OPrestamoProv> NBuscarPresProv(string @Opcion, string @Busqueda, DateTime @Fecha)
        {
            return DPrestamoProv.DBuscarPresProv(Opcion, Busqueda, Fecha);
        }

        public static int NAnulRestauPresProv(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DPrestamoProv.DAnulRestauPresProv(cod, nomtupla, estado, inmod);
        }
    }
}
