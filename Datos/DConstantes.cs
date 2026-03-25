using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class DConstantes
    {
        public class Mensajes
        {
            public const string MensajeExito = "OPERACIÓN REALIZADA CON ÉXITO";
            public const string MensajeError = "OCURRIÓ UN ERROR, INTENTE MAS TARDE";
            public const string MensajeNotienePermisoGuardar = "NO TIENE PERMISO PARA GUARDAR";
            public const string MensajeNotienePermisoModificar = "NO TIENE PERMISO PARA MODIFICAR";
            public const string MensajeNotienePermisoEliminar = "NO TIENE PERMISO PARA ELIMINAR";
            public const string MensajeNotienePermisoAnular = "NO TIENE PERMISO PARA ANULAR";
            public const string MensajeNotienePermisoEnviar = "NO TIENE PERMISO PARA ENVIAR";
        }

        public class Imprimir
        {
            public class Nota_Venta
            {
                public static readonly bool IMP_NOTA_VENTA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static readonly bool VISUALIZAR_NOTA_VENTA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_NOTA_VENTA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static readonly string NOM_REPORTE_NOTA_VENTA = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_NOTA_VENTA'").ToString();

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Nota_Factura
            {
                public static readonly bool IMP_FACTURA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_FACTURA'"));
                public static readonly bool VISUALIZAR_FACTURA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_FACTURA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static readonly string NOM_REPORTE_FACTURA = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_FACTURA'").ToString();

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Lista_Venta
            {
                public static readonly string NOM_REPORTE_LISTA_VENTA = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_LISTA_VENTA'").ToString();

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Lista_Venta_Detallado
            {
                public static readonly string NOM_REPORTE_LISTA_VENTA_DETALLADO = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_LISTA_VENTA_DETALLADO'").ToString();

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Lista_Libro_Venta
            {
                public static readonly string NOM_REPORTE_LIBRO_VENTA = "Carta\\RptLibroVentas";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }
            
            public class Nota_Compra
            {
                public static readonly bool IMP_NOTA_COMPRA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static readonly bool VISUALIZAR_NOTA_COMPRA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_NOTA_COMPRA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static readonly string NOM_REPORTE_NOTA_COMPRA = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_NOTA_COMPRA'").ToString();
                
                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Lista_Compra
            {
                public static readonly string NOM_REPORTE_LISTA_COMPRA = "Carta\\RptListaCompras";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Nota_IngSalProd
            {
                public static bool IMP_NOTA_INGSALPROD = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static bool VISUALIZAR_NOTA_INGSALPROD = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static bool IMPAUTOMATIC_NOTA_INGSALPROD = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static string NOM_REPORTE_NOTA_INGSALPROD = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_NOTA_INGSALPROD'").ToString();

                public static bool MOSTRAR_BTN_IMP = true;
                public static bool MOSTRAR_BTN_COPIAR = false;
                public static bool MOSTRAR_BTN_EXPORT = false;
                public static bool MOSTRAR_ARBOL = false;
            }

            public class Nota_CierreCaja
            {
                public static bool IMP_NOTA_CIERRECAJA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_CIERRE'"));
                public static bool VISUALIZAR_NOTA_CIERRECAJA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static bool IMPAUTOMATIC_NOTA_CIERRECAJA = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static string NOM_REPORTE_NOTA_CIERRECAJA = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_NOTA_CIERRECAJA'").ToString();

                public static bool MOSTRAR_BTN_IMP = true;
                public static bool MOSTRAR_BTN_COPIAR = false;
                public static bool MOSTRAR_BTN_EXPORT = false;
                public static bool MOSTRAR_ARBOL = false;
            }

            public class Lista_IngSalProd
            {
                public static readonly string NOM_REPORTE_LISTA_INGSALPROD = "Carta\\RptListaIngSal";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Lista_IngSalProd_Detallado
            {
                public static readonly string NOM_REPORTE_LISTA_INGSALPROD_DETALLADO = "Carta\\RptListaIngSal_Detallado";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Nota_Pedido
            {
                public static readonly bool IMP_NOTA_PEDIDO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static readonly bool VISUALIZAR_NOTA_PEDIDO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_NOTA_PEDIDO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static readonly string NOM_REPORTE_NOTA_PEDIDO = "Carta\\RepNotaPedido";
                public static readonly string NOM_TITULO_NOTA_PEDIDO = "NOTA DE PEDIDO";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Lista_Pedido
            {
                public static readonly string NOM_REPORTE_LISTA_PEDIDO = "Carta\\RptListaVentas";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Lista_Pedido_Detallado
            {
                public static readonly string NOM_REPORTE_LISTA_PEDIDO_DETALLADO = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_LISTA_VENTA_DETALLADO'").ToString();

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Nota_Cotizacion
            {
                public static readonly bool IMP_NOTA_COTIZACION = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static readonly bool VISUALIZAR_NOTA_COTIZACION = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_NOTA_COTIZACION = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static readonly string NOM_REPORTE_NOTA_COTIZACION = "RepNotaCotizacion";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Nota_Traspaso
            {
                public static readonly bool IMP_NOTA_TRASPASO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static readonly bool VISUALIZAR_NOTA_TRASPASO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_NOTA_TRASPASO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static readonly string NOM_REPORTE_NOTA_TRASPASO = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_NOTA_TRASPASO'").ToString();

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Lista_Traspaso
            {
                public static string NOM_REPORTE_LISTA_TRASPASO = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_LISTA_TRASPASO'").ToString();

                public static bool MOSTRAR_BTN_IMP = true;
                public static bool MOSTRAR_BTN_COPIAR = true;
                public static bool MOSTRAR_BTN_EXPORT = true;
                public static bool MOSTRAR_ARBOL = true;
            }

            public class Lista_Traspaso_Detallado
            {
                public static readonly string NOM_REPORTE_LISTA_TRASPASO_DETALLADO = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_LISTA_TRASPASO_DETALLADO'").ToString();

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Nota_Inventario
            {
                public static readonly bool IMP_NOTA_INVENTARIO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static readonly bool VISUALIZAR_NOTA_INVENTARIO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_NOTA_INVENTARIO = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static readonly string NOM_REPORTE_NOTA_INVENTARIO = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='NOM_REPORTE_NOTA_INVENTARIO'").ToString();

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Nota_Abono
            {
                public static bool VISUALIZAR_NOTA_ABONOCLI = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static bool IMPAUTOMATIC_NOTA_ABONOCLI = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));
            }

            public class Nota_Pago
            {
                public static readonly bool VISUALIZAR_NOTA_PAGOPROV = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_NOTA_PAGOPROV = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));
            }

            public class Nota_IngrEgre
            {
                public static readonly bool IMP_NOTA_INGREGRE = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static readonly bool VISUALIZAR_NOTA_INGREGRE = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                public static readonly bool IMPAUTOMATIC_NOTA_INGREGRE = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMPAUTOMATIC'"));

                public static readonly string NOM_REPORTE_NOTA_INGREGRE = "Carta\\RptIngresosEgresos";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Lista_IngrEgre
            {
                public static readonly string NOM_REPORTE_LISTA_INGREGRE = "RptListaIngrEgre";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = true;
                public static readonly bool MOSTRAR_BTN_EXPORT = true;
                public static readonly bool MOSTRAR_ARBOL = true;
            }

            public class Nota_Proyeccion
            {
                public static readonly bool IMP_NOTA_PROYECCION = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='IMP_NOTA'"));
                public static readonly bool VISUALIZAR_NOTA_PROYECCION = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='VISUALIZAR_NOTA'"));
                
                public static readonly string NOM_REPORTE_NOTA_PROYECCION = "Carta\\RepNotaProyeccion";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Rep_Pagos_Proveedores
            {
                public static readonly string NOM_REPORTE_PAGOS_PROV = "Carta\\RepPagosProveedores";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }

            public class Rep_Abonos_Clientes
            {
                public static readonly string NOM_REPORTE_ABONO_CLI = "Carta\\RepAbonosClientes";

                public static readonly bool MOSTRAR_BTN_IMP = true;
                public static readonly bool MOSTRAR_BTN_COPIAR = false;
                public static readonly bool MOSTRAR_BTN_EXPORT = false;
                public static readonly bool MOSTRAR_ARBOL = false;
            }
        }

        public class General
        {
            public static readonly bool RESTRING_PRECIOS_VENTAS = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='RESTRING_PRECIOS_VENTAS'"));
            public static readonly string TIP_CIERRE_CAJA = DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='TIP_CIERRE_CAJA'").ToString();
            public static readonly bool CONFIRM_AUT_TRASP = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='CONFIRM_AUT_TRASP'"));
        }

        public class Clasificacion
        {
            public static readonly int Insumos = 1014;
            public static readonly int SemiElaborados = 1015;
            public static readonly int Terminados = 1016;
            public static readonly int PorPeso = 1017;
            public static readonly int Combo = 1018;
            public static readonly int MatPublicidad = 1019;
            public static readonly int Servicio = 1020;
            public static readonly int Activos = 1021;
        }
    }
}
