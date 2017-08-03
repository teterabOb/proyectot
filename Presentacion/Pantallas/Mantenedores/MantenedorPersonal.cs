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
    public partial class MantenedorPersonal : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;
        nPersona objPersonal = new nPersona();



        public MantenedorPersonal()
        {
            this.cadenaconexion = (@"Data Source =.; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

        public void PersonalDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "select * from personal";
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

        public DataTable NombreCargo()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT nombrecargo FROM cargo";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }



        public int idComuna(string nombre)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idComuna from comuna where nombre = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public int idCargo(string nombre)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idCargo from cargo where nombrecargo = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        private void MantenedorPersonal_Load(object sender, EventArgs e)
        {
            PersonalDGV(dgvPersonal);
            DataTable dt = NombreRegion();
            foreach (DataRow fila in dt.Rows)
            {
                cmbNombreRegion.Items.Add(Convert.ToString(fila["nombreregion"]));

            }
            txtIdComuna.Visible = false;

            DataTable dt1 = NombreCargo();
            foreach (DataRow fila in dt1.Rows)
            {
                cmbNombreCargo.Items.Add(Convert.ToString(fila["nombrecargo"]));

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

        private void cmbNombreCargo_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            res = idCargo(cmbNombreCargo.SelectedItem.ToString());
            txtIdCargo.Text = res.ToString();
        }

        public bool validarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
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
            if (txtNombre.Text != "" && txtRut.Text != "" && txtPaterno.Text != "" &&
                txtMaterno.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" &&
                txtIdComuna.Text != "")
            {
                bool res = false;
                res = validarRut(txtNombre.Text);
                if (res == true)
                {
                    nPersona objPersonal = new nPersona();
                    objPersonal.Rut = txtNombre.Text;
                    objPersonal.Primernombre = txtRut.Text;
                    objPersonal.Apellidopaterno = txtPaterno.Text;
                    objPersonal.Apellidomaterno = txtMaterno.Text;
                    objPersonal.Telefono = txtTelefono.Text;
                    objPersonal.Direccion = txtDireccion.Text;
                    objPersonal.Idcomuna = Convert.ToInt32(txtIdComuna.Text);
                    objPersonal.Idcargo = Convert.ToInt32(txtIdCargo.Text);
                    //objPersonal.crearPersonal();
                    MessageBox.Show("Personal ingresado");
                }
                else
                {
                    MessageBox.Show("RUT no valido");
                    txtNombre.Clear();
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("No deben haber campos vacios");
            }
            PersonalDGV(dgvPersonal);
        }

        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text != "")
            {
                objPersonal.Rut = txtRut.Text;
                //objPersonal.eliminarPersonal();
                MessageBox.Show("Empleado eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Ingrese un rut a eliminar");
            }
            PersonalDGV(dgvPersonal);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtRut.Text != "" && txtPaterno.Text != "" &&
                txtMaterno.Text != "" && txtTelefono.Text != "" && txtIdCargo.Text != "" &&
                txtIdComuna.Text != "")
            {
                objPersonal.Rut = txtRut.Text;
                objPersonal.Primernombre = txtNombre.Text;
                objPersonal.Apellidopaterno = txtPaterno.Text;
                objPersonal.Apellidomaterno = txtMaterno.Text;
                objPersonal.Telefono = txtTelefono.Text;
                objPersonal.Idcargo = Convert.ToInt32(txtIdCargo.Text);
                objPersonal.Idcomuna = Convert.ToInt32(txtIdComuna.Text);
                //objPersonal.editarPersonal();
                MessageBox.Show("Empleado editado con éxito");
            }
            else
            {
                MessageBox.Show("No deben haber campos vacíos");
            }
            PersonalDGV(dgvPersonal);
        }

        private void btnBuscarPorRut_Click(object sender, EventArgs e)
        {
            this.sql = string.Format(@"SELECT personal.idcomuna,personal.primernombre,personal.apellidopaterno,personal.apellidomaterno,personal.telefono,cargo.nombrecargo,comuna.nombrecomuna,cargo.idcargo from personal inner join cargo on cargo.idcargo = personal.idcargo inner join comuna on comuna.idcomuna = personal.idcomuna  where personal.rut = '" + txtRut.Text + "'");

            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtNombre.Text = Reg["primernombre"].ToString();
                txtPaterno.Text = Reg["apellidopaterno"].ToString();
                txtMaterno.Text = Reg["apellidomaterno"].ToString();
                txtMaterno.Text = Reg["telefono"].ToString();
                txtIdCargo.Text = Reg["idcargo"].ToString();
                txtIdComuna.Text = Reg["idcomuna"].ToString();
                conn.Close();
            }
            this.conn.Close();
        }
    }
}
