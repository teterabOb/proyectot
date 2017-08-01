namespace Presentacion.Pantallas.Mantenedores
{
    partial class MantenedorPersonal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorRut = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdComuna = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbNombreComuna = new System.Windows.Forms.ComboBox();
            this.cmbNombreCiudad = new System.Windows.Forms.ComboBox();
            this.cmbNombreRegion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbInterna = new System.Windows.Forms.GroupBox();
            this.txtIdCargo = new System.Windows.Forms.TextBox();
            this.cmbNombreCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
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
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbInterna.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tclContenedor.SuspendLayout();
            this.tbpFormulario.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPorRut);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtMaterno);
            this.groupBox1.Controls.Add(this.txtPaterno);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblMaterno);
            this.groupBox1.Controls.Add(this.lblPaterno);
            this.groupBox1.Controls.Add(this.lblRut);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // btnBuscarPorRut
            // 
            this.btnBuscarPorRut.Location = new System.Drawing.Point(329, 19);
            this.btnBuscarPorRut.Name = "btnBuscarPorRut";
            this.btnBuscarPorRut.Size = new System.Drawing.Size(72, 23);
            this.btnBuscarPorRut.TabIndex = 10;
            this.btnBuscarPorRut.Text = "Buscar";
            this.btnBuscarPorRut.UseVisualStyleBackColor = true;
            this.btnBuscarPorRut.Click += new System.EventHandler(this.btnBuscarPorRut_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(128, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(194, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(129, 97);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(194, 20);
            this.txtMaterno.TabIndex = 8;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(128, 71);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(194, 20);
            this.txtPaterno.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(128, 19);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(194, 20);
            this.txtRut.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(33, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(33, 104);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblMaterno.TabIndex = 3;
            this.lblMaterno.Text = "Apellido Materno";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(33, 78);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblPaterno.TabIndex = 2;
            this.lblPaterno.Text = "Apellido Paterno";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(38, 26);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(30, 13);
            this.lblRut.TabIndex = 1;
            this.lblRut.Text = "RUT";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdComuna);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.cmbNombreComuna);
            this.groupBox2.Controls.Add(this.cmbNombreCiudad);
            this.groupBox2.Controls.Add(this.cmbNombreRegion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // txtIdComuna
            // 
            this.txtIdComuna.Location = new System.Drawing.Point(329, 81);
            this.txtIdComuna.Name = "txtIdComuna";
            this.txtIdComuna.Size = new System.Drawing.Size(100, 20);
            this.txtIdComuna.TabIndex = 8;
            this.txtIdComuna.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 109);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(194, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // cmbNombreComuna
            // 
            this.cmbNombreComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreComuna.FormattingEnabled = true;
            this.cmbNombreComuna.Location = new System.Drawing.Point(129, 80);
            this.cmbNombreComuna.Name = "cmbNombreComuna";
            this.cmbNombreComuna.Size = new System.Drawing.Size(194, 21);
            this.cmbNombreComuna.TabIndex = 6;
            this.cmbNombreComuna.TextChanged += new System.EventHandler(this.cmbNombreComuna_TextChanged);
            // 
            // cmbNombreCiudad
            // 
            this.cmbNombreCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCiudad.FormattingEnabled = true;
            this.cmbNombreCiudad.Location = new System.Drawing.Point(129, 53);
            this.cmbNombreCiudad.Name = "cmbNombreCiudad";
            this.cmbNombreCiudad.Size = new System.Drawing.Size(194, 21);
            this.cmbNombreCiudad.TabIndex = 5;
            this.cmbNombreCiudad.TextChanged += new System.EventHandler(this.cmbNombreCiudad_TextChanged);
            // 
            // cmbNombreRegion
            // 
            this.cmbNombreRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreRegion.FormattingEnabled = true;
            this.cmbNombreRegion.Location = new System.Drawing.Point(129, 26);
            this.cmbNombreRegion.Name = "cmbNombreRegion";
            this.cmbNombreRegion.Size = new System.Drawing.Size(194, 21);
            this.cmbNombreRegion.TabIndex = 4;
            this.cmbNombreRegion.TextChanged += new System.EventHandler(this.cmbNombreRegion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comuna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Región";
            // 
            // gpbInterna
            // 
            this.gpbInterna.Controls.Add(this.txtIdCargo);
            this.gpbInterna.Controls.Add(this.cmbNombreCargo);
            this.gpbInterna.Controls.Add(this.lblCargo);
            this.gpbInterna.Location = new System.Drawing.Point(12, 325);
            this.gpbInterna.Name = "gpbInterna";
            this.gpbInterna.Size = new System.Drawing.Size(511, 77);
            this.gpbInterna.TabIndex = 2;
            this.gpbInterna.TabStop = false;
            this.gpbInterna.Text = "Información Interna";
            // 
            // txtIdCargo
            // 
            this.txtIdCargo.Location = new System.Drawing.Point(329, 29);
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.Size = new System.Drawing.Size(100, 20);
            this.txtIdCargo.TabIndex = 2;
            this.txtIdCargo.Visible = false;
            // 
            // cmbNombreCargo
            // 
            this.cmbNombreCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCargo.FormattingEnabled = true;
            this.cmbNombreCargo.Location = new System.Drawing.Point(129, 28);
            this.cmbNombreCargo.Name = "cmbNombreCargo";
            this.cmbNombreCargo.Size = new System.Drawing.Size(194, 21);
            this.cmbNombreCargo.TabIndex = 1;
            this.cmbNombreCargo.TextChanged += new System.EventHandler(this.cmbNombreCargo_TextChanged);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(33, 36);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Cargo";
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
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnNuevo
            // 
            this.tbtnNuevo.Image = global::Presentacion.Properties.Resources.mas;
            this.tbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNuevo.Name = "tbtnNuevo";
            this.tbtnNuevo.Size = new System.Drawing.Size(62, 22);
            this.tbtnNuevo.Text = "Nuevo";
            // 
            // tbtnGuardar
            // 
            this.tbtnGuardar.Image = global::Presentacion.Properties.Resources.guardar;
            this.tbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGuardar.Name = "tbtnGuardar";
            this.tbtnGuardar.Size = new System.Drawing.Size(69, 22);
            this.tbtnGuardar.Text = "Guardar";
            this.tbtnGuardar.Click += new System.EventHandler(this.tbtnGuardar_Click);
            // 
            // tbtnEliminar
            // 
            this.tbtnEliminar.Image = global::Presentacion.Properties.Resources.menos;
            this.tbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEliminar.Name = "tbtnEliminar";
            this.tbtnEliminar.Size = new System.Drawing.Size(70, 22);
            this.tbtnEliminar.Text = "Eliminar";
            this.tbtnEliminar.Click += new System.EventHandler(this.tbtnEliminar_Click);
            // 
            // tbtnCancelar
            // 
            this.tbtnCancelar.Image = global::Presentacion.Properties.Resources.eliminar;
            this.tbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCancelar.Name = "tbtnCancelar";
            this.tbtnCancelar.Size = new System.Drawing.Size(73, 22);
            this.tbtnCancelar.Text = "Cancelar";
            // 
            // tbtnActualizar
            // 
            this.tbtnActualizar.Image = global::Presentacion.Properties.Resources.editar;
            this.tbtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnActualizar.Name = "tbtnActualizar";
            this.tbtnActualizar.Size = new System.Drawing.Size(79, 22);
            this.tbtnActualizar.Text = "Actualizar";
            this.tbtnActualizar.Click += new System.EventHandler(this.tbtnActualizar_Click);
            // 
            // tbtnBuscar
            // 
            this.tbtnBuscar.Image = global::Presentacion.Properties.Resources.busqueda;
            this.tbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnBuscar.Name = "tbtnBuscar";
            this.tbtnBuscar.Size = new System.Drawing.Size(62, 22);
            this.tbtnBuscar.Text = "Buscar";
            // 
            // tbtnMenu
            // 
            this.tbtnMenu.Image = global::Presentacion.Properties.Resources.menus;
            this.tbtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMenu.Name = "tbtnMenu";
            this.tbtnMenu.Size = new System.Drawing.Size(58, 22);
            this.tbtnMenu.Text = "Menu";
            this.tbtnMenu.Click += new System.EventHandler(this.tbtnMenu_Click);
            // 
            // tbtnCerrarSesion
            // 
            this.tbtnCerrarSesion.Image = global::Presentacion.Properties.Resources.home;
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
            this.tclContenedor.Location = new System.Drawing.Point(12, 31);
            this.tclContenedor.Name = "tclContenedor";
            this.tclContenedor.SelectedIndex = 0;
            this.tclContenedor.Size = new System.Drawing.Size(569, 451);
            this.tclContenedor.TabIndex = 17;
            // 
            // tbpFormulario
            // 
            this.tbpFormulario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpFormulario.Controls.Add(this.groupBox1);
            this.tbpFormulario.Controls.Add(this.gpbInterna);
            this.tbpFormulario.Controls.Add(this.groupBox2);
            this.tbpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tbpFormulario.Name = "tbpFormulario";
            this.tbpFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFormulario.Size = new System.Drawing.Size(561, 425);
            this.tbpFormulario.TabIndex = 0;
            this.tbpFormulario.Text = "Formulario";
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.dgvPersonal);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(561, 425);
            this.tbpDatos.TabIndex = 1;
            this.tbpDatos.Text = "Vista Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonal.Location = new System.Drawing.Point(3, 3);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.Size = new System.Drawing.Size(555, 419);
            this.dgvPersonal.TabIndex = 0;
            // 
            // MantenedorPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 494);
            this.Controls.Add(this.tclContenedor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MantenedorPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenedorPersonal";
            this.Load += new System.EventHandler(this.MantenedorPersonal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbInterna.ResumeLayout(false);
            this.gpbInterna.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tclContenedor.ResumeLayout(false);
            this.tbpFormulario.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbNombreComuna;
        private System.Windows.Forms.ComboBox cmbNombreCiudad;
        private System.Windows.Forms.ComboBox cmbNombreRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbInterna;
        private System.Windows.Forms.ComboBox cmbNombreCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtIdComuna;
        private System.Windows.Forms.TextBox txtIdCargo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnNuevo;
        private System.Windows.Forms.ToolStripButton tbtnGuardar;
        private System.Windows.Forms.ToolStripButton tbtnEliminar;
        private System.Windows.Forms.ToolStripButton tbtnCancelar;
        private System.Windows.Forms.ToolStripButton tbtnActualizar;
        private System.Windows.Forms.ToolStripButton tbtnBuscar;
        private System.Windows.Forms.ToolStripButton tbtnMenu;
        private System.Windows.Forms.ToolStripButton tbtnCerrarSesion;
        private System.Windows.Forms.Button btnBuscarPorRut;
        private System.Windows.Forms.TabControl tclContenedor;
        private System.Windows.Forms.TabPage tbpFormulario;
        private System.Windows.Forms.TabPage tbpDatos;
        private System.Windows.Forms.DataGridView dgvPersonal;
    }
}