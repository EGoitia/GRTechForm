using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0
{
    public partial class Frm_Dosificacion : Form
    {
        private int ID;

        public Frm_Dosificacion()
        {
            InitializeComponent();
        }

        private void ListarSucursal()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 ORDER BY NomSuc");
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;
                cboSucursal.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS AL CARGAR LAS SUCURSALES", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoDosificacion()
        {
            try
            {
                cboTipoDosific.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Tupla='FACTURA' AND Estado=1 ORDER BY NomTipo");
                cboTipoDosific.DisplayMember = "NomTipo";
                cboTipoDosific.ValueMember = "TipoID";
                cboTipoDosific.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS AL CARGAR LOS TIPOS DE DOSIFICACIÓN", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoActividad()
        {
            try
            {
                cboActividad.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo WHERE Tupla='Actividad' AND Estado=1 ORDER BY NomTipo");
                cboActividad.DisplayMember = "NomTipo";
                cboActividad.ValueMember = "TipoID";
                cboActividad.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS AL CARGAR LOS TIPOS DE DOSIFICACIÓN", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerDosificacion()
        {
            try
            {
                string consulta = "SELECT DosificacionID, Descripcion, Autorizacion, Llave, Fecha_Ini, Fecha_Lim, " +
                    "Leyenda FROM Dosificacion_Factura WHERE Estado=1 AND Eliminado=0";
                consulta += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();
                consulta += " AND ActividadID=" + cboActividad.SelectedValue.ToString();
                consulta += " AND TipoDosificacionID=" + cboTipoDosific.SelectedValue.ToString();

                DataTable dtDosific = DListarPersonalizado.ConsultarDT(consulta);
                if (dtDosific.Rows.Count > 0)
                {
                    string strDosificacion = string.Format("DESCRIPCIÓN: {1}{0}AUTORIZACION: {2}{0}LLAVE: {3}{0}"+
                        "FECHA INICIO: {4}{0}FECHA LIMITE: {5}{0}LEYENDA: {6}", Environment.NewLine, 
                        dtDosific.Rows[0]["Descripcion"].ToString(), dtDosific.Rows[0]["Autorizacion"].ToString(),
                        dtDosific.Rows[0]["Llave"].ToString(), Convert.ToDateTime(dtDosific.Rows[0]["Fecha_Ini"]).ToShortDateString(),
                        Convert.ToDateTime(dtDosific.Rows[0]["Fecha_Lim"]).ToShortDateString(), dtDosific.Rows[0]["Leyenda"].ToString());
                   
                    ID = (int)dtDosific.Rows[0]["DosificacionID"];
                    txtDosificActual.Text = strDosificacion;
                    //    "DESCRIPCIÓN:  " + dtDosific.Rows[0]["Descripcion"].ToString() + "\t" +
                    //    "AUTORIZACION: " + dtDosific.Rows[0]["Autorizacion"].ToString() + "\t" +
                    //    "LLAVE:        " + dtDosific.Rows[0]["Llave"].ToString() + "\t" +
                    //    "AUTORIZACION: " + dtDosific.Rows[0]["Autorizacion"].ToString() + "\t" +
                    //    "FECHA INICIO: " + Convert.ToDateTime(dtDosific.Rows[0]["Fecha_Ini"]).ToShortDateString() + "\t" +
                    //    "FECHA LIMITE: " + Convert.ToDateTime(dtDosific.Rows[0]["Fecha_Lim"]).ToShortDateString() + "\t" +
                    //    "LEYENDA:      " + dtDosific.Rows[0]["Leyenda"].ToString();
                }
                else
                {
                    ID = -1;
                    txtDosificActual.Text = "";
                }                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarDosificacion()
        {
            if (!Verificar())
                return;

            try
            {
                BtnGuardar.Enabled = false;

                ODosificacion dosif = new ODosificacion();
                dosif.DosificacionID = ID;
                dosif.ActividadID = (int)cboActividad.SelectedValue;
                dosif.Autorizacion = txtAutorizacion.Text;
                dosif.Descripcion = txtDescripcion.Text;
                dosif.Fecha_Ini = dtFechaInicio.Value;
                dosif.Fecha_Lim = dtFechaLimite.Value;
                dosif.Leyenda = txtLeyenda.Text;
                dosif.Llave = txtLlave.Text;
                dosif.SucursalID = (int)cboSucursal.SelectedValue;
                dosif.TipoDosificacionID = (int)cboTipoDosific.SelectedValue;

                int resp = DDosificacion.DInsertDosificacion(dosif, OInmode.DTInmode("", "Nuevo", ""));
                if (resp > 0)
                {
                    ID = resp;
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE");
                }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BtnGuardar.Enabled = true;
            }
        }

        private bool Verificar()
        {
            if (string.IsNullOrEmpty(txtAutorizacion.Text))
            {
                txtAutorizacion.Focus();
                MessageBox.Show("AUTORIZACIÓN ES REQUERIDO", "AUTORIZACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.Focus();
                MessageBox.Show("DESCRIPCIÓN ES REQUERIDO", "DESCRIPCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (string.IsNullOrEmpty(txtLeyenda.Text))
            {
                txtLeyenda.Focus();
                MessageBox.Show("LEYENDA ES REQUERIDO", "LEYENDA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (string.IsNullOrEmpty(txtLlave.Text))
            {
                txtLlave.Focus();
                MessageBox.Show("LLAVE ES REQUERIDO", "LLAVE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboSucursal.Text == "")
            {
                cboSucursal.Focus();
                MessageBox.Show("SELECCIONE UNA SUCURSAL VÁLIDA", "SUCURSAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboActividad.Text == "")
            {
                cboActividad.Focus();
                MessageBox.Show("SELECCIONE UNA ACTIVIDAD VÁLIDA", "ACTIVIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboTipoDosific.Text == "")
            {
                cboTipoDosific.Focus();
                MessageBox.Show("SELECCIONE UN TIPO DE DOSIFICACIÓN VÁLIDO", "TIPO DOSIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDosificacion();
        }

        private void Frm_Dosificacion_Load(object sender, EventArgs e)
        {
            ListarSucursal();
            ListarTipoDosificacion();
            ListarTipoActividad();

            ObtenerDosificacion();
        }

        private void cbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ObtenerDosificacion();
        }
    }
}
