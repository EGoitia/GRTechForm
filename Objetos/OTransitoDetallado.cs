using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTransitoDetallado
    {
        private string codCompra = string.Empty;

        public string CodCompra
        {
            get { return codCompra; }
            set { codCompra = value; }
        }

        private DateTime fechaCompra = DateTime.Now;

        public DateTime FechaCompra
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
        }
        private string numCompra = string.Empty;

        public string NumCompra
        {
            get { return numCompra; }
            set { numCompra = value; }
        }
        private string detalleCompra = string.Empty;

        public string DetalleCompra
        {
            get { return detalleCompra; }
            set { detalleCompra = value; }
        }
        private string nomCaja = string.Empty;

        public string NomCaja
        {
            get { return nomCaja; }
            set { nomCaja = value; }
        }
        private int productoID = -1;

        public int ProductoID
        {
            get { return productoID; }
            set { productoID = value; }
        }
        private string nomProd = string.Empty;

        public string NomProd
        {
            get { return nomProd; }
            set { nomProd = value; }
        }
        private decimal cantidadCompra = 0;

        public decimal CantidadCompra
        {
            get { return cantidadCompra; }
            set { cantidadCompra = value; }
        }
        private decimal pCostoCompra = 0;

        public decimal PCostoCompra
        {
            get { return pCostoCompra; }
            set { pCostoCompra = value; }
        }
        private decimal pTotalCompra = 0;

        public decimal PTotalCompra
        {
            get { return pTotalCompra; }
            set { pTotalCompra = value; }
        }
        private DateTime fechaIngreso = DateTime.Now;

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        private string numIngreso = string.Empty;

        public string NumIngreso
        {
            get { return numIngreso; }
            set { numIngreso = value; }
        }
        private string detalleIngreso = string.Empty;

        public string DetalleIngreso
        {
            get { return detalleIngreso; }
            set { detalleIngreso = value; }
        }
        private string almacen = string.Empty;

        public string Almacen
        {
            get { return almacen; }
            set { almacen = value; }
        }
        private decimal cantidadIngreso = 0;

        public decimal CantidadIngreso
        {
            get { return cantidadIngreso; }
            set { cantidadIngreso = value; }
        }
        private decimal cantidadTransito = 0;

        public decimal CantidadTransito
        {
            get { return cantidadTransito; }
            set { cantidadTransito = value; }
        }
        private decimal transitoValorado = 0;

        public decimal TransitoValorado
        {
            get { return transitoValorado; }
            set { transitoValorado = value; }
        }
        private decimal totTransitoValor = 0;

        public decimal TotTransitoValor
        {
            get { return totTransitoValor; }
            set { totTransitoValor = value; }
        }

        public decimal TotCompra { get; set; }
        public decimal TotTransito { get; set; }
        public decimal TotIngresado { get; set; }
    }
}
