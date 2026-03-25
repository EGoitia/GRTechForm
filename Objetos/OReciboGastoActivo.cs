using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OReciboGastoActivo
    {
        string codRecGastoActivo = string.Empty;

        public string CodRecGastoActivo
        {
            get { return codRecGastoActivo; }
            set { codRecGastoActivo = value; }
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
        private string numRecGastoActivo = string.Empty;

        public string NumRecGastoActivo
        {
            get { return numRecGastoActivo; }
            set { numRecGastoActivo = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int cajaID = -1;

        public int CajaID
        {
            get { return cajaID; }
            set { cajaID = value; }
        }
        private string nomCaja = string.Empty;

        public string NomCaja
        {
            get { return nomCaja; }
            set { nomCaja = value; }
        }
        private int activoID = -1;

        public int ActivoID
        {
            get { return activoID; }
            set { activoID = value; }
        }
        private string nomActivo = string.Empty;

        public string NomActivo
        {
            get { return nomActivo; }
            set { nomActivo = value; }
        }
        private int tipoActivoID = -1;

        public int TipoActivoID
        {
            get { return tipoActivoID; }
            set { tipoActivoID = value; }
        }
        private string nomTipoActivo = string.Empty;

        public string NomTipoActivo
        {
            get { return nomTipoActivo; }
            set { nomTipoActivo = value; }
        }
        private int gastosTipoActivoID = -1;

        public int GastosTipoActivoID
        {
            get { return gastosTipoActivoID; }
            set { gastosTipoActivoID = value; }
        }
        private string nomGastoTipoActivo = string.Empty;

        public string NomGastoTipoActivo
        {
            get { return nomGastoTipoActivo; }
            set { nomGastoTipoActivo = value; }
        }
        private string concepto = string.Empty;

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
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
        private string suma = string.Empty;

        public string Suma
        {
            get { return suma; }
            set { suma = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
