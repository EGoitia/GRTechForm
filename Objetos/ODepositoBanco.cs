using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODepositoBanco
    {
        private int depBancoID = -1;

        public int DepBancoID
        {
            get { return depBancoID; }
            set { depBancoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codAsiento = string.Empty;

        public string CodAsiento
        {
            get { return codAsiento; }
            set { codAsiento = value; }
        }
        private string codImagen = string.Empty;

        public string CodImagen
        {
            get { return codImagen; }
            set { codImagen = value; }
        }
        byte[] img;

        public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }
        private int bancoID = -1;

        public int BancoID
        {
            get { return bancoID; }
            set 
            {
                if (value > 0)
                    bancoID = value;
                else
                    throw new Exception("Seleccione un Banco");
            }
        }
        private string numCuenta = string.Empty;

        public string NumCuenta
        {
            get { return numCuenta; }
            set
            {
                numCuenta = value;
            }
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
        private string nomBanco = string.Empty;

        public string NomBanco
        {
            get { return nomBanco; }
            set
            {
                nomBanco = value; 
            }
        }
        private string numComprobante = string.Empty;

        public string NumComprobante
        {
            get { return numComprobante; }
            set 
            {
                if ((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    numComprobante = value;
                else
                    throw new Exception("El número de comprobante no puede estar vacío");
            }
        }
        private string depositante = string.Empty;

        public string Depositante
        {
            get { return depositante; }
            set
            { 
                if ((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    depositante = value;
                else
                    throw new Exception("El campo depositante no puede estar vacío");
            }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int cajaSalID = -1;

        public int CajaSalID
        {
            get { return cajaSalID; }
            set 
            {
                if (value > 0)
                    cajaSalID = value;
                else
                    throw new Exception("Seleccione una caja valida");
            }
        }
        private string nomCajaSal = string.Empty;

        public string NomCajaSal
        {
            get { return nomCajaSal; }
            set { nomCajaSal = value; }
        }

        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
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
        private decimal tC = 1;

        public decimal TC
        {
            get { return tC; }
            set { tC = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
