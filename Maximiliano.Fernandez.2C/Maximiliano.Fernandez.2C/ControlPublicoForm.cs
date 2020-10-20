using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maximiliano.Fernandez._2C
{
    public partial class ControlPublicoForm : Form
    {
        
        public ControlPublicoForm()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string Nombre
        {
            get
            {
                return txtNombre.Text;
            }
        }
        public string Dni
        {
            get
            {
                return txtDNI.Text;
            }
        }
        public string Edad
        {
            get
            {
                return txtEdad.Text;
            }
        }

        
    }
}
