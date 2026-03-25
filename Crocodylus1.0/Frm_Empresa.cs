using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Datos;
using System.IO;

namespace GRTechnology1._0
{
    public partial class Frm_Empresa : Form
    {
        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        OEmpresa Emp = null;

        public Frm_Empresa(string opcion)
        {
            InitializeComponent();

            Opcion = opcion;
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
        }

        private void CargarEmpresa()
        {
            try
            {
                Emp = DEmpresa.DListarEmpresa();

                if(Emp != null)
                {
                    txtEmpID.Text = Emp.EmpresaID.ToString();
                    CodInmode = Emp.CodInmode;
                    txtNomEmp.Text = Emp.NomEmp;
                    txtGiro.Text = Emp.Giro;
                    txtNIT.Text = Emp.NIT;
                    txtPagWeb.Text = Emp.PagWeb;
                    txtCorreo.Text = Emp.Email;
                    txtRegEmp.Text = Emp.RegEmp;
                    txtPagWeb.Text = Emp.PagWeb;

                    txtCodActiv.Text = Emp.CodActividad;
                    txtCodEmpCNS.Text = Emp.CodEmpleadorCNS;
                    txtCodEmpMT.Text = Emp.CodEmpleadorMT;
                    txtCodEmpAFP.Text = Emp.CodEmpleadorAFP;

                    txtRepLegal.Text = Emp.NomRepresentLegal;
                    txtNITRepLegal.Text = Emp.NITRepresentLegal;

                    //Cargamos el Logo
                    MemoryStream m_MemoryStream = new MemoryStream(Emp.Logo);
                    pbxImagen.Image = Image.FromStream(m_MemoryStream);
                    pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch
            { }
        }

        private void InsertModifEmpresa()
        {
            string DetalleInmode = string.Empty;
            try
            {
                //Objeto Empresa
                OEmpresa emp = new OEmpresa();
                emp.EmpresaID = Convert.ToInt32(txtEmpID.Text);
                emp.NomEmp = txtNomEmp.Text;
                emp.NIT = txtNIT.Text;
                emp.Giro = txtGiro.Text;
                emp.PagWeb = txtPagWeb.Text;
                emp.Email = txtCorreo.Text;
                emp.RegEmp = txtRegEmp.Text;
                emp.CodActividad = txtCodActiv.Text;
                emp.CodEmpleadorMT = txtCodEmpMT.Text;
                emp.CodEmpleadorCNS = txtCodEmpCNS.Text;
                emp.CodEmpleadorAFP = txtCodEmpAFP.Text;
                emp.NomRepresentLegal = txtRepLegal.Text;
                emp.NITRepresentLegal = txtNITRepLegal.Text;

                //Guardamos la Imagen
                if (pbxImagen.Image != null)
                {
                    MemoryStream m_MemoryStream = new MemoryStream();
                    pbxImagen.Image.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    emp.Logo = m_MemoryStream.ToArray();
                }                

                //Detalle de la modificacion
                Frm_DetaModifAnul mod = new Frm_DetaModifAnul("Modificar");
                mod.Owner = this;
                mod.ShowDialog();
                DetalleInmode = mod.DetaModAnul();

                //Guardamos los datos
                int respuesta = DEmpresa.DModifEmpresa(emp, OInmode.DTInmode("", "MODIFICAR", DetalleInmode));
                if (respuesta > 0)
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("ERROR AL GUARDAR, CONSULTE CON EL ADMINISTRADOR DEL SISTEMA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cerrar()
        {
        }

        private void CargarImg()
        {
            openFileDialog.Title = "Seleccionar una Imagen";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                System.Drawing.Bitmap bm = new System.Drawing.Bitmap(openFileDialog.FileName);
                
                pbxImagen.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                //NomImg = openFileDialog.SafeFileName;

                //txtNomImg.Text = openFileDialog.SafeFileName;
                //}
                //else
                //{
                //    MessageBox.Show("Solo se aceptan imagenes de 800x600 px, tiene que redimensionar la imagen", "redimensionar imagen",
                //            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
            }
        }

        private void BorrarImg()
        {
            pbxImagen.Image = null;
        }

        private void CargarInmode()
        {
            if(txtEmpID.Text != string.Empty)
            {
                Frm_Inmode inmode = new Frm_Inmode(CodInmode);
                inmode.Owner = this;
                inmode.ShowDialog();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifEmpresa();
        }

        private void Empresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cerrar();
        }

        private void lblImg_Click(object sender, EventArgs e)
        {
            CargarImg();
        }

        private void lblBorrarImg_Click(object sender, EventArgs e)
        {
            BorrarImg();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            CargarInmode();
        }
    }
}
