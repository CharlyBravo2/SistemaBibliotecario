using System.Windows.Forms;

namespace BibliotecaFrontEnd.GUI
{
    partial class frmListarPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlLibro = new System.Windows.Forms.Panel();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFechas = new System.Windows.Forms.Panel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlLibro.SuspendLayout();
            this.pnlFechas.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.pnlLibro);
            this.gbFiltros.Controls.Add(this.pnlUsuario);
            this.gbFiltros.Controls.Add(this.pnlFechas);
            this.gbFiltros.Controls.Add(this.cmbTipoFiltro);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.btnFiltrar);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(860, 150);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de Búsqueda";
            this.gbFiltros.Enter += new System.EventHandler(this.gbFiltros_Enter);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.cmbUsuario);
            this.pnlUsuario.Controls.Add(this.label4);
            this.pnlUsuario.Location = new System.Drawing.Point(287, 80);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(343, 50);
            this.pnlUsuario.TabIndex = 4;
            this.pnlUsuario.Visible = false;
            // 
            // pnlLibro
            // 
            this.pnlLibro.Controls.Add(this.cmbLibro);
            this.pnlLibro.Controls.Add(this.label5);
            this.pnlLibro.Location = new System.Drawing.Point(577, 80);
            this.pnlLibro.Name = "pnlLibro";
            this.pnlLibro.Size = new System.Drawing.Size(263, 50);
            this.pnlLibro.TabIndex = 5;
            this.pnlLibro.Visible = false;
            // 
            // cmbLibro
            // 
            this.cmbLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(37, 14);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(200, 21);
            this.cmbLibro.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Libro";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(80, 15);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(200, 21);
            this.cmbUsuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuario";
            // 
            // pnlFechas
            // 
            this.pnlFechas.Controls.Add(this.dtpHasta);
            this.pnlFechas.Controls.Add(this.label3);
            this.pnlFechas.Controls.Add(this.dtpDesde);
            this.pnlFechas.Controls.Add(this.label2);
            this.pnlFechas.Location = new System.Drawing.Point(20, 80);
            this.pnlFechas.Name = "pnlFechas";
            this.pnlFechas.Size = new System.Drawing.Size(261, 50);
            this.pnlFechas.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(170, 15);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(81, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(50, 15);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(80, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde";
            // 
            // cmbTipoFiltro
            // 
            this.cmbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFiltro.FormattingEnabled = true;
            this.cmbTipoFiltro.Location = new System.Drawing.Point(120, 30);
            this.cmbTipoFiltro.Name = "cmbTipoFiltro";
            this.cmbTipoFiltro.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoFiltro.TabIndex = 2;
            this.cmbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Filtro:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(750, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 30);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.lblTotal);
            this.gbResultados.Controls.Add(this.dgvPrestamos);
            this.gbResultados.Location = new System.Drawing.Point(12, 170);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(860, 350);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(20, 320);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total préstamos";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamos.ColumnHeadersHeight = 30;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamos.EnableHeadersVisualStyles = false;
            this.dgvPrestamos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPrestamos.Location = new System.Drawing.Point(20, 30);
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(820, 280);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(570, 530);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 30);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(680, 530);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(790, 530);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmListarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 571);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarPrestamos";
            this.Text = "Listado de Préstamos";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlLibro.ResumeLayout(false);
            this.pnlLibro.PerformLayout();
            this.pnlFechas.ResumeLayout(false);
            this.pnlFechas.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ComboBox cmbTipoFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlFechas;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlLibro;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
    }
}