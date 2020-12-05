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
    public partial class FormPrincipal : Form
    {
        public FrmTestDelegados test;
        public FormMostrar mostrar;
        public FormPrincipal()
        {
            InitializeComponent();
            mostrarToolStripMenuItem.Enabled = false;
            mostrar = new FormMostrar();
            test = new FrmTestDelegados();
            

        }
//        h.Se pide que el usuario ingrese un nombre por el TextBox de la instancia de
//frmTestDelegados y que al pulsar el botón btnActualizar, se cambie el valor del Label de la
//instancia de frmMostrar.
        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test = new FrmTestDelegados();
            test.MdiParent = this;
            test.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar = new FormMostrar();
            mostrar.MdiParent = this;
            mostrar.Show();
        }
    }
}
