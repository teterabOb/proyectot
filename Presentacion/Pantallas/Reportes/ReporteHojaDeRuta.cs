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


namespace Presentacion.Pantallas.Reportes
{
    public partial class ReporteHojaDeRuta : MenuADM
    {


        public ReporteHojaDeRuta()
        {

            InitializeComponent();
        }

        private void ReporteHojaDeRuta_Load(object sender, EventArgs e)
        {

            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.id = Convert.ToInt32(txtId.Text);
            f.Show();

        }
    }
}
