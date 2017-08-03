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
    public partial class RegistroSalida : Form
    {
        public RegistroSalida()
        {
            InitializeComponent();
        }
        public string cadenaconexion;
        protected string sql;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;



        //public RegistroSalida()
        //{
        //    this.cadenaconexion = (@"Data Source =.; Initial Catalog = PROYECTOT; Integrated security=true");
        //    this.conn = new SqlConnection(this.cadenaconexion);
        //    InitializeComponent();
        //}

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {

            //DataTable dt = new DataTable();



            //if (txtIdRuta.Text != "")
            //{

            //    Salida objSalida = new Salida();
            //    objSalida.Fechasalida = Convert.ToDateTime(txtFechaIngreso.Text);
            //    objSalida.Comentario = txtComentario.Text;
            //    objSalida.Idruta = txtIdRuta.Text;
            //    objSalida.registrarSalida();
            //    //Ruta objRuta = new Ruta();
            //    //objRuta.Idruta = txtIdRuta.Text;
            //    //objRuta.actualizarEstadoRutaSalida();
            //    MessageBox.Show("Salida registrada con exito");
            //}
            //else
            //{
            //    MessageBox.Show("El campo esta vacio o la ruta no esta disponible");
            //}


        }

        private void btnBuscarr_Click(object sender, EventArgs e)
        {
            //this.sql = string.Format("select personal.PrimerNombre, PERSONAL.ApellidoPaterno, PERSONAL.rut, CAMION.patente,ESTADORUTA.NombreEstado, SUBCATEGORIA.nombresubcategoria, OBRA.NombreObra, RUTA.DescripcionCarga from RUTA inner join PERSONAL on PERSONAL.idPersonal = RUTA.idPersonal inner join CAMION on CAMION.idCamion = RUTA.idCamion inner join ESTADORUTA on ESTADORUTA.idEstadoRuta = ruta.idEstado inner join SUBCATEGORIA on SUBCATEGORIA.idSubcategoria = ruta.idSubCategoria inner join OBRA on OBRA.idObra = ruta.idObra where RUTA.idRuta =  '" + txtIdRuta.Text + "' and ruta.idestado = 2");
            //this.comandosql = new SqlCommand(this.sql, this.conn);
            //this.conn.Open();
            //SqlDataReader Reg = null;
            //Reg = this.comandosql.ExecuteReader();
            //if (Reg.Read() == true)
            //{
            //    txtNombreChofer.Text = Reg["PrimerNombre"].ToString();
            //    txtApellidoPaterno.Text = Reg["ApellidoPaterno"].ToString();
            //    txtRut.Text = Reg["rut"].ToString();
            //    txtPatente.Text = Reg["patente"].ToString();
            //    txtEstado.Text = Reg["nombreestado"].ToString();
            //    txtMaterial.Text = Reg["nombresubcategoria"].ToString();
            //    txtDestino.Text = Reg["nombreobra"].ToString();
            //    txtCarga.Text = Reg["descripcioncarga"].ToString();
            //    MessageBox.Show("Ruta Encontrada");
            //    this.conn.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Ruta NO Encontrada o no disponible");
            //    this.conn.Close();
            //}
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuADM obManUs = new MenuADM();
            obManUs.Show();
            this.Hide();
        }

        private void RegistroSalida_Load(object sender, EventArgs e)
        {
            tmrHora.Enabled = true;
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            txtFechaIngreso.Text = DateTime.Now.ToString();
        }
    }
}
