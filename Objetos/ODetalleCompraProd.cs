using System.Xml.Serialization;

namespace Objetos
{
    public class ODetalleCompraProd
    {
        private string codCompraProd = string.Empty;

        public string CodCompraProd
        {
            get { return codCompraProd; }
            set { codCompraProd = value; }
        }
        private int productoID = -1;

        public int ProductoID
        {
            get { return productoID; }
            set { productoID = value; }
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
            set { cantidad = value; }
        }
        private decimal cantidadRegul = 0;

        public decimal CantidadRegul
        {
            get { return cantidadRegul; }
            set { cantidadRegul = value; }
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
            set { pUnitario = value; }
        }
        private decimal pTotal = 0;

        public decimal PTotal
        {
            get { return pTotal; }
            set { pTotal = value; }
        }
        private decimal incremento = 0;

        public decimal Incremento
        {
            get { return incremento; }
            set { incremento = value; }
        }
        private decimal incrementoCosto = 0;

        public decimal IncrementoCosto
        {
            get { return incrementoCosto; }
            set { incrementoCosto = value; }
        }
        private decimal costoTotal = 0;

        public decimal CostoTotal
        {
            get { return costoTotal; }
            set { costoTotal = value; }
        }
        private decimal costoUnitTotal = 0;

        public decimal CostoUnitTotal
        {
            get { return costoUnitTotal; }
            set { costoUnitTotal = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
