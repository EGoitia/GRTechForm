using System;
using System.Data;
using System.Windows.Forms;
using Objetos;
using Datos;
using System.IO;
using System.Drawing;

namespace GRTechnology1._0
{
    public partial class Frm_Producto : Form
    {
        OpcionFormularios op = new OpcionFormularios();
        public static Frm_Producto pr = null;
        public int ProductoID = -1;

        private byte[] Imagen;

        public Frm_Producto()
        {
            InitializeComponent();
        }

        private void ExaminarImg()
        {
            try
            {
                openFileDialog.Title = "Seleccione un Documento";
                openFileDialog.FileName = "";
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp|" +
                                 "JPG (*.jpg)|*.jpg|" +
                                 "JPEG (*.jpeg)|*.jpeg|" +
                                 "PNG (*.png)|*.png|" +
                                 "BMP (*.bmp)|*.bmp|" +
                                 "Todos los archivos (*.*)|*.*";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    string ext = Path.GetExtension(openFileDialog.FileName).ToLower();

                    if (ext != ".jpg" && ext != ".jpeg" && ext != ".png" && ext != ".bmp")
                    {
                        MessageBox.Show("Formato no permitido");
                        return;
                    }

                    // Validar tamaño
                    FileInfo fi = new FileInfo(openFileDialog.FileName);
                    if (fi.Length > 5 * 1024 * 1024)
                    {
                        MessageBox.Show("Imagen demasiado grande (máx 5MB)");
                        return;
                    }

                    // Validar contenido real
                    try
                    {
                        using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        using (var img = Image.FromStream(fs))
                        {
                            pbxImagen.BackgroundImage = new Bitmap(img);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Archivo inválido o corrupto");
                    }

                    //pbxImagen.BackgroundImage = new System.Drawing.Bitmap(openFileDialog.FileName);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbxImagen.BackgroundImage = Properties.Resources.sinimagen;
            }
        }

        private bool Verificar()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                txtNom.Focus();
                MessageBox.Show("INGRESE EL NOMBRE DEL PRODUCTO", "NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboRubro.SelectedValue.ToString() == "-1")
            {
                cboRubro.Focus();
                MessageBox.Show("SELECCIONE UN GRUPO", "GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboSubRubro.SelectedValue.ToString() == "-1")
            {
                cboSubRubro.Focus();
                MessageBox.Show("SELECCIONE UN SUBGRUPO", "SUBGRUPO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboMarca.SelectedValue.ToString() == "-1" &&
                DConstantes.Clasificacion.Combo != (int)cboTipoClasific.SelectedValue &&
                DConstantes.Clasificacion.Servicio != (int)cboTipoClasific.SelectedValue)
            {
                cboMarca.Focus();
                MessageBox.Show("SELECCIONE UNA MARCA", "MARCA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboTipoClasific.SelectedValue.ToString() == "-1")
            {
                cboTipoClasific.Focus();
                MessageBox.Show("SELECCIONE UNA CLASIFICACIÓN", "CLASIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (NUpDwnPrecVentMenor.Value < NUpDwnPrecCosto.Value)
            {
                NUpDwnPrecVentMenor.Focus();
                MessageBox.Show("EL PRECIO DE VENTA POR MENOR NO PUEDE SER MENOR AL PRECIO DE COSTO", "PRECIO VENTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (NUpDwnPrecVentaMayor.Value < NUpDwnPrecCosto.Value)
            {
                NUpDwnPrecVentMenor.Focus();
                MessageBox.Show("EL PRECIO DE VENTA POR MAYOR NO PUEDE SER MENOR AL PRECIO DE COSTO", "PRECIO VENTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void Listar_Rubro()
        {
            try
            {
                cboRubro.DataSource = DListarPersonalizado.ConsultarDT("SELECT RubroSubrubroID, NomRubroSubrubro FROM RubroSubRubro WHERE Tipo='Rubro' AND Estado=1 UNION SELECT -1, '[SELECCIONE UN RUBRO]' ORDER BY NomRubroSubrubro");
                cboRubro.DisplayMember = "NomRubroSubrubro";
                cboRubro.ValueMember = "RubroSubrubroID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Subrubro()
        {
            try
            {
                cboSubRubro.DataSource = DListarPersonalizado.ConsultarDT("SELECT RubroSubrubroID, NomRubroSubrubro FROM RubroSubRubro WHERE Tipo='SubRubro' AND Estado=1  UNION SELECT -1, '[SELECCIONE UN SUBRUBRO]' ORDER BY NomRubroSubrubro");
                cboSubRubro.DisplayMember = "NomRubroSubrubro";
                cboSubRubro.ValueMember = "RubroSubrubroID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Marca()
        {
            try
            {
                cboMarca.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo WHERE Tupla='Marca' AND Estado=1 UNION SELECT -1, '[SELECCIONE UNA MARCA]' ORDER BY NomTipo");
                cboMarca.DisplayMember = "NomTipo";
                cboMarca.ValueMember = "TipoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Tipo_Unidad()
        {
            try
            {
                cboUnidMed.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoUnidadID, Nombre FROM Tipo_Unidad WHERE Estado=1 ORDER BY Nombre");
                cboUnidMed.DisplayMember = "Nombre";
                cboUnidMed.ValueMember = "TipoUnidadID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Clasific()
        {
            try
            {
                cboTipoClasific.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Tupla='CLASIFICACION' AND Estado=1 ORDER BY NomTipo");
                cboTipoClasific.DisplayMember = "NomTipo";
                cboTipoClasific.ValueMember = "TipoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Producto()
        {
            DataTable ProdDT = DListarPersonalizado.ConsultarDT("SELECT * FROM Producto WHERE ProductoID=" + ProductoID.ToString());
            if (ProdDT.Rows.Count > 0)
            {
                txtProdID.Text = ProductoID.ToString();
                txtCodFab.Text = ProdDT.Rows[0]["CodFabrica"].ToString();
                txtSKU.Text = ProdDT.Rows[0]["SKU"].ToString();
                txtNom.Text = ProdDT.Rows[0]["NomProd"].ToString();
                cboRubro.SelectedValue = ProdDT.Rows[0]["RubroID"].ToString();
                cboSubRubro.SelectedValue = ProdDT.Rows[0]["SubRubroID"].ToString();
                cboMarca.SelectedValue = ProdDT.Rows[0]["MarcaID"].ToString();
                cboUnidMed.Text = ProdDT.Rows[0]["UnidMedida"].ToString();
                cboTipoClasific.SelectedValue = ProdDT.Rows[0]["ClasificacionID"].ToString();
                txtDesc.Text = ProdDT.Rows[0]["Descripcion"].ToString();

                chkComodin.Checked = Convert.ToBoolean(ProdDT.Rows[0]["Comodin"]);
                chkConSerial.Checked = Convert.ToBoolean(ProdDT.Rows[0]["serial"]);
                chkModifPrec.Checked = Convert.ToBoolean(ProdDT.Rows[0]["ModifPrec"]);
                chkVencimiento.Checked = Convert.ToBoolean(ProdDT.Rows[0]["Vencimiento"]);

                NUpDwnStockMax.Value = Convert.ToDecimal(ProdDT.Rows[0]["StockMax"]);
                NUpDwnStockMin.Value = Convert.ToDecimal(ProdDT.Rows[0]["StockMin"]);
                NUpDwnPedMin.Value = Convert.ToDecimal(ProdDT.Rows[0]["PedidMin"]);

                NUpDwnPrecCosto.Enabled = false;
                NUpDwnPrecCosto.Value = Convert.ToDecimal(ProdDT.Rows[0]["PCostoEmp"]);
                NUpDwnPrecVentMenor.Value = Convert.ToDecimal(ProdDT.Rows[0]["PVentaMenorEmp"]);
                NUpDwnPrecVentaMayor.Value = Convert.ToDecimal(ProdDT.Rows[0]["PVentaMayorEmp"]);

                DataTable ImgDT = DListarPersonalizado.ConsultarDT("SELECT * FROM Imagen WHERE CodImagen='" + ProdDT.Rows[0]["CodImagen"] + "'" +
                                                                   "AND Principal=1");
                if (ImgDT.Rows.Count > 0 && ImgDT.Rows[0]["Img"] != DBNull.Value)
                {
                    try
                    {
                        byte[] imgBytes = (byte[])ImgDT.Rows[0]["Img"];

                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        using (Image img = Image.FromStream(ms))
                        {
                            pbxImagen.BackgroundImage = new Bitmap(img); // desacoplado del stream
                        }
                    }
                    catch (Exception)
                    {
                        pbxImagen.BackgroundImage = Properties.Resources.sinimagen;
                    }
                }
                else
                {
                    pbxImagen.BackgroundImage = Properties.Resources.sinimagen; // imagen por defecto
                }
            }
        }

        private void InsertModifProducto()
        {
            btnGuardar.Enabled = false;
            btnSalir.Enabled = false;

            try
            {
                if (!Verificar())
                    return;

                OProducto prod = new OProducto();
                prod.ProductoID = ProductoID;
                prod.CodFabrica = txtCodFab.Text.Trim();
                prod.SKU = txtSKU.Text.Trim();
                prod.Descripcion = txtDesc.Text.Trim();
                prod.RubroID = (int)cboRubro.SelectedValue;
                prod.SubRubroID = (int)cboSubRubro.SelectedValue;
                prod.MarcaID = (int)cboMarca.SelectedValue;
                prod.ClasificacionID = (int)cboTipoClasific.SelectedValue;
                prod.NomProd = txtNom.Text.Trim();
                prod.PCosto = NUpDwnPrecCosto.Value;
                prod.PedidMin = NUpDwnPedMin.Value;
                prod.Peso = NUpDwnPeso.Value;
                prod.PVentaMayor = NUpDwnPrecVentaMayor.Value;
                prod.PVentaMenor = NUpDwnPrecVentMenor.Value;
                prod.StockMax = NUpDwnStockMax.Value;
                prod.StockMin = NUpDwnStockMin.Value;
                prod.UnidMedida = cboUnidMed.Text;
                prod.ValorComision = NUpDwnValCom.Value;
                prod.ModifPrec = chkModifPrec.Checked;
                prod.Vencimiento = chkVencimiento.Checked;
                prod.Serial = chkConSerial.Checked;
                prod.Comodin = chkComodin.Checked;

                if (pbxImagen.BackgroundImage != null)
                {
                    try
                    {
                        //Cargamos la Imagen
                        MemoryStream m_MemoryStream = new MemoryStream();
                        pbxImagen.BackgroundImage.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Imagen = m_MemoryStream.ToArray();
                        prod.Img = Imagen;
                    }
                    catch (Exception ex)
                    {
                        DialogResult dialogo = MessageBox.Show("ERROR: " + ex.Message + " ; ¿DESEA DE TODAS MANERAS GUARDAR LA INFORMACION DEL PRODUCTO SIN UNA IMAGEN?",
                            "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dialogo == DialogResult.No)
                            return;
                        else
                            prod.Img = null;
                    }
                }

                int resp = DProducto.DInsertarModifProd(prod, OInmode.DTInmode("", (ProductoID == -1 ? "NUEVO" : "MODIFICAR"), ""));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    prod = null;
                    Borrar();

                    if (ProductoID > -1)
                        this.Close();
                }
                else
                    throw new Exception("ERROR AL GUARDAR EL PRODUCTO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnSalir.Enabled = true;
            }
        }

        private void Borrar()
        {
            cboRubro.SelectedValue = -1;
            cboSubRubro.SelectedValue = -1;
            cboMarca.SelectedValue = -1;
            cboTipoClasific.SelectedValue = DConstantes.Clasificacion.Terminados;
            txtCodFab.Clear();
            txtNom.Clear();
            txtDesc.Clear();
            NUpDwnStockMax.Value = NUpDwnStockMax.Minimum;
            NUpDwnCantUnidMed.Value = NUpDwnCantUnidMed.Minimum;
            NUpDwnPedMin.Value = NUpDwnPedMin.Minimum;
            NUpDwnPeso.Value = NUpDwnPeso.Minimum;
            NUpDwnPrecCosto.Value = NUpDwnPrecCosto.Minimum;
            NUpDwnPrecVentaMayor.Value = NUpDwnPrecVentaMayor.Minimum;
            NUpDwnPrecVentMenor.Value = NUpDwnPrecVentMenor.Minimum;
            NUpDwnStockMax.Value = NUpDwnStockMax.Minimum;
            NUpDwnStockMin.Value = NUpDwnStockMin.Minimum;
            NUpDwnValCom.Value = NUpDwnValCom.Minimum;
            pbxImagen.BackgroundImage = Properties.Resources.sinimagen; ;
        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            cboUnidMed.Text = "METRO";
            Listar_Rubro();
            Listar_Subrubro();
            Listar_Marca();
            Listar_Clasific();
            Listar_Tipo_Unidad();

            if (ProductoID > -1)
                Listar_Producto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
                this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifProducto();
        }

        private void Frm_Producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            pr.Dispose();
            pr = null;
        }

        private void btnBusqMarca_Click(object sender, EventArgs e)
        {
            Frm_Tipo marc = new Frm_Tipo("Marca");
            marc.ShowDialog();
            Listar_Marca();
            cboMarca.SelectedValue = marc.ID;
            marc.Dispose();
        }

        private void btnBusqTProd_Click(object sender, EventArgs e)
        {
            Frm_RubroSubRubro rubsubrub = new Frm_RubroSubRubro();
            rubsubrub.ShowDialog();
            Listar_Subrubro();
            rubsubrub.Dispose();
        }

        private void btnBusqProv_Click(object sender, EventArgs e)
        {
            Frm_RubroSubRubro rubsubrub = new Frm_RubroSubRubro();
            rubsubrub.ShowDialog();
            Listar_Rubro();
            rubsubrub.Dispose();
        }

        private void lblImg_Click(object sender, EventArgs e)
        {
            ExaminarImg();
        }

        private void lblBorrarImg_Click(object sender, EventArgs e)
        {
            pbxImagen.BackgroundImage = null;
        }

        private void btnGenCodBarra_Click(object sender, EventArgs e)
        {
            bool existecodigo = true;
            string codean8 = string.Empty;
            while (existecodigo)
            {
                codean8 = GenerarEAN8Aleatorio();
                existecodigo = DProducto.ExisteCodFab(codean8);
            }

            txtCodFab.Text = codean8;
        }

        private string GenerarEAN8Aleatorio()
        {
            Random rnd = new Random();
            string base7 = rnd.Next(1000000, 9999999).ToString(); // genera 7 dígitos
            int suma = 0;

            for (int i = 0; i < 7; i++)
            {
                int digito = int.Parse(base7[i].ToString());
                suma += (i % 2 == 0) ? digito * 3 : digito;
            }

            int dv = (10 - (suma % 10)) % 10;
            return base7 + dv.ToString();
        }
    }
}
