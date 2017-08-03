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
    public partial class MantenedorRegion : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;

        protected string mensaje;
        public MantenedorRegion()
        {
            this.cadenaconexion = (@"Data Source =.; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

        public void cargasPorDefecto()
        {
            txtId.Text = "";
            txtNombre.Text = "";
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
            txtNombre.Text = "";
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

        public void RegionDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from region";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
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
            if (txtId.Text != "" && txtNombre.Text != "")
            {
                nRegion objRegion = new nRegion();
                objRegion.Idregion = Convert.ToInt32(txtId.Text);
                objRegion.Nombre = txtNombre.Text;
                //objRegion.crearRegion();
                MessageBox.Show("Región ingresada con éxito");
                cargaBotonGuardar();
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }

            RegionDGV(dgvRegion);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                nRegion objRegion = new nRegion();
                objRegion.Idregion = Convert.ToInt32(txtId.Text);
                //objRegion.eliminarRegion();
                MessageBox.Show("Región eliminada con éxito");
                cargaBotonEliminar();
            }
            else
            {
                MessageBox.Show("Debe ingresar una ID a eliminar");
            }

            RegionDGV(dgvRegion);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtNombre.Text != "")
            {
                nRegion objRegion = new nRegion();
                objRegion.Idregion = Convert.ToInt32(txtId.Text);
                objRegion.Nombre = txtNombre.Text;
                //objRegion.editarRegion();
                MessageBox.Show("Región actualizada con éxito");
                cargaBotonActualizar();
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }

            RegionDGV(dgvRegion);
        }

        private void MantenedorRegion_Load(object sender, EventArgs e)
        {
            cargasPorDefecto();
            RegionDGV(dgvRegion);
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"SELECT * from region where idregion = '" + txtId.Text + "'");

            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtNombre.Text = Reg["nombreregion"].ToString();
                conn.Close();
                MessageBox.Show("Región encontrada con éxito");
                cargaAlEncontrarBusqueda();
            }
            else
            {
                MessageBox.Show("No se encontró la región buscada");
                txtId.Text = "";
            }
            conn.Close();
        }

        private void tbtnCancelar_Click(object sender, EventArgs e)
        {
            cargasPorDefecto();
        }

        private void tbtnBuscar_Click(object sender, EventArgs e)
        {
            cargasBotonBuscar();
        }

        private void tbtnNuevo_Click(object sender, EventArgs e)
        {
            cargaBotonNuevo();
        }
    }
}
