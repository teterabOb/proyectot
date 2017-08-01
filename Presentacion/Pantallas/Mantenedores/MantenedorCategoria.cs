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
    public partial class MantenedorCategoria : Form
    {
        #region variables de conexion
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;
        #endregion

        public MantenedorCategoria()
        {
            this.cadenaconexion = (@"Data Source =DESKTOP-AA9RM3O; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }


        public void CategoriaDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from categoria";
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
            this.sql = string.Format(@"SELECT * FROM categoria where idcategoria = '" + txtId.Text + "'");
            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtNombre.Text = Reg["nombrecategoria"].ToString();
                txtDescripcion.Text = Reg["descripcion"].ToString();

                this.conn.Close();
            }
            this.conn.Close();
        }

        private void MantenedorCategoria_Load(object sender, EventArgs e)
        {
            CategoriaDGV(dgvCategoria);
            txtId.Focus();
        }

        private void tbtnMenu_Click(object sender, EventArgs e)
        {
            MenuADM log = new MenuADM();
            log.Show();
            this.Hide();
        }

        private void tbtnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtNombre.Text != "" && txtDescripcion.Text != "")
            //{
            //    nCategoria objCategoria = new nCategoria();
            //    objCategoria.Nombrecategoria = txtNombre.Text;
            //    objCategoria.Descripcion = txtDescripcion.Text;
            //    objCategoria.crearCategoria();
            //    MessageBox.Show("Categoria creada con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacíos");
            //}
            //CategoriaDGV(dgvCategoria);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "")
            //{
            //    nCategoria objCategoria = new nCategoria();
            //    objCategoria.Idcategoria = Convert.ToInt32(txtId.Text);
            //    objCategoria.eliminarCategoria();
            //    MessageBox.Show("Categoría eliminada con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo eliminar la categoría");
            //}
            //CategoriaDGV(dgvCategoria);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "" && txtNombre.Text != "" && txtDescripcion.Text != "")
            //{
            //    nCategoria objCategoria = new nCategoria();
            //    objCategoria.Idcategoria = Convert.ToInt32(txtId.Text);
            //    objCategoria.Nombrecategoria = txtNombre.Text;
            //    objCategoria.Descripcion = txtDescripcion.Text;
            //    objCategoria.editarCategoria();
            //    MessageBox.Show("Categoría actualizada con éxito");
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacíos");
            //}
            //CategoriaDGV(dgvCategoria);
        }
    }
}
