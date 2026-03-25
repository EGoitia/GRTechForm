using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Datos;
using Objetos;

namespace Negocio
{
    public static class NInmode
    {
        public static List<OInmode> NListarInmode(string @codinmode)
        {
            return DInmode.DListarInmode(codinmode);
        }
    }
}
