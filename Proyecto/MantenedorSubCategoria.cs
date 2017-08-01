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
    public partial class MantenedorSubCategoria : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;
        


        public MantenedorSubCategoria()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =DESKTOP-T2K4EBD; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void SubcDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from subcategoria";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        public DataTable NombreCategoria()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT nombrecategoria from categoria";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public int idCategoria(string cate)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idcategoria from categoria where categoria.nombrecategoria = '" + cate + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

      

        private void MantenedorSubCategoria_Load(object sender, EventArgs e)
        {
            SubcDGV(dgvSubCategoria);
            DataTable dt = NombreCategoria();
            foreach (DataRow fila in dt.Rows)
            {
                cmbCategoria.Items.Add(Convert.ToString(fila["nombrecategoria"]));

            }
           
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

        private void cmbCategoria_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            res = idCategoria(cmbCategoria.SelectedItem.ToString());
            txtIdCategoria.Text = res.ToString();
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
            if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtIdCategoria.Text != "")
            {
                SubCategoria objSub = new SubCategoria();
                objSub.Nombre = txtNombre.Text;
                objSub.Descripcion = txtDescripcion.Text;
                objSub.Idcategoria = Convert.ToInt32(txtIdCategoria.Text);
                objSub.crearSubCategoria();
                MessageBox.Show("Sub Categoria ingresada con exito");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacios");
            }
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                SubCategoria objSub = new SubCategoria();
                objSub.Idsub = Convert.ToInt32(txtId.Text);
                objSub.eliminarSubcategoria();
                MessageBox.Show("Sub Categoria eliminada con exito");
            }
            else
            {
                MessageBox.Show("Debe ingresar una ID a eliminar");
                txtId.Focus();
            }
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                SubCategoria objSub = new SubCategoria();
                objSub.Idsub = Convert.ToInt32(txtId.Text);
                objSub.Nombre = txtNombre.Text;
                objSub.Descripcion = txtDescripcion.Text;
                objSub.Idcategoria = Convert.ToInt32(txtIdCategoria.Text);
                objSub.editarSubCategoria();
                MessageBox.Show("Sub Categoria editada con exito");
            }
            else
            {
                MessageBox.Show("Debe ingresar una ID a editar");
            }
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"select nombre, descripcion, idcategoria from subcategoria where idsubcategoria =  '" + txtId.Text + "'");

            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtNombre.Text = Reg["nombresubcategoria"].ToString();
                txtDescripcion.Text = Reg["descripcion"].ToString();
                txtIdCategoria.Text = Reg["idcategoria"].ToString();
                conn.Close();
                MessageBox.Show("Búsqueda realizada con éxito");
            }
            else
            {
                MessageBox.Show("No se encontró la id ingresada");
                txtId.Text = "";
            }
        }
    }
}
