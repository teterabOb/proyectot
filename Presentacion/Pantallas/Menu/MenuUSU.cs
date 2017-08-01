using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Pantallas.Mantenedores;
using Presentacion.Pantallas.Menu;

namespace Presentacion.Pantallas.Menu
{
    public partial class MenuUSU : Form
    {
        public MenuUSU()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenedorCargo obManUs = new MantenedorCargo();
            obManUs.Show();
            this.Hide();
        }

        //private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    MantenedorUsuario obManUs = new MantenedorUsuarios();           
        //    obManUs.Show();
        //    this.Hide();
        //}


        private void comunaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenedorComuna obManUs = new MantenedorComuna();
            obManUs.Show();
            this.Hide();
        }



        private void marcaCamiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorMarca obManUs = new MantenedorMarca();
            obManUs.Show();
            this.Hide();
        }

        private void modeloCamiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorModelo obManUs = new MantenedorModelo();
            obManUs.Show();
            this.Hide();
        }



        private void obraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenedorObra obManUs = new MantenedorObra();
            obManUs.Show();
            this.Hide();
        }

        private void regiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorRegion obManUs = new MantenedorRegion();
            obManUs.Show();
            this.Hide();
        }

        private void subCategoríaDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorSubCategoria obManUs = new MantenedorSubCategoria();
            obManUs.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenedorCamion obManUs = new MantenedorCamion();
            obManUs.Show();
            this.Hide();
        }

        private void registroEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEntrada obManUs = new RegistroEntrada();
            obManUs.Show();
            this.Hide();
        }

        private void registroSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroSalida obManUs = new RegistroSalida();
            obManUs.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorCategoria log = new MantenedorCategoria();
            log.Show();
            this.Hide();
        }

        private void comunaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MantenedorComuna log = new MantenedorComuna();
            log.Show();
            this.Hide();
        }

        private void modeloCamiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenedorModelo log = new MantenedorModelo();
            log.Show();
            this.Hide();
        }



        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorRuta log = new MantenedorRuta();
            log.Show();
            this.Hide();
        }

        private void MenuUSU_Load(object sender, EventArgs e)
        {

        }
    }
}
