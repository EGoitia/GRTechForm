using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;
using System.Data;

namespace Negocio
{
    public static class NDetallePersonal
    {
        public static ODetallePersonal NBuscarDetPer(int personalid)
        {
            return DDetallePersonal.DBuscarDetPer(personalid);
        }

        public static int NInsertModifDetPer(ODetallePersonal dper, DataTable inm)
        {
            return DDetallePersonal.DInsertModifDetPer(dper, inm);
        }
    }
}
