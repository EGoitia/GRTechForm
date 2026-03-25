using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OPrestamoProv
    {
        private int prestamoID = -1;

        public int PrestamoID
        {
            get { return prestamoID; }
            set { prestamoID = value; }
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
        private string codPago = string.Empty;

        public string CodPago
        {
            get { return codPago; }
            set { codPago = value; }
        }
        private string numContrato = string.Empty;

        public string NumContrato
        {
            get { return numContrato; }
            set { numContrato = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int proveedorID = -1;

        public int ProveedorID
        {
            get { return proveedorID; }
            set { proveedorID = value; }
        }
        private string nomProv = string.Empty;

        public string NomProv
        {
            get { return nomProv; }
            set { nomProv = value; }
        }
        private int plazoMeses = 0;

        public int PlazoMeses
        {
            get { return plazoMeses; }
            set { plazoMeses = value; }
        }
        private decimal contratoBs = 0;

        public decimal ContratoBs
        {
            get { return contratoBs; }
            set { contratoBs = value; }
        }
        private decimal interesPorcent = 0;

        public decimal InteresPorcent
        {
            get { return interesPorcent; }
            set { interesPorcent = value; }
        }
        private decimal totalPrestamoBs = 0;

        public decimal TotalPrestamoBs
        {
            get { return totalPrestamoBs; }
            set { totalPrestamoBs = value; }
        }       
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private bool documento = false;

        public bool Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
