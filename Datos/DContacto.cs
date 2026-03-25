using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DContacto
    {
        /// <summary>
        /// Procedimiento para Insertar o Modificar Datos de los Contactos del Proveedor
        /// </summary>
        /// <param name="provid"></param>
        /// <param name="contact"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static int DInsertModifContact(int codigo, string tupla, OContacto contact, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifContac", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
               
                miCmd.Parameters.AddWithValue("@Codigo", codigo);
                miCmd.Parameters.AddWithValue("@Tupla", tupla);
                
                if(contact.ContactoID == -1)
                {
                    miCmd.Parameters.AddWithValue("@ContactoID", DBNull.Value);
                }
                else
                {
                    miCmd.Parameters.AddWithValue("@ContactoID", contact.ContactoID);
                }
                
                miCmd.Parameters.AddWithValue("@NomContact", contact.NomContact);
                miCmd.Parameters.AddWithValue("@Cargo", contact.Cargo);
                miCmd.Parameters.AddWithValue("@Dpto", contact.Dpto);
                miCmd.Parameters.AddWithValue("@Telf", contact.Telf);
                miCmd.Parameters.AddWithValue("@Celular", contact.Celular);
                miCmd.Parameters.AddWithValue("@PagWeb", contact.PagWeb);
                miCmd.Parameters.AddWithValue("@Correo", contact.Correo);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                IDataParameter ReturnValue;
                ReturnValue = miCmd.CreateParameter();
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                miCmd.Parameters.Add(ReturnValue);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToInt32(ReturnValue.Value);
                }
                catch(SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    miCon.Close();
                }
            }
            return result;
        }

        /// <summary>
        /// Procedimiento para Listar los Contacto
        /// </summary>
        /// <returns>Lista Contactos</returns>
        public static List<OContacto> DListarContactos(string @tupla, int @codigo)
        {
            List<OContacto> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarContac", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Tupla", tupla);
                miCmd.Parameters.AddWithValue("@Codigo", codigo);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OContacto>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordContact(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos de los Contactos
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Contactos</returns>
        private static OContacto FillDataRecordContact(IDataRecord miRecord)
        {
            OContacto cont = new OContacto();

            cont.ContactoID = miRecord.GetInt32(miRecord.GetOrdinal("ContactoID"));
            cont.NomContact = miRecord.GetString(miRecord.GetOrdinal("NomContact"));
            cont.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            cont.Cargo = miRecord.GetString(miRecord.GetOrdinal("Cargo"));
            cont.Dpto = miRecord.GetString(miRecord.GetOrdinal("Dpto"));
            cont.Telf = miRecord.GetString(miRecord.GetOrdinal("Telf"));
            cont.Celular = miRecord.GetString(miRecord.GetOrdinal("Celular"));
            cont.PagWeb = miRecord.GetString(miRecord.GetOrdinal("PagWeb"));
            cont.Correo = miRecord.GetString(miRecord.GetOrdinal("Correo"));
            cont.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return cont;
        }
    }
}
