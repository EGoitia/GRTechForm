using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OPagoEfectivo
    {
        private string codPago = string.Empty;

        public string CodPago
        {
            get { return codPago; }
            set { codPago = value; }
        }
        private decimal efectivoBs = 0;

        public decimal EfectivoBs
        {
            get { return efectivoBs; }
            set { efectivoBs = value; }
        }
        private decimal efectivoSus = 0;

        public decimal EfectivoSus
        {
            get { return efectivoSus; }
            set { efectivoSus = value; }
        }
        private decimal devolBs = 0;

        public decimal DevolBs
        {
            get { return devolBs; }
            set { devolBs = value; }
        }
        private decimal devolSus = 0;

        public decimal DevolSus
        {
            get { return devolSus; }
            set { devolSus = value; }
        }
        private string estado = string.Empty;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
