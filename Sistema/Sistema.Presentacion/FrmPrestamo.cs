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
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvLibros.DataSource = NLibro.ListarDisponible();
                DvgProfesores.DataSource = NUsuario.ListarProfesores();
                DvgProfesores2.DataSource = NUsuario.ListarProfesores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvLibros.Columns[0].Visible = false;
            DgvLibros.Columns[1].Visible = false;
            for (int i = 5; i < 15; i++)
            {
                DgvLibros.Columns[i].Visible = false;
            }

            DvgProfesores.Columns[1].Visible = false;
            DvgProfesores.Columns[2].Visible = false;
            for (int i = 4; i < 8; i++)
            {
                DvgProfesores.Columns[i].Visible = false;
            }
            DvgProfesores.Columns[9].Visible = false;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.Formato();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                {
                    Rpta = NPrestamo.Insertar(Convert.ToInt32(DvgProfesores.SelectedRows[0].Cells[0].Value),
                        Convert.ToInt32(DgvLibros.SelectedRows[0].Cells[0].Value),
                        DateTime.Now.ToString(), DTFechaDevolucion.Value.ToString());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");
                        this.Listar();
                        DvgPrestamos.DataSource = NPrestamo.Buscar(Convert.ToInt32(DvgProfesores.SelectedRows[0].Cells[0].Value));
                        //DvgPrestamos2.DataSource = NPrestamo.Buscar(Convert.ToInt32(DvgProfesores2.SelectedRows[0].Cells[0].Value));
                    }
                    else
                    {
                        //this.MensajeError(Rpta);
                        this.Listar();
                        DvgPrestamos.DataSource = NPrestamo.Buscar(Convert.ToInt32(DvgProfesores.SelectedRows[0].Cells[0].Value));
                        //DvgPrestamos2.DataSource = NPrestamo.Buscar(Convert.ToInt32(DvgProfesores2.SelectedRows[0].Cells[0].Value));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void DvgProfesores_Click(object sender, EventArgs e)
        {
            DvgPrestamos.DataSource = NPrestamo.Buscar(Convert.ToInt32(DvgProfesores.SelectedRows[0].Cells[0].Value));
        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {
            string Rpta = NPrestamo.Eliminar(Convert.ToInt32(DvgPrestamos2.SelectedRows[0].Cells[0].Value));
            this.Listar();
            DvgPrestamos2.DataSource = NPrestamo.Buscar(Convert.ToInt32(DvgProfesores2.SelectedRows[0].Cells[0].Value));
        }

        private void DvgProfesores2_Click(object sender, EventArgs e)
        {
            DvgPrestamos2.DataSource = NPrestamo.Buscar(Convert.ToInt32(DvgProfesores2.SelectedRows[0].Cells[0].Value));
        }
    }
}
