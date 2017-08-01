namespace Presentacion.Pantallas.Menu
{
    partial class MenuUSU
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
            this.btnTransacciones = new System.Windows.Forms.ToolStripDropDownButton();
            this.registroEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroEntradaToolStripMenuItem,
            this.registroSalidaToolStripMenuItem});
            this.btnTransacciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(94, 22);
            this.btnTransacciones.Text = "Transacciones";
            // 
            // registroEntradaToolStripMenuItem
            // 
            this.registroEntradaToolStripMenuItem.Name = "registroEntradaToolStripMenuItem";
            this.registroEntradaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registroEntradaToolStripMenuItem.Text = "Registro Entrada";
            this.registroEntradaToolStripMenuItem.Click += new System.EventHandler(this.registroEntradaToolStripMenuItem_Click);
            // 
            // registroSalidaToolStripMenuItem
            // 
            this.registroSalidaToolStripMenuItem.Name = "registroSalidaToolStripMenuItem";
            this.registroSalidaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registroSalidaToolStripMenuItem.Text = "Registro Salida";
            this.registroSalidaToolStripMenuItem.Click += new System.EventHandler(this.registroSalidaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTransacciones,
            this.toolStripSeparator1,
            this.btnCerrarSesion});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(80, 22);
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MenuUSU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 400);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MenuUSU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Usuarios";
            this.Load += new System.EventHandler(this.MenuUSU_Load);
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
    }
}