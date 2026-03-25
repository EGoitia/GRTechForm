using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OReferenciaPersonal: OUbicacion
    {
        private int refPersonalID = -1;

        public int RefPersonalID
        {
            get { return refPersonalID; }
            set { refPersonalID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
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
        private string nomRefer = string.Empty;

        public string NomRefer
        {
            get { return nomRefer; }
            set { nomRefer = value; }
        }
        private string parentescoRefer = string.Empty;

        public string ParentescoRefer
        {
            get { return parentescoRefer; }
            set { parentescoRefer = value; }
        }
        private string telfRefer = string.Empty;

        public string TelfRefer
        {
            get { return telfRefer; }
            set { telfRefer = value; }
        }
        private string celRefer = string.Empty;

        public string CelRefer
        {
            get { return celRefer; }
            set { celRefer = value; }
        }
    }
}
