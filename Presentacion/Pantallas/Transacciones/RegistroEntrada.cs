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

namespace Presentacion.Pantallas
{
    public partial class RegistroEntrada : Form
    {
        //public RegistroEntrada()
        //{
        //    InitializeComponent();
        //}
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public RegistroEntrada()
        {
            cadenaconexion = (@"Data Source =.; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
            InitializeComponent();
        }

        public string DatosRuta(int idruta)
        {
            string resul;
            DataTable dt = new DataTable();
            string sql = "select personal.PrimerNombre NOMBRE, PERSONAL.ApellidoPaterno, PERSONAL.rut, CAMION.patente,ESTADORUTA.NombreEstado, SUBCATEGORIA.nombresubcategoria, OBRA.NombreObra, RUTA.DescripcionCarga from RUTA inner join PERSONAL on PERSONAL.idPersonal = RUTA.idPersonal inner join CAMION on CAMION.idCamion = RUTA.idCamion inner join ESTADORUTA on ESTADORUTA.idEstadoRuta = ruta.idEstado inner join SUBCATEGORIA on SUBCATEGORIA.idSubcategoria = ruta.idSubCategoria inner join OBRA on OBRA.idObra = ruta.idObra where RUTA.idRuta = '" + idruta + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToString(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public void rutasDisponiblesEntradaDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = @"select ruta.imagencodigo,personal.PrimerNombre, PERSONAL.ApellidoPaterno, PERSONAL.rut, CAMION.patente,ESTADORUTA.NombreEstado, SUBCATEGORIA.nombresubcategoria, OBRA.NombreObra, RUTA.DescripcionCarga from RUTA inner join PERSONAL on PERSONAL.idPersonal = RUTA.idPersonal inner join CAMION on CAMION.idCamion = RUTA.idCamion inner join ESTADORUTA on ESTADORUTA.idEstadoRuta = ruta.idEstado inner join SUBCATEGORIA on SUBCATEGORIA.idSubcategoria = ruta.idSubCategoria inner join OBRA on OBRA.idObra = ruta.idObra where ruta.idestado = 1";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);

            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

        private void RegistroEntrada_Load(object sender, EventArgs e)
        {

            txtIdRuta.Focus();
            tmrHora.Enabled = true;
            txtNombreChofer.ReadOnly = true;
            rutasDisponiblesEntradaDGV(dgvRutas);


        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            txtFechaIngreso.Text = DateTime.Now.ToString();
            txtFechaIngreso.ReadOnly = true;
        }


        private void txtIdRuta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIdRuta.MaxLength = 8;
                string codigo = txtIdRuta.Text;

            }

        }

        private void btnBuscarr_Click(object sender, EventArgs e)
        {
            this.sql = string.Format("select personal.PrimerNombre, PERSONAL.ApellidoPaterno, PERSONAL.rut, CAMION.patente,ESTADORUTA.NombreEstado, SUBCATEGORIA.nombresubcategoria, OBRA.NombreObra, RUTA.DescripcionCarga from RUTA inner join PERSONAL on PERSONAL.idPersonal = RUTA.idPersonal inner join CAMION on CAMION.idCamion = RUTA.idCamion inner join ESTADORUTA on ESTADORUTA.idEstadoRuta = ruta.idEstado inner join SUBCATEGORIA on SUBCATEGORIA.idSubcategoria = ruta.idSubCategoria inner join OBRA on OBRA.idObra = ruta.idObra where RUTA.idRuta =  '" + txtIdRuta.Text + "' and ruta.idestado = 1");
            this.comandosql = new SqlCommand(this.sql, this.conn);
            this.conn.Open();
            SqlDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read() == true)
            {
                txtNombreChofer.Text = Reg["PrimerNombre"].ToString();
                txtApellidoPaterno.Text = Reg["ApellidoPaterno"].ToString();
                txtRut.Text = Reg["rut"].ToString();
                txtPatente.Text = Reg["patente"].ToString();
                txtEstado.Text = Reg["nombreestado"].ToString();
                txtMaterial.Text = Reg["nombresubcategoria"].ToString();
                txtDestino.Text = Reg["nombreobra"].ToString();
                txtCarga.Text = Reg["descripcioncarga"].ToString();

                this.conn.Close();
                MessageBox.Show("Ruta Encontrada, Ingrese un comentario");
                txtComentario.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("ruta no encontrada");
                txtIdRuta.Text = "";
            }
            this.conn.Close();
        }

        //private void btnRegistrarEntra_Click(object sender, EventArgs e)
        //{
        //    if (txtIdRuta.Text != "")
        //    {
        //        Entrada objEntrada = new Entrada();
        //        objEntrada.Fechaentrada = Convert.ToDateTime(txtFechaIngreso.Text);
        //        objEntrada.Comentario = txtComentario.Text;
        //        objEntrada.Idruta = txtIdRuta.Text;
        //        objEntrada.registrarEntrada();
        //        Ruta objRuta = new Ruta();
        //        objRuta.Idruta = txtIdRuta.Text;
        //        objRuta.actualizarEstadoRutaEntrada();
        //        MessageBox.Show("Se ha registrado la entrada");
        //    }
        //    else
        //    {
        //        MessageBox.Show("no se pudo registrar la entrada");
        //    }
        //}

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuADM obManUs = new MenuADM();
            obManUs.Show();
            this.Hide();
        }

        private void btnRegistrarEntra_Click(object sender, EventArgs e)
        {

        }


    }
}
