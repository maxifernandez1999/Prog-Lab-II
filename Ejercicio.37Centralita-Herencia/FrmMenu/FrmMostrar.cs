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
        public FrmMostrar(Centralita c)
        {
            InitializeComponent();
            if (tipo == Llamada.TipoLlamada.Local)
            {
                richTxtBox.Text = c.GananciaPorLocal.ToString();
            }
            else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                richTxtBox.Text = c.GananciaPorProvincial.ToString();

            }
            else if (tipo == Llamada.TipoLlamada.Local && tipo == Llamada.TipoLlamada.Provincial)
            {
                richTxtBox.Text = c.GananciaPorTotal.ToString();
            }
            
            
            
        }
        public Llamada.TipoLlamada Tipo
        {
            set
            {
                tipo = value;
            }
        }

    }
}
