using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NPlanillaSueldo
    {
        public static XmlDocument[] NListarPlanillaSueldo(DateTime @Fecha)
        {
            return DPlanillaSueldo.DListarPlanillaSueldo(Fecha);
        }

        public static int NInsertModifPlanillaSueldo(OPlanillaSueldo pla, string dpla, OInmode inm)
        {
            return DPlanillaSueldo.DInsertModifPlanillaSueldo(pla, dpla, inm);
        }
    }
}
