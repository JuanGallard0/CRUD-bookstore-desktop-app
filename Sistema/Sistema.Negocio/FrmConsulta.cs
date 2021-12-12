using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Negocio
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NLibro.Listar();
                this.Formato();
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

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NLibro.Buscar(TxtBuscar.Text, 1);
                this.Formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
