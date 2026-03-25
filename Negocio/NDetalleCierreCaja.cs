using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleCierreCaja
    {
        public static List<ODetalleCierreCaja> NListarDetCierreCaja(string Opcion, int @AperCajaID, OInmode inm)
        {
            return DDetalleCierreCaja.DListarDetCierreCaja(Opcion, AperCajaID, inm);
        }
    }
}
