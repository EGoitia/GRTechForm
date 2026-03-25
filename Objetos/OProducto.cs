
namespace Objetos
{
    public class OProducto
    {
        public int ProductoID { get; set; }
        public byte[] Img { get; set; }
        public int SubRubroID { get; set; }
        public int RubroID { get; set; }
        public int MarcaID { get; set; }
        public int ClasificacionID { get; set; }
        public string CodFabrica { get; set; }
        public string SKU { get; set; }
        public string NomProd { get; set; }
        public string Descripcion { get; set; }
        public string UnidMedida { get; set; }
        public decimal CantUnidMedida { get; set; }
        public string Moneda { get; set; }
        public decimal StockMax { get; set; }
        public decimal StockMin { get; set; }
        public decimal PedidMin { get; set; }
        public decimal Peso { get; set; }
        public decimal ValorComision { get; set; }
        public bool ModifPrec { get; set; }
        public bool FueraLinea { get; set; }
        public bool Vencimiento { get; set; }
        public bool Serial { get; set; }
        public bool Comodin { get; set; }
        public bool Estado { get; set; }
        public decimal StockAlmacen { get; set; }
        public decimal Transito { get; set; }
        public decimal Pendiente { get; set; }
        public decimal PCosto { get; set; }
        public decimal PVentaMenor { get; set; }
        public decimal PVentaMayor { get; set; }
    }
}
