using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Configuration;
using System.Drawing.Imaging;




namespace Proyecto
{
    public partial class MantenedorRuta : Form
    {
        public string cadenaconexion;
        protected string sql;
        //protected int resultado;
        protected SqlConnection conn;
        protected SqlCommand comandosql;
        protected string mensaje;

        public MantenedorRuta()
        {
            //InitializeComponent();

            this.cadenaconexion = (@"Data Source =DESKTOP-T2K4EBD; Initial Catalog = PROYECTOT; Integrated security=true");
            this.conn = new SqlConnection(this.cadenaconexion);
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
            DataTable dt = NombreChofer();
            foreach (DataRow fila in dt.Rows)
            {
                cmbNombreChofer.Items.Add(Convert.ToString(fila["primernombre"]));

            }

            DataTable dt1 = cargaPatente();
            foreach (DataRow fila in dt1.Rows)
            {
                cmbPatente.Items.Add(Convert.ToString(fila["patente"]));

            }

            DataTable dt2 = nombreObra();
            foreach (DataRow fila in dt2.Rows)
            {
                cmbNombreObra.Items.Add(Convert.ToString(fila["nombreobra"]));

            }

            DataTable dt3 = nombreMaterial();
            foreach (DataRow fila in dt3.Rows)
            {
                cmbNombreMaterial.Items.Add(Convert.ToString(fila["nombresubcategoria"]));

            }

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
            string sql = "SELECT imagencodigo,idruta,nombreruta,fechacreacion,descripcioncarga FROM RUTA  ";
            SqlCommand comandosql = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comandosql);
            da.Fill(dt);
            dv.DataSource = dt;
            conn.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.sql = string.Format("select imagencodigo from ruta where idruta = '" + txtIdBuscar.Text+"'");
            this.conn.Open();
            this.comandosql = new SqlCommand(this.sql, this.conn);
            SqlDataAdapter da = new SqlDataAdapter(this.comandosql);
            DataSet ds = new DataSet();
            
            
            da.Fill(ds, "ruta");
            conn.Close();
            byte[] ap = (byte[])(ds.Tables["ruta"].Rows[0]["imagencodigo"]);
            System.IO.MemoryStream ms1 = new System.IO.MemoryStream(ap);
            MemoryStream ms = new MemoryStream();
            pbImagenRuta.Image = System.Drawing.Image.FromStream(ms1);
            ms.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tclMantenedorRutas.SelectedTab = tbpIngresoDatos;
            tbpIngresoDatos.Enabled = true;
            tbtnGuardar.Enabled = true;
            txtIdRuta.ReadOnly = true;
            tbtnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreRuta.Text != "" && txtIdChofer.Text != "" && txtIdCamion.Text != "" && txtIdEstado.Text != "" &&
               txtIdObra.Text != "" && txtIdMaterial.Text != "" && txtDescripcion.Text != "")
            {
                codigoDeBarra.SaveImageAs(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG", System.Drawing.Imaging.ImageFormat.Jpeg);
                //CREA IMAGEN CON CODIGO QR
                //System.Drawing.Image img = (System.Drawing.Image)qrRuta.Image.Clone();
                //ptrCodigoQr.Image = img;
                //ptrCodigoQr.Image.Save(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG");
                //CREA PDF Y LE INSERTA LA IMAGEN CON CODIGO QR

                /*
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".pdf", FileMode.OpenOrCreate));
                document.Open();
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG");
                jpg.Alignment = iTextSharp.text.Image.MIDDLE_ALIGN;
                document.Add(jpg);
                document.Add(new Paragraph(txtDescripcion.Text));
                document.Close();
                 * */

                codigoDeBarra.SaveImageAs(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG", System.Drawing.Imaging.ImageFormat.Jpeg);


                DateTime fe = DateTime.Now.Date;
                this.conn.Open();
                this.sql = string.Format(@"INSERT INTO ruta (idruta,nombreruta,fechacreacion,idpersonal,idcamion,idestado,idobra,idsubcategoria,descripcioncarga,imagencodigo) values (@idruta,@nombreruta,@fecha,@idpersonal,@idcamion,@idestado,@idobra,@idsubcategoria,@descripcioncarga,@imagencodigo)");
                this.comandosql = new SqlCommand(this.sql, this.conn);
                this.comandosql.Parameters.AddWithValue("@idruta", txtIdRuta.Text);
                this.comandosql.Parameters.AddWithValue("@nombreruta", txtNombreRuta.Text);
                this.comandosql.Parameters.AddWithValue("@idpersonal", txtIdChofer.Text);
                this.comandosql.Parameters.AddWithValue("@idcamion", txtIdCamion.Text);
                this.comandosql.Parameters.AddWithValue("@idestado", txtIdEstado.Text);
                this.comandosql.Parameters.AddWithValue("@idobra", txtIdObra.Text);
                this.comandosql.Parameters.AddWithValue("@idsubcategoria", txtIdMaterial.Text);
                this.comandosql.Parameters.AddWithValue("@descripcioncarga", txtDescripcion.Text);
                this.comandosql.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = fe;

                FileStream stream = new FileStream(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG", FileMode.Open, FileAccess.Read);

                byte[] bd = new byte[stream.Length];
                stream.Read(bd, 0, Convert.ToInt32(stream.Length));
                this.comandosql.Parameters.AddWithValue("@imagencodigo", bd);
                this.comandosql.ExecuteNonQuery();

                //MemoryStream ms= new MemoryStream();
                //pbImagenRuta.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] b = new byte[m_MemoryStream.Length];
                //m_MemoryStream.Read(b, 0, Convert.ToInt32(m_MemoryStream.Length));
                //this.comandosql.Parameters.AddWithValue("@imagencodigo", ms);
                //this.comandosql.ExecuteNonQuery();

                /*
                MemoryStream m_MemoryStream = new MemoryStream();
                pictureBox1.Image.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] m_imagen = m_MemoryStream.ToArray();

                
                Ruta objRuta = new Ruta();
                objRuta.Idruta = txtIdRuta.Text;
                objRuta.Nombreruta = txtNombreRuta.Text;
                objRuta.ImagenCodigo = m_imagen;
                objRuta.Idpersonal = Convert.ToInt32(txtIdChofer.Text);
                objRuta.Idcamion = Convert.ToInt32(txtIdCamion.Text);
                objRuta.Idestado = Convert.ToInt32(txtIdEstado.Text);
                objRuta.Idobra = Convert.ToInt32(txtIdObra.Text);
                objRuta.Idsubcategoria = Convert.ToInt32(txtIdMaterial.Text);
                objRuta.Descripcion = txtDescripcion.Text;
                objRuta.crearRuta();
                 * */


                MessageBox.Show("Ruta Ingresada con exito");

                //codigoDeBarra.SaveImageAs(@"C:\Users\GILBERTS\Pictures\" + txtIdRuta.Text + ".JPG", System.Drawing.Imaging.ImageFormat.Jpeg);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tclMantenedorRutas.SelectedTab = tbpDatos;
        }

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

        private void Inicio()
        {
            this.SuspendLayout();
            // 
            // MantenedorRuta
            // 
            this.ClientSize = new System.Drawing.Size(914, 566);
            this.Name = "MantenedorRuta";
            this.ResumeLayout(true);

        }


        
    }
}

        

        

        

        

        
        
    

