namespace BibliotecaFrontEnd.GUI
{
    partial class frmGestionBackup
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
            this.gbRutaActual = new System.Windows.Forms.GroupBox();
            this.txtRutaActual = new System.Windows.Forms.TextBox();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.dtpFechaBackup = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnRestaurarSistema = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbRutaActual.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRutaActual
            // 
            this.gbRutaActual.Controls.Add(this.txtRutaActual);
            this.gbRutaActual.Location = new System.Drawing.Point(12, 12);
            this.gbRutaActual.Name = "gbRutaActual";
            this.gbRutaActual.Size = new System.Drawing.Size(560, 60);
            this.gbRutaActual.TabIndex = 0;
            this.gbRutaActual.TabStop = false;
            this.gbRutaActual.Text = "Ruta actual del archivo de datos";
            // 
            // txtRutaActual
            // 
            this.txtRutaActual.Location = new System.Drawing.Point(20, 25);
            this.txtRutaActual.Name = "txtRutaActual";
            this.txtRutaActual.Size = new System.Drawing.Size(520, 20);
            this.txtRutaActual.TabIndex = 0;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.dtpFechaBackup);
            this.gbAcciones.Controls.Add(this.label1);
            this.gbAcciones.Controls.Add(this.btnExportar);
            this.gbAcciones.Controls.Add(this.btnImportar);
            this.gbAcciones.Controls.Add(this.btnRestaurarSistema);
            this.gbAcciones.Location = new System.Drawing.Point(12, 80);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(560, 180);
            this.gbAcciones.TabIndex = 1;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones de Backup";
            this.gbAcciones.Enter += new System.EventHandler(this.gbAcciones_Enter);
            // 
            // dtpFechaBackup
            // 
            this.dtpFechaBackup.Location = new System.Drawing.Point(120, 30);
            this.dtpFechaBackup.Name = "dtpFechaBackup";
            this.dtpFechaBackup.Size = new System.Drawing.Size(150, 20);
            this.dtpFechaBackup.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de backup";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(20, 70);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(250, 40);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "Exportar Copia de Seguridad";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(290, 70);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(250, 40);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar Copia de Seguridad";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnRestaurarSistema
            // 
            this.btnRestaurarSistema.Location = new System.Drawing.Point(20, 120);
            this.btnRestaurarSistema.Name = "btnRestaurarSistema";
            this.btnRestaurarSistema.Size = new System.Drawing.Size(520, 40);
            this.btnRestaurarSistema.TabIndex = 2;
            this.btnRestaurarSistema.Text = "Restaurar Sistema a Valores Predeterminados";
            this.btnRestaurarSistema.UseVisualStyleBackColor = true;
            this.btnRestaurarSistema.Click += new System.EventHandler(this.btnRestaurarSistema_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(482, 270);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 30);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmGestionBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbRutaActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Copias de Seguridad";
            this.Load += new System.EventHandler(this.frmGestionBackup_Load);
            this.gbRutaActual.ResumeLayout(false);
            this.gbRutaActual.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRutaActual;
        private System.Windows.Forms.TextBox txtRutaActual;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnRestaurarSistema;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFechaBackup;
        private System.Windows.Forms.Label label1;
    }
}