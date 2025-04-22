namespace BibliotecaFrontEnd.GUI
{
    partial class frmAgregarLibro
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
            this.numEjemplares = new System.Windows.Forms.NumericUpDown();
            this.numAnioPublicacion = new System.Windows.Forms.NumericUpDown();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkAutorBestSeller = new System.Windows.Forms.CheckBox();
            this.txtAutorPseudonimo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numAutorLibrosPublicados = new System.Windows.Forms.NumericUpDown();
            this.numAutorAnioNacimiento = new System.Windows.Forms.NumericUpDown();
            this.txtAutorNacionalidad = new System.Windows.Forms.TextBox();
            this.txtAutorApellido = new System.Windows.Forms.TextBox();
            this.txtAutorNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtEditorialSitioWeb = new System.Windows.Forms.TextBox();
            this.numEditorialAnioFundacion = new System.Windows.Forms.NumericUpDown();
            this.txtEditorialCorreo = new System.Windows.Forms.TextBox();
            this.txtEditorialTelefono = new System.Windows.Forms.TextBox();
            this.txtEditorialDireccion = new System.Windows.Forms.TextBox();
            this.txtEditorialPais = new System.Windows.Forms.TextBox();
            this.txtEditorialNombre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtGeneroTema = new System.Windows.Forms.TextBox();
            this.txtGeneroNombre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEjemplares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioPublicacion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutorLibrosPublicados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutorAnioNacimiento)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditorialAnioFundacion)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numEjemplares);
            this.tabPage1.Controls.Add(this.numAnioPublicacion);
            this.tabPage1.Controls.Add(this.txtISBN);
            this.tabPage1.Controls.Add(this.txtTitulo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información Básica";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // numEjemplares
            // 
            this.numEjemplares.Location = new System.Drawing.Point(150, 150);
            this.numEjemplares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEjemplares.Name = "numEjemplares";
            this.numEjemplares.Size = new System.Drawing.Size(120, 20);
            this.numEjemplares.TabIndex = 7;
            this.numEjemplares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numAnioPublicacion
            // 
            this.numAnioPublicacion.Location = new System.Drawing.Point(150, 110);
            this.numAnioPublicacion.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAnioPublicacion.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAnioPublicacion.Name = "numAnioPublicacion";
            this.numAnioPublicacion.Size = new System.Drawing.Size(120, 20);
            this.numAnioPublicacion.TabIndex = 6;
            this.numAnioPublicacion.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(150, 70);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(150, 30);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(300, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Ejemplares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año de Publicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkAutorBestSeller);
            this.tabPage2.Controls.Add(this.txtAutorPseudonimo);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.numAutorLibrosPublicados);
            this.tabPage2.Controls.Add(this.numAutorAnioNacimiento);
            this.tabPage2.Controls.Add(this.txtAutorNacionalidad);
            this.tabPage2.Controls.Add(this.txtAutorApellido);
            this.tabPage2.Controls.Add(this.txtAutorNombre);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkAutorBestSeller
            // 
            this.chkAutorBestSeller.AutoSize = true;
            this.chkAutorBestSeller.Location = new System.Drawing.Point(150, 230);
            this.chkAutorBestSeller.Name = "chkAutorBestSeller";
            this.chkAutorBestSeller.Size = new System.Drawing.Size(76, 17);
            this.chkAutorBestSeller.TabIndex = 12;
            this.chkAutorBestSeller.Text = "Best Seller";
            this.chkAutorBestSeller.UseVisualStyleBackColor = true;
            // 
            // txtAutorPseudonimo
            // 
            this.txtAutorPseudonimo.Location = new System.Drawing.Point(150, 190);
            this.txtAutorPseudonimo.MaxLength = 50;
            this.txtAutorPseudonimo.Name = "txtAutorPseudonimo";
            this.txtAutorPseudonimo.Size = new System.Drawing.Size(200, 20);
            this.txtAutorPseudonimo.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Pseudónimo";
            // 
            // numAutorLibrosPublicados
            // 
            this.numAutorLibrosPublicados.Location = new System.Drawing.Point(150, 150);
            this.numAutorLibrosPublicados.Name = "numAutorLibrosPublicados";
            this.numAutorLibrosPublicados.Size = new System.Drawing.Size(120, 20);
            this.numAutorLibrosPublicados.TabIndex = 9;
            // 
            // numAutorAnioNacimiento
            // 
            this.numAutorAnioNacimiento.Location = new System.Drawing.Point(150, 110);
            this.numAutorAnioNacimiento.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAutorAnioNacimiento.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAutorAnioNacimiento.Name = "numAutorAnioNacimiento";
            this.numAutorAnioNacimiento.Size = new System.Drawing.Size(120, 20);
            this.numAutorAnioNacimiento.TabIndex = 8;
            this.numAutorAnioNacimiento.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // txtAutorNacionalidad
            // 
            this.txtAutorNacionalidad.Location = new System.Drawing.Point(150, 70);
            this.txtAutorNacionalidad.MaxLength = 50;
            this.txtAutorNacionalidad.Name = "txtAutorNacionalidad";
            this.txtAutorNacionalidad.Size = new System.Drawing.Size(200, 20);
            this.txtAutorNacionalidad.TabIndex = 7;
            // 
            // txtAutorApellido
            // 
            this.txtAutorApellido.Location = new System.Drawing.Point(150, 40);
            this.txtAutorApellido.MaxLength = 50;
            this.txtAutorApellido.Name = "txtAutorApellido";
            this.txtAutorApellido.Size = new System.Drawing.Size(200, 20);
            this.txtAutorApellido.TabIndex = 6;
            // 
            // txtAutorNombre
            // 
            this.txtAutorNombre.Location = new System.Drawing.Point(150, 10);
            this.txtAutorNombre.MaxLength = 50;
            this.txtAutorNombre.Name = "txtAutorNombre";
            this.txtAutorNombre.Size = new System.Drawing.Size(200, 20);
            this.txtAutorNombre.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Libros Publicados (total)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Año de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nacionalidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtEditorialSitioWeb);
            this.tabPage3.Controls.Add(this.numEditorialAnioFundacion);
            this.tabPage3.Controls.Add(this.txtEditorialCorreo);
            this.tabPage3.Controls.Add(this.txtEditorialTelefono);
            this.tabPage3.Controls.Add(this.txtEditorialDireccion);
            this.tabPage3.Controls.Add(this.txtEditorialPais);
            this.tabPage3.Controls.Add(this.txtEditorialNombre);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Editorial";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtEditorialSitioWeb
            // 
            this.txtEditorialSitioWeb.Location = new System.Drawing.Point(150, 190);
            this.txtEditorialSitioWeb.MaxLength = 100;
            this.txtEditorialSitioWeb.Name = "txtEditorialSitioWeb";
            this.txtEditorialSitioWeb.Size = new System.Drawing.Size(300, 20);
            this.txtEditorialSitioWeb.TabIndex = 13;
            // 
            // numEditorialAnioFundacion
            // 
            this.numEditorialAnioFundacion.Location = new System.Drawing.Point(150, 160);
            this.numEditorialAnioFundacion.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numEditorialAnioFundacion.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEditorialAnioFundacion.Name = "numEditorialAnioFundacion";
            this.numEditorialAnioFundacion.Size = new System.Drawing.Size(120, 20);
            this.numEditorialAnioFundacion.TabIndex = 12;
            this.numEditorialAnioFundacion.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtEditorialCorreo
            // 
            this.txtEditorialCorreo.Location = new System.Drawing.Point(150, 130);
            this.txtEditorialCorreo.MaxLength = 100;
            this.txtEditorialCorreo.Name = "txtEditorialCorreo";
            this.txtEditorialCorreo.Size = new System.Drawing.Size(300, 20);
            this.txtEditorialCorreo.TabIndex = 11;
            // 
            // txtEditorialTelefono
            // 
            this.txtEditorialTelefono.Location = new System.Drawing.Point(150, 100);
            this.txtEditorialTelefono.MaxLength = 20;
            this.txtEditorialTelefono.Name = "txtEditorialTelefono";
            this.txtEditorialTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtEditorialTelefono.TabIndex = 10;
            // 
            // txtEditorialDireccion
            // 
            this.txtEditorialDireccion.Location = new System.Drawing.Point(150, 70);
            this.txtEditorialDireccion.MaxLength = 200;
            this.txtEditorialDireccion.Name = "txtEditorialDireccion";
            this.txtEditorialDireccion.Size = new System.Drawing.Size(300, 20);
            this.txtEditorialDireccion.TabIndex = 9;
            // 
            // txtEditorialPais
            // 
            this.txtEditorialPais.Location = new System.Drawing.Point(150, 40);
            this.txtEditorialPais.MaxLength = 50;
            this.txtEditorialPais.Name = "txtEditorialPais";
            this.txtEditorialPais.Size = new System.Drawing.Size(200, 20);
            this.txtEditorialPais.TabIndex = 8;
            // 
            // txtEditorialNombre
            // 
            this.txtEditorialNombre.Location = new System.Drawing.Point(150, 10);
            this.txtEditorialNombre.MaxLength = 100;
            this.txtEditorialNombre.Name = "txtEditorialNombre";
            this.txtEditorialNombre.Size = new System.Drawing.Size(300, 20);
            this.txtEditorialNombre.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Sitio Web";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Año de Fundación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Correo Electrónico";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Dirección";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "País";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtGeneroTema);
            this.tabPage4.Controls.Add(this.txtGeneroNombre);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(552, 324);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Género Literario";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtGeneroTema
            // 
            this.txtGeneroTema.Location = new System.Drawing.Point(150, 50);
            this.txtGeneroTema.MaxLength = 100;
            this.txtGeneroTema.Name = "txtGeneroTema";
            this.txtGeneroTema.Size = new System.Drawing.Size(300, 20);
            this.txtGeneroTema.TabIndex = 3;
            // 
            // txtGeneroNombre
            // 
            this.txtGeneroNombre.Location = new System.Drawing.Point(150, 20);
            this.txtGeneroNombre.MaxLength = 100;
            this.txtGeneroNombre.Name = "txtGeneroNombre";
            this.txtGeneroNombre.Size = new System.Drawing.Size(300, 20);
            this.txtGeneroNombre.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Tema";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(400, 380);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(490, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Nuevo Libro";
            this.Load += new System.EventHandler(this.frmAgregarLibro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEjemplares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioPublicacion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutorLibrosPublicados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutorAnioNacimiento)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditorialAnioFundacion)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numEjemplares;
        private System.Windows.Forms.NumericUpDown numAnioPublicacion;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkAutorBestSeller;
        private System.Windows.Forms.TextBox txtAutorPseudonimo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numAutorLibrosPublicados;
        private System.Windows.Forms.NumericUpDown numAutorAnioNacimiento;
        private System.Windows.Forms.TextBox txtAutorNacionalidad;
        private System.Windows.Forms.TextBox txtAutorApellido;
        private System.Windows.Forms.TextBox txtAutorNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtEditorialSitioWeb;
        private System.Windows.Forms.NumericUpDown numEditorialAnioFundacion;
        private System.Windows.Forms.TextBox txtEditorialCorreo;
        private System.Windows.Forms.TextBox txtEditorialTelefono;
        private System.Windows.Forms.TextBox txtEditorialDireccion;
        private System.Windows.Forms.TextBox txtEditorialPais;
        private System.Windows.Forms.TextBox txtEditorialNombre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtGeneroTema;
        private System.Windows.Forms.TextBox txtGeneroNombre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}