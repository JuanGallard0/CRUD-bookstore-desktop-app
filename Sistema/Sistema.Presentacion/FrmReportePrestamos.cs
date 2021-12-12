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
    public partial class FrmReportePrestamos : Form
    {
        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

        private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSistema.prestamo_listar' table. You can move, or remove it, as needed.
            this.prestamo_listarTableAdapter.Fill(this.dsSistema.prestamo_listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
