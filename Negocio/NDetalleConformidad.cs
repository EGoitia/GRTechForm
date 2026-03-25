using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleConformidad
    {
        public static List<ODetalleConformidad> NBuscarDConf(string CodConformidad)
        {
            return DDetalleConformidad.DBuscarDConf(CodConformidad);
        }
    }
}
