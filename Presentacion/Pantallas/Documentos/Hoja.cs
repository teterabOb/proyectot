using Presentacion.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Pantallas.Documentos
{
    public partial class Hoja : MenuADM
    {
        protected string id { get; set; }

        public Hoja()
        {
            InitializeComponent();
        }

        private void Hoja_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            id = txtIdRuta.Text;
            if(id != String.Empty)
            {
                get_planilla_de_rutaTableAdapter.Fill(pDataSet.get_planilla_de_ruta, id);
                this.reportViewer1.RefreshReport();
            }               
            else
            {
                MessageBox.Show("Favor Ingresar la ruta");
            }
        }
    }
}
