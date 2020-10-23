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
    public partial class FrmMostrar : Form
    {
        public Llamada.TipoLlamada tipo;
        Centralita c;
        public FrmMostrar(Centralita c)
        {
            this.c = c;
            InitializeComponent();
            
        }
        public Llamada.TipoLlamada Tipo
        {
            set
            {
                tipo = value;
            }
            get
            {
                return this.tipo;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (tipo == Llamada.TipoLlamada.Local)
            {
                richTxtBox.Text = "Ganancia por llamadas locales: " + c.GananciaPorLocal.ToString();
            }
            else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                richTxtBox.Text = "Ganancia por llamadas provinciales: " + c.GananciaPorProvincial.ToString();

            }
            else if (tipo == Llamada.TipoLlamada.Todas)
            {
                richTxtBox.Text = "Ganancia por total de llamadas: " + c.GananciaPorTotal.ToString();
            }
        }
    }
}
