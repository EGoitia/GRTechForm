using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Datos;
using System.Xml;

namespace Negocio
{
    public static class NLibroDiario
    {
        public static XmlDocument[] NListarLibroDiario(DateTime Fecha)
        {
            return DLibroDiario.DListarLibroDiario(Fecha);
        }

        public static XmlDocument[] NListarLibroMayor(string CodCuenta, DateTime FecIni, DateTime FecFin)
        {
            return DLibroDiario.DListarLibroMayor(CodCuenta, FecIni, FecFin);
        }
    }
}
