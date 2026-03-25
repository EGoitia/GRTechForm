using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OPersonal
    {
        private Int32 personalID = -1;

        public Int32 PersonalID
        {
            get { return personalID; }
            set { personalID = value; }
        }
        private Int32 cargoID = -1;

        public Int32 CargoID
        {
            get { return cargoID; }
            set { cargoID = value; }
        }
        private string nomCargo = string.Empty;

        public string NomCargo
        {
            get { return nomCargo; }
            set { nomCargo = value; }
        }
        private Int32 sucursalID = -1;

        public Int32 SucursalID
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
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codImagen = string.Empty;

        public string CodImagen
        {
            get { return codImagen; }
            set { codImagen = value; }
        }
        private byte[] img;

        public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }
        private string codUbicacion = string.Empty;

        public string CodUbicacion
        {
            get { return codUbicacion; }
            set { codUbicacion = value; }
        }
        private string nomPer = string.Empty;

        public string NomPer
        {
            get { return nomPer; }
            set { nomPer = value; }
        }
        private string nacionalidad = string.Empty;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        private string cI = string.Empty;

        public string CI
        {
            get { return cI; }
            set { cI = value; }
        }
        private string estCivil = string.Empty;

        public string EstCivil
        {
            get { return estCivil; }
            set { estCivil = value; }
        }
        private string sexo = string.Empty;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private string telf = string.Empty;

        public string Telf
        {
            get { return telf; }
            set { telf = value; }
        }
        private string email = string.Empty;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private DateTime fecNac = DateTime.Now;

        public DateTime FecNac
        {
            get { return fecNac; }
            set { fecNac = value; }
        }
        private DateTime fecIngreso = DateTime.Now;

        public DateTime FecIngreso
        {
            get { return fecIngreso; }
            set { fecIngreso = value; }
        }
        private decimal haberBasico = 0;

        public decimal HaberBasico
        {
            get { return haberBasico; }
            set { haberBasico = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
