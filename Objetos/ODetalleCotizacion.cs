using System;
using System.Xml.Serialization;

namespace Objetos
{
    public class ODetalleCotizacion
    {
        private int productoID = -1;

        public int ProductoID
        {
            get { return productoID; }
            set 
            {
                if((value == -1) || (string.IsNullOrEmpty(value.ToString())))
                    throw new Exception("Problemas al Ingresar un Item");
                else
                    productoID = value; 
            }
        }
        private string nomProd = string.Empty;
        [XmlIgnore] 
        public string NomProd
        {
            get { return nomProd; }
            set 
            {
                if ((string.IsNullOrEmpty(value)) || (string.IsNullOrWhiteSpace(value)))
                    throw new Exception("El Nombre del Item no puede estar Vacio");
                else
                    nomProd = value; 
            }
        }
        private decimal cantidad = 0;

        public decimal Cantidad
        {
            get { return cantidad; }
            set 
            {
                if (value <= 0)
                    throw new Exception("La Cantidad de los Items tienen que ser Mayor a Cero");
                else
                    cantidad = value; 
            }
        }
        private decimal pUnitario = 0;

        public decimal PUnitario
        {
            get { return pUnitario; }
            set 
            {
                if(value <= 0)
                    throw new Exception("El Precio Unitario de los Items tiene que ser Mayor a Cero");
                else
                    pUnitario = value; 
            }
        }
        private decimal pTotal = 0;

        public decimal PTotal
        {
            get { return pTotal; }
            set 
            {
                if (value <= 0)
                    throw new Exception("El Importe de los Items tiene que ser Mayor a Cero");
                else
                    pTotal = value; 
            }
        }
        private string unidMedida = string.Empty;
        [XmlIgnore] 
        public string UnidMedida
        {
            get { return unidMedida; }
            set { unidMedida = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
