using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NCuentaCont
    {
        public static List<OCuentaCont> NListarCuentasCont()
        {
            return DCuentaCont.DListarCuentasCont();
        }

        public static int NInsertModifCuentaCont(OCuentaCont ccont, OInmode inm)
        {
            return DCuentaCont.DInsertModifCuentaCont(ccont, inm);
        }
    }
}
