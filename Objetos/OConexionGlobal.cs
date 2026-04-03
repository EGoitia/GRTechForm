using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Objetos
{
    public static class OConexionGlobal
    {
        static string _globalValor = "Comercial";
        static string _globalValorLocal = "Local";
        static string _globalIPServidor;
        static int _empresaID;
        static int _sucursalID;
        static int _personalID;
        static int _usuarioID;
        static string _nomEmp;
        static string _nomSuc;
        static string _nomPer;
        static string _nomUsu;
        static string _tipoUsu;
        static string _ciudad;
        static string _pais = "BOLIVIA";
        static string _direccion;
        static string _telf;
        static byte[] _logoEmp;
        static DataTable _detalle_Rol;

        public static string GlobalValor
        {
            get
            {
                return _globalValor;
            }
            set
            {
                _globalValor = value;
            }
        }

        public static string GlobalValorLocal
        {
            get
            {
                return _globalValorLocal;
            }
            set
            {
                _globalValorLocal = value;
            }
        }

        public static string GlobalIPServidor
        {
            get
            {
                return _globalIPServidor;
            }
            set
            {
                _globalIPServidor = value;
            }
        }

        public static int EmpresaID
        {
            get
            {
                return _empresaID;
            }
            set
            {
                _empresaID = value;
            }
        }

        public static int SucursalID
        {
            get
            {
                return _sucursalID;
            }
            set
            {
                _sucursalID = value;
            }
        }

        public static int PersonalID
        {
            get
            {
                return _personalID;
            }
            set
            {
                _personalID = value;
            }
        }

        public static int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                _usuarioID = value;
            }
        }

        public static string NomEmp
        {
            get
            {
                return _nomEmp;
            }
            set
            {
                _nomEmp = value;
            }
        }

        public static string NomSuc
        {
            get
            {
                return _nomSuc;
            }
            set
            {
                _nomSuc = value;
            }
        }

        public static string NomPer
        {
            get
            {
                return _nomPer;
            }
            set
            {
                _nomPer = value;
            }
        }

        public static string NomUsu
        {
            get
            {
                return _nomUsu;
            }
            set
            {
                _nomUsu = value;
            }
        }

        public static string TipoUsu
        {
            get
            {
                return _tipoUsu;
            }
            set
            {
                _tipoUsu = value;
            }
        }

        public static string Ciudad
        {
            get
            {
                return _ciudad;
            }
            set
            {
                _ciudad = value;
            }
        }

        public static string Pais
        {
            get
            {
                return _pais;
            }
            set
            {
                _pais = value;
            }
        }

        public static string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public static string Telf
        {
            get
            {
                return _telf;
            }
            set
            {
                _telf = value;
            }
        }

        public static byte[] LogoEmp
        {
            get
            {
                return _logoEmp;
            }
            set
            {
                _logoEmp = value;
            }
        }
        
        public static DataTable Detalle_Rol
        {
            get
            {
                return _detalle_Rol;
            }
            set
            {
                _detalle_Rol = value;
            }
        }
    }
}
