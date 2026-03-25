using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Objetos
{
    public class ODetalleRolUsuario
    {
        public static bool HabilDesabil(string control, int padre)
        {
            IEnumerable<DataRow> fila = (from val in OConexionGlobal.Detalle_Rol.AsEnumerable() select val)
                .Where(x => x.Field<int>("PadreID") == padre).Where(x => x.Field<string>("NomMenu") == control);

            return fila.Count() == 0;
        }
    }
}
