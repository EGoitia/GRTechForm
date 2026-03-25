using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OConformidad:OUbicacion
    {
        private string codConformidad = string.Empty;

        public string CodConformidad
        {
            get { return codConformidad; }
            set { codConformidad = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private Int32 sucursalID = -1;

        public Int32 SucursalID
        {
            get { return sucursalID; }
            set 
            {
                if (value > 0)
                    sucursalID = value;
                else
                    throw new Exception("Error al obtener la ID de la sucursal, reinicie el sistema");
            }
        }
        private string nomSuc = string.Empty;

        public string NomSuc
        {
            get { return nomSuc; }
            set { nomSuc = value; }
        }
        private Int32 destinoID = -1;

        public Int32 DestinoID
        {
            get { return destinoID; }
            set 
            {
                if (value > 0)
                    destinoID = value;
                else
                    throw new Exception("Seleccione un Destino Valido");
            }
        }
        private string nomContTransporte = string.Empty;

        public string NomContTransporte
        {
            get { return nomContTransporte; }
            set { nomContTransporte = value; }
        }
        private Int32 choferID = -1;

        public Int32 ChoferID
        {
            get { return choferID; }
            set 
            {
                if (value > 0)
                    choferID = value;
                else
                    throw new Exception("Seleccione un Chofer");
            }
        }
        private string nomChofer = string.Empty;

        public string NomChofer
        {
            get { return nomChofer; }
            set { nomChofer = value; }
        }
        private string numConform = string.Empty;

        public string NumConform
        {
            get { return numConform; }
            set { numConform = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string notSalida = string.Empty;

        public string NotSalida
        {
            get { return notSalida; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    notSalida = value;
                else
                    throw new Exception("N/Salida no puede estar vacio");
            }
        }
        private int valor = 1;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private string placa = string.Empty;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        private string referencia = string.Empty;

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private decimal totalm2 = 0;

        public decimal Totalm2
        {
            get { return totalm2; }
            set { totalm2 = value; }
        }
        private decimal totalBolsa = 0;

        public decimal TotalBolsa
        {
            get { return totalBolsa; }
            set { totalBolsa = value; }
        }
        private decimal totalPzas = 0;

        public decimal TotalPzas
        {
            get { return totalPzas; }
            set { totalPzas = value; }
        }
        private byte[] imgQR;

        public byte[] ImgQR
        {
            get { return imgQR; }
            set { imgQR = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
