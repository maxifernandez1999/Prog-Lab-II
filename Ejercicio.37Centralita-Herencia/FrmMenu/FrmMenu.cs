using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace FrmMenu
{
    public partial class FrmMenu : Form
    {
        public Centralita c;
        public FrmMenu()
         {
            InitializeComponent();

        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(c);
            llamador.ShowDialog();
        }

        private void btnFactTotal_Click(object sender, EventArgs e)
        {

            //Llamada.TipoLlamada tipo = Llamada.TipoLlamada.Todas;
            FrmMostrar mostrar = new FrmMostrar(c);
            mostrar.Tipo = Llamada.TipoLlamada.Todas;

            mostrar.ShowDialog();
        }

        private void btnFactLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(c);
            mostrar.Tipo = Llamada.TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFactProv_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(c);
            mostrar.Tipo = Llamada.TipoLlamada.Provincial;
            mostrar.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            c = new Centralita("nn");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
