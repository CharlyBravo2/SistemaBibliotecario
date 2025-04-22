namespace BibliotecaFrontEnd.GUI
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAgregarLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListarLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAgregarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPrestarLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDevolverLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListarPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLibros,
            this.menuUsuarios,
            this.menuPrestamos,
            this.menuConfiguracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuLibros
            // 
            this.menuLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAgregarLibro,
            this.itemListarLibros});
            this.menuLibros.Name = "menuLibros";
            this.menuLibros.Size = new System.Drawing.Size(51, 20);
            this.menuLibros.Text = "Libros";
            // 
            // itemAgregarLibro
            // 
            this.itemAgregarLibro.Name = "itemAgregarLibro";
            this.itemAgregarLibro.Size = new System.Drawing.Size(146, 22);
            this.itemAgregarLibro.Text = "Agregar Libro";
            // 
            // itemListarLibros
            // 
            this.itemListarLibros.Name = "itemListarLibros";
            this.itemListarLibros.Size = new System.Drawing.Size(146, 22);
            this.itemListarLibros.Text = "Listar Libros";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAgregarUsuario});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.menuUsuarios.Text = "Usuarios";
            // 
            // itemAgregarUsuario
            // 
            this.itemAgregarUsuario.Name = "itemAgregarUsuario";
            this.itemAgregarUsuario.Size = new System.Drawing.Size(159, 22);
            this.itemAgregarUsuario.Text = "Agregar Usuario";
            // 
            // menuPrestamos
            // 
            this.menuPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPrestarLibros,
            this.itemDevolverLibros,
            this.itemListarPrestamos});
            this.menuPrestamos.Name = "menuPrestamos";
            this.menuPrestamos.Size = new System.Drawing.Size(74, 20);
            this.menuPrestamos.Text = "Préstamos";
            this.menuPrestamos.Click += new System.EventHandler(this.menuPrestamos_Click);
            // 
            // itemPrestarLibros
            // 
            this.itemPrestarLibros.Name = "itemPrestarLibros";
            this.itemPrestarLibros.Size = new System.Drawing.Size(160, 22);
            this.itemPrestarLibros.Text = "Prestar Libros";
            // 
            // itemDevolverLibros
            // 
            this.itemDevolverLibros.Name = "itemDevolverLibros";
            this.itemDevolverLibros.Size = new System.Drawing.Size(160, 22);
            this.itemDevolverLibros.Text = "Devolver Libros";
            // 
            // itemListarPrestamos
            // 
            this.itemListarPrestamos.Name = "itemListarPrestamos";
            this.itemListarPrestamos.Size = new System.Drawing.Size(160, 22);
            this.itemListarPrestamos.Text = "Listar Préstamos";
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBackup,
            this.itemSalir});
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.menuConfiguracion.Text = "Configuración";
            // 
            // itemBackup
            // 
            this.itemBackup.Name = "itemBackup";
            this.itemBackup.Size = new System.Drawing.Size(113, 22);
            this.itemBackup.Text = "Backup";
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(113, 22);
            this.itemSalir.Text = "Salir";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(50, 515);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(510, 37);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Sistema de Gestión Bibliotecaria";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 561);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Gestión Bibliotecaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLibros;
        private System.Windows.Forms.ToolStripMenuItem itemAgregarLibro;
        private System.Windows.Forms.ToolStripMenuItem itemListarLibros;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem itemAgregarUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuPrestamos;
        private System.Windows.Forms.ToolStripMenuItem itemPrestarLibros;
        private System.Windows.Forms.ToolStripMenuItem itemDevolverLibros;
        private System.Windows.Forms.ToolStripMenuItem itemListarPrestamos;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem itemBackup;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.Label lblBienvenida;
    }
}