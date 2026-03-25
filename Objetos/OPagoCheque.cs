using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OPagoCheque
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
        private byte[] img;

        public byte[] Img
        {
            get { return img; }
            set { img = value; }
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
        private string numCuenta = string.Empty;

        public string NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }
        private string tipoCuenta = string.Empty;

        public string TipoCuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
        }
        private string moneda = string.Empty;

        public string Moneda
        {
            get { return moneda; }
            set { moneda = value; }
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
        private decimal montoBs = 0;

        public decimal MontoBs
        {
            get { return montoBs; }
            set { montoBs = value; }
        }
        private decimal montoSus = 0;

        public decimal MontoSus
        {
            get { return montoSus; }
            set { montoSus = value; }
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
