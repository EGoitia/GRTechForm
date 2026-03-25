using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OImagen
    {
        private string codImagen = string.Empty;

        public string CodImagen
        {
            get { return codImagen; }
            set { codImagen = value; }
        }
        private string nomImagen = string.Empty;

        public string NomImagen
        {
            get { return nomImagen; }
            set { nomImagen = value; }
        }
        private string dimensiones = string.Empty;

        public string Dimensiones
        {
            get { return dimensiones; }
            set { dimensiones = value; }
        }
        private byte[] img;

        public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
