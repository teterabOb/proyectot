using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto
{
    public partial class Reportes : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public Reportes()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =DESKTOP-T2K4EBD; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void ChoferesDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select PERSONAL.PrimerNombre,personal.ApellidoPaterno,PERSONAL.rut  from PERSONAL inner join CARGO on cargo.idCargo = PERSONAL.idCargo where CARGO.nombrecargo = 'chofer'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        //private void btnGenerar_Click(object sender, EventArgs e)
        //{
        //    InformeRutasPorFecha inf = new InformeRutasPorFecha();
        //    inf.Fecha = dtpRutasPorFecha.Value;

        //    inf.ShowDialog();
        //}

        private void tbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void tbtnMenu_Click(object sender, EventArgs e)
        {
            MenuADM log = new MenuADM();
            log.Show();
            this.Hide();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            ChoferesDGV(dgvChoferes);
        }

        //private void btnGenerarIngresosPorFecha_Click(object sender, EventArgs e)
        //{
        //    InformeSalidasPorFecha inf = new InformeSalidasPorFecha();
        //    inf.Fecha = dtpRutasPorFecha.Value;

        //    inf.ShowDialog();
        //}

        //private void btnSalidasPorFecha_Click(object sender, EventArgs e)
        //{
        //    InformeIngresosPorFecha inf = new InformeIngresosPorFecha();
        //    inf.Fecha = dtpRutasPorFecha.Value;

        //    inf.ShowDialog();
        //}

        

        //private void dgvChoferes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    InformeChofer inf = new InformeChofer();
        //    string nombre = dgvChoferes.CurrentRow.Cells[0].Value.ToString();
        //    inf.Nomchofer = nombre;
        //    inf.ShowDialog(); 
        //}
    }
}
