using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OBanco
    {
        private Int32 bancoID = -1;

        public Int32 BancoID
        {
            get { return bancoID; }
            set { bancoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string numCuenta = string.Empty;

        public string NumCuenta
        {
            get { return numCuenta; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Numero de Cuenta no puede estar vacio");
                else
                    numCuenta = value; 
            }
        }
        private string tipoCuenta = string.Empty;

        public string TipoCuenta
        {
            get { return tipoCuenta; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    tipoCuenta = value;
                else
                    throw new Exception("Seleccione un Tipo de Cuenta Valido");
            }
        }
        private string moneda = string.Empty;

        public string Moneda
        {
            get { return moneda; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    moneda = value;
                else
                    throw new Exception("Seleccione una Moneda");
            }
        }
        private string nomBanco = string.Empty;

        public string NomBanco
        {
            get { return nomBanco; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nombre del Banco no puede estar vacio");
                else
                    nomBanco = value; 
            }
        }
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
