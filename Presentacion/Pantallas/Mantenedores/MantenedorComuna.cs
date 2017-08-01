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
using Presentacion.Menu;
using Logica.Clases;

namespace Presentacion.Pantallas.Mantenedores
{
    public partial class MantenedorComuna : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorComuna()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =DESKTOP-AA9RM3O; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void ComunaDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from comuna";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        public int idRegion(string nombre)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idRegion from region where nombreregion = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public int idCiudad(string nombre)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idCiudad from ciudad where nombreciudad = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public DataTable NombreRegion()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT nombreregion from region";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public DataTable NombreCiudad(string nomr)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Ciudad.nombreciudad FROM ciudad INNER JOIN region on region.idregion = ciudad.idregion WHERE region.nombreregion = '" + nomr + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        private void MantenedorComuna_Load(object sender, EventArgs e)
        {
            ComunaDGV(dgvComuna);
            DataTable dt = NombreRegion();
            foreach (DataRow fila in dt.Rows)
            {
                cmbNombreRegion.Items.Add(Convert.ToString(fila["nombreregion"]));

            }
        }


        private void cmbNombreRegion_TextChanged(object sender, EventArgs e)
        {
            cmbNombreCiudad.Items.Clear();
            DataTable dt = NombreCiudad(cmbNombreRegion.SelectedItem.ToString());
            foreach (DataRow fila in dt.Rows)
            {
                cmbNombreCiudad.Items.Add(Convert.ToString(fila["nombreciudad"]));
            }

            int res = 0;
            res = idRegion(cmbNombreRegion.SelectedItem.ToString());
            txtCodigoRegion.Text = res.ToString();
        }

        private void cmbNombreCiudad_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            res = idCiudad(cmbNombreCiudad.SelectedItem.ToString());
            txtCodigoCiudad.Text = res.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuADM obManUs = new MenuADM();
            obManUs.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnBuscarComuna_Click(object sender, EventArgs e)
        {
            this.sql = string.Format("SELECT Ciudad.idciudad, comuna.nombrecomuna, comuna.idComuna, region.idregion FROM comuna INNER JOIN CIUDAD on CIUDAD.idCiudad = COMUNA.idCiudad INNER JOIN REGION on REGION.idRegion = CIUDAD.idCiudad WHERE COMUNA.idComuna = '" + Convert.ToInt32(txtCodigoComuna.Text) + "'");
            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtNombreComuna.Text = Reg["nombrecomuna"].ToString();
                txtCodigoCiudad.Text = Reg["idciudad"].ToString();
                txtCodigoRegion.Text = Reg["idregion"].ToString();

                this.conn.Close();
            }
            this.conn.Close();
        }


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

        private void tbtnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtNombreComuna.Text != "" && txtCodigoCiudad.Text != "")
            //{
            //    nComuna objComuna = new nComuna();
            //    objComuna.Nombre = txtNombreComuna.Text;
            //    objComuna.Idciudad = Convert.ToInt32(txtCodigoCiudad.Text);
            //    objComuna.crearComuna();
            //    MessageBox.Show("Comuna ingresada con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacíos");
            //}
            //ComunaDGV(dgvComuna);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            //if (txtCodigoComuna.Text != "")
            //{
            //    nComuna objComuna = new nComuna();
            //    objComuna.Idcomuna = Convert.ToInt32(txtCodigoComuna.Text);

            //    objComuna.eliminarComuna();
            //    MessageBox.Show("Comuna eliminada con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo eliminar la comuna");
            //}
            //ComunaDGV(dgvComuna);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            //if (txtCodigoComuna.Text != "" && txtCodigoCiudad.Text != "" && txtCodigoRegion.Text != ""
            //    && txtNombreComuna.Text != "")
            //{
            //    nComuna objComuna = new nComuna();
            //    objComuna.Idcomuna = Convert.ToInt32(txtCodigoComuna.Text);
            //    objComuna.Nombre = txtNombreComuna.Text;
            //    objComuna.Idciudad = Convert.ToInt32(txtCodigoCiudad.Text);
            //    objComuna.editarComuna();
            //    MessageBox.Show("comuna editada con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacíos");
            //}

            //ComunaDGV(dgvComuna);
        }
    }
}
