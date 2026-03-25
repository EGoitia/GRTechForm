using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OCompraPorFecha
    {
        private string codCompraProd = string.Empty;

        public string CodCompraProd
        {
            get { return codCompraProd; }
            set { codCompraProd = value; }
        }
        private string numCompraProd = string.Empty;

        public string NumCompraProd
        {
            get { return numCompraProd; }
            set { numCompraProd = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string referencia = string.Empty;

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        private string tipoCompra = string.Empty;

        public string TipoCompra
        {
            get { return tipoCompra; }
            set { tipoCompra = value; }
        }
        private decimal totalBs = 0;

        public decimal TotalBs
        {
            get { return totalBs; }
            set { totalBs = value; }
        }
        private string tipoPago = string.Empty;

        public string TipoPago
        {
            get { return tipoPago; }
            set { tipoPago = value; }
        }
        private decimal importeBs = 0;

        public decimal ImporteBs
        {
            get { return importeBs; }
            set { importeBs = value; }
        }
        private decimal importeSus = 0;

        public decimal ImporteSus
        {
            get { return importeSus; }
            set { importeSus = value; }
        }
    }
}
