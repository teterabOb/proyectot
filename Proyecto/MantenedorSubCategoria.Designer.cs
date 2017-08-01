namespace Proyecto
{
    partial class MantenedorSubCategoria
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
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
            this.dgvSubCategoria = new System.Windows.Forms.DataGridView();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tclContenedor.SuspendLayout();
            this.tbpFormulario.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPorId);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(118, 110);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(172, 21);
            this.cmbCategoria.TabIndex = 7;
            this.cmbCategoria.TextChanged += new System.EventHandler(this.cmbCategoria_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(49, 118);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(118, 84);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(172, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 20);
            this.txtId.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(49, 91);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(49, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(131, 257);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(172, 20);
            this.txtIdCategoria.TabIndex = 8;
            this.txtIdCategoria.Visible = false;
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
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 13;
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
            this.tclContenedor.Size = new System.Drawing.Size(578, 185);
            this.tclContenedor.TabIndex = 17;
            // 
            // tbpFormulario
            // 
            this.tbpFormulario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpFormulario.Controls.Add(this.groupBox1);
            this.tbpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tbpFormulario.Name = "tbpFormulario";
            this.tbpFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFormulario.Size = new System.Drawing.Size(570, 159);
            this.tbpFormulario.TabIndex = 0;
            this.tbpFormulario.Text = "Formulario";
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.dgvSubCategoria);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(570, 159);
            this.tbpDatos.TabIndex = 1;
            this.tbpDatos.Text = "Vista Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // dgvSubCategoria
            // 
            this.dgvSubCategoria.AllowUserToAddRows = false;
            this.dgvSubCategoria.AllowUserToDeleteRows = false;
            this.dgvSubCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubCategoria.Location = new System.Drawing.Point(3, 3);
            this.dgvSubCategoria.Name = "dgvSubCategoria";
            this.dgvSubCategoria.ReadOnly = true;
            this.dgvSubCategoria.Size = new System.Drawing.Size(564, 153);
            this.dgvSubCategoria.TabIndex = 0;
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(307, 28);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorId.TabIndex = 8;
            this.btnBuscarPorId.Text = "Buscar";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // MantenedorSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 219);
            this.Controls.Add(this.tclContenedor);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MantenedorSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenedorSubCategoria";
            this.Load += new System.EventHandler(this.MantenedorSubCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tclContenedor.ResumeLayout(false);
            this.tbpFormulario.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
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
        private System.Windows.Forms.DataGridView dgvSubCategoria;
        private System.Windows.Forms.Button btnBuscarPorId;
    }
}