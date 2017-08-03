namespace Presentacion.Pantallas.Reportes
{
    partial class Form1
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvHojaDeRuta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(44, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(173, 26);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rvHojaDeRuta);
            this.panel1.Location = new System.Drawing.Point(44, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 345);
            this.panel1.TabIndex = 2;
            // 
            // rvHojaDeRuta
            // 
            this.rvHojaDeRuta.ActiveViewIndex = -1;
            this.rvHojaDeRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rvHojaDeRuta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvHojaDeRuta.Location = new System.Drawing.Point(0, 0);
            this.rvHojaDeRuta.Name = "rvHojaDeRuta";
            this.rvHojaDeRuta.Size = new System.Drawing.Size(726, 345);
            this.rvHojaDeRuta.TabIndex = 0;
            this.rvHojaDeRuta.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rvHojaDeRuta;
    }
}