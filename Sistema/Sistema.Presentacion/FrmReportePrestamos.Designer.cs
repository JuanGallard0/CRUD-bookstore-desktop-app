
namespace Sistema.Presentacion
{
    partial class FrmReportePrestamos
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
            this.prestamolistarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new Sistema.Presentacion.Reportes.DsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prestamo_listarTableAdapter = new Sistema.Presentacion.Reportes.DsSistemaTableAdapters.prestamo_listarTableAdapter();
            this.prestamolistarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamolistarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamo_listarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prestamolistarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamolistarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamolistarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamo_listarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamolistarBindingSource
            // 
            this.prestamolistarBindingSource.DataMember = "prestamo_listar";
            this.prestamolistarBindingSource.DataSource = this.dsSistema;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsPrestamo";
            reportDataSource1.Value = this.prestamo_listarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema.Presentacion.Reportes.RptPrestamos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(833, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // prestamo_listarTableAdapter
            // 
            this.prestamo_listarTableAdapter.ClearBeforeFill = true;
            // 
            // prestamolistarBindingSource1
            // 
            this.prestamolistarBindingSource1.DataMember = "prestamo_listar";
            this.prestamolistarBindingSource1.DataSource = this.dsSistema;
            // 
            // prestamolistarBindingSource2
            // 
            this.prestamolistarBindingSource2.DataMember = "prestamo_listar";
            this.prestamolistarBindingSource2.DataSource = this.dsSistema;
            // 
            // prestamo_listarBindingSource
            // 
            this.prestamo_listarBindingSource.DataMember = "prestamo_listar";
            this.prestamo_listarBindingSource.DataSource = this.dsSistema;
            // 
            // FrmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 474);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePrestamos";
            this.Text = "FrmReportePrestamos";
            this.Load += new System.EventHandler(this.FrmReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamolistarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamolistarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamolistarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamo_listarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DsSistema dsSistema;
        private System.Windows.Forms.BindingSource prestamolistarBindingSource;
        private Reportes.DsSistemaTableAdapters.prestamo_listarTableAdapter prestamo_listarTableAdapter;
        private System.Windows.Forms.BindingSource prestamolistarBindingSource1;
        private System.Windows.Forms.BindingSource prestamolistarBindingSource2;
        private System.Windows.Forms.BindingSource prestamo_listarBindingSource;
    }
}