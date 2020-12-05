using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
namespace Ejercicio._68
{
    public partial class Form1 : Form
    {
        private Persona persona;
        public Form1()
        {
            InitializeComponent();
        }
        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                persona = new Persona(txtApellido.Text, txtNombre.Text);
                btnCrear.Text = "Actualizar";
                persona.Mostrar();
            }
            else
            {
                
                persona.EventoString += NotificarCambio;
            }

        }
    }
}
