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

namespace Presentacion.Pantallas.MantenedorUsuarios
{
    public partial class MantenedorUsuarios : Form
    {
        #region variables de conexion
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;
        #endregion

        #region Constructor
        public MantenedorUsuarios()
        {
            this.cadenaconexion = (@"Data Source =DESKTOP-AA9RM3O; Initial Catalog = Seguridad; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }
        #endregion


        public void usuariosDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM USUARIO";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtPassword.Text == txtConfirmar.Text)
            //{
            //    nUsuario obUsuario = new nUsuario();
            //    obUsuario.Nombre = txtNombre.Text;
            //    obUsuario.User = txtUser.Text;
            //    obUsuario.Contraseña = txtPassword.Text;
            //    if (cmbTipo.SelectedValue.ToString() == "Administrador")
            //    {

            //        obUsuario.Idtipo = 1;
            //    }
            //    if (cmbTipo.SelectedValue.ToString() == "Usuario")
            //    {

            //        obUsuario.Idtipo = 2;
            //    }
            //    if (cmbTipo.SelectedValue.ToString() == "Jefe de Patio")
            //    {

            //        obUsuario.Idtipo = 3;
            //    }
            //    if (cmbTipo.SelectedValue.ToString() == "Jefe de Bodega")
            //    {

            //        obUsuario.Idtipo = 4;
            //    }
            //    obUsuario.crearUsuario();
            //    MessageBox.Show(obUsuario.Mensaje, "Crear");
            //    txtNombre.Text = null;
            //    txtUser.Text = null;
            //    txtPassword.Text = null;
            //    txtConfirmar.Text = null;
            //}
            //else
            //{
            //    MessageBox.Show("Las contraseñas no coinciden");
            //    txtPassword.Text = null;
            //    txtConfirmar.Text = null;
            //}
            //usuariosDGV(dgvPersonas);

        }

        #region Carga por defecto
        private void MantenedorUsuarios_Load(object sender, EventArgs e)
        {
            usuariosDGV(dgvPersonas);



            btnBuscar.Enabled = false;
            tbtnGuardar.Enabled = false;
            tbtnCancelar.Enabled = false;
            tbtnActualizar.Enabled = false;
            txtId.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtUser.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtConfirmar.ReadOnly = true;


            tabPage3.Enabled = false;
            // TODO: esta línea de código carga datos en la tabla 'seguridadDataSet.TipoUsuario' Puede moverla o quitarla según sea necesario.
            //this.tipoUsuarioTableAdapter.Fill(this.seguridadDataSet.TipoUsuario);


        }
        #endregion





        #region Boton Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtUser.Clear();
            txtPassword.Clear();
            txtConfirmar.Clear();
        }
        #endregion



        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuADM obManUs = new MenuADM();
            obManUs.Show();
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "" && txtNombre.Text != "" && txtUser.Text != "" && txtPassword.Text == txtConfirmar.Text)
            //{

            //    nUsuario objUsuario = new nUsuario();
            //    objUsuario.nombre = txtNombre.Text;
            //    objUsuario.user = txtUser.Text;
            //    objUsuario.contrasena = txtPassword.Text;
            //    objUsuario.id = Convert.ToInt32(txtId.Text);
            //    if (objUsuario.validaUsuario(objUsuario.nombre,objUsuario.contrasena) == 1)
            //    {
            //        objUsuario.editarUsuario();
            //        MessageBox.Show("Usuario editado");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacios y las contraseñas deben coincidir");
            //}
        }

        private void tbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void tbtnNuevo_Click(object sender, EventArgs e)
        {
            tclMantenedorUsuarios.SelectedTab = tabPage1;
            txtNombre.Clear();
            txtUser.Clear();
            txtId.Clear();
            txtPassword.Clear();
            txtConfirmar.Clear();
            tbtnActualizar.Enabled = false;
            tbtnNuevo.Enabled = false;
            tbtnGuardar.Enabled = true;
            tbtnEliminar.Enabled = false;
            tbtnCancelar.Enabled = true;

            txtId.ReadOnly = true;
            txtNombre.ReadOnly = false;
            txtUser.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtConfirmar.ReadOnly = false;
        }

        private void tbtnCancelar_Click(object sender, EventArgs e)
        {
            tclMantenedorUsuarios.SelectedTab = tabPage3;
            tbtnNuevo.Enabled = true;

        }

        private void tclMantenedorUsuarios_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tbtnBuscar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            btnBuscar.Enabled = true;
            txtNombre.Clear();
            txtUser.Clear();
            txtId.Clear();
            txtPassword.Clear();
            txtConfirmar.Clear();
            btnBuscar.Enabled = true;
            tclMantenedorUsuarios.SelectedTab = tabPage1;
            txtId.ReadOnly = false;
            tbtnCancelar.Enabled = true;
            tbtnActualizar.Enabled = true;
            txtNombre.ReadOnly = true;
            txtUser.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtConfirmar.ReadOnly = true;

            MessageBox.Show("Ingrese ID de usuario a buscar");
        }

        private void tbtnGuardar_Click(object sender, EventArgs e)
        {
            //if (txtNombre.Text != "" && txtUser.Text != "" && txtConfirmar.Text != "" && txtPassword.Text != "")
            //{
            //    if (txtPassword.Text == txtConfirmar.Text)
            //    {
            //        nUsuario obUsuario = new nUsuario();
            //        obUsuario.nombre = txtNombre.Text;
            //        obUsuario.user = txtUser.Text;
            //        obUsuario.contraseña = txtPassword.Text;
            //        if (cmbTipo.SelectedValue.ToString() == "Administrador")
            //        {

            //            obUsuario.idtipo = 1;
            //        }
            //        if (cmbTipo.SelectedValue.ToString() == "Usuario")
            //        {

            //            obUsuario.idtipo = 2;
            //        }
            //        if (cmbTipo.SelectedValue.ToString() == "Jefe de Patio")
            //        {

            //            obUsuario.idtipo = 3;
            //        }
            //        if (cmbTipo.SelectedValue.ToString() == "Jefe de Bodega")
            //        {

            //            obUsuario.idtipo = 4;
            //        }
            //        obUsuario.crearUsuario();
            //        MessageBox.Show(obUsuario.mensaje, "Crear");
            //        txtNombre.Text = null;
            //        txtUser.Text = null;
            //        txtPassword.Text = null;
            //        txtConfirmar.Text = null;
            //    }

            //    else
            //    {
            //        MessageBox.Show("Las contraseñas no coinciden");
            //        txtPassword.Text = null;
            //        txtConfirmar.Text = null;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacíos");
            //}
            //usuariosDGV(dgvPersonas);
        }



        private void tbtnEliminar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "")
            //{
            //    nUsuario objUsuario = new nUsuario();
            //    objUsuario.Id = Convert.ToInt32(txtId.Text);
            //    if (objUsuario.validaUsuario() == true)
            //    {
            //        this.sql = string.Format(@"DELETE FROM Usuario where idUsuario = '" + txtId.Text + "'");
            //        this.comandosql = new SqlCommand(this.sql, this.conn);
            //        this.conn.Open();
            //        SqlDataReader Reg = null;
            //        Reg = this.comandosql.ExecuteReader();
            //        MessageBox.Show("Usuario eliminado");
            //        txtId.Focus();
            //        this.conn.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario no encontrado");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Debe ingresar una ID a eliminar");
            //}
            //txtNombre.ReadOnly = true;
            //txtUser.ReadOnly = true;
            //txtPassword.ReadOnly = true;
            //txtConfirmar.ReadOnly = true;
            //txtId.Clear();
            //txtNombre.Clear();
            //txtUser.Clear();
            //txtPassword.Clear();
            //txtConfirmar.Clear();
            //usuariosDGV(dgvPersonas);
        }

        private void tbtnActualizar_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "" && txtNombre.Text != "" && txtUser.Text != "" && txtPassword.Text == txtConfirmar.Text)
            //{

            //    nUsuario objUsuario = new nUsuario();
            //    objUsuario.Nombre = txtNombre.Text;
            //    objUsuario.User = txtUser.Text;
            //    objUsuario.Contraseña = txtPassword.Text;
            //    objUsuario.Id = Convert.ToInt32(txtId.Text);
            //    if (objUsuario.usuarioExistente() == true)
            //    {
            //        objUsuario.editarUsuario();
            //        MessageBox.Show("Usuario editado");
            //        txtNombre.Clear();
            //        txtUser.Clear();
            //        txtId.Clear();
            //        txtPassword.Clear();
            //        txtConfirmar.Clear();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No deben haber campos vacios y las contraseñas deben coincidir");
            //}
            //usuariosDGV(dgvPersonas);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //if (txtId.Text == "")
            //{
            //    MessageBox.Show("Debe ingresar una ID a buscar");
            //}
            //else
            //{
            //    nUsuario objUsuario = new nUsuario();
            //    objUsuario.Id = Convert.ToInt32(txtId.Text);
            //    objUsuario.buscarUsuario();

            //    if (objUsuario.buscarUsuario() == 1)
            //    {

            //        MessageBox.Show("Usuario encontrado");
            //        this.sql = string.Format(@"SELECT usuario.nombre,usuario.username,tipousuario.tipo FROM Usuario inner join tipousuario on tipousuario.idtipo = usuario.idtipousuario where idUsuario = '" + txtId.Text + "'");
            //        this.comandosql = new SqlCommand(this.sql, this.conn);
            //        this.conn.Open();
            //        SqlDataReader Reg = null;
            //        Reg = this.comandosql.ExecuteReader();
            //        if (Reg.Read() == true)
            //        {
            //            txtNombre.Text = Reg["nombre"].ToString();
            //            txtUser.Text = Reg["username"].ToString();
            //            cmbTipo.SelectedValue = Reg["tipo"].ToString();

            //            this.conn.Close();
            //        }
            //        txtUser.ReadOnly = false;
            //        txtNombre.ReadOnly = false;
            //        txtPassword.ReadOnly = false;
            //        txtConfirmar.ReadOnly = false;
            //        btnBuscar.Enabled = false;
            //        txtId.Enabled = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario no encontrado o no existe");
            //        txtNombre.Clear();
            //        txtUser.Clear();
            //        txtId.Clear();
            //    }
            //}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MenuADM obManUs = new MenuADM();
            obManUs.Show();
            this.Hide();
        }
    }
}
