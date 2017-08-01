namespace Presentacion.Pantallas.MantenedorUsuarios
{
    partial class MantenedorUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.seguridadDataSet = new Proyecto.SeguridadDataSet();
            this.label6 = new System.Windows.Forms.Label();
            //this.tipoUsuarioTableAdapter = new Proyecto.SeguridadDataSetTableAdapters.TipoUsuarioTableAdapter();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tclMantenedorUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tbtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.tbtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.seguridadDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tclMantenedorUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataSource = this.tipoUsuarioBindingSource;
            this.cmbTipo.DisplayMember = "tipo";
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(185, 156);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(181, 21);
            this.cmbTipo.TabIndex = 10;
            this.cmbTipo.ValueMember = "tipo";
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataMember = "TipoUsuario";
            //this.tipoUsuarioBindingSource.DataSource = this.seguridadDataSet;
            // 
            // seguridadDataSet
            // 
            //this.seguridadDataSet.DataSetName = "SeguridadDataSet";
            //this.seguridadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirme Password";
            // 
            // tipoUsuarioTableAdapter
            // 
            //this.tipoUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(185, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(185, 71);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(181, 20);
            this.txtUser.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(186, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 16;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(184, 123);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(182, 20);
            this.txtConfirmar.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(382, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 20);
            this.txtId.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(23, 197);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtConfirmar);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 235);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID Usuario";
            // 
            // tclMantenedorUsuarios
            // 
            this.tclMantenedorUsuarios.Controls.Add(this.tabPage1);
            this.tclMantenedorUsuarios.Controls.Add(this.tabPage3);
            this.tclMantenedorUsuarios.Location = new System.Drawing.Point(12, 40);
            this.tclMantenedorUsuarios.Multiline = true;
            this.tclMantenedorUsuarios.Name = "tclMantenedorUsuarios";
            this.tclMantenedorUsuarios.SelectedIndex = 0;
            this.tclMantenedorUsuarios.Size = new System.Drawing.Size(577, 368);
            this.tclMantenedorUsuarios.TabIndex = 26;
            this.tclMantenedorUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tclMantenedorUsuarios_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Formulario";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.tbtnCerrarSesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "Menu";
            // 
            // tbtnNuevo
            // 
            this.tbtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tbtnNuevo.Image")));
            this.tbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNuevo.Name = "tbtnNuevo";
            this.tbtnNuevo.Size = new System.Drawing.Size(62, 22);
            this.tbtnNuevo.Text = "Nuevo";
            this.tbtnNuevo.Click += new System.EventHandler(this.tbtnNuevo_Click);
            // 
            // tbtnGuardar
            // 
            this.tbtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnGuardar.Image")));
            this.tbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGuardar.Name = "tbtnGuardar";
            this.tbtnGuardar.Size = new System.Drawing.Size(69, 22);
            this.tbtnGuardar.Text = "Guardar";
            this.tbtnGuardar.Click += new System.EventHandler(this.tbtnGuardar_Click);
            // 
            // tbtnEliminar
            // 
            this.tbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEliminar.Image")));
            this.tbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEliminar.Name = "tbtnEliminar";
            this.tbtnEliminar.Size = new System.Drawing.Size(70, 22);
            this.tbtnEliminar.Text = "Eliminar";
            this.tbtnEliminar.Click += new System.EventHandler(this.tbtnEliminar_Click);
            // 
            // tbtnCancelar
            // 
            this.tbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCancelar.Image")));
            this.tbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCancelar.Name = "tbtnCancelar";
            this.tbtnCancelar.Size = new System.Drawing.Size(73, 22);
            this.tbtnCancelar.Text = "Cancelar";
            this.tbtnCancelar.Click += new System.EventHandler(this.tbtnCancelar_Click);
            // 
            // tbtnActualizar
            // 
            this.tbtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnActualizar.Image")));
            this.tbtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnActualizar.Name = "tbtnActualizar";
            this.tbtnActualizar.Size = new System.Drawing.Size(79, 22);
            this.tbtnActualizar.Text = "Actualizar";
            this.tbtnActualizar.Click += new System.EventHandler(this.tbtnActualizar_Click);
            // 
            // tbtnBuscar
            // 
            this.tbtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnBuscar.Image")));
            this.tbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnBuscar.Name = "tbtnBuscar";
            this.tbtnBuscar.Size = new System.Drawing.Size(62, 22);
            this.tbtnBuscar.Text = "Buscar";
            this.tbtnBuscar.Click += new System.EventHandler(this.tbtnBuscar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton1.Text = "Menú";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnCerrarSesion
            // 
            this.tbtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCerrarSesion.Image")));
            this.tbtnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCerrarSesion.Name = "tbtnCerrarSesion";
            this.tbtnCerrarSesion.Size = new System.Drawing.Size(96, 22);
            this.tbtnCerrarSesion.Text = "Cerrar Sesión";
            this.tbtnCerrarSesion.Click += new System.EventHandler(this.tbtnCerrarSesion_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvPersonas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(569, 342);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Vista Datos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonas.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.Size = new System.Drawing.Size(569, 342);
            this.dgvPersonas.TabIndex = 0;
            // 
            // MantenedorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 420);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tclMantenedorUsuarios);
            this.Name = "MantenedorUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenedorUsuarios";
            this.Load += new System.EventHandler(this.MantenedorUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.seguridadDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tclMantenedorUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label6;
        //private SeguridadDataSet seguridadDataSet;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        //private SeguridadDataSetTableAdapters.TipoUsuarioTableAdapter tipoUsuarioTableAdapter;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tclMantenedorUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnGuardar;
        private System.Windows.Forms.ToolStripButton tbtnEliminar;
        private System.Windows.Forms.ToolStripButton tbtnActualizar;
        private System.Windows.Forms.ToolStripButton tbtnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnCerrarSesion;
        private System.Windows.Forms.ToolStripButton tbtnCancelar;
        private System.Windows.Forms.ToolStripButton tbtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPersonas;
    }
}