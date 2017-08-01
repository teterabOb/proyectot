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
    public partial class MantenedorModelo : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorModelo()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =DESKTOP-T2K4EBD; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void ModeloDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from modelo";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuADM obManUs = new MenuADM();
            obManUs.Show();
            this.Hide();
        }

        public int idMarca(string subc)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idmarca from marca where marca.nombre = '" + subc + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public DataTable NombreMarca()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT nombre from marca";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void MantenedorModelo_Load(object sender, EventArgs e)
        {
            ModeloDGV(dgvModelo);
            DataTable dt = NombreMarca();
            foreach (DataRow fila in dt.Rows)
            {
                cmbNombre.Items.Add(Convert.ToString(fila["nombre"]));

            }
           
        }

        private void cmbNombre_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            res = idMarca(cmbNombre.SelectedItem.ToString());
            txtCodigo.Text = res.ToString();
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
            if (txtNombreModelo.Text != "" && txtCodigo.Text != "")
            {
                Modelo objModelo = new Modelo();
                objModelo.Nombre = txtNombreModelo.Text;
                objModelo.Idmarca = Convert.ToInt32(txtCodigo.Text);
                objModelo.crearModelo();
                MessageBox.Show("Modelo ingresado con éxito");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }

            ModeloDGV(dgvModelo);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdModelo.Text != "")
            {
                Modelo objModelo = new Modelo();
                objModelo.Idmodelo = Convert.ToInt32(txtIdModelo.Text);
                objModelo.eliminarModelo();
                MessageBox.Show("Modelo eliminado con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el modelo");
            }

            ModeloDGV(dgvModelo);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdModelo.Text != "" && txtCodigo.Text != "" && txtNombreModelo.Text != "")
            {
                Modelo objModelo = new Modelo();
                objModelo.Idmarca = Convert.ToInt32(txtCodigo.Text);
                objModelo.Nombre = txtNombreModelo.Text;
                objModelo.Idmodelo = Convert.ToInt32(txtIdModelo.Text);
                objModelo.editarModelo();
                MessageBox.Show("Modelo actualizado");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }

            ModeloDGV(dgvModelo);
        }




        
    }
}
