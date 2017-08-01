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
    public partial class MantenedorCamion : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorCamion()
        {
            InitializeComponent();
            this.cadenaconexion = (@"Data Source =DESKTOP-T2K4EBD; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
        }

        public void cargasPorDefecto()
        {
            txtId.Text = "";
            txtPatente.Text = "";
            tbpFormulario.Enabled = false;
            tbtnActualizar.Enabled = false;
            tbtnGuardar.Enabled = false;
            tbtnEliminar.Enabled = false;
            tbtnCancelar.Enabled = false;
            btnBuscarPorId.Enabled = false;

        }

        public void cargasBotonBuscar()
        {
            tclContenedor.SelectedTab = tbpFormulario;
            tbpFormulario.Enabled = true; ;
            txtId.Text = "";
            txtPatente.Text = "";
            txtId.ReadOnly = false;
            btnBuscarPorId.Enabled = true;
            tbtnCancelar.Enabled = true;

        }

        public void cargaAlEncontrarBusqueda()
        {

            tbtnEliminar.Enabled = true;
            tbtnActualizar.Enabled = true;
            txtId.ReadOnly = true;
        }

        public void cargaBotonNuevo()
        {
            tbtnCancelar.Enabled = true;
            tbtnGuardar.Enabled = true;
            tbpFormulario.Enabled = true;
            tbtnEliminar.Enabled = false;
            tbtnActualizar.Enabled = false;
            tclContenedor.SelectedTab = tbpFormulario;
            txtId.ReadOnly = false;
        }

        public void cargaBotonGuardar()
        {

            cargasPorDefecto();
        }

        public void cargaBotonEliminar()
        {
            cargasPorDefecto();
        }

        public void cargaBotonActualizar()
        {
            cargasPorDefecto();
        }

        public void CamionesDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select camion.patente,marca.nombre,MODELO.nombre  from CAMION inner join MODELO on modelo.idModelo = camion.idModelo inner join MARCA on MARCA.idmarca = MODELO.idMarca";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        public DataTable Marca()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT nombre from Marca";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public DataTable Modelo(string marca)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Modelo.nombre FROM modelo INNER JOIN marca on marca.idMarca = modelo.idMarca WHERE marca.nombre = '" + marca + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public int idMarca(string modelo)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idModelo from Modelo WHERE modelo.nombre = '" + modelo + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public string nombreModelo()
        {
            string resul;
            string sql1 = (@"SELECT modelo.nombre FROM modelo 
                                        inner join  camion on camion.idModelo = modelo.idModelo
                                        inner join  MARCA on MARCA.idMarca = MODELO.idMarca
                                        where camion.idCamion = '" + txtIdCamion.Text + "'");

            SqlCommand comandosql1 = new SqlCommand(sql1, conn);
            SqlDataAdapter da1 = new SqlDataAdapter(comandosql1);
            conn.Open();
            resul = Convert.ToString(comandosql1.ExecuteScalar());
            conn.Close();
            return resul;
        }


        
        private void MantenedorCamion_Load(object sender, EventArgs e)
        {
            
            CamionesDGV(dgvCamion);
            int Result = 0;
            if (!int.TryParse(txtIdCamion.Text, out Result))
                txtIdCamion.Text = "";

            DataTable dt = Marca();
            foreach (DataRow fila in dt.Rows)
            {
                cmbMarca.Items.Add(Convert.ToString(fila["nombre"]));

            }
            txtId.Visible = false;
        }

        private void cmbMarca_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
                cmbModelo.Items.Clear();
                dt = Modelo(cmbMarca.SelectedItem.ToString());
                foreach (DataRow fila in dt.Rows)
                {
                    cmbModelo.Items.Add(Convert.ToString(fila["nombre"]));
                }            
        }

        private void cmbModelo_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            res = idMarca(cmbModelo.SelectedItem.ToString());
            txtId.Text = res.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuADM obManUs = new MenuADM();
            obManUs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
            this.sql = string.Format(@"SELECT camion.idCamion, camion.idModelo, CAMION.patente, MARCA.nombre, modelo.nombre FROM Camion 
                                        inner join  modelo on modelo.idModelo = CAMION.idModelo
                                        inner join  MARCA on MARCA.idMarca = MODELO.idMarca
                                        where camion.idCamion = '" + txtIdCamion.Text + "'");

            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtPatente.Text = Reg["patente"].ToString();
                txtMarca.Text = Reg["nombre"].ToString();
                conn.Close();
                txtModelo.Text = nombreModelo();
                MessageBox.Show("Camión encontrado con éxito");
                cargaAlEncontrarBusqueda();
            }
            else
            {
                MessageBox.Show("Camión no encontrado");
            }

            this.conn.Close();
        }

        
        private void btnBuscarPorPatente_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"SELECT camion.idCamion, camion.idModelo, CAMION.patente, MARCA.nombre, modelo.nombre FROM Camion 
                                        inner join  modelo on modelo.idModelo = CAMION.idModelo
                                        inner join  MARCA on MARCA.idMarca = MODELO.idMarca
                                        where camion.idCamion = '" + txtPatente.Text + "'");
            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                MessageBox.Show("Camión encontrado");
                txtPatente.Text = Reg["patente"].ToString();
                txtIdCamion.Text = Reg["idCamion"].ToString();
                txtMarca.Text = Reg["nombre"].ToString();
                conn.Close();
                txtModelo.Text = nombreModelo();
                this.conn.Close();
                cargaAlEncontrarBusqueda();
            }
            else
            {
                MessageBox.Show("Camión no encontrado");
                
            }
            this.conn.Close();
        }

     

        private void tbtnMenu_Click(object sender, EventArgs e)
        {
            MenuADM log = new MenuADM();
            log.Show();
            this.Hide();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (txtPatente.Text != "" && txtModelo.Text != "")
            {
                Camion objCamion = new Camion();
                objCamion.Patente = txtPatente.Text;
                objCamion.Idmodelo = Convert.ToInt32(txtId.Text);
                objCamion.crearCamion();
                MessageBox.Show("Camion ingresado con exito");
                cargasPorDefecto();
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }
            CamionesDGV(dgvCamion);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (txtIdCamion.Text != "")
            {
                Camion objcamion = new Camion();
                objcamion.Idcamion = Convert.ToInt32(txtIdCamion.Text);
                objcamion.eliminarCamion();
                MessageBox.Show("Camión ingresado con exito");
                cargasPorDefecto();
            }
            else
            {
                MessageBox.Show("Camión no encontrado");
            }
            CamionesDGV(dgvCamion);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (txtIdCamion.Text != "" && txtPatente.Text != "" && txtModelo.Text != "")
            {
                Camion objCamion = new Camion();
                objCamion.Patente = txtPatente.Text;
                objCamion.Idmodelo = Convert.ToInt32(txtId.Text);
                objCamion.Idcamion = Convert.ToInt32(txtIdCamion.Text);
                objCamion.editarCamion();
                MessageBox.Show("Camión editado con éxito");
                cargasPorDefecto();
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cargaBotonNuevo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargasPorDefecto();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            cargasBotonBuscar();
        }

       }

}


