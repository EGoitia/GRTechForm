using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDepreciacionActivo
    {
        public static List<ODepreciacionActivo> NListarDepreciacionActivo(int ActivoID)
        {
            return DDepreciacionActivo.DListarDepreciacionActivo(ActivoID);
        }

        public static int NInsertarDepreciacionActivo(string dact, OInmode inm)
        {
            return DDepreciacionActivo.DInsertarDepreciacionActivo(dact, inm);
        }
    }
}
