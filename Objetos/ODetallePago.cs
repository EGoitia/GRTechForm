using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetallePago
    {
        private string codPago = string.Empty;

        public string CodPago
        {
            get { return codPago; }
            set { codPago = value; }
        }
        private string codImagen = string.Empty;

        public string CodImagen
        {
            get { return codImagen; }
            set { codImagen = value; }
        }
        private string tipoPago = string.Empty;

        public string TipoPago
        {
            get { return tipoPago; }
            set { tipoPago = value; }
        }
        private decimal montoPagoBs = 0;

        public decimal MontoPagoBs
        {
            get { return montoPagoBs; }
            set { montoPagoBs = value; }
        }
        private decimal montoPagoSus = 0;

        public decimal MontoPagoSus
        {
            get { return montoPagoSus; }
            set { montoPagoSus = value; }
        }
        private decimal montoDevBs = 0;

        public decimal MontoDevBs
        {
            get { return montoDevBs; }
            set { montoDevBs = value; }
        }
        private decimal montoDevSus = 0;

        public decimal MontoDevSus
        {
            get { return montoDevSus; }
            set { montoDevSus = value; }
        }
        private int bancoID = -1;

        public int BancoID
        {
            get { return bancoID; }
            set { bancoID = value; }
        }
        private string nomBanco = string.Empty;

        public string NomBanco
        {
            get { return nomBanco; }
            set { nomBanco = value; }
        }
        private int tarjetaID = -1;

        public int TarjetaID
        {
            get { return tarjetaID; }
            set { tarjetaID = value; }
        }
        private string nomTarjeta = string.Empty;

        public string NomTarjeta
        {
            get { return nomTarjeta; }
            set { nomTarjeta = value; }
        }
        private string numCheque = string.Empty;

        public string NumCheque
        {
            get { return numCheque; }
            set { numCheque = value; }
        }
        private string referencia = string.Empty;

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        private DateTime fecEmision = DateTime.Now;

        public DateTime FecEmision
        {
            get { return fecEmision; }
            set { fecEmision = value; }
        }
        private DateTime fecCobro = DateTime.Now;

        public DateTime FecCobro
        {
            get { return fecCobro; }
            set { fecCobro = value; }
        }
        private DateTime fecCobrado = DateTime.Now;

        public DateTime FecCobrado
        {
            get { return fecCobrado; }
            set { fecCobrado = value; }
        }
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private string estado = string.Empty;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
