using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OMovimientoCheque:OPagoCheque
    {
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codTransaccion = string.Empty;

        public string CodTransaccion
        {
            get { return codTransaccion; }
            set { codTransaccion = value; }
        }
        private string numTrasnsaccion = string.Empty;

        public string NumTrasnsaccion
        {
            get { return numTrasnsaccion; }
            set { numTrasnsaccion = value; }
        }
        private string tipoTransaccion = string.Empty;

        public string TipoTransaccion
        {
            get { return tipoTransaccion; }
            set { tipoTransaccion = value; }
        }
        private decimal totalBs = 0;

        public decimal TotalBs
        {
            get { return totalBs; }
            set { totalBs = value; }
        }
        private decimal dsctoBs = 0;

        public decimal DsctoBs
        {
            get { return dsctoBs; }
            set { dsctoBs = value; }
        }
        private decimal totalPagadoBs = 0;

        public decimal TotalPagadoBs
        {
            get { return totalPagadoBs; }
            set { totalPagadoBs = value; }
        }
        private decimal saldoBs = 0;

        public decimal SaldoBs
        {
            get { return saldoBs; }
            set { saldoBs = value; }
        }
        private decimal tC = 1;

        public decimal TC
        {
            get { return tC; }
            set { tC = value; }
        }
    }
}
