using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTraspasoCaja
    {
        private int traspasoCajaID = -1;

        public int TraspasoCajaID
        {
            get { return traspasoCajaID; }
            set { traspasoCajaID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string numTraspCaja = string.Empty;

        public string NumTraspCaja
        {
            get { return numTraspCaja; }
            set { numTraspCaja = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int cajaIDDel = -1;

        public int CajaIDDel
        {
            get { return cajaIDDel; }
            set { cajaIDDel = value; }
        }
        private string nomCajaDel = string.Empty;

        public string NomCajaDel
        {
            get { return nomCajaDel; }
            set { nomCajaDel = value; }
        }
        private int cajaIDAl = -1;

        public int CajaIDAl
        {
            get { return cajaIDAl; }
            set { cajaIDAl = value; }
        }
        private string nomCajaAl = string.Empty;

        public string NomCajaAl
        {
            get { return nomCajaAl; }
            set { nomCajaAl = value; }
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
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set 
            {
                if ((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    detalle = value;
                else
                    throw new Exception("El Detalle no puede estar vacío");
            }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
