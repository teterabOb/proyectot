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
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Configuration;
using System.Drawing.Imaging;
using Logica.Clases;
using Presentacion.Menu;

namespace Presentacion.Pantallas
{
    public partial class MantenedorRuta : Form
    {
        //public MantenedorRuta()
        //{
        //    InitializeComponent();
        //}

        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorRuta()
        {
            InitializeComponent();

            this.cadenaconexion = (@"Data Source =DESKTOP-AA9RM3O; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
            CargaBotones();
        }

        private void MantenedorRuta_Load(object sender, EventArgs e)
        {
            tbtnEliminar.Enabled = false;
            tbtnGuardar.Enabled = false;
            tbtnCancelar.Enabled = false;
            tbtnActualizar.Enabled = false;
            tbpIngresoDatos.Enabled = false;
            rutassDGV(dgvRutas);
            txtIdRuta.Text = generarCodigo();
            codigoDeBarra.DataToEncode = generarCodigo();
            pictureBox1.Image = codigoDeBarra.BMPPicture;
            txtEstado.ReadOnly = true;
            txtEstado.Text = "EN RUTA";
            txtIdEstado.Text = "1";
            txtIdEstado.Visible = false;
            txtIdObra.Visible = false;
            txtIdCamion.Visible = false;
            txtIdChofer.Visible = false;
            txtRutChofer.ReadOnly = true;
            txtModeloCamion.ReadOnly = true;
            txtIdMaterial.Visible = false;


            cmbNombreChofer.Items.Insert(0, "Seleccionar");
            foreach (DataRow fila in NombreChofer().Rows)
            {
                cmbNombreChofer.Items.Add(Convert.ToString(fila["primernombre"]));
            }
            cmbNombreChofer.SelectedIndex = 0;


            cmbPatente.Items.Insert(0, "Seleccionar");
            foreach (DataRow fila in cargaPatente().Rows)
            {
                                    
                cmbPatente.Items.Add(Convert.ToString(fila["patente"]));

            }
            cmbPatente.SelectedIndex = 0;

            cmbNombreObra.Items.Insert(0, "Seleccionar");
            foreach (DataRow fila in nombreObra().Rows)
            {
                cmbNombreObra.Items.Add(Convert.ToString(fila["nombreobra"]));

            }
            cmbNombreObra.SelectedIndex = 0;

            cmbNombreMaterial.Items.Insert(0, "Seleccionar");
            foreach (DataRow fila in nombreMaterial().Rows)
            {
                cmbNombreMaterial.Items.Add(Convert.ToString(fila["nombresubcategoria"]));

            }
            cmbNombreMaterial.SelectedIndex = 0;

        }

        public DataTable NombreChofer()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT primernombre from PERSONAL inner join cargo on cargo.idcargo = PERSONAL.idcargo where nombrecargo = 'chofer' ";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public DataTable cargaPatente()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT patente from camion";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public DataTable nombreObra()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT nombreobra from obra";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public DataTable nombreMaterial()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT nombresubcategoria from subcategoria";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            return dt;
        }

        public string rutChofer(string nombre)
        {
            string resul;
            DataTable dt = new DataTable();
            string sql = "SELECT rut  from PERSONAL inner join cargo on cargo.idcargo = PERSONAL.idcargo where primernombre = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            this.conn.Open();
            resul = Convert.ToString(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public int idChofer(string nombre)
        {
            int resul = 0;
            DataTable dt = new DataTable();
            string sql = "SELECT idpersonal  from PERSONAL inner join cargo on cargo.idcargo = PERSONAL.idcargo where primernombre = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public string modeloCamion(string nombre)
        {
            string resul;
            DataTable dt = new DataTable();
            string sql = "SELECT MODELO.nombre from camion inner join MODELO on MODELO.idModelo = CAMION.idModelo where patente = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToString(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public int idCamion(string nombre)
        {
            int resul = 0; ;
            DataTable dt = new DataTable();
            string sql = "SELECT idcamion from camion inner join MODELO on MODELO.idModelo = CAMION.idModelo where patente = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public int idObra(string nombre)
        {
            int resul = 0; ;
            DataTable dt = new DataTable();
            string sql = "SELECT idObra from obra where nombreobra = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public int idSubCategoria(string nombre)
        {
            int resul = 0; ;
            DataTable dt = new DataTable();
            string sql = "SELECT idsubcategoria from subcategoria where nombresubcategoria = '" + nombre + "'";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            conn.Open();
            resul = Convert.ToInt32(comandosql.ExecuteScalar());
            conn.Close();
            return resul;
        }

        public string generarCodigo()
        {
            int l = 7;
            Random aleatorio = new Random();
            string res = "";
            string[] vals = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = 0; i <= l; i++)
            {
                res = res + vals[aleatorio.Next(vals.GetUpperBound(0) + 1)];
            }
            return res;
        }

        private void cmbNombreChofer_TextChanged(object sender, EventArgs e)
        {
            string res;
            res = rutChofer(cmbNombreChofer.SelectedItem.ToString());
            txtRutChofer.Text = res.ToString();

            int resu = 0;
            resu = idChofer(cmbNombreChofer.SelectedItem.ToString());
            txtIdChofer.Text = resu.ToString();

        }

        private void cmbPatente_TextChanged(object sender, EventArgs e)
        {
            string res;
            res = modeloCamion(cmbPatente.SelectedItem.ToString());
            txtModeloCamion.Text = res.ToString();

            int resu = 0;
            resu = idCamion(cmbPatente.SelectedItem.ToString());
            txtIdCamion.Text = resu.ToString();

        }

        private void cmbNombreObra_TextChanged(object sender, EventArgs e)
        {
            int resu = 0;
            resu = idObra(cmbNombreObra.SelectedItem.ToString());
            txtIdObra.Text = resu.ToString();

        }

        private void cmbMaterial_TextChanged(object sender, EventArgs e)
        {
            int resu = 0;
            resu = idSubCategoria(cmbNombreMaterial.SelectedItem.ToString());
            txtIdMaterial.Text = resu.ToString();

        }

        //private void btnBuscarPorIdRuta_Click(object sender, EventArgs e)
        //{
        //    if (txtIdRuta.Text == "")
        //    {
        //        MessageBox.Show("Debe ingresar una ID a buscar");
        //    }
        //    else
        //    {
        //        Ruta objRuta = new Ruta();
        //        objRuta.Idruta = txtIdRuta.Text;
        //        objRuta.buscarRuta();

        //        if (objRuta.buscarRuta() == 1)
        //        {
        //            MessageBox.Show("Ruta encontrada con éxito");
        //            this.sql = string.Format(@"select camion.idcamion,personal.idpersonal,subcategoria.idsubcategoria,obra.idobra,modelo.nombre,estadoruta.nombreestado,ruta.descripcioncarga,ruta.NombreRuta,personal.rut,PERSONAL.PrimerNombre,CAMION.patente,obra.NombreObra,SUBCATEGORIA.NombreSubCategoria from RUTA inner join PERSONAL on personal.idPersonal=ruta.idPersonal inner join CAMION on camion.idCamion=ruta.idCamion inner join OBRA on obra.idObra=ruta.idObra inner join SUBCATEGORIA on SUBCATEGORIA.idSubcategoria=ruta.idSubCategoria inner join modelo on CAMION.idModelo = MODELO.idModelo inner join ESTADORUTA on ESTADORUTA.idEstadoRuta = ruta.idEstado where RUTA.idRuta ='" + txtIdRuta.Text + "'");
        //            this.comandosql = new SqlCommand(this.sql, this.conn);
        //            this.conn.Open();
        //            SqlDataReader Reg = null;
        //            Reg = this.comandosql.ExecuteReader();
        //            if (Reg.Read() == true)
        //            {
        //                txtNombreRuta.Text = Reg["nombreestado"].ToString();
        //                txtNombreRuta.Text = Reg["nombreruta"].ToString();
        //                txtRutChofer.Text = Reg["rut"].ToString();
        //                txtModeloCamion.Text = Reg["nombre"].ToString();
        //                txtDescripcion.Text = Reg["descripcioncarga"].ToString();                      
        //                txtIdCamion.Text = Reg["idcamion"].ToString(); ;
        //                txtIdChofer.Text = Reg["idpersonal"].ToString(); ;
        //                txtIdMaterial.Text = Reg["idsubcategoria"].ToString(); ;
        //                txtIdObra.Text = Reg["idobra"].ToString(); ;
        //                this.conn.Close();
        //                tbtnActualizar.Enabled = true;
        //                tbtnEliminar.Enabled = true;
        //                txtDescripcion.ReadOnly = false;
        //                txtIdRuta.ReadOnly = true;
        //                txtNombreRuta.ReadOnly = false;
        //            }

        //        }
        //        else
        //        {
        //            MessageBox.Show("Usuario no encontrado o no existe");
        //            txtIdRuta.Clear();
        //        }
        //    }
        //    rutassDGV(dgvRutas);
        //}

        public void rutassDGV(DataGridView dv)
        {
            DataTable dt = new DataTable();
            string sql = string.Format(@"SELECT imagencodigo
                                                ,idruta [CODIGO]
                                                ,nombreruta [NOMBRE]
                                                ,fechacreacion [FECHA_CREACION]
                                                ,descripcioncarga  [DESCRIPCION]
                                                FROM RUTA ");
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
        //    this.sql = string.Format("select imagencodigo from ruta where idruta = '" + txtIdBuscar.Text + "'");
        //    this.conn.Open();
        //    this.comandosql = new SqlCommand(this.sql, this.conn);
        //    SqlDataAdapter da = new SqlDataAdapter(this.comandosql);
        //    DataSet ds = new DataSet();


        //    da.Fill(ds, "ruta");
        //    conn.Close();
        //    byte[] ap = (byte[])(ds.Tables["ruta"].Rows[0]["imagencodigo"]);
        //    System.IO.MemoryStream ms1 = new System.IO.MemoryStream(ap);
        //    MemoryStream ms = new MemoryStream();
        //    pbImagenRuta.Image = System.Drawing.Image.FromStream(ms1);
        //    ms.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tclMantenedorRutas.SelectedTab = tbpIngresoDatos;
            tbpIngresoDatos.Enabled = true;
            //tbtnGuardar.Enabled = true;
            txtIdRuta.ReadOnly = true;
            //tbtnCancelar.Enabled = true;
            AccionBtnNuevo();
        }

        public void AccionBtnNuevo()
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = false;
            btnBuscarPorIdRuta.Enabled = true;

            cmbNombreChofer.Enabled = true;
            cmbPatente.Enabled = true;
            cmbNombreMaterial.Enabled = true;
            cmbNombreObra.Enabled = true;
        }

        public void AccionBtnCancelar()
        {
            CargaBotones();

        }

        public void LimpiaControles()
        {
            txtNombreRuta.Text = String.Empty;
            txtModeloCamion.Text = String.Empty;
            txtRutChofer.Text = String.Empty;
            txtDescripcion.Text = String.Empty;

      
        }

        public void DesactivaControles()
        {
            cmbNombreChofer.Enabled = false;
            cmbPatente.Enabled = false;
            cmbNombreMaterial.Enabled = false;
            cmbNombreObra.Enabled = false;
            txtNombreRuta.Enabled = false; 
            txtDescripcion.Enabled = false;
            btnBuscarPorIdRuta.Enabled = false;
        }

        public void ActivaControles()
        {
            cmbNombreChofer.Enabled = true;
            cmbPatente.Enabled = true;
            cmbNombreMaterial.Enabled = true;
            cmbNombreObra.Enabled = true;
            txtNombreRuta.Enabled = true;
            txtDescripcion.Enabled = true;
            btnBuscarPorIdRuta.Enabled = true;
        }

        public void CargaBotones()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = true;
            btnBuscarPorIdRuta.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AccionBtnCancelar();
            DesactivaControles();
            LimpiaControles();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreRuta.Text != "" && txtIdChofer.Text != "" && txtIdCamion.Text != "" && txtIdEstado.Text != "" &&
               txtIdObra.Text != "" && txtIdMaterial.Text != "" && txtDescripcion.Text != "")
            {
                codigoDeBarra.SaveImageAs(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG", System.Drawing.Imaging.ImageFormat.Jpeg);
                //codigoDeBarra.SaveImageAs(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG", System.Drawing.Imaging.ImageFormat.Jpeg);

                FileStream stream = new FileStream(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG", FileMode.Open, FileAccess.Read);

                byte[] bd = new byte[stream.Length];
                stream.Read(bd, 0, Convert.ToInt32(stream.Length));

                nRuta neg = new nRuta();
                neg.Idruta = txtIdRuta.Text;
                neg.Nombreruta = txtNombreRuta.Text;
                neg.Fechacreacion = (DateTime.Now).ToString();
                neg.Idpersonal = Convert.ToInt32(txtIdChofer.Text);
                neg.Idcamion = Convert.ToInt32(txtIdCamion.Text);
                neg.Idestado = Convert.ToInt32(txtIdEstado.Text);
                neg.Idobra = Convert.ToInt32(txtIdObra.Text);
                neg.Idsubcategoria = Convert.ToInt32(txtIdMaterial.Text);
                neg.Descripcion = txtDescripcion.Text;
                neg.ImagenCodigo  = bd;
                neg.Insert(neg);             


                MessageBox.Show("Ruta Ingresada con exito");

                txtIdRuta.Text = "";
                txtNombreRuta.Text = "";
                txtObra.Text = "";
                txtIdRuta.Text = generarCodigo();
            }
            else
            {
                MessageBox.Show("No deben haber campos vacios");
                txtIdRuta.Text = "";
                txtIdRuta.Text = generarCodigo();
            }
            txtIdRuta.Text = generarCodigo();
            codigoDeBarra.DataToEncode = txtIdRuta.Text;
            pictureBox1.Image = codigoDeBarra.BMPPicture;
            rutassDGV(dgvRutas);
        }

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    if (txtIdRuta.Text != "")
        //    {
        //        Ruta objRuta = new Ruta();
        //        objRuta.Idruta = txtIdRuta.Text;
        //        if (objRuta.rutaExistente() == true)
        //        {
        //            this.sql = string.Format(@"DELETE FROM ruta where idruta = '" + txtIdRuta.Text + "'");
        //            this.comandosql = new SqlCommand(this.sql, this.conn);
        //            this.conn.Open();
        //            SqlDataReader Reg = null;
        //            Reg = this.comandosql.ExecuteReader();
        //            MessageBox.Show("Ruta eliminada");
        //            txtIdRuta.Focus();
        //            this.conn.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("ruta no encontrada");
        //            txtIdRuta.Clear();
        //            txtIdRuta.Focus();
        //        }
        //        txtIdRuta.Clear();
        //        txtModeloCamion.Clear();
        //        txtNombreRuta.Clear();
        //        txtDescripcion.Clear();
        //        txtModeloCamion.Clear();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Debe ingresar una ID a eliminar");
        //    }
        //}



        //private void btnActualizar_Click(object sender, EventArgs e)
        //{
        //    Ruta objRuta = new Ruta();
        //    objRuta.Nombreruta = txtNombreRuta.Text;
        //    objRuta.Idpersonal = Convert.ToInt32(txtIdChofer.Text);
        //    objRuta.Idcamion = Convert.ToInt32(txtIdCamion.Text);
        //    objRuta.Idestado = Convert.ToInt32(txtIdEstado.Text);
        //    objRuta.Idobra = Convert.ToInt32(txtIdObra.Text);
        //    objRuta.Idsubcategoria = Convert.ToInt32(txtIdMaterial.Text);
        //    objRuta.Idruta = txtIdRuta.Text;
        //    objRuta.Descripcion = txtDescripcion.Text;
        //    objRuta.editarRuta();
        //    rutassDGV(dgvRutas);
        //}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdRuta.Text = "";
            tclMantenedorRutas.SelectedTab = tbpIngresoDatos;
            tbpIngresoDatos.Enabled = true;
            txtIdRuta.ReadOnly = false;
            txtNombreRuta.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            tbtnCancelar.Enabled = true;
            txtIdRuta.ReadOnly = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuADM log = new MenuADM();
            log.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void cmbNombreChofer_ValueMemberChanged(object sender, EventArgs e)
        {

        }

    }
}
