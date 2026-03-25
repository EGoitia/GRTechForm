using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleProyeccion
    {
        public static List<ODetalleProyecciones> NBuscarDProy(int proyid, int sucid, int perid, DateTime fecini, DateTime fecfin)
        {
            return DDetalleProyeccion.DBuscarDProy(proyid, sucid, perid, fecini, fecfin);
        }
    }
}
