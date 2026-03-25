using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OVentasPorFecha
    {
        private string codVenta = string.Empty;

        public string CodVenta
        {
            get { return codVenta; }
            set { codVenta = value; }
        }
        private string numVenta = string.Empty;

        public string NumVenta
        {
            get { return numVenta; }
            set { numVenta = value; }
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
        private string tipoVenta = string.Empty;

        public string TipoVenta
        {
            get { return tipoVenta; }
            set { tipoVenta = value; }
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
