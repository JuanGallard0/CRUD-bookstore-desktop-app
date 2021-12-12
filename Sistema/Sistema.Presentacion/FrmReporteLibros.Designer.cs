
namespace Sistema.Presentacion
{
    partial class FrmReporteLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.librolistarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new Sistema.Presentacion.Reportes.DsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libro_listarTableAdapter = new Sistema.Presentacion.Reportes.DsSistemaTableAdapters.libro_listarTableAdapter();
            this.libro_listarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.librolistarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libro_listarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // librolistarBindingSource
            // 
            this.librolistarBindingSource.DataMember = "libro_listar";
            this.librolistarBindingSource.DataSource = this.dsSistema;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsLibro";
            reportDataSource1.Value = this.libro_listarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.RptLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(881, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // libro_listarTableAdapter
            // 
            this.libro_listarTableAdapter.ClearBeforeFill = true;
            // 
            // libro_listarBindingSource
            // 
            this.libro_listarBindingSource.DataMember = "libro_listar";
            this.libro_listarBindingSource.DataSource = this.dsSistema;
            // 
            // FrmReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 486);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteLibros";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librolistarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libro_listarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DsSistema dsSistema;
        private System.Windows.Forms.BindingSource librolistarBindingSource;
        private Reportes.DsSistemaTableAdapters.libro_listarTableAdapter libro_listarTableAdapter;
        private System.Windows.Forms.BindingSource libro_listarBindingSource;
    }
}