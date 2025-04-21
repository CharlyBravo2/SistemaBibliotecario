namespace BibliotecaFrontEnd.GUI
{
    partial class frmAgregarUsuario
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
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTipoUsuario = new System.Windows.Forms.GroupBox();
            this.rbProfesor = new System.Windows.Forms.RadioButton();
            this.rbEstudiante = new System.Windows.Forms.RadioButton();
            this.pnlEstudiante = new System.Windows.Forms.Panel();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.txtTipoBeca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEstadoCivilEstudiante = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numEdadEstudiante = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numPromedio = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numSemestre = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlProfesor = new System.Windows.Forms.Panel();
            this.txtCursos = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGradoAcademico = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEstadoCivilProfesor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numEdadProfesor = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.chkTitular = new System.Windows.Forms.CheckBox();
            this.numExperiencia = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatosGenerales.SuspendLayout();
            this.gbTipoUsuario.SuspendLayout();
            this.pnlEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemestre)).BeginInit();
            this.pnlProfesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.txtTelefono);
            this.gbDatosGenerales.Controls.Add(this.label6);
            this.gbDatosGenerales.Controls.Add(this.txtCorreo);
            this.gbDatosGenerales.Controls.Add(this.label5);
            this.gbDatosGenerales.Controls.Add(this.txtIdentificacion);
            this.gbDatosGenerales.Controls.Add(this.label4);
            this.gbDatosGenerales.Controls.Add(this.txtApellido);
            this.gbDatosGenerales.Controls.Add(this.label3);
            this.gbDatosGenerales.Controls.Add(this.txtNombre);
            this.gbDatosGenerales.Controls.Add(this.label2);
            this.gbDatosGenerales.Location = new System.Drawing.Point(12, 12);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(360, 180);
            this.gbDatosGenerales.TabIndex = 0;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 140);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(120, 110);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Correo";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(120, 80);
            this.txtIdentificacion.MaxLength = 20;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(200, 20);
            this.txtIdentificacion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Identificación";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(120, 50);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 20);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // gbTipoUsuario
            // 
            this.gbTipoUsuario.Controls.Add(this.rbProfesor);
            this.gbTipoUsuario.Controls.Add(this.rbEstudiante);
            this.gbTipoUsuario.Location = new System.Drawing.Point(390, 12);
            this.gbTipoUsuario.Name = "gbTipoUsuario";
            this.gbTipoUsuario.Size = new System.Drawing.Size(200, 60);
            this.gbTipoUsuario.TabIndex = 1;
            this.gbTipoUsuario.TabStop = false;
            this.gbTipoUsuario.Text = "Tipo de Usuario";
            // 
            // rbProfesor
            // 
            this.rbProfesor.AutoSize = true;
            this.rbProfesor.Location = new System.Drawing.Point(100, 25);
            this.rbProfesor.Name = "rbProfesor";
            this.rbProfesor.Size = new System.Drawing.Size(64, 17);
            this.rbProfesor.TabIndex = 1;
            this.rbProfesor.Text = "Profesor";
            this.rbProfesor.UseVisualStyleBackColor = true;
            // 
            // rbEstudiante
            // 
            this.rbEstudiante.AutoSize = true;
            this.rbEstudiante.Location = new System.Drawing.Point(20, 25);
            this.rbEstudiante.Name = "rbEstudiante";
            this.rbEstudiante.Size = new System.Drawing.Size(75, 17);
            this.rbEstudiante.TabIndex = 0;
            this.rbEstudiante.Text = "Estudiante";
            this.rbEstudiante.UseVisualStyleBackColor = true;
            // 
            // pnlEstudiante
            // 
            this.pnlEstudiante.Controls.Add(this.chkRegular);
            this.pnlEstudiante.Controls.Add(this.txtTipoBeca);
            this.pnlEstudiante.Controls.Add(this.label13);
            this.pnlEstudiante.Controls.Add(this.txtEstadoCivilEstudiante);
            this.pnlEstudiante.Controls.Add(this.label12);
            this.pnlEstudiante.Controls.Add(this.numEdadEstudiante);
            this.pnlEstudiante.Controls.Add(this.label11);
            this.pnlEstudiante.Controls.Add(this.numPromedio);
            this.pnlEstudiante.Controls.Add(this.label10);
            this.pnlEstudiante.Controls.Add(this.numSemestre);
            this.pnlEstudiante.Controls.Add(this.label9);
            this.pnlEstudiante.Controls.Add(this.txtCarrera);
            this.pnlEstudiante.Controls.Add(this.label8);
            this.pnlEstudiante.Location = new System.Drawing.Point(390, 80);
            this.pnlEstudiante.Name = "pnlEstudiante";
            this.pnlEstudiante.Size = new System.Drawing.Size(380, 250);
            this.pnlEstudiante.TabIndex = 2;
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Checked = true;
            this.chkRegular.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRegular.Location = new System.Drawing.Point(20, 210);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(111, 17);
            this.chkRegular.TabIndex = 12;
            this.chkRegular.Text = "Estudiante regular";
            this.chkRegular.UseVisualStyleBackColor = true;
            // 
            // txtTipoBeca
            // 
            this.txtTipoBeca.Location = new System.Drawing.Point(120, 180);
            this.txtTipoBeca.MaxLength = 50;
            this.txtTipoBeca.Name = "txtTipoBeca";
            this.txtTipoBeca.Size = new System.Drawing.Size(200, 20);
            this.txtTipoBeca.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tipo Beca";
            // 
            // txtEstadoCivilEstudiante
            // 
            this.txtEstadoCivilEstudiante.Location = new System.Drawing.Point(120, 150);
            this.txtEstadoCivilEstudiante.MaxLength = 50;
            this.txtEstadoCivilEstudiante.Name = "txtEstadoCivilEstudiante";
            this.txtEstadoCivilEstudiante.Size = new System.Drawing.Size(200, 20);
            this.txtEstadoCivilEstudiante.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Estado Civil";
            // 
            // numEdadEstudiante
            // 
            this.numEdadEstudiante.Location = new System.Drawing.Point(120, 120);
            this.numEdadEstudiante.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numEdadEstudiante.Name = "numEdadEstudiante";
            this.numEdadEstudiante.Size = new System.Drawing.Size(60, 20);
            this.numEdadEstudiante.TabIndex = 7;
            this.numEdadEstudiante.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Edad";
            // 
            // numPromedio
            // 
            this.numPromedio.DecimalPlaces = 2;
            this.numPromedio.Location = new System.Drawing.Point(120, 90);
            this.numPromedio.Name = "numPromedio";
            this.numPromedio.Size = new System.Drawing.Size(60, 20);
            this.numPromedio.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Promedio";
            // 
            // numSemestre
            // 
            this.numSemestre.Location = new System.Drawing.Point(120, 60);
            this.numSemestre.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numSemestre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSemestre.Name = "numSemestre";
            this.numSemestre.Size = new System.Drawing.Size(60, 20);
            this.numSemestre.TabIndex = 3;
            this.numSemestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Semestre";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(120, 30);
            this.txtCarrera.MaxLength = 100;
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(200, 20);
            this.txtCarrera.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Carrera";
            // 
            // pnlProfesor
            // 
            this.pnlProfesor.Controls.Add(this.txtCursos);
            this.pnlProfesor.Controls.Add(this.label18);
            this.pnlProfesor.Controls.Add(this.txtGradoAcademico);
            this.pnlProfesor.Controls.Add(this.label17);
            this.pnlProfesor.Controls.Add(this.txtEstadoCivilProfesor);
            this.pnlProfesor.Controls.Add(this.label16);
            this.pnlProfesor.Controls.Add(this.numEdadProfesor);
            this.pnlProfesor.Controls.Add(this.label15);
            this.pnlProfesor.Controls.Add(this.chkTitular);
            this.pnlProfesor.Controls.Add(this.numExperiencia);
            this.pnlProfesor.Controls.Add(this.label14);
            this.pnlProfesor.Controls.Add(this.txtDepartamento);
            this.pnlProfesor.Controls.Add(this.label7);
            this.pnlProfesor.Location = new System.Drawing.Point(390, 80);
            this.pnlProfesor.Name = "pnlProfesor";
            this.pnlProfesor.Size = new System.Drawing.Size(380, 250);
            this.pnlProfesor.TabIndex = 3;
            this.pnlProfesor.Visible = false;
            // 
            // txtCursos
            // 
            this.txtCursos.Location = new System.Drawing.Point(120, 180);
            this.txtCursos.MaxLength = 200;
            this.txtCursos.Multiline = true;
            this.txtCursos.Name = "txtCursos";
            this.txtCursos.Size = new System.Drawing.Size(200, 50);
            this.txtCursos.TabIndex = 12;
            this.txtCursos.Text = "Separar con comas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Cursos Impartidos";
            // 
            // txtGradoAcademico
            // 
            this.txtGradoAcademico.Location = new System.Drawing.Point(120, 150);
            this.txtGradoAcademico.MaxLength = 100;
            this.txtGradoAcademico.Name = "txtGradoAcademico";
            this.txtGradoAcademico.Size = new System.Drawing.Size(200, 20);
            this.txtGradoAcademico.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Grado Académico";
            // 
            // txtEstadoCivilProfesor
            // 
            this.txtEstadoCivilProfesor.Location = new System.Drawing.Point(120, 120);
            this.txtEstadoCivilProfesor.MaxLength = 50;
            this.txtEstadoCivilProfesor.Name = "txtEstadoCivilProfesor";
            this.txtEstadoCivilProfesor.Size = new System.Drawing.Size(200, 20);
            this.txtEstadoCivilProfesor.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Estado Civil";
            // 
            // numEdadProfesor
            // 
            this.numEdadProfesor.Location = new System.Drawing.Point(120, 90);
            this.numEdadProfesor.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numEdadProfesor.Name = "numEdadProfesor";
            this.numEdadProfesor.Size = new System.Drawing.Size(60, 20);
            this.numEdadProfesor.TabIndex = 6;
            this.numEdadProfesor.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Edad";
            // 
            // chkTitular
            // 
            this.chkTitular.AutoSize = true;
            this.chkTitular.Location = new System.Drawing.Point(200, 60);
            this.chkTitular.Name = "chkTitular";
            this.chkTitular.Size = new System.Drawing.Size(55, 17);
            this.chkTitular.TabIndex = 4;
            this.chkTitular.Text = "Titular";
            this.chkTitular.UseVisualStyleBackColor = true;
            // 
            // numExperiencia
            // 
            this.numExperiencia.Location = new System.Drawing.Point(120, 60);
            this.numExperiencia.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numExperiencia.Name = "numExperiencia";
            this.numExperiencia.Size = new System.Drawing.Size(60, 20);
            this.numExperiencia.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Años Experiencia";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(120, 30);
            this.txtDepartamento.MaxLength = 100;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(200, 20);
            this.txtDepartamento.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Departamento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(500, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(650, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlProfesor);
            this.Controls.Add(this.pnlEstudiante);
            this.Controls.Add(this.gbTipoUsuario);
            this.Controls.Add(this.gbDatosGenerales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Nuevo Usuario";
            this.Load += new System.EventHandler(this.frmAgregarUsuario_Load);
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.gbTipoUsuario.ResumeLayout(false);
            this.gbTipoUsuario.PerformLayout();
            this.pnlEstudiante.ResumeLayout(false);
            this.pnlEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemestre)).EndInit();
            this.pnlProfesor.ResumeLayout(false);
            this.pnlProfesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTipoUsuario;
        private System.Windows.Forms.RadioButton rbProfesor;
        private System.Windows.Forms.RadioButton rbEstudiante;
        private System.Windows.Forms.Panel pnlEstudiante;
        private System.Windows.Forms.NumericUpDown numSemestre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPromedio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numEdadEstudiante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEstadoCivilEstudiante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTipoBeca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.Panel pnlProfesor;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numExperiencia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkTitular;
        private System.Windows.Forms.NumericUpDown numEdadProfesor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEstadoCivilProfesor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGradoAcademico;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCursos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}