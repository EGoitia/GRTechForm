using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NCuentaXCobrarPagar
    {
        public static List<OCuentasXCobrarPagar> NBuscarCuentaXCobPag(string opcion, string lugar, int desclugar, DateTime fecha)
        {
            return DCuentasXCobrarPagar.DBuscarCuentaXCobPag(opcion, lugar, desclugar, fecha);
        }
    }
}
