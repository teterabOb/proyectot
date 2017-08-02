using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Pantallas;
using Presentacion.Pantallas.Reportes;
using Presentacion.Pantallas.MantenedorUsuarios;

namespace Presentacion.Menu
{
    public partial class MenuADM : Form 
    {
        public MenuADM()
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
            //MantenedorCargo obManUs = new MantenedorCargo();
            //obManUs.Show();
            //this.Hide();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorUsuarios obManUs = new MantenedorUsuarios();
            //obManUs.Show();
            //this.Hide();
        }


        private void comunaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MantenedorComuna obManUs = new MantenedorComuna();
            //obManUs.Show();
            //this.Hide();
        }

        private void marcaCamiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorMarca obManUs = new MantenedorMarca();
            //obManUs.Show();
            //this.Hide();
        }

        private void modeloCamiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorModelo obManUs = new MantenedorModelo();
            //obManUs.Show();
            //this.Hide();
        }



        private void obraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MantenedorObra obManUs = new MantenedorObra();
            //obManUs.Show();
            //this.Hide();
        }

        private void regiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorRegion obManUs = new MantenedorRegion();
            //obManUs.Show();
            //this.Hide();
        }

        private void subCategoríaDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorSubCategoria obManUs = new MantenedorSubCategoria();
            //obManUs.Show();
            //this.Hide();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MantenedorCamion obManUs = new MantenedorCamion();
            //obManUs.Show();
            //this.Hide();
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
            //MantenedorCategoria log = new MantenedorCategoria();
            //log.Show();
            //this.Hide();
        }

        private void comunaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //MantenedorComuna log = new MantenedorComuna();
            //log.Show();
            //this.Hide();
        }

        private void modeloCamiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MantenedorModelo log = new MantenedorModelo();
            //log.Show();
            //this.Hide();
        }

        private void MenuADM_Load(object sender, EventArgs e)
        {

        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorRuta log = new MantenedorRuta();
            log.Show();
            this.Hide();
        }



        private void rutaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MantenedorRuta log = new MantenedorRuta();
            log.Show();
            this.Hide();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorCiudad log = new MantenedorCiudad();
            //log.Show();
            //this.Hide();
        }

        private void comunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorComuna log = new MantenedorComuna();
            //log.Show();
            //this.Hide();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorModelo log = new MantenedorModelo();
            //log.Show();
            //this.Hide();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorMarca log = new MantenedorMarca();
            //log.Show();
            //this.Hide();
        }

        private void camiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorCamion log = new MantenedorCamion();
            //log.Show();
            //this.Hide();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorCargo log = new MantenedorCargo();
            //log.Show();
            //this.Hide();
        }

        private void categoríaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //MantenedorCategoria log = new MantenedorCategoria();
            //log.Show();
            //this.Hide();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorMaterial log = new MantenedorMaterial();
            //log.Show();
            //this.Hide();
        }

        private void obraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorObra log = new MantenedorObra();
            //log.Show();
            //this.Hide();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorPersonal log = new MantenedorPersonal();
            //log.Show();
            //this.Hide();
        }

        private void regiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //MantenedorRegion log = new MantenedorRegion();
            //log.Show();
            //this.Hide();
        }

        private void rutaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenedorRuta log = new MantenedorRuta();
            log.Show();
            this.Hide();
        }

        private void subCategoríaMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MantenedorSubCategoria log = new MantenedorSubCategoria();
            //log.Show();
            //this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorUsuarios log = new MantenedorUsuarios();
            log.Show();
            this.Hide();
        }

        private void generarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes log = new Reportes();
            log.Show();
            this.Hide();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
