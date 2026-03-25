using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OEmpresa
    {
        private Int32 empresaID = -1;

        public Int32 EmpresaID
        {
            get { return empresaID; }
            set { empresaID = value; }
        }
        private string codLogo = string.Empty;

        public string CodLogo
        {
            get { return codLogo; }
            set { codLogo = value; }
        }
        private byte[] logo;

        public byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomEmp = string.Empty;

        public string NomEmp
        {
            get { return nomEmp; }
            set 
            {
                if ((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    nomEmp = value;
                else
                    throw new Exception("El nombre de la Empresa no puede estar vacio");
            }
        }
        private string nIT = string.Empty;

        public string NIT
        {
            get { return nIT; }
            set { nIT = value; }
        }
        private string giro = string.Empty;

        public string Giro
        {
            get { return giro; }
            set { giro = value; }
        }
        private string codActividad = string.Empty;

        public string CodActividad
        {
            get { return codActividad; }
            set { codActividad = value; }
        }
        private string codEmpleadorMT = string.Empty;

        public string CodEmpleadorMT
        {
            get { return codEmpleadorMT; }
            set { codEmpleadorMT = value; }
        }
        private string codEmpleadorCNS = string.Empty;

        public string CodEmpleadorCNS
        {
            get { return codEmpleadorCNS; }
            set { codEmpleadorCNS = value; }
        }
        private string codEmpleadorAFP = string.Empty;

        public string CodEmpleadorAFP
        {
            get { return codEmpleadorAFP; }
            set { codEmpleadorAFP = value; }
        }
        private string pagWeb = string.Empty;

        public string PagWeb
        {
            get { return pagWeb; }
            set { pagWeb = value; }
        }
        private string email = string.Empty;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string nomRepresentLegal = string.Empty;

        public string NomRepresentLegal
        {
            get { return nomRepresentLegal; }
            set { nomRepresentLegal = value; }
        }
        private string nITRepresentLegal = string.Empty;

        public string NITRepresentLegal
        {
            get { return nITRepresentLegal; }
            set { nITRepresentLegal = value; }
        }
        private string regEmp = string.Empty;

        public string RegEmp
        {
            get { return regEmp; }
            set { regEmp = value; }
        }
    }
}
