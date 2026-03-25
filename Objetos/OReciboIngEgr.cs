using System.Data;

namespace Objetos
{
    public class OIngresoEgreso
    {
        public string CodIngrEgre { get; set; }
        public int Cuenta_Ingreso_EgresoID { get; set; }
        public int CajaID { get; set; }
        public int SucursalID { get; set; }
        public int PersonActivID { get; set; }
        public int VariosPersonActivID { get; set; }
        public string TipoIngrEgre { get; set; }
        public string Concepto { get; set; }
        public string Detalle { get; set; }
        public decimal TC { get; set; }
        public decimal Monto { get; set; }
        public DataTable TipoPagoDT { get; set; }
        public DataTable ReciboDT { get; set; }
        public DataTable FacturaDT { get; set; }
    }
}
