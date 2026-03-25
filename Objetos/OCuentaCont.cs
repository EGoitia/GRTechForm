using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OCuentaCont
    {
        private int cuentaContID = -1;

        public int CuentaContID
        {
            get { return cuentaContID; }
            set { cuentaContID = value; }
        }
        private string codCuenta = string.Empty;

        public string CodCuenta
        {
            get { return codCuenta; }
            set { codCuenta = value; }
        }
        private string padreCuenta = String.Empty;

        public string PadreCuenta
        {
            get { return padreCuenta; }
            set { padreCuenta = value; }
        }
        private string nomCuenta = string.Empty;

        public string NomCuenta
        {
            get { return nomCuenta; }
            set { nomCuenta = value; }
        }
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private string moneda = string.Empty;

        public string Moneda
        {
            get { return moneda; }
            set { moneda = value; }
        }
        private string tipoCuenta = string.Empty;

        public string TipoCuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
        }
        private decimal debe = 0;

        public decimal Debe
        {
            get { return debe; }
            set { debe = value; }
        }
        private decimal haber = 0;

        public decimal Haber
        {
            get { return haber; }
            set { haber = value; }
        }
        private bool borrar = false;

        public bool Borrar
        {
            get { return borrar; }
            set { borrar = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
