using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Datos;
using Objetos;

namespace Negocio
{
    public class NLibroMayor
    {
        public static List<OLibroMayor> DListarLibroMayor(DateTime @fecini, DateTime @fecfin, string @TipoLibro, string @TipoRep)
        {
            return DLibroMayor.DListarLibroMayor(fecini, fecfin, TipoLibro, TipoRep);
        }
    }
}
