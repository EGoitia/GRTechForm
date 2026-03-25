using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NTipoUsuario
    {
        public static int NBloquearTipoUsu(int @TipoUsuarioID, OInmode @inm)
        {
            return DTipoUsuario.DBloquearTipoUsu(TipoUsuarioID, inm);
        }

        public static int NInsertModifTipoUsu(OTipoUsuario @TipoUsu, OInmode @inm)
        {
            return DTipoUsuario.DInsertModifTipoUsu(TipoUsu, inm);
        }

        public static List<OTipoUsuario> NListarTipoUsu()
        {
            return DTipoUsuario.DListarTipoUsu();
        }
    }
}
