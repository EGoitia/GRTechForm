using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NReciboIngEgr
    {

        public static int NInsertReciboDevolPagAnticip(OIngresoEgreso rec, OInmode inm)
        {
            return DIngrEgre.DInsertReciboDevolPagAnticip(rec, inm);
        }

    }
}
