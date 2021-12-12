using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;
using System.Drawing.Imaging;
using System.IO;

namespace Sistema.Presentacion
{
    public partial class FrmLibro : Form
    {
        private string ISBNAnt;

        public FrmLibro()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NLibro.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NLibro.Buscar(TxtBuscar.Text, 1);
                this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[7].Visible = false;
            DgvListado.Columns[8].Visible = false;
            DgvListado.Columns[9].Visible = false;
            DgvListado.Columns[10].Visible = false;
            DgvListado.Columns[12].Visible = false;
            DgvListado.Columns[13].Visible = false;
            DgvListado.Columns[14].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[14].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[5].Width = 150;
            DgvListado.Columns[6].Width = 100;
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtTitulo.Clear();
            TxtAutor.Clear();
            TxtId.Clear();
            TxtISBN.Clear();
            TxtEditorial.Clear();
            TxtPais.Clear();
            TxtIdioma.Clear();
            TxtMateria.Clear();
            TxtDescripcion.Clear();
            PanelCodigo.BackgroundImage = null;
            BtnGuardarCodigo.Enabled = true;
            NumYear.Value = 0;
            NumEdicion.Value = 0;
            NumPags.Value = 0;
            NumUbicacion.Value = 0;
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            ChkSeleccionar.Checked = false;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmArtículo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = 0;
                if (TxtISBN.Text == string.Empty || !int.TryParse(TxtISBN.Text, out temp) || TxtISBN.Text.Length > 10) {
                    this.MensajeError("Falta ingresar un código valido (max. 10 dígitos), será remarcado.");
                    ErrorIcono.SetError(TxtISBN, "Ingrese un código válido");
                }
                else
                {
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    Codigo.IncludeLabel = true;
                    PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, TxtISBN.Text, Color.Black, Color.White, 400, 100);
                    BtnGuardarCodigo.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
    }

        private void BtnGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)PanelCodigo.BackgroundImage.Clone();

            SaveFileDialog DiaologoGuardar = new SaveFileDialog();
            DiaologoGuardar.AddExtension = true;
            DiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
            DiaologoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(DiaologoGuardar.FileName))
            {
                imgFinal.Save(DiaologoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtTitulo.Text == string.Empty || TxtAutor.Text == string.Empty || TxtISBN.Text ==string.Empty || TxtEditorial.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtTitulo,"Ingrese un título.");
                    ErrorIcono.SetError(TxtAutor, "Ingrese un autor.");
                    ErrorIcono.SetError(TxtISBN, "Ingrese un ISBN.");
                    ErrorIcono.SetError(TxtEditorial, "Ingrese un editorial.");
                }
                else
                {
                    Rpta = NLibro.Insertar(1, TxtISBN.Text.Trim(), TxtTitulo.Text.Trim(), TxtAutor.Text.Trim(),
                        TxtEditorial.Text.Trim(), (int)NumYear.Value, (int)NumEdicion.Value, TxtPais.Text.Trim(), 
                        TxtIdioma.Text.Trim(), TxtMateria.Text.Trim(), (int)NumPags.Value,
                        (int)NumUbicacion.Value, TxtDescripcion.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Codigo"].Value);
                TxtTitulo.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Titulo"].Value);
                TxtAutor.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Autor"].Value);
                TxtISBN.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ISBN"].Value);
                ISBNAnt = Convert.ToString(DgvListado.CurrentRow.Cells["ISBN"].Value);
                TxtEditorial.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Editorial"].Value);
                NumYear.Value = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Year_Edicion"].Value);
                NumEdicion.Value = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Numero_Edicion"].Value);
                TxtPais.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Pais"].Value);
                TxtIdioma.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Idioma"].Value);
                TxtMateria.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Materia"].Value);
                TxtDescripcion.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Descripcion"].Value);
                
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtTitulo.Text == string.Empty || TxtAutor.Text == string.Empty || TxtISBN.Text ==string.Empty || TxtEditorial.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtTitulo,"Ingrese un título.");
                    ErrorIcono.SetError(TxtAutor, "Ingrese un autor.");
                    ErrorIcono.SetError(TxtISBN, "Ingrese un ISBN.");
                    ErrorIcono.SetError(TxtEditorial, "Ingrese un editorial.");
                }
                else
                {
                    Rpta = NLibro.Actualizar(Convert.ToInt32(TxtId.Text.Trim()), 1, TxtISBN.Text.Trim(), ISBNAnt, TxtTitulo.Text.Trim(), TxtAutor.Text.Trim(),
                        TxtEditorial.Text.Trim(), (int)NumYear.Value, (int)NumEdicion.Value, TxtPais.Text.Trim(), 
                        TxtIdioma.Text.Trim(), TxtMateria.Text.Trim(), (int)NumPags.Value,
                        (int)NumUbicacion.Value, TxtDescripcion.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NLibro.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[4].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas desactivar el(los) registro(s)?", "Gestión de librería", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NLibro.Desactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivó el registro: " + Convert.ToString(row.Cells[4].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas desactivar el(los) registro(s)?", "Sistema de libros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NLibro.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activó el registro: " + Convert.ToString(row.Cells[4].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
