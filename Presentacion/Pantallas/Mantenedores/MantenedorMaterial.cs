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
    public partial class MantenedorMaterial : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorMaterial()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =.; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void MaterialDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from material";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        public int idSubCategoria(string subc)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idSubCategoria from subcategoria where subcategoria.nombre = '" + subc + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
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

        public DataTable NombreSubCategoria(string categoria)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT subcategoria.nombre FROM subcategoria INNER JOIN categoria on categoria.idcategoria = subcategoria.idcategoria WHERE categoria.nombrecategoria = '" + categoria + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            MaterialDGV(dgvMaterial);
            txtCapturarIdSubCategoria.Visible = false;
            DataTable dt = NombreCategoria();
            foreach (DataRow fila in dt.Rows)
            {
                cmbCategoria.Items.Add(Convert.ToString(fila["nombrecategoria"]));

            }

        }

        private void cmbCategoria_TextChanged(object sender, EventArgs e)
        {
            cmbSubCategoria.Items.Clear();
            DataTable dt = NombreSubCategoria(cmbCategoria.SelectedItem.ToString());
            foreach (DataRow fila in dt.Rows)
            {
                cmbSubCategoria.Items.Add(Convert.ToString(fila["nombre"]));
            }
        }

        private void cmbSubCategoria_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            res = idSubCategoria(cmbSubCategoria.SelectedItem.ToString());
            txtCapturarIdSubCategoria.Text = res.ToString();
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

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                this.sql = string.Format(@"select * from material where idmaterial = '" + txtId.Text + "'");
                this.comandosql = new SqlCommand(this.sql, this.conn);
                this.conn.Open();
                this.comandosql.ExecuteNonQuery();
                SqlDataReader Reg = null;
                Reg = this.comandosql.ExecuteReader();
                if (Reg.Read() == true)
                {
                    txtId.Text = Reg["idmaterial"].ToString();
                    txtNombre.Text = Reg["nombre"].ToString();
                    txtDescripcion.Text = Reg["descripcion"].ToString();
                    this.conn.Close();
                }
                else
                {
                    MessageBox.Show("La ID ingresada no existe");
                    txtId.Clear();
                    txtId.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una ID buscar");
            }
            MaterialDGV(dgvMaterial);
            this.conn.Close();

        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                this.sql = string.Format(@"select * from material where nombre = '" + txtNombre.Text + "'");
                this.comandosql = new SqlCommand(this.sql, this.conn);
                this.conn.Open();
                this.comandosql.ExecuteNonQuery();
                SqlDataReader Reg = null;
                Reg = this.comandosql.ExecuteReader();
                if (Reg.Read() == true)
                {
                    txtId.Text = Reg["idmaterial"].ToString();
                    txtNombre.Text = Reg["nombre"].ToString();
                    txtDescripcion.Text = Reg["descripcion"].ToString();
                    this.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre a buscar");
            }
            MaterialDGV(dgvMaterial);
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
            if (txtNombre.Text != "" || txtDescripcion.Text != "" || txtCapturarIdSubCategoria.Text != "")
            {
                nMaterial objMaterial = new nMaterial();
                objMaterial.Nombre = txtNombre.Text;
                objMaterial.Descripcion = txtDescripcion.Text;
                objMaterial.IdSubcategoria = Convert.ToInt32(txtCapturarIdSubCategoria.Text);
                //objMaterial.crearMaterial();
                MessageBox.Show("Material ingresado con exito");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacios");
            }
            MaterialDGV(dgvMaterial);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "" && txtNombre.Text != "" && txtDescripcion.Text != "" && txtCapturarIdSubCategoria.Text != "")
            //{
            //    nMaterial objMaterial = new nMaterial();
            //    objMaterial.Idmaterial = Convert.ToInt32(txtId.Text);
            //    objMaterial.Nombre = txtNombre.Text;
            //    objMaterial.Descripcion = txtDescripcion.Text;
            //    objMaterial.IdSubcategoria = Convert.ToInt32(txtCapturarIdSubCategoria.Text);
            //    if (objMaterial.materialExistente() == true)
            //    {
            //        objMaterial.editarMaterial();
            //        MessageBox.Show("Material editado con exito");
            //    }
            //    else
            //    {
            //        MessageBox.Show("La ID ingresada no existe");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacios");
            //}
            //MaterialDGV(dgvMaterial);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "")
            //{
            //    nMaterial objMaterial = new nMaterial();
            //    objMaterial.Idmaterial = Convert.ToInt32(txtId.Text);
            //    if (objMaterial.materialExistente() == true)
            //    {
            //        objMaterial.eliminarMaterial();
            //        MessageBox.Show("Material eliminado");
            //    }
            //    else
            //    {
            //        MessageBox.Show("La ID ingresada no existe");
            //        txtId.Focus();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Debe ingresar una ID a eliminar");
            //}
            //MaterialDGV(dgvMaterial);
        }
    }
}
