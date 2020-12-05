using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio._69
{
    public delegate void MostrarDelegado(string dato);
    public partial class FormMostrar : Form
    {
        public event MostrarDelegado EventoMostrar;
        public FormMostrar()
        {
            InitializeComponent();
        }
        public void ActualizarNombre(string dato)
        {
            lblMostrar.Text = dato;
        }
    }
}
