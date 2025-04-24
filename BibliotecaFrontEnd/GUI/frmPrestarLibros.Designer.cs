namespace BibliotecaFrontEnd.GUI
{
    partial class frmPrestarLibros
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
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.lblInfoUsuario = new System.Windows.Forms.Label();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.gbLibrosDisponibles = new System.Windows.Forms.GroupBox();
            this.lblLibrosDisponibles = new System.Windows.Forms.Label();
            this.lvLibrosDisponibles = new System.Windows.Forms.ListView();
            this.colTituloDisponible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAutorDisponible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colISBNDisponible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEjemplaresDisponible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbLibrosSeleccionados = new System.Windows.Forms.GroupBox();
            this.lblLibrosSeleccionados = new System.Windows.Forms.Label();
            this.lvLibrosSeleccionados = new System.Windows.Forms.ListView();
            this.colTituloSeleccionado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAutorSeleccionado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colISBNSeleccionado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbUsuario.SuspendLayout();
            this.gbFechas.SuspendLayout();
            this.gbLibrosDisponibles.SuspendLayout();
            this.gbLibrosSeleccionados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.lblInfoUsuario);
            this.gbUsuario.Controls.Add(this.cbUsuarios);
            this.gbUsuario.Controls.Add(this.label1);
            this.gbUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(360, 100);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Datos del Usuario";
            // 
            // lblInfoUsuario
            // 
            this.lblInfoUsuario.AutoSize = true;
            this.lblInfoUsuario.Location = new System.Drawing.Point(10, 60);
            this.lblInfoUsuario.Name = "lblInfoUsuario";
            this.lblInfoUsuario.Size = new System.Drawing.Size(112, 13);
            this.lblInfoUsuario.TabIndex = 2;
            this.lblInfoUsuario.Text = "Seleccione un usuario";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.DisplayMember = "NombreCompleto";
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(70, 25);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(280, 21);
            this.cbUsuarios.TabIndex = 1;
            this.cbUsuarios.ValueMember = "Identificacion";
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.dtpFechaDevolucion);
            this.gbFechas.Controls.Add(this.label4);
            this.gbFechas.Controls.Add(this.label3);
            this.gbFechas.Controls.Add(this.dtpFechaPrestamo);
            this.gbFechas.Location = new System.Drawing.Point(390, 12);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(380, 100);
            this.gbFechas.TabIndex = 1;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Fechas del Préstamo";
            this.gbFechas.Enter += new System.EventHandler(this.gbFechas_Enter);
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(120, 60);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaDevolucion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de Devolución";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de Préstamo";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Enabled = false;
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(120, 25);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaPrestamo.TabIndex = 0;
            // 
            // gbLibrosDisponibles
            // 
            this.gbLibrosDisponibles.Controls.Add(this.lblLibrosDisponibles);
            this.gbLibrosDisponibles.Controls.Add(this.lvLibrosDisponibles);
            this.gbLibrosDisponibles.Location = new System.Drawing.Point(12, 120);
            this.gbLibrosDisponibles.Name = "gbLibrosDisponibles";
            this.gbLibrosDisponibles.Size = new System.Drawing.Size(360, 300);
            this.gbLibrosDisponibles.TabIndex = 2;
            this.gbLibrosDisponibles.TabStop = false;
            this.gbLibrosDisponibles.Text = "Libros Disponibles";
            // 
            // lblLibrosDisponibles
            // 
            this.lblLibrosDisponibles.AutoSize = true;
            this.lblLibrosDisponibles.Location = new System.Drawing.Point(10, 280);
            this.lblLibrosDisponibles.Name = "lblLibrosDisponibles";
            this.lblLibrosDisponibles.Size = new System.Drawing.Size(102, 13);
            this.lblLibrosDisponibles.TabIndex = 1;
            this.lblLibrosDisponibles.Text = "Libros disponibles: 0";
            // 
            // lvLibrosDisponibles
            // 
            this.lvLibrosDisponibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTituloDisponible,
            this.colAutorDisponible,
            this.colISBNDisponible,
            this.colEjemplaresDisponible});
            this.lvLibrosDisponibles.FullRowSelect = true;
            this.lvLibrosDisponibles.GridLines = true;
            this.lvLibrosDisponibles.HideSelection = false;
            this.lvLibrosDisponibles.Location = new System.Drawing.Point(10, 20);
            this.lvLibrosDisponibles.Name = "lvLibrosDisponibles";
            this.lvLibrosDisponibles.Size = new System.Drawing.Size(340, 250);
            this.lvLibrosDisponibles.TabIndex = 0;
            this.lvLibrosDisponibles.UseCompatibleStateImageBehavior = false;
            this.lvLibrosDisponibles.View = System.Windows.Forms.View.Details;
            this.lvLibrosDisponibles.SelectedIndexChanged += new System.EventHandler(this.lvLibrosDisponibles_SelectedIndexChanged);
            // 
            // colTituloDisponible
            // 
            this.colTituloDisponible.Text = "Título";
            this.colTituloDisponible.Width = 120;
            // 
            // colAutorDisponible
            // 
            this.colAutorDisponible.Text = "Autor";
            this.colAutorDisponible.Width = 100;
            // 
            // colISBNDisponible
            // 
            this.colISBNDisponible.Text = "ISBN";
            this.colISBNDisponible.Width = 80;
            // 
            // colEjemplaresDisponible
            // 
            this.colEjemplaresDisponible.Text = "Disponibles";
            this.colEjemplaresDisponible.Width = 80;
            // 
            // gbLibrosSeleccionados
            // 
            this.gbLibrosSeleccionados.Controls.Add(this.lblLibrosSeleccionados);
            this.gbLibrosSeleccionados.Controls.Add(this.lvLibrosSeleccionados);
            this.gbLibrosSeleccionados.Location = new System.Drawing.Point(390, 120);
            this.gbLibrosSeleccionados.Name = "gbLibrosSeleccionados";
            this.gbLibrosSeleccionados.Size = new System.Drawing.Size(380, 300);
            this.gbLibrosSeleccionados.TabIndex = 3;
            this.gbLibrosSeleccionados.TabStop = false;
            this.gbLibrosSeleccionados.Text = "Libros a Prestar";
            this.gbLibrosSeleccionados.Enter += new System.EventHandler(this.gbLibrosSeleccionados_Enter);
            // 
            // lblLibrosSeleccionados
            // 
            this.lblLibrosSeleccionados.AutoSize = true;
            this.lblLibrosSeleccionados.Location = new System.Drawing.Point(10, 280);
            this.lblLibrosSeleccionados.Name = "lblLibrosSeleccionados";
            this.lblLibrosSeleccionados.Size = new System.Drawing.Size(91, 13);
            this.lblLibrosSeleccionados.TabIndex = 1;
            this.lblLibrosSeleccionados.Text = "Libros a prestar: 0";
            // 
            // lvLibrosSeleccionados
            // 
            this.lvLibrosSeleccionados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTituloSeleccionado,
            this.colAutorSeleccionado,
            this.colISBNSeleccionado});
            this.lvLibrosSeleccionados.FullRowSelect = true;
            this.lvLibrosSeleccionados.GridLines = true;
            this.lvLibrosSeleccionados.HideSelection = false;
            this.lvLibrosSeleccionados.Location = new System.Drawing.Point(10, 20);
            this.lvLibrosSeleccionados.Name = "lvLibrosSeleccionados";
            this.lvLibrosSeleccionados.Size = new System.Drawing.Size(360, 250);
            this.lvLibrosSeleccionados.TabIndex = 0;
            this.lvLibrosSeleccionados.UseCompatibleStateImageBehavior = false;
            this.lvLibrosSeleccionados.View = System.Windows.Forms.View.Details;
            // 
            // colTituloSeleccionado
            // 
            this.colTituloSeleccionado.Text = "Título";
            this.colTituloSeleccionado.Width = 150;
            // 
            // colAutorSeleccionado
            // 
            this.colAutorSeleccionado.Text = "Autor";
            this.colAutorSeleccionado.Width = 120;
            // 
            // colISBNSeleccionado
            // 
            this.colISBNSeleccionado.Text = "ISBN";
            this.colISBNSeleccionado.Width = 80;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(350, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(55, 30);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(350, 260);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(55, 30);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(500, 430);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(120, 40);
            this.btnPrestar.TabIndex = 6;
            this.btnPrestar.Text = "Registrar Préstamo";
            this.btnPrestar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(650, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPrestarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbLibrosSeleccionados);
            this.Controls.Add(this.gbLibrosDisponibles);
            this.Controls.Add(this.gbFechas);
            this.Controls.Add(this.gbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrestarLibros";
            this.Text = "Registrar Préstamo de Libros";
            this.Load += new System.EventHandler(this.frmPrestarLibros_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            this.gbLibrosDisponibles.ResumeLayout(false);
            this.gbLibrosDisponibles.PerformLayout();
            this.gbLibrosSeleccionados.ResumeLayout(false);
            this.gbLibrosSeleccionados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.GroupBox gbLibrosDisponibles;
        private System.Windows.Forms.Label lblLibrosDisponibles;
        private System.Windows.Forms.ListView lvLibrosDisponibles;
        private System.Windows.Forms.ColumnHeader colTituloDisponible;
        private System.Windows.Forms.ColumnHeader colAutorDisponible;
        private System.Windows.Forms.ColumnHeader colISBNDisponible;
        private System.Windows.Forms.ColumnHeader colEjemplaresDisponible;
        private System.Windows.Forms.GroupBox gbLibrosSeleccionados;
        private System.Windows.Forms.Label lblLibrosSeleccionados;
        private System.Windows.Forms.ListView lvLibrosSeleccionados;
        private System.Windows.Forms.ColumnHeader colTituloSeleccionado;
        private System.Windows.Forms.ColumnHeader colAutorSeleccionado;
        private System.Windows.Forms.ColumnHeader colISBNSeleccionado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Button btnCancelar;
    }
}