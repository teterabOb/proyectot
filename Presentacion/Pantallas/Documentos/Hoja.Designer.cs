namespace Presentacion.Pantallas.Documentos
{
    partial class Hoja
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getplanilladerutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDataSet = new Presentacion.PDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_planilla_de_rutaTableAdapter = new Presentacion.PDataSetTableAdapters.get_planilla_de_rutaTableAdapter();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.txtIdRuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.getplanilladerutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getplanilladerutaBindingSource
            // 
            this.getplanilladerutaBindingSource.DataMember = "get_planilla_de_ruta";
            this.getplanilladerutaBindingSource.DataSource = this.pDataSet;
            // 
            // pDataSet
            // 
            this.pDataSet.DataSetName = "PDataSet";
            this.pDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getplanilladerutaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Pantallas.Documentos.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(938, 499);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // pDataSetBindingSource
            // 
            this.pDataSetBindingSource.DataSource = this.pDataSet;
            this.pDataSetBindingSource.Position = 0;
            // 
            // get_planilla_de_rutaTableAdapter
            // 
            this.get_planilla_de_rutaTableAdapter.ClearBeforeFill = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(160, 35);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "Generar";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdRuta
            // 
            this.txtIdRuta.Location = new System.Drawing.Point(257, 37);
            this.txtIdRuta.Name = "txtIdRuta";
            this.txtIdRuta.Size = new System.Drawing.Size(122, 20);
            this.txtIdRuta.TabIndex = 2;
            // 
            // Hoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 609);
            this.Controls.Add(this.txtIdRuta);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Hoja";
            this.Text = "Hoja";
            this.Load += new System.EventHandler(this.Hoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getplanilladerutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pDataSetBindingSource;
        private PDataSet pDataSet;
        private System.Windows.Forms.BindingSource getplanilladerutaBindingSource;
        private PDataSetTableAdapters.get_planilla_de_rutaTableAdapter get_planilla_de_rutaTableAdapter;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.TextBox txtIdRuta;
    }
}