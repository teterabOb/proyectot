namespace Presentacion.Pantallas
{
    partial class RegistroSalida
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegistrarSalida = new System.Windows.Forms.ToolStripButton();
            this.btnBuscarr = new System.Windows.Forms.ToolStripButton();
            this.btnMenu = new System.Windows.Forms.ToolStripButton();
            this.gbxEntrada = new System.Windows.Forms.GroupBox();
            this.txtIdRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.tclRegistroSalida = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.gbxEntrada.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tclRegistroSalida.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarSalida,
            this.btnBuscarr,
            this.btnMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(658, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Image = global::Presentacion.Properties.Resources.guardar;
            this.btnRegistrarSalida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(107, 22);
            this.btnRegistrarSalida.Text = "Registrar Salida";
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // btnBuscarr
            // 
            this.btnBuscarr.Image = global::Presentacion.Properties.Resources.busqueda;
            this.btnBuscarr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarr.Name = "btnBuscarr";
            this.btnBuscarr.Size = new System.Drawing.Size(62, 22);
            this.btnBuscarr.Text = "Buscar";
            this.btnBuscarr.Click += new System.EventHandler(this.btnBuscarr_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::Presentacion.Properties.Resources.menus;
            this.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(58, 22);
            this.btnMenu.Text = "Menú";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // gbxEntrada
            // 
            this.gbxEntrada.Controls.Add(this.txtIdRuta);
            this.gbxEntrada.Controls.Add(this.label1);
            this.gbxEntrada.Location = new System.Drawing.Point(6, 5);
            this.gbxEntrada.Name = "gbxEntrada";
            this.gbxEntrada.Size = new System.Drawing.Size(612, 51);
            this.gbxEntrada.TabIndex = 5;
            this.gbxEntrada.TabStop = false;
            this.gbxEntrada.Text = "Salida";
            // 
            // txtIdRuta
            // 
            this.txtIdRuta.Location = new System.Drawing.Point(95, 15);
            this.txtIdRuta.Name = "txtIdRuta";
            this.txtIdRuta.Size = new System.Drawing.Size(159, 20);
            this.txtIdRuta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID RUTA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.txtCarga);
            this.groupBox1.Controls.Add(this.txtMaterial);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtPatente);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.txtApellidoPaterno);
            this.groupBox1.Controls.Add(this.txtNombreChofer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Ruta";
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDestino.Location = new System.Drawing.Point(343, 125);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(139, 20);
            this.txtDestino.TabIndex = 15;
            // 
            // txtCarga
            // 
            this.txtCarga.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCarga.Location = new System.Drawing.Point(343, 89);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.ReadOnly = true;
            this.txtCarga.Size = new System.Drawing.Size(139, 20);
            this.txtCarga.TabIndex = 14;
            // 
            // txtMaterial
            // 
            this.txtMaterial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaterial.Location = new System.Drawing.Point(343, 54);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = true;
            this.txtMaterial.Size = new System.Drawing.Size(139, 20);
            this.txtMaterial.TabIndex = 13;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEstado.Location = new System.Drawing.Point(343, 23);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(139, 20);
            this.txtEstado.TabIndex = 12;
            // 
            // txtPatente
            // 
            this.txtPatente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPatente.Location = new System.Drawing.Point(95, 125);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.ReadOnly = true;
            this.txtPatente.Size = new System.Drawing.Size(159, 20);
            this.txtPatente.TabIndex = 11;
            // 
            // txtRut
            // 
            this.txtRut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRut.Location = new System.Drawing.Point(95, 89);
            this.txtRut.Name = "txtRut";
            this.txtRut.ReadOnly = true;
            this.txtRut.Size = new System.Drawing.Size(159, 20);
            this.txtRut.TabIndex = 10;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(95, 54);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ReadOnly = true;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(159, 20);
            this.txtApellidoPaterno.TabIndex = 9;
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombreChofer.Location = new System.Drawing.Point(95, 24);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.ReadOnly = true;
            this.txtNombreChofer.Size = new System.Drawing.Size(159, 20);
            this.txtNombreChofer.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Carga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Patente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "RUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtFechaIngreso);
            this.groupBox2.Controls.Add(this.txtComentario);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 111);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Ingreso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Fecha Salida";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Enabled = false;
            this.txtFechaIngreso.Location = new System.Drawing.Point(95, 23);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(159, 20);
            this.txtFechaIngreso.TabIndex = 2;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(95, 49);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(387, 50);
            this.txtComentario.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Comentario";
            // 
            // tmrHora
            // 
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // tclRegistroSalida
            // 
            this.tclRegistroSalida.Controls.Add(this.tabPage1);
            this.tclRegistroSalida.Controls.Add(this.tabPage2);
            this.tclRegistroSalida.Location = new System.Drawing.Point(10, 32);
            this.tclRegistroSalida.Name = "tclRegistroSalida";
            this.tclRegistroSalida.SelectedIndex = 0;
            this.tclRegistroSalida.Size = new System.Drawing.Size(645, 390);
            this.tclRegistroSalida.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gbxEntrada);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Formulario Salida";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Salidas";
            // 
            // RegistroSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 436);
            this.Controls.Add(this.tclRegistroSalida);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RegistroSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroSalida";
            this.Load += new System.EventHandler(this.RegistroSalida_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbxEntrada.ResumeLayout(false);
            this.gbxEntrada.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tclRegistroSalida.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRegistrarSalida;
        private System.Windows.Forms.ToolStripButton btnBuscarr;
        private System.Windows.Forms.ToolStripButton btnMenu;
        private System.Windows.Forms.GroupBox gbxEntrada;
        private System.Windows.Forms.TextBox txtIdRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.TabControl tclRegistroSalida;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}