using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NSucursal
    {
        public static List<OSucursal> NListarSucursales()
        {
            return DSucursal.DListarSucursales();
        }
    }
}
