using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NAperturaMes
    {
        public static int DInsertAperturaMes(OAperturaCierreMes apmes, OInmode @inm)
        {
            return DAperturaMes.DInsertAperturaMes(apmes, inm);
        }
    }
}
