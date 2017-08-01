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
    public partial class MantenedorCiudad : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorCiudad()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =DESKTOP-T2K4EBD; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void CiudadDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from ciudad";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
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

        private void MantenedorCiudad_Load(object sender, EventArgs e)
        {
            CiudadDGV(dgvCiudad);
            DataTable dt = NombreRegion();
            foreach (DataRow fila in dt.Rows)
            {
                cmbNombreRegion.Items.Add(Convert.ToString(fila["nombreregion"]));

            }
        }

        private void cmbNombreRegion_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            res = idRegion(cmbNombreRegion.SelectedItem.ToString());
            txtCodigoRegion.Text = res.ToString();
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

        

        private void btnBuscarCodigoCiudad_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"SELECT * FROM ciudad where idciudad = '" + txtCodigoCiudad.Text + "'");
            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtNombre.Text = Reg["nombre"].ToString();
                txtCodigoRegion.Text = Reg["idregion"].ToString();
                

                this.conn.Close();
            }
            this.conn.Close();
        }

        private void btnBuscarNombreCiudad_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"SELECT * FROM ciudad where nombre = '" + txtNombre.Text + "'");
            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtCodigoCiudad.Text = Reg["idciudad"].ToString();
                txtCodigoRegion.Text = Reg["idregion"].ToString();


                this.conn.Close();
            }
            this.conn.Close();
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
            if (txtCodigoRegion.Text != "" && txtNombre.Text != "")
            {
                Ciudad objCiudad = new Ciudad();
                objCiudad.Idciudad = Convert.ToInt32(txtCodigoCiudad.Text);
                objCiudad.Nombre = txtNombre.Text;
                objCiudad.Idregion = Convert.ToInt32(txtCodigoRegion.Text);
                objCiudad.crearCiudad();
                MessageBox.Show("Ciudad ingresada con éxito");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }
            CiudadDGV(dgvCiudad);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCiudad.Text != "")
            {
                Ciudad objCiudad = new Ciudad();
                objCiudad.Idciudad = Convert.ToInt32(txtCodigoCiudad.Text);
                objCiudad.eliminarCiudad();
                MessageBox.Show("Ciudad eliminada con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la ciudad");
            }

            CiudadDGV(dgvCiudad);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCiudad.Text != "" && txtNombre.Text != "" && txtCodigoRegion.Text != "")
            {
                Ciudad objCiudad = new Ciudad();
                objCiudad.Idciudad = Convert.ToInt32(txtCodigoCiudad.Text);
                objCiudad.Nombre = txtNombre.Text;
                objCiudad.Idregion = Convert.ToInt32(txtCodigoRegion.Text);
                objCiudad.editarCiudad();
                MessageBox.Show("Ciudad actualizada");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }

            CiudadDGV(dgvCiudad);
        }
        
    }
}
