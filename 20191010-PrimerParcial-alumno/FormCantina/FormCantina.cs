using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ControlCantina;
namespace FormCantina
{
    public partial class FormCantina : Form
    {
        Barra barra = new Barra();
        public FormCantina()
        {
            InitializeComponent();
        }

        private void nudCapacidad_ValueChanged(object sender, EventArgs e)
        {
            
            nudCapacidad.Minimum = 1;
            nudCapacidad.Maximum = 5000;
        }

        private void nudContenido_ValueChanged(object sender, EventArgs e)
        {
            nudContenido.Minimum = 1;
            nudContenido.Maximum = 5000;
        }

        private void FormCantina_Load(object sender, EventArgs e)
        {
            nudCapacidad.Value = 1000;
            nudContenido.Value = 1000;
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            this.barra.SetCantina = Cantina.GetCantina(10);
            
        }

        private void cmbBotellaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
            if (rbBtnAgua.Checked)
            {
                Agua agua= new Agua((int)nudCapacidad.Value, txtMarca.Text, (int)nudContenido.Value);
                barra.AgregarBotella(agua);
                MessageBox.Show(agua.toString());
                
                
            }
            else if (rdBtnCerveza.Checked)
            {
                Cerveza cerveza = new Cerveza((int)nudCapacidad.Value, txtMarca.Text, tipo, (int)nudContenido.Value);
                barra.AgregarBotella(cerveza);
                MessageBox.Show(cerveza.toString());
            }
           
            
        }
    }
}
