using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Presentacion.Pantallas.Reportes
{
    public partial class Form1 : Form
    {
        public int id;
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public Form1()
        {
            cadenaconexion = (@"Data Source =.; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PROYECTOTDataSet ds = new PROYECTOTDataSet();

            ReporteHojaDeRuta rp = new ReporteHojaDeRuta();
            conn.Open();
            String query = string.Format(@"get_planilla_de_ruta {0}", id);
            String tb = "";
            SqlDataAdapter ad = new SqlDataAdapter(query,conn);
            ad.Fill(ds, tb);

            //rp.set

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
