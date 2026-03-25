using System;
using System.Data.SQLite;

namespace Datos
{
    public class ConfigService
    {
        public static string ObtenerValor(string _nombre)
        {
            string valor = string.Empty;

            try
            {
                using (var ctx = DbContext.GetInstance())
                {
                    var query = "SELECT Valor FROM Configuracion WHERE Nombre='" + _nombre + "'";

                    using (var command = new SQLiteCommand(query, ctx))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                valor = reader["Valor"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return valor;
        }

        public static bool ModificarValor(string _nombre, string _valor)
        {
            try
            {
                using (var ctx = DbContext.GetInstance())
                {
                    string sql = "UPDATE Configuracion SET Valor='" + _valor + "' WHERE Nombre='" + _nombre + "'";
                    SQLiteCommand comando = new SQLiteCommand(sql, ctx);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {   
                throw;
            }

            return true;
        }
    }
}
