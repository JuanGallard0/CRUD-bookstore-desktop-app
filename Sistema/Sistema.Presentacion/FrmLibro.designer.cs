namespace Sistema.Presentacion
{
    partial class FrmLibro
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
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NumPags = new System.Windows.Forms.NumericUpDown();
            this.NumUbicacion = new System.Windows.Forms.NumericUpDown();
            this.NumEdicion = new System.Windows.Forms.NumericUpDown();
            this.NumYear = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtIdioma = new System.Windows.Forms.TextBox();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.BtnGuardarCodigo = new System.Windows.Forms.Button();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(14, 26);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(396, 20);
            this.TxtBuscar.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(794, 393);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total:";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(14, 53);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(953, 336);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(2, 2);
            this.TabGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1054, 485);
            this.TabGeneral.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.BtnDesactivar);
            this.tabPage1.Controls.Add(this.BtnActivar);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1046, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(399, 393);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 23);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.Location = new System.Drawing.Point(291, 393);
            this.BtnDesactivar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(94, 23);
            this.BtnDesactivar.TabIndex = 6;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.UseVisualStyleBackColor = true;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnActivar
            // 
            this.BtnActivar.Location = new System.Drawing.Point(183, 393);
            this.BtnActivar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(94, 23);
            this.BtnActivar.TabIndex = 5;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.UseVisualStyleBackColor = true;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(14, 393);
            this.ChkSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(414, 24);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(123, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NumPags);
            this.tabPage2.Controls.Add(this.NumUbicacion);
            this.tabPage2.Controls.Add(this.NumEdicion);
            this.tabPage2.Controls.Add(this.NumYear);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.TxtMateria);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TxtIdioma);
            this.tabPage2.Controls.Add(this.TxtPais);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TxtTitulo);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.PanelCodigo);
            this.tabPage2.Controls.Add(this.BtnGuardarCodigo);
            this.tabPage2.Controls.Add(this.BtnGenerar);
            this.tabPage2.Controls.Add(this.TxtISBN);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TxtEditorial);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtDescripcion);
            this.tabPage2.Controls.Add(this.TxtAutor);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1046, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NumPags
            // 
            this.NumPags.Location = new System.Drawing.Point(781, 260);
            this.NumPags.Name = "NumPags";
            this.NumPags.Size = new System.Drawing.Size(92, 20);
            this.NumPags.TabIndex = 38;
            // 
            // NumUbicacion
            // 
            this.NumUbicacion.Location = new System.Drawing.Point(781, 295);
            this.NumUbicacion.Name = "NumUbicacion";
            this.NumUbicacion.Size = new System.Drawing.Size(92, 20);
            this.NumUbicacion.TabIndex = 37;
            // 
            // NumEdicion
            // 
            this.NumEdicion.Location = new System.Drawing.Point(781, 122);
            this.NumEdicion.Name = "NumEdicion";
            this.NumEdicion.Size = new System.Drawing.Size(92, 20);
            this.NumEdicion.TabIndex = 36;
            // 
            // NumYear
            // 
            this.NumYear.Location = new System.Drawing.Point(781, 87);
            this.NumYear.Name = "NumYear";
            this.NumYear.Size = new System.Drawing.Size(92, 20);
            this.NumYear.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(679, 297);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Ubicación";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(781, 224);
            this.TxtMateria.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(92, 20);
            this.TxtMateria.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(679, 262);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Número de páginas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(679, 227);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Materia";
            // 
            // TxtIdioma
            // 
            this.TxtIdioma.Location = new System.Drawing.Point(781, 188);
            this.TxtIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdioma.Name = "TxtIdioma";
            this.TxtIdioma.Size = new System.Drawing.Size(92, 20);
            this.TxtIdioma.TabIndex = 28;
            // 
            // TxtPais
            // 
            this.TxtPais.Location = new System.Drawing.Point(781, 157);
            this.TxtPais.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(92, 20);
            this.TxtPais.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Idioma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(679, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "País";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(166, 50);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(278, 20);
            this.TxtTitulo.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(679, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Número de edición";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Año de Edición";
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.Location = new System.Drawing.Point(166, 188);
            this.PanelCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(400, 100);
            this.PanelCodigo.TabIndex = 19;
            // 
            // BtnGuardarCodigo
            // 
            this.BtnGuardarCodigo.Enabled = false;
            this.BtnGuardarCodigo.Location = new System.Drawing.Point(316, 157);
            this.BtnGuardarCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarCodigo.Name = "BtnGuardarCodigo";
            this.BtnGuardarCodigo.Size = new System.Drawing.Size(128, 26);
            this.BtnGuardarCodigo.TabIndex = 18;
            this.BtnGuardarCodigo.Text = "Guardar código";
            this.BtnGuardarCodigo.UseVisualStyleBackColor = true;
            this.BtnGuardarCodigo.Click += new System.EventHandler(this.BtnGuardarCodigo_Click);
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(166, 158);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(128, 26);
            this.BtnGenerar.TabIndex = 17;
            this.BtnGenerar.Text = "Generar código";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // TxtISBN
            // 
            this.TxtISBN.Location = new System.Drawing.Point(166, 133);
            this.TxtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(278, 20);
            this.TxtISBN.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ISBN (*)";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(682, 50);
            this.TxtEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(191, 20);
            this.TxtEditorial.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Editorial (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Título (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(*) Indica que el dato es obligatorio";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(316, 372);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(350, 20);
            this.TxtId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(95, 20);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(641, 336);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(281, 72);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(166, 90);
            this.TxtAutor.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(278, 20);
            this.TxtAutor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor (*)";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(169, 372);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(134, 23);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(169, 372);
            this.BtnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(134, 23);
            this.BtnInsertar.TabIndex = 5;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 459);
            this.Controls.Add(this.TabGeneral);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLibro";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmArtículo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown NumPags;
        private System.Windows.Forms.NumericUpDown NumUbicacion;
        private System.Windows.Forms.NumericUpDown NumEdicion;
        private System.Windows.Forms.NumericUpDown NumYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtIdioma;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.Button BtnGuardarCodigo;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnInsertar;
    }
}