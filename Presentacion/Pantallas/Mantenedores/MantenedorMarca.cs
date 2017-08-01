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
    public partial class MantenedorMarca : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorMarca()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =DESKTOP-AA9RM3O; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void MarcaDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from marca";
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"SELECT * FROM marca where nombre = '" + txtNombre.Text + "'");
            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtId.Text = Reg["idmarca"].ToString();
                txtTelefono.Text = Reg["telefono"].ToString();
                txtDireccion.Text = Reg["direccion"].ToString();


                this.conn.Close();
            }
            this.conn.Close();
        }



        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                this.sql = string.Format(@"SELECT * FROM marca where idmarca = '" + txtId.Text + "'");
                this.comandosql = new SqlCommand(this.sql, this.conn);
                this.conn.Open();
                SqlDataReader Reg = null;
                Reg = this.comandosql.ExecuteReader();
                if (Reg.Read() == true)
                {
                    txtNombre.Text = Reg["nombre"].ToString();
                    txtTelefono.Text = Reg["telefono"].ToString();
                    txtDireccion.Text = Reg["direccion"].ToString();
                    this.conn.Close();
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una ID a buscar");
                txtId.Focus();
            }
            this.conn.Close();
        }



        private void MantenedorMarca_Load(object sender, EventArgs e)
        {
            MarcaDGV(dgvMarca);
            txtId.Focus();
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
            //if (txtNombre.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "")
            //{
            //    nMarca objMarca = new nMarca();
            //    objMarca.Nombre = txtNombre.Text;
            //    objMarca.Telefono = txtTelefono.Text;
            //    objMarca.Direccion = txtDireccion.Text;
            //    objMarca.crearMarca();
            //    MessageBox.Show("Marca ingresada con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacíos");
            //}
            //MarcaDGV(dgvMarca);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "")
            //{
            //    nMarca objMarca = new nMarca();
            //    objMarca.Idmarca = Convert.ToInt32(txtId.Text);
            //    if (objMarca.marcaExistente() == true)
            //    {
            //        objMarca.eliminarMarca();
            //        MessageBox.Show("Marca eliminada");
            //    }
            //    else
            //    {
            //        MessageBox.Show("La marca ingresada no existe");
            //        txtId.Focus();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Debe ingresar una ID a eliminar");
            //}
            //MarcaDGV(dgvMarca);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" &&
            //    txtDireccion.Text != "")
            //{
            //    nMarca objMarca = new nMarca();
            //    objMarca.Nombre = txtNombre.Text;
            //    objMarca.Telefono = txtTelefono.Text;
            //    objMarca.Direccion = txtDireccion.Text;
            //    objMarca.Idmarca = Convert.ToInt32(txtId.Text);
            //    objMarca.editarMarca();
            //    MessageBox.Show("Marca actualizada con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacíos");
            //}
            //MarcaDGV(dgvMarca);
        }
    }
}
