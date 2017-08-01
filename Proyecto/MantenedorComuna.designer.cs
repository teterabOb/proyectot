namespace Proyecto
{
    public partial class MantenedorComuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNombreRegion = new System.Windows.Forms.ComboBox();
            this.txtCodigoRegion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNombreCiudad = new System.Windows.Forms.ComboBox();
            this.txtCodigoCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarComuna = new System.Windows.Forms.Button();
            this.txtNombreComuna = new System.Windows.Forms.TextBox();
            this.txtCodigoComuna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tbtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.tbtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.tbtnMenu = new System.Windows.Forms.ToolStripButton();
            this.tbtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.tclContenedor = new System.Windows.Forms.TabControl();
            this.tbpFormulario = new System.Windows.Forms.TabPage();
            this.tbpDatos = new System.Windows.Forms.TabPage();
            this.dgvComuna = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tclContenedor.SuspendLayout();
            this.tbpFormulario.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComuna)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNombreRegion);
            this.groupBox2.Controls.Add(this.txtCodigoRegion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 79);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Región";
            // 
            // cmbNombreRegion
            // 
            this.cmbNombreRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreRegion.FormattingEnabled = true;
            this.cmbNombreRegion.Location = new System.Drawing.Point(139, 13);
            this.cmbNombreRegion.Name = "cmbNombreRegion";
            this.cmbNombreRegion.Size = new System.Drawing.Size(191, 21);
            this.cmbNombreRegion.TabIndex = 7;
            this.cmbNombreRegion.TextChanged += new System.EventHandler(this.cmbNombreRegion_TextChanged);
            // 
            // txtCodigoRegion
            // 
            this.txtCodigoRegion.Location = new System.Drawing.Point(139, 40);
            this.txtCodigoRegion.Name = "txtCodigoRegion";
            this.txtCodigoRegion.Size = new System.Drawing.Size(191, 20);
            this.txtCodigoRegion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNombreCiudad);
            this.groupBox1.Controls.Add(this.txtCodigoCiudad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Ciudad";
            // 
            // cmbNombreCiudad
            // 
            this.cmbNombreCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCiudad.FormattingEnabled = true;
            this.cmbNombreCiudad.Location = new System.Drawing.Point(139, 32);
            this.cmbNombreCiudad.Name = "cmbNombreCiudad";
            this.cmbNombreCiudad.Size = new System.Drawing.Size(191, 21);
            this.cmbNombreCiudad.TabIndex = 8;
            this.cmbNombreCiudad.TextChanged += new System.EventHandler(this.cmbNombreCiudad_TextChanged);
            // 
            // txtCodigoCiudad
            // 
            this.txtCodigoCiudad.Location = new System.Drawing.Point(139, 58);
            this.txtCodigoCiudad.Name = "txtCodigoCiudad";
            this.txtCodigoCiudad.Size = new System.Drawing.Size(191, 20);
            this.txtCodigoCiudad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarComuna);
            this.groupBox3.Controls.Add(this.txtNombreComuna);
            this.groupBox3.Controls.Add(this.txtCodigoComuna);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 79);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Comuna";
            // 
            // btnBuscarComuna
            // 
            this.btnBuscarComuna.Location = new System.Drawing.Point(336, 37);
            this.btnBuscarComuna.Name = "btnBuscarComuna";
            this.btnBuscarComuna.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarComuna.TabIndex = 10;
            this.btnBuscarComuna.Text = "Buscar";
            this.btnBuscarComuna.UseVisualStyleBackColor = true;
            this.btnBuscarComuna.Visible = false;
            this.btnBuscarComuna.Click += new System.EventHandler(this.btnBuscarComuna_Click);
            // 
            // txtNombreComuna
            // 
            this.txtNombreComuna.Location = new System.Drawing.Point(139, 14);
            this.txtNombreComuna.Name = "txtNombreComuna";
            this.txtNombreComuna.Size = new System.Drawing.Size(191, 20);
            this.txtNombreComuna.TabIndex = 7;
            // 
            // txtCodigoComuna
            // 
            this.txtCodigoComuna.Location = new System.Drawing.Point(139, 40);
            this.txtCodigoComuna.Name = "txtCodigoComuna";
            this.txtCodigoComuna.Size = new System.Drawing.Size(191, 20);
            this.txtCodigoComuna.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnNuevo,
            this.tbtnGuardar,
            this.tbtnEliminar,
            this.tbtnCancelar,
            this.tbtnActualizar,
            this.tbtnBuscar,
            this.tbtnMenu,
            this.tbtnCerrarSesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(585, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnNuevo
            // 
            this.tbtnNuevo.Image = global::Proyecto.Properties.Resources.mas;
            this.tbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNuevo.Name = "tbtnNuevo";
            this.tbtnNuevo.Size = new System.Drawing.Size(62, 22);
            this.tbtnNuevo.Text = "Nuevo";
            // 
            // tbtnGuardar
            // 
            this.tbtnGuardar.Image = global::Proyecto.Properties.Resources.guardar;
            this.tbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGuardar.Name = "tbtnGuardar";
            this.tbtnGuardar.Size = new System.Drawing.Size(69, 22);
            this.tbtnGuardar.Text = "Guardar";
            this.tbtnGuardar.Click += new System.EventHandler(this.tbtnGuardar_Click);
            // 
            // tbtnEliminar
            // 
            this.tbtnEliminar.Image = global::Proyecto.Properties.Resources.menos;
            this.tbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEliminar.Name = "tbtnEliminar";
            this.tbtnEliminar.Size = new System.Drawing.Size(70, 22);
            this.tbtnEliminar.Text = "Eliminar";
            this.tbtnEliminar.Click += new System.EventHandler(this.tbtnEliminar_Click);
            // 
            // tbtnCancelar
            // 
            this.tbtnCancelar.Image = global::Proyecto.Properties.Resources.eliminar;
            this.tbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCancelar.Name = "tbtnCancelar";
            this.tbtnCancelar.Size = new System.Drawing.Size(73, 22);
            this.tbtnCancelar.Text = "Cancelar";
            // 
            // tbtnActualizar
            // 
            this.tbtnActualizar.Image = global::Proyecto.Properties.Resources.editar;
            this.tbtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnActualizar.Name = "tbtnActualizar";
            this.tbtnActualizar.Size = new System.Drawing.Size(79, 22);
            this.tbtnActualizar.Text = "Actualizar";
            this.tbtnActualizar.Click += new System.EventHandler(this.tbtnActualizar_Click);
            // 
            // tbtnBuscar
            // 
            this.tbtnBuscar.Image = global::Proyecto.Properties.Resources.busqueda;
            this.tbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnBuscar.Name = "tbtnBuscar";
            this.tbtnBuscar.Size = new System.Drawing.Size(62, 22);
            this.tbtnBuscar.Text = "Buscar";
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
            // tclContenedor
            // 
            this.tclContenedor.Controls.Add(this.tbpFormulario);
            this.tclContenedor.Controls.Add(this.tbpDatos);
            this.tclContenedor.Location = new System.Drawing.Point(12, 28);
            this.tclContenedor.Name = "tclContenedor";
            this.tclContenedor.SelectedIndex = 0;
            this.tclContenedor.Size = new System.Drawing.Size(566, 304);
            this.tclContenedor.TabIndex = 18;
            // 
            // tbpFormulario
            // 
            this.tbpFormulario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpFormulario.Controls.Add(this.groupBox2);
            this.tbpFormulario.Controls.Add(this.groupBox1);
            this.tbpFormulario.Controls.Add(this.groupBox3);
            this.tbpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tbpFormulario.Name = "tbpFormulario";
            this.tbpFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFormulario.Size = new System.Drawing.Size(558, 278);
            this.tbpFormulario.TabIndex = 0;
            this.tbpFormulario.Text = "Formulario";
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.dgvComuna);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(558, 278);
            this.tbpDatos.TabIndex = 1;
            this.tbpDatos.Text = "Vista Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // dgvComuna
            // 
            this.dgvComuna.AllowUserToAddRows = false;
            this.dgvComuna.AllowUserToDeleteRows = false;
            this.dgvComuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComuna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComuna.Location = new System.Drawing.Point(3, 3);
            this.dgvComuna.Name = "dgvComuna";
            this.dgvComuna.ReadOnly = true;
            this.dgvComuna.Size = new System.Drawing.Size(552, 272);
            this.dgvComuna.TabIndex = 0;
            // 
            // MantenedorComuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.tclContenedor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MantenedorComuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenedorComuna";
            this.Load += new System.EventHandler(this.MantenedorComuna_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tclContenedor.ResumeLayout(false);
            this.tbpFormulario.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbNombreRegion;
        private System.Windows.Forms.TextBox txtCodigoRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNombreCiudad;
        private System.Windows.Forms.TextBox txtCodigoCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombreComuna;
        private System.Windows.Forms.TextBox txtCodigoComuna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarComuna;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnNuevo;
        private System.Windows.Forms.ToolStripButton tbtnGuardar;
        private System.Windows.Forms.ToolStripButton tbtnEliminar;
        private System.Windows.Forms.ToolStripButton tbtnCancelar;
        private System.Windows.Forms.ToolStripButton tbtnActualizar;
        private System.Windows.Forms.ToolStripButton tbtnBuscar;
        private System.Windows.Forms.ToolStripButton tbtnMenu;
        private System.Windows.Forms.ToolStripButton tbtnCerrarSesion;
        private System.Windows.Forms.TabControl tclContenedor;
        private System.Windows.Forms.TabPage tbpFormulario;
        private System.Windows.Forms.TabPage tbpDatos;
        private System.Windows.Forms.DataGridView dgvComuna;

    }
}