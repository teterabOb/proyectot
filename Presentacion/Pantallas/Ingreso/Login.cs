using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Clases;
using Presentacion.Menu;

namespace Presentacion.Pantallas
{
    public partial class Login : Form
    {
        MenuADM obMenuAd = new MenuADM();

        public Login()
        {
            InitializeComponent();
            
        }
        #region Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Carga al Iniciar
        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seguridadDataSet.TipoUsuario' Puede moverla o quitarla según sea necesario.
            //this.tipoUsuarioTableAdapter.Fill(this.seguridadDataSet.TipoUsuario);
            // TODO: esta línea de código carga datos en la tabla 'seguridadDataSet.TipoUsuario' Puede moverla o quitarla según sea necesario.
            //this.tipoUsuarioTableAdapter.Fill(this.seguridadDataSet.TipoUsuario);

        }
        #endregion

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string contrasena = this.txtPassword.Text;
            int tipousuario = 0;
            if (usuario != String.Empty && contrasena != String.Empty)
            {
                tipousuario = new nUsuario().GetValidaUsuario(usuario, contrasena);
                if (tipousuario == 1)
                {
                    this.obMenuAd.Show();
                    this.Hide();
                }
                else if (tipousuario != 1)
                {
                    MessageBox.Show("Acceso no Permitido");
                    LimpiaTexto();

                }
            }
            else
            {
                MessageBox.Show("Favor Ingresar Información");
                LimpiaTexto();
            }

        }

        public void LimpiaTexto()
        {

            this.txtUsuario.Text = String.Empty;
            this.txtPassword.Text = String.Empty;
        }
    }
}
