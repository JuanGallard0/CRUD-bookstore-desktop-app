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
    public partial class FrmReporteLibros : Form
    {
        public FrmReporteLibros()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSistema.libro_listar' table. You can move, or remove it, as needed.
            this.libro_listarTableAdapter.Fill(this.dsSistema.libro_listar);
            this.reportViewer1.RefreshReport();
        }
    }
}
