using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.C6
{
    public partial class MensajeForm : Form
    {
        private string mensaje;
        
        public MensajeForm()
        {
            //this.mensaje = mensaje;
            InitializeComponent();
            this.label1.Text = string.Empty;
            //this.LblSaludo.Text = mensaje;

        }    

        public string Mensaje
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                string valor = value.Trim();
                this.label1.Text = value;
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

