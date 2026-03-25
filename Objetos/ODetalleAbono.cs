using System.Xml.Serialization;

namespace Objetos
{
    public class ODetalleAbono
    {
        private string codAbono = string.Empty;

        public string CodAbono
        {
            get { return codAbono; }
            set { codAbono = value; }
        }
        private string codCompraVentaGasto = string.Empty;

        public string CodCompraVentaGasto
        {
            get { return codCompraVentaGasto; }
            set { codCompraVentaGasto = value; }
        }
        private string codKardex = string.Empty;
        [XmlIgnore] 
        public string CodKardex
        {
            get { return codKardex; }
            set { codKardex = value; }
        }
        //datos globales
        private string numNota = string.Empty;
        [XmlIgnore] 
        public string NumNota
        {
            get { return numNota; }
            set { numNota = value; }
        }
        private string nomSucCaj = string.Empty;
        [XmlIgnore] 
        public string NomSucCaj
        {
            get { return nomSucCaj; }
            set { nomSucCaj = value; }
        }
        private decimal totalBs = 0;
        [XmlIgnore] 
        public decimal TotalBs
        {
            get { return totalBs; }
            set { totalBs = value; }
        }
        private decimal totalDsctoBs = 0;
        [XmlIgnore] 
        public decimal TotalDsctoBs
        {
            get { return totalDsctoBs; }
            set { totalDsctoBs = value; }
        }
        private decimal totalPagadoBs = 0;
        [XmlIgnore] 
        public decimal TotalPagadoBs
        {
            get { return totalPagadoBs; }
            set { totalPagadoBs = value; }
        }
        private decimal totalSaldoBs = 0;
        [XmlIgnore] 
        public decimal TotalSaldoBs
        {
            get { return totalSaldoBs; }
            set { totalSaldoBs = value; }
        }
        //datos de la nota
        private decimal dsctoBs = 0;

        public decimal DsctoBs
        {
            get { return dsctoBs; }
            set { dsctoBs = value; }
        }
        private decimal montoBs = 0;

        public decimal MontoBs
        {
            get { return montoBs; }
            set { montoBs = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
