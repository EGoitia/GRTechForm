using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NMovimientoCheque
    {
        public static List<ODetallePago> NListarCheqPen()
        {
            return DMovimientoCheque.DListarCheqPen();
        }

        public static int NChequeCobrado(string CodPago, OInmode inm)
        {
            return DMovimientoCheque.DChequeCobrado(CodPago, inm);
        }

        public static List<ODetallePago> NListarCheqCobr(DateTime Fecha)
        {
            return DMovimientoCheque.DListarCheqCobr(Fecha);
        }
    }
}
