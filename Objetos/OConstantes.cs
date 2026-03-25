using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OConstantes
    {
        #region Tipo Pagos

        public const int Tipo_Pago_EFECTIVO = 12;
        public const int Tipo_Pago_TARJETA = 13;
        public const int Tipo_Pago_CHEQUE = 14;
        public const int Tipo_Pago_DEPOSITO = 15;
        public const int Tipo_Pago_TRANSFERENCIA = 16;
        public const int Tipo_Pago_POSTERIOR = 32;

        #endregion

        #region Tipo Venta

        public const int Tipo_Venta_CONTADO = 4;
        public const int Tipo_Venta_CREDITO = 5;
        public const int Tipo_Venta_ANTICIPADO = 6;

        #endregion

        #region Tipo Caja

        public const int Tipo_Caja_VENTAS = 30;
        public const int Tipo_Caja_BANCO = 31;        
        public const int Tipo_Caja_CAJA_CHICA = 32;
        public const int Tipo_Caja_TARJETA = 33;

        #endregion

        #region Cliente

        public const int Clientes_Varios = 1;

        #endregion
    }
}
