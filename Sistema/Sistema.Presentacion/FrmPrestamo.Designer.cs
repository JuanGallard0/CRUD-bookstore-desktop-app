
namespace Sistema.Presentacion
{
    partial class FrmPrestamo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrestar = new System.Windows.Forms.Button();
            this.DTFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DvgPrestamos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DvgProfesores = new System.Windows.Forms.DataGridView();
            this.TxtBuscarProfesor = new System.Windows.Forms.Button();
            this.TxtProfesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.BtnBuscarLibro = new System.Windows.Forms.Button();
            this.Txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DvgProfesores2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DvgPrestamos2 = new System.Windows.Forms.DataGridView();
            this.BtnDevolver = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgProfesores)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgProfesores2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgPrestamos2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BtnPrestar);
            this.tabPage1.Controls.Add(this.DTFechaDevolucion);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(953, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prestamo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha de devolución:";
            // 
            // BtnPrestar
            // 
            this.BtnPrestar.Location = new System.Drawing.Point(642, 360);
            this.BtnPrestar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrestar.Name = "BtnPrestar";
            this.BtnPrestar.Size = new System.Drawing.Size(197, 60);
            this.BtnPrestar.TabIndex = 13;
            this.BtnPrestar.Text = "Prestar";
            this.BtnPrestar.UseVisualStyleBackColor = true;
            this.BtnPrestar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // DTFechaDevolucion
            // 
            this.DTFechaDevolucion.Location = new System.Drawing.Point(639, 306);
            this.DTFechaDevolucion.Name = "DTFechaDevolucion";
            this.DTFechaDevolucion.Size = new System.Drawing.Size(200, 20);
            this.DTFechaDevolucion.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DvgPrestamos);
            this.groupBox3.Location = new System.Drawing.Point(5, 244);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(562, 216);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prestamos activos del profesor";
            // 
            // DvgPrestamos
            // 
            this.DvgPrestamos.AllowUserToAddRows = false;
            this.DvgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgPrestamos.Location = new System.Drawing.Point(19, 30);
            this.DvgPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.DvgPrestamos.Name = "DvgPrestamos";
            this.DvgPrestamos.RowTemplate.Height = 24;
            this.DvgPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgPrestamos.Size = new System.Drawing.Size(525, 168);
            this.DvgPrestamos.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DvgProfesores);
            this.groupBox1.Controls.Add(this.TxtBuscarProfesor);
            this.groupBox1.Controls.Add(this.TxtProfesor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(507, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(441, 235);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesores";
            // 
            // DvgProfesores
            // 
            this.DvgProfesores.AllowUserToAddRows = false;
            this.DvgProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgProfesores.Location = new System.Drawing.Point(19, 57);
            this.DvgProfesores.Margin = new System.Windows.Forms.Padding(2);
            this.DvgProfesores.Name = "DvgProfesores";
            this.DvgProfesores.RowTemplate.Height = 24;
            this.DvgProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgProfesores.Size = new System.Drawing.Size(403, 161);
            this.DvgProfesores.TabIndex = 3;
            this.DvgProfesores.Click += new System.EventHandler(this.DvgProfesores_Click);
            // 
            // TxtBuscarProfesor
            // 
            this.TxtBuscarProfesor.Location = new System.Drawing.Point(336, 24);
            this.TxtBuscarProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBuscarProfesor.Name = "TxtBuscarProfesor";
            this.TxtBuscarProfesor.Size = new System.Drawing.Size(88, 22);
            this.TxtBuscarProfesor.TabIndex = 2;
            this.TxtBuscarProfesor.Text = "Ver";
            this.TxtBuscarProfesor.UseVisualStyleBackColor = true;
            // 
            // TxtProfesor
            // 
            this.TxtProfesor.Location = new System.Drawing.Point(105, 25);
            this.TxtProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProfesor.Name = "TxtProfesor";
            this.TxtProfesor.Size = new System.Drawing.Size(227, 20);
            this.TxtProfesor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvLibros);
            this.groupBox2.Controls.Add(this.BtnBuscarLibro);
            this.groupBox2.Controls.Add(this.Txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(498, 235);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libros disponibles";
            // 
            // DgvLibros
            // 
            this.DgvLibros.AllowUserToAddRows = false;
            this.DgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibros.Location = new System.Drawing.Point(19, 57);
            this.DgvLibros.Margin = new System.Windows.Forms.Padding(2);
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.RowTemplate.Height = 24;
            this.DgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLibros.Size = new System.Drawing.Size(464, 161);
            this.DgvLibros.TabIndex = 3;
            // 
            // BtnBuscarLibro
            // 
            this.BtnBuscarLibro.Location = new System.Drawing.Point(388, 24);
            this.BtnBuscarLibro.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarLibro.Name = "BtnBuscarLibro";
            this.BtnBuscarLibro.Size = new System.Drawing.Size(95, 22);
            this.BtnBuscarLibro.TabIndex = 2;
            this.BtnBuscarLibro.Text = "Buscar";
            this.BtnBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // Txt
            // 
            this.Txt.Location = new System.Drawing.Point(105, 25);
            this.Txt.Margin = new System.Windows.Forms.Padding(2);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(279, 20);
            this.Txt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Libro";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnDevolver);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(953, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devolución";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DvgProfesores2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(5, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(441, 235);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profesores";
            // 
            // DvgProfesores2
            // 
            this.DvgProfesores2.AllowUserToAddRows = false;
            this.DvgProfesores2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgProfesores2.Location = new System.Drawing.Point(19, 57);
            this.DvgProfesores2.Margin = new System.Windows.Forms.Padding(2);
            this.DvgProfesores2.Name = "DvgProfesores2";
            this.DvgProfesores2.RowTemplate.Height = 24;
            this.DvgProfesores2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgProfesores2.Size = new System.Drawing.Size(403, 161);
            this.DvgProfesores2.TabIndex = 3;
            this.DvgProfesores2.Click += new System.EventHandler(this.DvgProfesores2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Profesor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DvgPrestamos2);
            this.groupBox5.Location = new System.Drawing.Point(5, 244);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(562, 216);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prestamos activos del profesor";
            // 
            // DvgPrestamos2
            // 
            this.DvgPrestamos2.AllowUserToAddRows = false;
            this.DvgPrestamos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgPrestamos2.Location = new System.Drawing.Point(19, 30);
            this.DvgPrestamos2.Margin = new System.Windows.Forms.Padding(2);
            this.DvgPrestamos2.Name = "DvgPrestamos2";
            this.DvgPrestamos2.RowTemplate.Height = 24;
            this.DvgPrestamos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgPrestamos2.Size = new System.Drawing.Size(525, 168);
            this.DvgPrestamos2.TabIndex = 3;
            // 
            // BtnDevolver
            // 
            this.BtnDevolver.Location = new System.Drawing.Point(672, 180);
            this.BtnDevolver.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDevolver.Name = "BtnDevolver";
            this.BtnDevolver.Size = new System.Drawing.Size(197, 60);
            this.BtnDevolver.TabIndex = 14;
            this.BtnDevolver.Text = "Devolver";
            this.BtnDevolver.UseVisualStyleBackColor = true;
            this.BtnDevolver.Click += new System.EventHandler(this.BtnDevolver_Click);
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPrestamo";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DvgPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgProfesores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgProfesores2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DvgPrestamos2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DvgProfesores;
        private System.Windows.Forms.Button TxtBuscarProfesor;
        private System.Windows.Forms.TextBox TxtProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.Button BtnBuscarLibro;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTFechaDevolucion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DvgPrestamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPrestar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DvgPrestamos2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DvgProfesores2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDevolver;
    }
}