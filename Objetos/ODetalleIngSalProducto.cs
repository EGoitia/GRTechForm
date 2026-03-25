using System;
using System.Xml.Serialization;

namespace Objetos
{
    public class ODetalleIngSalProducto
    {
        private string codIngSalProd = string.Empty;

        public string CodIngSalProd
        {
            get { return codIngSalProd; }
            set { codIngSalProd = value; }
        }
        private int productoID = -1;

        public int ProductoID
        {
            get { return productoID; }
            set 
            {
                if (value > 0)
                    productoID = value;
                else
                    throw new Exception("Seleccione un item Valido");
            }
        }
        private string nomProd = string.Empty;
        [XmlIgnore] 
        public string NomProd
        {
            get { return nomProd; }
            set { nomProd = value; }
        }
        private decimal cantidad = 0;

        public decimal Cantidad
        {
            get { return cantidad; }
            set 
            {
                if (value > 0)
                    cantidad = value;
                else
                    throw new Exception("La Cantidad del item tiene que ser Mayor a acero");
            }
        }
        private string unidMedida = string.Empty;
        [XmlIgnore] 
        public string UnidMedida
        {
            get { return unidMedida; }
            set { unidMedida = value; }
        }
        private decimal cantUnidMedida = 0;
        [XmlIgnore] 
        public decimal CantUnidMedida
        {
            get { return cantUnidMedida; }
            set { cantUnidMedida = value; }
        }
        private decimal peso = 0;
        [XmlIgnore] 
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private byte[] img;
        [XmlIgnore] 
        public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }
        private decimal pUnitario = 0;

        public decimal PUnitario
        {
            get { return pUnitario; }
            set 
            {
                if (value > 0)
                    pUnitario = value;
                else
                    throw new Exception("El Precio tiene que ser mayor a cero");
            }
        }
        private decimal pTotal = 0;

        public decimal PTotal
        {
            get { return pTotal; }
            set { pTotal = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
