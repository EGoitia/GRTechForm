using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NCajaUsuario
    {
        public static List<OCajaUsuario> NListarCajaUsuario(int usuid)
        {
            return DCajaUsuario.DListarCajaUsuario(usuid);
        }

        public static int NInsertModifCajaUsuario(OCajaUsuario cusu, string opc, OInmode inm)
        {
            return DCajaUsuario.DInsertModifCajaUsuario(cusu, opc, inm);
        }

        public static int NAnulRestauCajaUsuario(int cajaid, int usuarioid, bool estado, OInmode inmod)
        {
            return DCajaUsuario.DAnulRestauCajaUsuario(cajaid, usuarioid, estado, inmod);
        }
    }
}
