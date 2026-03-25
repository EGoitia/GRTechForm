using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NAlmacen
    {
        public static int NInsertModifAlmacen(OAlmacen alm, OUbicacion ubic, OInmode inm)
        {
            return DAlmacen.DInsertModifAlmacen(alm, ubic, inm);
        }

        public static List<OAlmacen> NListarAlmacenes(int @sucid)
        {
            return DAlmacen.DListarAlmacenes(sucid);
        }
    }
}
