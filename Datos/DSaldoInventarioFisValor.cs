using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class DSaldoInventarioFisValor
    {
        private static Manejador man = null;

        public static DataTable DBuscaSaldoInventarioFisValor(string cosulta, DateTime fecha, DataTable almacenes)
        {
            man = new Manejador();
            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@Consulta", cosulta));
            LParam.Add(new Parametros("@Fecha", fecha));
            LParam.Add(new Parametros("@AlmacenesID", almacenes));

            return man.ListadoDT("ListarStockProdFecha", LParam);
        }
    }
}
