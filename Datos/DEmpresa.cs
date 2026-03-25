using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

using Objetos;
using Datos;

namespace Datos
{
    public static class DEmpresa
    {
        /// <summary>
        /// procedimiento para Listar datos de la Empresa
        /// </summary>
        /// <returns>Objeto Empresa</returns>
        public static OEmpresa DListarEmpresa()
        {
            OEmpresa Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarEmpresa", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new OEmpresa();

                        if (miLector.Read())
                        {
                            Temp = FillDataRecordEmp(miLector);
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// procedimiento para Modificar los Datos de la Empresa
        /// </summary>
        /// <returns>Modificar Empresa</returns>
        /// 
        public static int DModifEmpresa(OEmpresa emp, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifEmpresa", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@EmpresaID", emp.EmpresaID);
                miCmd.Parameters.AddWithValue("@NomEmp", emp.NomEmp);
                miCmd.Parameters.AddWithValue("@NIT", emp.NIT);
                miCmd.Parameters.AddWithValue("@Giro", emp.Giro);
                miCmd.Parameters.AddWithValue("@PagWeb", emp.PagWeb);
                miCmd.Parameters.AddWithValue("@Email", emp.Email);
                miCmd.Parameters.AddWithValue("@RegEmp", emp.RegEmp);
                miCmd.Parameters.AddWithValue("@CodActividad", emp.CodActividad);
                miCmd.Parameters.AddWithValue("@CodEmpleadorMT", emp.CodEmpleadorMT);
                miCmd.Parameters.AddWithValue("@CodEmpleadorCNS", emp.CodEmpleadorCNS);
                miCmd.Parameters.AddWithValue("@CodEmpleadorAFP", emp.CodEmpleadorAFP);
                miCmd.Parameters.AddWithValue("@NomRepresentLegal", emp.NomRepresentLegal);
                miCmd.Parameters.AddWithValue("@NITRepresentLegal", emp.NITRepresentLegal);
                miCmd.Parameters.AddWithValue("@Logo", emp.Logo);
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
        /// Cargamos datos de lo Empresa
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Empresa</returns>
        private static OEmpresa FillDataRecordEmp(IDataRecord miRecord)
        {
            OEmpresa emp = new OEmpresa();

            emp.EmpresaID = miRecord.GetInt32(miRecord.GetOrdinal("EmpresaID"));
            emp.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            emp.NomEmp = miRecord.GetString(miRecord.GetOrdinal("NomEmp"));
            emp.NIT = miRecord.GetString(miRecord.GetOrdinal("NIT"));
            emp.Giro = miRecord.GetString(miRecord.GetOrdinal("Giro"));
            emp.CodActividad = miRecord.GetString(miRecord.GetOrdinal("CodActividad"));
            emp.CodEmpleadorMT = miRecord.GetString(miRecord.GetOrdinal("CodEmpleadorMT"));
            emp.CodEmpleadorCNS = miRecord.GetString(miRecord.GetOrdinal("CodEmpleadorCNS"));
            emp.CodEmpleadorAFP = miRecord.GetString(miRecord.GetOrdinal("CodEmpleadorAFP"));
            emp.PagWeb = miRecord.GetString(miRecord.GetOrdinal("PagWeb"));
            emp.Email = miRecord.GetString(miRecord.GetOrdinal("Email"));
            emp.NomRepresentLegal = miRecord.GetString(miRecord.GetOrdinal("NomRepresentLegal"));
            emp.NITRepresentLegal = miRecord.GetString(miRecord.GetOrdinal("NITRepresentLegal"));
            emp.RegEmp = miRecord.GetString(miRecord.GetOrdinal("RegEmp"));
            emp.CodLogo = miRecord.GetString(miRecord.GetOrdinal("CodLogo"));

            try
            {
                emp.Logo = (byte[])miRecord["Img"];
            }
            catch (Exception)
            {    }
                

            return emp;
        }
    }
}
