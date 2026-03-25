using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NBackup
    {
        public static int NCrearBackup(string tipo, OInmode inm)
        {
            return DBackup.DCrearBackup(tipo, inm);
        }
    }
}
