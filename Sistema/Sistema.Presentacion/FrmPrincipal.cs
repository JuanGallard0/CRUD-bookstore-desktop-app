using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            StBarraInferior.Text = "Usuario: " + this.Nombre;
            MessageBox.Show("Bienvenido: " + this.Nombre, "Sistema de Librería", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.Rol.Equals("administrador"))
            {
                TsLibros.Visible = true;
                TsLibros.Enabled = true;
                TsVentas.Visible = true;
                TsVentas.Enabled = true;
                BtnConsulta.Visible = true;
                BtnConsulta.Enabled = true;
                DDBtnReportes.Visible = true;
                DDBtnReportes.Enabled = true;
            }
            else
            {
                TsLibros.Visible = false;
                TsLibros.Enabled = false;
                TsVentas.Visible = false;
                TsVentas.Enabled = false;
                BtnConsulta.Visible = true;
                BtnConsulta.Enabled = true;
                DDBtnReportes.Visible = false;
                DDBtnReportes.Enabled = false;
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TsCompras_Click(object sender, EventArgs e)
        {
            FrmLibro frm = new FrmLibro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TsVentas_Click(object sender, EventArgs e)
        {
            FrmPrestamo frm = new FrmPrestamo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta frm = new FrmConsulta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteLibros frm = new FrmReporteLibros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePrestamos frm = new FrmReportePrestamos();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
