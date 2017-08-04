namespace Presentacion.Menu
{
    partial class MenuADM
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnMantenedores = new System.Windows.Forms.ToolStripDropDownButton();
            this.ciudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoríaMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransacciones = new System.Windows.Forms.ToolStripDropDownButton();
            this.registroEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.generarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnMantenedores,
            this.btnTransacciones,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.btnCerrarSesion});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(541, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "Menu";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tbtnMantenedores
            // 
            this.tbtnMantenedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciudadToolStripMenuItem,
            this.comunaToolStripMenuItem,
            this.modeloToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.camiónToolStripMenuItem,
            this.cargoToolStripMenuItem,
            this.categoríaToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.obraToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.regiónToolStripMenuItem,
            this.rutaToolStripMenuItem1,
            this.subCategoríaMaterialToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.tbtnMantenedores.Image = global::Presentacion.Properties.Resources.menus;
            this.tbtnMantenedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMantenedores.Name = "tbtnMantenedores";
            this.tbtnMantenedores.Size = new System.Drawing.Size(112, 22);
            this.tbtnMantenedores.Text = "Mantenedores";
            // 
            // ciudadToolStripMenuItem
            // 
            this.ciudadToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            this.ciudadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ciudadToolStripMenuItem.Text = "Ciudad";
            this.ciudadToolStripMenuItem.Click += new System.EventHandler(this.ciudadToolStripMenuItem_Click);
            // 
            // comunaToolStripMenuItem
            // 
            this.comunaToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.comunaToolStripMenuItem.Name = "comunaToolStripMenuItem";
            this.comunaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.comunaToolStripMenuItem.Text = "Comuna";
            this.comunaToolStripMenuItem.Click += new System.EventHandler(this.comunaToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.modeloToolStripMenuItem.Text = "Modelo Camión";
            this.modeloToolStripMenuItem.Click += new System.EventHandler(this.modeloToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // camiónToolStripMenuItem
            // 
            this.camiónToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.camiónToolStripMenuItem.Name = "camiónToolStripMenuItem";
            this.camiónToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.camiónToolStripMenuItem.Text = "Camión";
            this.camiónToolStripMenuItem.Click += new System.EventHandler(this.camiónToolStripMenuItem_Click);
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            this.categoríaToolStripMenuItem.Click += new System.EventHandler(this.categoríaToolStripMenuItem_Click_1);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.materialToolStripMenuItem.Text = "Material";
            this.materialToolStripMenuItem.Click += new System.EventHandler(this.materialToolStripMenuItem_Click);
            // 
            // obraToolStripMenuItem
            // 
            this.obraToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            this.obraToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.obraToolStripMenuItem.Text = "Obra";
            this.obraToolStripMenuItem.Click += new System.EventHandler(this.obraToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // regiónToolStripMenuItem
            // 
            this.regiónToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.regiónToolStripMenuItem.Name = "regiónToolStripMenuItem";
            this.regiónToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.regiónToolStripMenuItem.Text = "Región";
            this.regiónToolStripMenuItem.Click += new System.EventHandler(this.regiónToolStripMenuItem_Click_1);
            // 
            // rutaToolStripMenuItem1
            // 
            this.rutaToolStripMenuItem1.Image = global::Presentacion.Properties.Resources.flecha;
            this.rutaToolStripMenuItem1.Name = "rutaToolStripMenuItem1";
            this.rutaToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.rutaToolStripMenuItem1.Text = "Ruta";
            this.rutaToolStripMenuItem1.Click += new System.EventHandler(this.rutaToolStripMenuItem1_Click);
            // 
            // subCategoríaMaterialToolStripMenuItem
            // 
            this.subCategoríaMaterialToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.subCategoríaMaterialToolStripMenuItem.Name = "subCategoríaMaterialToolStripMenuItem";
            this.subCategoríaMaterialToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.subCategoríaMaterialToolStripMenuItem.Text = "Sub Categoría Material";
            this.subCategoríaMaterialToolStripMenuItem.Click += new System.EventHandler(this.subCategoríaMaterialToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroEntradaToolStripMenuItem,
            this.registroSalidaToolStripMenuItem});
            this.btnTransacciones.Image = global::Presentacion.Properties.Resources.menus;
            this.btnTransacciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(110, 22);
            this.btnTransacciones.Text = "Transacciones";
            // 
            // registroEntradaToolStripMenuItem
            // 
            this.registroEntradaToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.registroEntradaToolStripMenuItem.Name = "registroEntradaToolStripMenuItem";
            this.registroEntradaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registroEntradaToolStripMenuItem.Text = "Registro Entrada";
            this.registroEntradaToolStripMenuItem.Click += new System.EventHandler(this.registroEntradaToolStripMenuItem_Click);
            // 
            // registroSalidaToolStripMenuItem
            // 
            this.registroSalidaToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.registroSalidaToolStripMenuItem.Name = "registroSalidaToolStripMenuItem";
            this.registroSalidaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registroSalidaToolStripMenuItem.Text = "Registro Salida";
            this.registroSalidaToolStripMenuItem.Click += new System.EventHandler(this.registroSalidaToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReportesToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Presentacion.Properties.Resources.menus;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripSplitButton1.Text = "Informes";
            // 
            // generarReportesToolStripMenuItem
            // 
            this.generarReportesToolStripMenuItem.Image = global::Presentacion.Properties.Resources.flecha;
            this.generarReportesToolStripMenuItem.Name = "generarReportesToolStripMenuItem";
            this.generarReportesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.generarReportesToolStripMenuItem.Text = "Generar Reportes";
            this.generarReportesToolStripMenuItem.Click += new System.EventHandler(this.generarReportesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = global::Presentacion.Properties.Resources.eliminar;
            this.btnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(96, 22);
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MenuADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 437);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MenuADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Administrador";
            this.Load += new System.EventHandler(this.MenuADM_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 

        private System.Windows.Forms.ToolStripDropDownButton btnTransacciones;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCerrarSesion;
        private System.Windows.Forms.ToolStripDropDownButton tbtnMantenedores;
        private System.Windows.Forms.ToolStripMenuItem ciudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subCategoríaMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem generarReportesToolStripMenuItem;
    }
}