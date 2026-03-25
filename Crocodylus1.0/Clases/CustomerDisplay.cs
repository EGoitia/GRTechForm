using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace GRTechnology1._0.Clases
{
    class CustomerDisplay
    {
        // Instancia única (Singleton)
        private static CustomerDisplay _instance;
        private SerialPort port;

        // Constructor privado para evitar nuevas instancias externas
        private CustomerDisplay()
        {
            try
            {
                // Configuración fija según tus pruebas exitosas
                port = new SerialPort(Properties.Settings.Default.Display_COM,
                    Convert.ToInt32(Properties.Settings.Default.Display_BaudRate),
                    Parity.None, 8, StopBits.One);
                port.Encoding = Encoding.ASCII;
            }
            catch (Exception)
            {

            }
        }

        // Propiedad para acceder a la instancia global
        public static CustomerDisplay Instance
        {
            get
            {
                if (_instance == null) _instance = new CustomerDisplay();
                return _instance;
            }
        }

        public void Open()
        {
            try { if (!port.IsOpen) port.Open(); }
            catch { /* Manejar error de puerto */ }
        }

        public void Close()
        {
            if (port != null && port.IsOpen) port.Close();
        }

        public void Limpiar()
        {
            if (port != null && port.IsOpen) port.Write(new byte[] { 0x0C }, 0, 1);
        }

        public void Mostrar(string valor)
        {
            if (!port.IsOpen) Open();

            byte[] comando = { 0x1B, 0x51, 0x41 };
            byte[] datos = Encoding.ASCII.GetBytes(valor);
            byte[] fin = { 0x0D };

            port.Write(comando, 0, comando.Length);
            port.Write(datos, 0, datos.Length);
            port.Write(fin, 0, fin.Length);
        }

        public void MostrarCantidad(string valor)
        {
            if (!port.IsOpen) Open();
            byte[] cmdStatus = { 0x1B, 0x73, 0x31 }; // LED Cantidad           
            port.Write(cmdStatus, 0, cmdStatus.Length);
            Mostrar(valor);
        }

        public void MostrarTotal(decimal monto)
        {
            if (!port.IsOpen) Open();
            string precioStr = monto.ToString("N2").Replace(",", ".");
            byte[] ledTotal = { 0x1B, 0x73, 0x32 }; // LED Total 
            port.Write(ledTotal, 0, ledTotal.Length);
            Mostrar(precioStr);
        }

        public void MostrarCobrar(decimal monto)
        {
            if (!port.IsOpen) Open();

            // Formateamos el monto a 2 decimales y aseguramos el punto decimal
            string cambioStr = monto.ToString("N2").Replace(",", ".");

            // 0x1B 0x73 0x33 es el comando estándar para activar el LED de "Cobro"
            byte[] ledCambio = { 0x1B, 0x73, 0x33 };
            port.Write(ledCambio, 0, ledCambio.Length);
            Mostrar(cambioStr);
        }

        public void MostrarCambio(decimal monto)
        {
            if (!port.IsOpen) Open();

            // Formateamos el monto a 2 decimales y aseguramos el punto decimal
            string cambioStr = monto.ToString("N2").Replace(",", ".");

            // 0x1B 0x73 0x33 es el comando estándar para activar el LED de "Cambio"
            byte[] ledCambio = { 0x1B, 0x73, 0x34 };
            port.Write(ledCambio, 0, ledCambio.Length);
            Mostrar(cambioStr);
        }
    }
}
