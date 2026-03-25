using System;

namespace Objetos
{
    public class OFactura
    {
        public int FacturaID { get; set; }
        public int Numero { get; set; }
        public string CodNota { get; set; }
        public string Tupla { get; set; }
        public DateTime Fecha { get; set; }
        public double NIT { get; set; }
        public string RazonSocial { get; set; }
        public string Codigo_Control { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public decimal Dscto { get; set; }
        public decimal IVA { get; set; }
        public decimal ICE { get; set; }
        public decimal Exentos { get; set; }
        public int SucursalID { get; set; }
        public double Autorizacion { get; set; }
        public int ActividadID { get; set; }
        public int DosificacionID { get; set; }
        public bool Estado { get; set; }
    }
}
