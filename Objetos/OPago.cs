using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OPago
    {
        private string codPago = string.Empty;

        public string CodPago
        {
            get { return codPago; }
            set { codPago = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private decimal tC = 1;

        public decimal TC
        {
            get { return tC; }
            set { tC = value; }
        }
        private decimal anticipoBs = 0;

        public decimal AnticipoBs
        {
            get { return anticipoBs; }
            set { anticipoBs = value; }
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
    }
}
