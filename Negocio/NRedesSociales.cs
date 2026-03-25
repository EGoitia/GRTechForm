using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;
using System.Data;

namespace Negocio
{
    public static class NRedesSociales
    {
        public static int NAnulRestauRedSoc(string @cod, string @nomtupla, int @estado, OInmode @inm)
        {
            return DRedesSociales.DAnulRestauRedSoc(cod, nomtupla, estado, inm);
        }

        public static int NInsertModifRedSoc(ORedesSociales @redsoc, DataTable @inm)
        {
            return DRedesSociales.DInsertModifRedSoc(redsoc, inm);
        }

        public static List<ORedesSociales> NListarRedSoc(int @codid, string @Tipo)
        {
            return DRedesSociales.DListarRedSoc(codid, Tipo);
        }
    }
}
