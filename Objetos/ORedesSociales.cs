using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ORedesSociales
    {
        private int redSocialID = -1;

        public int RedSocialID
        {
            get { return redSocialID; }
            set { redSocialID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string link = string.Empty;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
