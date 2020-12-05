using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MensajeForm : Form
    {
        private string mensaje;
        public MensajeForm()
        {
            //this.mensaje = mensaje;
            InitializeComponent();
            this.LblSaludo.Text = string.Empty;
            //this.LblSaludo.Text = mensaje;

        }

        public string Mensaje
        {
            get
            {
                return this.LblSaludo.Text;
            }
            set
            {
                string valor = value.Trim();
                this.LblSaludo.Text = value;
            }
        }

        private void LblSaludo_Click(object sender, EventArgs e)
        {

        }
        /*  public string GetMensaje()
 {
     return this.LblSaludo.Text;
 }
 public void SetMensaje(string mensaje)
 {
     this.LblSaludo.Text = mensaje;
 }*/
    }
}
