using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class NTipo
    {
        public static int InsertModif_Tipo(OTipo OTip, DataTable Inmode)
        {
            return DTipo.InsertModif_Tipo(OTip, Inmode);
        }
        
        public static DataTable Listar_TipoDT(string tupla)
        {
            return DTipo.Listar_TipoDT(tupla);
        }

        public static DataSet Listar_TipoDS(string tupla)
        {
            return DTipo.Listar_TipoDS(tupla);
        }
    }
}
