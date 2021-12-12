
namespace Sistema.Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StBarraInferior = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TsLibros = new System.Windows.Forms.ToolStripButton();
            this.TsVentas = new System.Windows.Forms.ToolStripButton();
            this.BtnConsulta = new System.Windows.Forms.ToolStripButton();
            this.DDBtnReportes = new System.Windows.Forms.ToolStripDropDownButton();
            this.reporteDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsLibros,
            this.TsVentas,
            this.BtnConsulta,
            this.DDBtnReportes});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StBarraInferior});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // StBarraInferior
            // 
            this.StBarraInferior.Name = "StBarraInferior";
            this.StBarraInferior.Size = new System.Drawing.Size(164, 17);
            this.StBarraInferior.Text = "Desarrollado por Carlos López";
            // 
            // TsLibros
            // 
            this.TsLibros.BackColor = System.Drawing.SystemColors.Control;
            this.TsLibros.Image = global::Sistema.Presentacion.Properties.Resources.books;
            this.TsLibros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsLibros.Name = "TsLibros";
            this.TsLibros.Size = new System.Drawing.Size(59, 22);
            this.TsLibros.Text = "Libros";
            this.TsLibros.Click += new System.EventHandler(this.TsCompras_Click);
            // 
            // TsVentas
            // 
            this.TsVentas.Image = global::Sistema.Presentacion.Properties.Resources.lend;
            this.TsVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsVentas.Name = "TsVentas";
            this.TsVentas.Size = new System.Drawing.Size(77, 22);
            this.TsVentas.Text = "Prestamo";
            this.TsVentas.Click += new System.EventHandler(this.TsVentas_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Image = global::Sistema.Presentacion.Properties.Resources.consulta;
            this.BtnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(110, 22);
            this.BtnConsulta.Text = "Consultar libros";
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // DDBtnReportes
            // 
            this.DDBtnReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeLibrosToolStripMenuItem,
            this.reporteDePrestamosToolStripMenuItem});
            this.DDBtnReportes.Image = global::Sistema.Presentacion.Properties.Resources.report;
            this.DDBtnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DDBtnReportes.Name = "DDBtnReportes";
            this.DDBtnReportes.Size = new System.Drawing.Size(82, 22);
            this.DDBtnReportes.Text = "Reportes";
            // 
            // reporteDeLibrosToolStripMenuItem
            // 
            this.reporteDeLibrosToolStripMenuItem.Name = "reporteDeLibrosToolStripMenuItem";
            this.reporteDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reporteDeLibrosToolStripMenuItem.Text = "Reporte de libros";
            this.reporteDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeLibrosToolStripMenuItem_Click);
            // 
            // reporteDePrestamosToolStripMenuItem
            // 
            this.reporteDePrestamosToolStripMenuItem.Name = "reporteDePrestamosToolStripMenuItem";
            this.reporteDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reporteDePrestamosToolStripMenuItem.Text = "Reporte de prestamos";
            this.reporteDePrestamosToolStripMenuItem.Click += new System.EventHandler(this.reporteDePrestamosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Gestión de librería";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StBarraInferior;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton TsLibros;
        private System.Windows.Forms.ToolStripButton TsVentas;
        private System.Windows.Forms.ToolStripButton BtnConsulta;
        private System.Windows.Forms.ToolStripDropDownButton DDBtnReportes;
        private System.Windows.Forms.ToolStripMenuItem reporteDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDePrestamosToolStripMenuItem;
    }
}



