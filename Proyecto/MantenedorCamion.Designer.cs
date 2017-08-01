namespace Proyecto
{
    partial class MantenedorCamion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCamion));
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.txtIdCamion = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnBuscarPorPatente = new System.Windows.Forms.Button();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.lblIdCamion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tbtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.tbtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.tbtnMenu = new System.Windows.Forms.ToolStripButton();
            this.btnMenu = new System.Windows.Forms.ToolStripButton();
            this.tclContenedor = new System.Windows.Forms.TabControl();
            this.tbpFormulario = new System.Windows.Forms.TabPage();
            this.tbpDatos = new System.Windows.Forms.TabPage();
            this.dgvCamion = new System.Windows.Forms.DataGridView();
            this.gpbInformacion.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tclContenedor.SuspendLayout();
            this.tbpFormulario.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(21, 49);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Patente";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(21, 75);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(21, 102);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(78, 49);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(195, 20);
            this.txtPatente.TabIndex = 3;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(78, 75);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(195, 21);
            this.cmbMarca.TabIndex = 4;
            this.cmbMarca.TextChanged += new System.EventHandler(this.cmbMarca_TextChanged);
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(78, 102);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(195, 21);
            this.cmbModelo.TabIndex = 5;
            this.cmbModelo.TextChanged += new System.EventHandler(this.cmbModelo_TextChanged);
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.txtIdCamion);
            this.gpbInformacion.Controls.Add(this.txtModelo);
            this.gpbInformacion.Controls.Add(this.txtMarca);
            this.gpbInformacion.Controls.Add(this.btnBuscarPorPatente);
            this.gpbInformacion.Controls.Add(this.btnBuscarPorId);
            this.gpbInformacion.Controls.Add(this.lblIdCamion);
            this.gpbInformacion.Controls.Add(this.lblModelo);
            this.gpbInformacion.Controls.Add(this.lblPatente);
            this.gpbInformacion.Controls.Add(this.lblMarca);
            this.gpbInformacion.Controls.Add(this.txtPatente);
            this.gpbInformacion.Controls.Add(this.cmbMarca);
            this.gpbInformacion.Controls.Add(this.cmbModelo);
            this.gpbInformacion.Location = new System.Drawing.Point(6, 6);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(590, 139);
            this.gpbInformacion.TabIndex = 8;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Información";
            // 
            // txtIdCamion
            // 
            this.txtIdCamion.Location = new System.Drawing.Point(78, 23);
            this.txtIdCamion.Name = "txtIdCamion";
            this.txtIdCamion.Size = new System.Drawing.Size(195, 20);
            this.txtIdCamion.TabIndex = 16;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(279, 104);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(117, 20);
            this.txtModelo.TabIndex = 15;
            this.txtModelo.Visible = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(279, 78);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(117, 20);
            this.txtMarca.TabIndex = 14;
            this.txtMarca.Visible = false;
            // 
            // btnBuscarPorPatente
            // 
            this.btnBuscarPorPatente.Location = new System.Drawing.Point(279, 49);
            this.btnBuscarPorPatente.Name = "btnBuscarPorPatente";
            this.btnBuscarPorPatente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorPatente.TabIndex = 14;
            this.btnBuscarPorPatente.Text = "Buscar";
            this.btnBuscarPorPatente.UseVisualStyleBackColor = true;
            this.btnBuscarPorPatente.Click += new System.EventHandler(this.btnBuscarPorPatente_Click);
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(279, 20);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorId.TabIndex = 13;
            this.btnBuscarPorId.Text = "Buscar";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblIdCamion
            // 
            this.lblIdCamion.AutoSize = true;
            this.lblIdCamion.Location = new System.Drawing.Point(24, 29);
            this.lblIdCamion.Name = "lblIdCamion";
            this.lblIdCamion.Size = new System.Drawing.Size(18, 13);
            this.lblIdCamion.TabIndex = 9;
            this.lblIdCamion.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(22, 249);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(144, 20);
            this.txtId.TabIndex = 7;
            // 
            // tbtnNuevo
            // 
            this.tbtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tbtnNuevo.Image")));
            this.tbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNuevo.Name = "tbtnNuevo";
            this.tbtnNuevo.Size = new System.Drawing.Size(62, 22);
            this.tbtnNuevo.Text = "Nuevo";
            // 
            // tbtnGuardar
            // 
            this.tbtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnGuardar.Image")));
            this.tbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGuardar.Name = "tbtnGuardar";
            this.tbtnGuardar.Size = new System.Drawing.Size(69, 22);
            this.tbtnGuardar.Text = "Guardar";
            // 
            // tbtnEliminar
            // 
            this.tbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEliminar.Image")));
            this.tbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEliminar.Name = "tbtnEliminar";
            this.tbtnEliminar.Size = new System.Drawing.Size(70, 22);
            this.tbtnEliminar.Text = "Eliminar";
            // 
            // tbtnCancelar
            // 
            this.tbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCancelar.Image")));
            this.tbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCancelar.Name = "tbtnCancelar";
            this.tbtnCancelar.Size = new System.Drawing.Size(73, 22);
            this.tbtnCancelar.Text = "Cancelar";
            // 
            // tbtnActualizar
            // 
            this.tbtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnActualizar.Image")));
            this.tbtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnActualizar.Name = "tbtnActualizar";
            this.tbtnActualizar.Size = new System.Drawing.Size(79, 22);
            this.tbtnActualizar.Text = "Actualizar";
            // 
            // tbtnBuscar
            // 
            this.tbtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnBuscar.Image")));
            this.tbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnBuscar.Name = "tbtnBuscar";
            this.tbtnBuscar.Size = new System.Drawing.Size(62, 22);
            this.tbtnBuscar.Text = "Buscar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnCerrarSesion
            // 
            this.tbtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCerrarSesion.Image")));
            this.tbtnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnCerrarSesion.Name = "tbtnCerrarSesion";
            this.tbtnCerrarSesion.Size = new System.Drawing.Size(96, 22);
            this.tbtnCerrarSesion.Text = "Cerrar Sesión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 20);
            this.toolStripButton1.Text = "Menú";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.btnCancelar,
            this.btnActualizar,
            this.btnBuscar,
            this.tbtnMenu,
            this.btnMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Proyecto.Properties.Resources.mas;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Proyecto.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Proyecto.Properties.Resources.menos;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Proyecto.Properties.Resources.eliminar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::Proyecto.Properties.Resources.editar;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Proyecto.Properties.Resources.busqueda;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
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
            // btnMenu
            // 
            this.btnMenu.Image = global::Proyecto.Properties.Resources.home;
            this.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(96, 22);
            this.btnMenu.Text = "Cerrar Sesión";
            this.btnMenu.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // tclContenedor
            // 
            this.tclContenedor.Controls.Add(this.tbpFormulario);
            this.tclContenedor.Controls.Add(this.tbpDatos);
            this.tclContenedor.Location = new System.Drawing.Point(12, 28);
            this.tclContenedor.Name = "tclContenedor";
            this.tclContenedor.SelectedIndex = 0;
            this.tclContenedor.Size = new System.Drawing.Size(610, 181);
            this.tclContenedor.TabIndex = 16;
            // 
            // tbpFormulario
            // 
            this.tbpFormulario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpFormulario.Controls.Add(this.gpbInformacion);
            this.tbpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tbpFormulario.Name = "tbpFormulario";
            this.tbpFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFormulario.Size = new System.Drawing.Size(602, 155);
            this.tbpFormulario.TabIndex = 0;
            this.tbpFormulario.Text = "Formulario";
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.dgvCamion);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(602, 155);
            this.tbpDatos.TabIndex = 1;
            this.tbpDatos.Text = "Vista Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // dgvCamion
            // 
            this.dgvCamion.AllowUserToAddRows = false;
            this.dgvCamion.AllowUserToDeleteRows = false;
            this.dgvCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCamion.Location = new System.Drawing.Point(3, 3);
            this.dgvCamion.Name = "dgvCamion";
            this.dgvCamion.ReadOnly = true;
            this.dgvCamion.Size = new System.Drawing.Size(596, 149);
            this.dgvCamion.TabIndex = 0;
            // 
            // MantenedorCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 222);
            this.Controls.Add(this.tclContenedor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtId);
            this.Name = "MantenedorCamion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Camion";
            this.Load += new System.EventHandler(this.MantenedorCamion_Load);
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tclContenedor.ResumeLayout(false);
            this.tbpFormulario.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdCamion;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Button btnBuscarPorPatente;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.MaskedTextBox txtIdCamion;
        private System.Windows.Forms.ToolStripButton tbtnNuevo;
        private System.Windows.Forms.ToolStripButton tbtnGuardar;
        private System.Windows.Forms.ToolStripButton tbtnEliminar;
        private System.Windows.Forms.ToolStripButton tbtnCancelar;
        private System.Windows.Forms.ToolStripButton tbtnActualizar;
        private System.Windows.Forms.ToolStripButton tbtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnCerrarSesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton tbtnMenu;
        private System.Windows.Forms.ToolStripButton btnMenu;
        private System.Windows.Forms.TabControl tclContenedor;
        private System.Windows.Forms.TabPage tbpFormulario;
        private System.Windows.Forms.TabPage tbpDatos;
        private System.Windows.Forms.DataGridView dgvCamion;
    }
}