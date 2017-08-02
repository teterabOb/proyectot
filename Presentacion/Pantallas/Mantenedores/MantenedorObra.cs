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
using Logica.Clases;
using Presentacion.Menu;

namespace Presentacion.Pantallas.Mantenedores
{
    public partial class MantenedorObra : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        nObra objObra = new nObra();

        public void ObraDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from obra";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        public MantenedorObra()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =.; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
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

        public DataTable NombreComuna(string nomr)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Comuna.nombrecomuna FROM comuna INNER JOIN ciudad on ciudad.idciudad = comuna.idcomuna WHERE ciudad.nombreciudad = '" + nomr + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public int idComuna(string nombre)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idComuna from comuna where nombrecomuna = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
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

        private void tbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void MantenedorObra_Load(object sender, EventArgs e)
        {
            ObraDGV(dgvObra);
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
        }

        private void cmbNombreCiudad_TextChanged(object sender, EventArgs e)
        {
            cmbNombreComuna.Items.Clear();
            DataTable dt = NombreComuna(cmbNombreCiudad.SelectedItem.ToString());
            foreach (DataRow fila in dt.Rows)
            {
                cmbNombreComuna.Items.Add(Convert.ToString(fila["nombrecomuna"]));
            }
        }

        private void cmbNombreComuna_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            res = idComuna(cmbNombreComuna.SelectedItem.ToString());
            txtIdComuna.Text = res.ToString();
        }

        private void tbtnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDireccion.Text != "" && txtIdComuna.Text != "")
            {
                objObra.Nombreobra = txtNombre.Text;
                objObra.Direccion = txtDireccion.Text;
                objObra.Idcomuna = Convert.ToInt32(txtIdComuna.Text);
                //objObra.crearObra();
                MessageBox.Show("Obra ingresada con éxito");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }

            ObraDGV(dgvObra);
        }



        private void btnBuscarIdObra_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"SELECT obra.nombreobra, comuna.idcomuna, comuna.nombrecomuna, obra.direccion from obra inner join comuna on comuna.idcomuna = obra.idcomuna where obra.idobra = '" + txtIdObra.Text + "'");

            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtNombre.Text = Reg["nombreobra"].ToString();
                txtDireccion.Text = Reg["direccion"].ToString();
                txtIdComuna.Text = Reg["idcomuna"].ToString();
                cmbNombreComuna.SelectedItem = Reg["nombrecomuna"].ToString();
                conn.Close();
                MessageBox.Show("Obra encontrada con éxito");

            }
            else
            {
                MessageBox.Show("Búsqueda fallida");
            }

            ObraDGV(dgvObra);
            this.conn.Close();
        }

        private void btnBuscarNombreObra_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"SELECT obra.idobra, comuna.idcomuna, comuna.nombrecomuna, obra.direccion from obra inner join comuna on comuna.idcomuna = obra.idcomuna where obra.nombreobra = '" + txtNombre.Text + "'");

            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtIdObra.Text = Reg["idobra"].ToString();
                txtDireccion.Text = Reg["direccion"].ToString();
                txtIdComuna.Text = Reg["idcomuna"].ToString();
                cmbNombreComuna.SelectedItem = Reg["nombrecomuna"].ToString();
                conn.Close();


            }
            ObraDGV(dgvObra);
            this.conn.Close();
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdObra.Text != "")
            {
                objObra.Idobra = Convert.ToInt32(txtIdObra.Text);
                //objObra.eliminarObra();
                MessageBox.Show("Obra eliminada con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la obra");
            }
            ObraDGV(dgvObra);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdObra.Text != "" && txtIdComuna.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "")
            {
                objObra.Idobra = Convert.ToInt32(txtIdObra.Text);
                objObra.Idcomuna = Convert.ToInt32(txtIdComuna.Text);
                objObra.Nombreobra = txtNombre.Text;
                objObra.Direccion = txtDireccion.Text;
                //objObra.editarObra();
                MessageBox.Show("Obra actualizada con éxito");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }
            ObraDGV(dgvObra);
        }

        private void tbtnMenu_Click(object sender, EventArgs e)
        {
            MenuADM log = new MenuADM();
            log.Show();
            this.Hide();
        }
    }
}
