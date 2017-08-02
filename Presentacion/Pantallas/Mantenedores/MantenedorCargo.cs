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
    public partial class MantenedorCargo : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorCargo()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =.; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void CargoDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from cargo";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        private void MantenedorCargo_Load(object sender, EventArgs e)
        {
            CargoDGV(dgvCargo);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuADM obManUs = new MenuADM();
            obManUs.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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

        private void tbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void tbtnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtNombre.Text != "" && txtDescripcion.Text != "")
            //{
            //    nCargo objCargo = new nCargo();
            //    objCargo.Nombre = txtNombre.Text;
            //    objCargo.Descripcion = txtDescripcion.Text;
            //    objCargo.crearCargo();
            //    MessageBox.Show("Cargo ingresado con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacíos");
            //}
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "")
            //{
            //    nCargo objCargo = new nCargo();
            //    objCargo.Idcargo = Convert.ToInt32(txtId.Text);
            //    objCargo.eliminarCargo();
            //    MessageBox.Show("Cargo eliminado con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo eliminar el cargo");
            //}
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            //if (txtNombre.Text != "" && txtDescripcion.Text != "")
            //{
            //    nCargo objCargo = new nCargo();
            //    objCargo.Nombre = txtNombre.Text;
            //    objCargo.Descripcion = txtDescripcion.Text;
            //    objCargo.Idcargo = Convert.ToInt32(txtId.Text);
            //    objCargo.editarCargo();
            //    MessageBox.Show("Cargo editado con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo editar el cargo");
            //}

        }
    }
}
