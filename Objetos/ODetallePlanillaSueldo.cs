using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetallePlanillaSueldo
    {
        private string codPlanilla = string.Empty;

        public string CodPlanilla
        {
            get { return codPlanilla; }
            set { codPlanilla = value; }
        }
        private DateTime fecIng = DateTime.Now;

        public DateTime FecIng
        {
            get { return fecIng; }
            set { fecIng = value; }
        }
        private int personalID = -1;

        public int PersonalID
        {
            get { return personalID; }
            set { personalID = value; }
        }
        private string nomPer = string.Empty;

        public string NomPer
        {
            get { return nomPer; }
            set { nomPer = value; }
        }
        private int sucursalID = -1;

        public int SucursalID
        {
            get { return sucursalID; }
            set { sucursalID = value; }
        }
        private string nomSuc = string.Empty;

        public string NomSuc
        {
            get { return nomSuc; }
            set { nomSuc = value; }
        }
        private int numOrden = 0;

        public int NumOrden
        {
            get { return numOrden; }
            set { numOrden = value; }
        }
        private string nro = string.Empty;

        public string Nro
        {
            get { return nro; }
            set { nro = value; }
        }
        private string cI = string.Empty;

        public string CI
        {
            get { return cI; }
            set { cI = value; }
        }
        private string cargo = string.Empty;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        private decimal haberBasico = 0;

        public decimal HaberBasico
        {
            get { return haberBasico; }
            set { haberBasico = value; }
        }
        private decimal diasTrabaj = 0;

        public decimal DiasTrabaj
        {
            get { return diasTrabaj; }
            set { diasTrabaj = value; }
        }
        private decimal haberGanado = 0;

        public decimal HaberGanado
        {
            get { return haberGanado; }
            set { haberGanado = value; }
        }
        private decimal incremento = 0;

        public decimal Incremento
        {
            get { return incremento; }
            set { incremento = value; }
        }
        private decimal bonoAntig = 0;

        public decimal BonoAntig
        {
            get { return bonoAntig; }
            set { bonoAntig = value; }
        }
        private decimal bonoHrExtr = 0;

        public decimal BonoHrExtr
        {
            get { return bonoHrExtr; }
            set { bonoHrExtr = value; }
        }
        private decimal otrosBonos = 0;

        public decimal OtrosBonos
        {
            get { return otrosBonos; }
            set { otrosBonos = value; }
        }
        private decimal numDiasDominic = 0;

        public decimal NumDiasDominic
        {
            get { return numDiasDominic; }
            set { numDiasDominic = value; }
        }
        private decimal dominicales = 0;

        public decimal Dominicales
        {
            get { return dominicales; }
            set { dominicales = value; }
        }
        private decimal comisionSVentas = 0;

        public decimal ComisionSVentas
        {
            get { return comisionSVentas; }
            set { comisionSVentas = value; }
        }
        private decimal totalGanado = 0;

        public decimal TotalGanado
        {
            get { return totalGanado; }
            set { totalGanado = value; }
        }
        private decimal anticipSueldo = 0;

        public decimal AnticipSueldo
        {
            get { return anticipSueldo; }
            set { anticipSueldo = value; }
        }
        private decimal anticipAlmuerzo = 0;

        public decimal AnticipAlmuerzo
        {
            get { return anticipAlmuerzo; }
            set { anticipAlmuerzo = value; }
        }
        private decimal prestamos = 0;

        public decimal Prestamos
        {
            get { return prestamos; }
            set { prestamos = value; }
        }
        private decimal celCorpo = 0;

        public decimal CelCorpo
        {
            get { return celCorpo; }
            set { celCorpo = value; }
        }
        private decimal dsctoFaltInv = 0;

        public decimal DsctoFaltInv
        {
            get { return dsctoFaltInv; }
            set { dsctoFaltInv = value; }
        }
        private decimal multasSanciones = 0;

        public decimal MultasSanciones
        {
            get { return multasSanciones; }
            set { multasSanciones = value; }
        }
        private decimal aFP = 0;

        public decimal AFP
        {
            get { return aFP; }
            set { aFP = value; }
        }
        private decimal rCIVA = 0;

        public decimal RCIVA
        {
            get { return rCIVA; }
            set { rCIVA = value; }
        }
        private decimal otrosDscto = 0;

        public decimal OtrosDscto
        {
            get { return otrosDscto; }
            set { otrosDscto = value; }
        }
        private decimal totalDscto = 0;

        public decimal TotalDscto
        {
            get { return totalDscto; }
            set { totalDscto = value; }
        }
        private decimal liquidoPagable = 0;

        public decimal LiquidoPagable
        {
            get { return liquidoPagable; }
            set { liquidoPagable = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private byte[] img;

        public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
