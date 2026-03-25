using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OCliente
    {
        private Int32 clienteID = -1;

        public Int32 ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }
        private string codinmode = string.Empty;

        public string CodInmode
        {
            get { return codinmode; }
            set { codinmode = value; }
        }
        private Int32 vendedorID = -1;

        public Int32 VendedorID
        {
            get { return vendedorID; }
            set { vendedorID = value; }
        }
        private string nomVendedor = string.Empty;

        public string NomVendedor
        {
            get { return nomVendedor; }
            set { nomVendedor = value; }
        }
        private string nomClien = string.Empty;

        public string NomClien
        {
            get { return nomClien; }
            set { nomClien = value; }
        }
        private Int32 tipoClienteID = -1;

        public Int32 TipoClienteID
        {
            get { return tipoClienteID; }
            set { tipoClienteID = value; }
        }
        private string telf = string.Empty;

        public string Telf
        {
            get { return telf; }
            set { telf = value; }
        }
        private string pagWeb = string.Empty;

        public string PagWeb
        {
            get { return pagWeb; }
            set { pagWeb = value; }
        }
        private string correo = string.Empty;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private decimal limiteCredito = 0;

        public decimal LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }
        private int plazoPago = 0;

        public int PlazoPago
        {
            get { return plazoPago; }
            set { plazoPago = value; }
        }
        
        private bool estadoLimCredit = false;

        public bool EstadoLimCredit
        {
            get { return estadoLimCredit; }
            set { estadoLimCredit = value; }
        }
        private bool estadoFactMorosas = false;

        public bool EstadoFactMorosas
        {
            get { return estadoFactMorosas; }
            set { estadoFactMorosas = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
