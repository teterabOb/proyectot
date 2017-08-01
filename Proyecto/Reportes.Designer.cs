namespace Proyecto
{
    partial class Reportes
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
            this.tclReportes = new System.Windows.Forms.TabControl();
            this.tpRutasPorFecha = new System.Windows.Forms.TabPage();
            this.btnGenerarRutasPorFecha = new System.Windows.Forms.Button();
            this.dtpRutasPorFecha = new System.Windows.Forms.DateTimePicker();
            this.tpRutasPorChofer = new System.Windows.Forms.TabPage();
            this.tpIngresosPorFecha = new System.Windows.Forms.TabPage();
            this.btnGenerarIngresosPorFecha = new System.Windows.Forms.Button();
            this.dtpIngresosPorFecha = new System.Windows.Forms.DateTimePicker();
            this.tbSalidasPorFecha = new System.Windows.Forms.TabPage();
            this.btnSalidasPorFecha = new System.Windows.Forms.Button();
            this.dtpSalidasPorFecha = new System.Windows.Forms.DateTimePicker();
            this.tpChoferConMasRutas = new System.Windows.Forms.TabPage();
            this.tpCamionConMasRutas = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnMenu = new System.Windows.Forms.ToolStripButton();
            this.tbtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.dgvChoferes = new System.Windows.Forms.DataGridView();
            this.tclReportes.SuspendLayout();
            this.tpRutasPorFecha.SuspendLayout();
            this.tpRutasPorChofer.SuspendLayout();
            this.tpIngresosPorFecha.SuspendLayout();
            this.tbSalidasPorFecha.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // tclReportes
            // 
            this.tclReportes.Controls.Add(this.tpRutasPorFecha);
            this.tclReportes.Controls.Add(this.tpRutasPorChofer);
            this.tclReportes.Controls.Add(this.tpIngresosPorFecha);
            this.tclReportes.Controls.Add(this.tbSalidasPorFecha);
            this.tclReportes.Controls.Add(this.tpChoferConMasRutas);
            this.tclReportes.Controls.Add(this.tpCamionConMasRutas);
            this.tclReportes.Location = new System.Drawing.Point(0, 34);
            this.tclReportes.Name = "tclReportes";
            this.tclReportes.SelectedIndex = 0;
            this.tclReportes.Size = new System.Drawing.Size(527, 276);
            this.tclReportes.TabIndex = 0;
            // 
            // tpRutasPorFecha
            // 
            this.tpRutasPorFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpRutasPorFecha.Controls.Add(this.btnGenerarRutasPorFecha);
            this.tpRutasPorFecha.Controls.Add(this.dtpRutasPorFecha);
            this.tpRutasPorFecha.Location = new System.Drawing.Point(4, 22);
            this.tpRutasPorFecha.Name = "tpRutasPorFecha";
            this.tpRutasPorFecha.Padding = new System.Windows.Forms.Padding(3);
            this.tpRutasPorFecha.Size = new System.Drawing.Size(519, 112);
            this.tpRutasPorFecha.TabIndex = 0;
            this.tpRutasPorFecha.Text = "Rutas por Fecha";
            // 
            // btnGenerarRutasPorFecha
            // 
            this.btnGenerarRutasPorFecha.Location = new System.Drawing.Point(19, 59);
            this.btnGenerarRutasPorFecha.Name = "btnGenerarRutasPorFecha";
            this.btnGenerarRutasPorFecha.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarRutasPorFecha.TabIndex = 1;
            this.btnGenerarRutasPorFecha.Text = "Generar Informe";
            this.btnGenerarRutasPorFecha.UseVisualStyleBackColor = true;
            //this.btnGenerarRutasPorFecha.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpRutasPorFecha
            // 
            this.dtpRutasPorFecha.Location = new System.Drawing.Point(19, 24);
            this.dtpRutasPorFecha.Name = "dtpRutasPorFecha";
            this.dtpRutasPorFecha.Size = new System.Drawing.Size(228, 20);
            this.dtpRutasPorFecha.TabIndex = 0;
            // 
            // tpRutasPorChofer
            // 
            this.tpRutasPorChofer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpRutasPorChofer.Controls.Add(this.dgvChoferes);
            this.tpRutasPorChofer.Location = new System.Drawing.Point(4, 22);
            this.tpRutasPorChofer.Name = "tpRutasPorChofer";
            this.tpRutasPorChofer.Padding = new System.Windows.Forms.Padding(3);
            this.tpRutasPorChofer.Size = new System.Drawing.Size(519, 250);
            this.tpRutasPorChofer.TabIndex = 1;
            this.tpRutasPorChofer.Text = "Rutas por Chofer";
            // 
            // tpIngresosPorFecha
            // 
            this.tpIngresosPorFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpIngresosPorFecha.Controls.Add(this.btnGenerarIngresosPorFecha);
            this.tpIngresosPorFecha.Controls.Add(this.dtpIngresosPorFecha);
            this.tpIngresosPorFecha.Location = new System.Drawing.Point(4, 22);
            this.tpIngresosPorFecha.Name = "tpIngresosPorFecha";
            this.tpIngresosPorFecha.Size = new System.Drawing.Size(519, 112);
            this.tpIngresosPorFecha.TabIndex = 2;
            this.tpIngresosPorFecha.Text = "Ingresos por Fecha";
            // 
            // btnGenerarIngresosPorFecha
            // 
            this.btnGenerarIngresosPorFecha.Location = new System.Drawing.Point(31, 60);
            this.btnGenerarIngresosPorFecha.Name = "btnGenerarIngresosPorFecha";
            this.btnGenerarIngresosPorFecha.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarIngresosPorFecha.TabIndex = 1;
            this.btnGenerarIngresosPorFecha.Text = "Generar";
            this.btnGenerarIngresosPorFecha.UseVisualStyleBackColor = true;
            //this.btnGenerarIngresosPorFecha.Click += new System.EventHandler(this.btnGenerarIngresosPorFecha_Click);
            // 
            // dtpIngresosPorFecha
            // 
            this.dtpIngresosPorFecha.Location = new System.Drawing.Point(31, 33);
            this.dtpIngresosPorFecha.Name = "dtpIngresosPorFecha";
            this.dtpIngresosPorFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpIngresosPorFecha.TabIndex = 0;
            // 
            // tbSalidasPorFecha
            // 
            this.tbSalidasPorFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSalidasPorFecha.Controls.Add(this.btnSalidasPorFecha);
            this.tbSalidasPorFecha.Controls.Add(this.dtpSalidasPorFecha);
            this.tbSalidasPorFecha.Location = new System.Drawing.Point(4, 22);
            this.tbSalidasPorFecha.Name = "tbSalidasPorFecha";
            this.tbSalidasPorFecha.Size = new System.Drawing.Size(519, 112);
            this.tbSalidasPorFecha.TabIndex = 3;
            this.tbSalidasPorFecha.Text = "Salidas por Fecha";
            // 
            // btnSalidasPorFecha
            // 
            this.btnSalidasPorFecha.Location = new System.Drawing.Point(33, 60);
            this.btnSalidasPorFecha.Name = "btnSalidasPorFecha";
            this.btnSalidasPorFecha.Size = new System.Drawing.Size(75, 23);
            this.btnSalidasPorFecha.TabIndex = 1;
            this.btnSalidasPorFecha.Text = "Generar";
            this.btnSalidasPorFecha.UseVisualStyleBackColor = true;
            //this.btnSalidasPorFecha.Click += new System.EventHandler(this.btnSalidasPorFecha_Click);
            // 
            // dtpSalidasPorFecha
            // 
            this.dtpSalidasPorFecha.Location = new System.Drawing.Point(33, 33);
            this.dtpSalidasPorFecha.Name = "dtpSalidasPorFecha";
            this.dtpSalidasPorFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpSalidasPorFecha.TabIndex = 0;
            // 
            // tpChoferConMasRutas
            // 
            this.tpChoferConMasRutas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpChoferConMasRutas.Location = new System.Drawing.Point(4, 22);
            this.tpChoferConMasRutas.Name = "tpChoferConMasRutas";
            this.tpChoferConMasRutas.Size = new System.Drawing.Size(519, 112);
            this.tpChoferConMasRutas.TabIndex = 4;
            this.tpChoferConMasRutas.Text = "Chofer Con Mas Rutas";
            // 
            // tpCamionConMasRutas
            // 
            this.tpCamionConMasRutas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpCamionConMasRutas.Location = new System.Drawing.Point(4, 22);
            this.tpCamionConMasRutas.Name = "tpCamionConMasRutas";
            this.tpCamionConMasRutas.Size = new System.Drawing.Size(519, 112);
            this.tpCamionConMasRutas.TabIndex = 5;
            this.tpCamionConMasRutas.Text = "Camión Con Mas Rutas";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnMenu,
            this.tbtnCerrarSesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnMenu
            // 
            this.tbtnMenu.Image = global::Proyecto.Properties.Resources.menus;
            this.tbtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMenu.Name = "tbtnMenu";
            this.tbtnMenu.Size = new System.Drawing.Size(58, 22);
            this.tbtnMenu.Text = "Menu";
            this.tbtnMenu.Click += new System.EventHandler(this.tbtnMenu_Click);
            // 
            // tbtnCerrarSesion
            // 
            this.tbtnCerrarSesion.Image = global::Proyecto.Properties.Resources.home;
            this.tbtnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCerrarSesion.Name = "tbtnCerrarSesion";
            this.tbtnCerrarSesion.Size = new System.Drawing.Size(96, 22);
            this.tbtnCerrarSesion.Text = "Cerrar Sesión";
            this.tbtnCerrarSesion.Click += new System.EventHandler(this.tbtnCerrarSesion_Click);
            // 
            // dgvChoferes
            // 
            this.dgvChoferes.AllowUserToAddRows = false;
            this.dgvChoferes.AllowUserToDeleteRows = false;
            this.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChoferes.Location = new System.Drawing.Point(3, 3);
            this.dgvChoferes.Name = "dgvChoferes";
            this.dgvChoferes.ReadOnly = true;
            this.dgvChoferes.Size = new System.Drawing.Size(513, 244);
            this.dgvChoferes.TabIndex = 0;
            //this.dgvChoferes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChoferes_CellDoubleClick);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 315);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tclReportes);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.tclReportes.ResumeLayout(false);
            this.tpRutasPorFecha.ResumeLayout(false);
            this.tpRutasPorChofer.ResumeLayout(false);
            this.tpIngresosPorFecha.ResumeLayout(false);
            this.tbSalidasPorFecha.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tclReportes;
        private System.Windows.Forms.TabPage tpRutasPorFecha;
        private System.Windows.Forms.TabPage tpRutasPorChofer;
        private System.Windows.Forms.Button btnGenerarRutasPorFecha;
        private System.Windows.Forms.DateTimePicker dtpRutasPorFecha;
        private System.Windows.Forms.TabPage tpIngresosPorFecha;
        private System.Windows.Forms.TabPage tbSalidasPorFecha;
        private System.Windows.Forms.TabPage tpChoferConMasRutas;
        private System.Windows.Forms.TabPage tpCamionConMasRutas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnMenu;
        private System.Windows.Forms.ToolStripButton tbtnCerrarSesion;
        private System.Windows.Forms.Button btnGenerarIngresosPorFecha;
        private System.Windows.Forms.DateTimePicker dtpIngresosPorFecha;
        private System.Windows.Forms.Button btnSalidasPorFecha;
        private System.Windows.Forms.DateTimePicker dtpSalidasPorFecha;
        private System.Windows.Forms.DataGridView dgvChoferes;
    }
}