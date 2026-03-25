using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Datos
{
    public class DbContext
    {
        private const string DBName = "config.sqlite";
        private static bool TablasCreadas = false;

        public static void Up()
        {
            // Crea la base de datos y registra usuario solo una vez
            if (!File.Exists(Application.StartupPath + @"\Db\" + DBName))
            {
                SQLiteConnection.CreateFile(Application.StartupPath + @"\Db\" + DBName);
                TablasCreadas = true;
            }

            using (var ctx = GetInstance())
            {
                if (TablasCreadas)
                {
                    //using (var reader = new StreamReader(Application.StartupPath + @"\Db\" + DBName))
                    //{
                    //    var query = "";
                    //    var line = "";
                    //    while ((line = reader.ReadLine()) != null)
                    //    {
                    //        query += line;
                    //    }

                    //    using (var command = new SQLiteCommand(query, ctx))
                    //    {
                    //        command.ExecuteNonQuery();
                    //    }
                    //}

                    //Creacion de Tablas
                    Crear_Tablas(ctx);
                }
            }
        }

        public static SQLiteConnection GetInstance()
        {
            var db = new SQLiteConnection(string.Format("Data Source={0};Version=3;", DBName));
            db.Open();
            
            return db;
        }

        public static void CerrarConexion(SQLiteConnection ctx)
        {
            ctx.Close();
        }

        private static void Crear_Tablas(SQLiteConnection ctx)
        {
            string sql = "CREATE TABLE Configuracion (Nombre varchar(20), Tipo varchar(10), Valor varchar(100)); " +
                "CREATE TABLE Detalle_IngSalProducto(Det_IngSalProd int, ProductoID int, Cantidad float, PUnitario float); " +
                "CREATE TABLE Detalle_Venta(DetCodVenta int, ProductoID int, Cantidad float, PUnitario float, RegSanitario varchar(50) NULL)";
            SQLiteCommand comando = new SQLiteCommand(sql, ctx);
            comando.ExecuteNonQuery();

            string commandText = "INSERT INTO Configuracion (Nombre, Tipo, Valor) VALUES (?, ?, ?)";

            using (var command = new SQLiteCommand(commandText, ctx))
            {
                command.Parameters.Add(new SQLiteParameter("Nombre", "RutaSistemaActualizador"));
                command.Parameters.Add(new SQLiteParameter("Tipo", "string"));
                command.Parameters.Add(new SQLiteParameter("Valor", ""));
                command.ExecuteNonQuery();
            }
        }
    }
}
