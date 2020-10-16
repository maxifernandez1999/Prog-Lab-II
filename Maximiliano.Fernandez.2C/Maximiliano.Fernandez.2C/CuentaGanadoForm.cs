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

namespace Maximiliano.Fernandez._2C
{
    public partial class CuentaGanadoForm : Form
    {

        Bar bar = Bar.GetBar();
        int valorActualEmpleados = 0;
        int valorActualGente = 0;
        public CuentaGanadoForm()
        {
            InitializeComponent();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            
            MostrarDatos form = new MostrarDatos(bar);
            form.ShowDialog();
            
           
        }

        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            ControlPublicoForm form = new ControlPublicoForm();
            
            if (nudEmpleados.Value >= valorActualEmpleados)
            {
                form.ShowDialog();
                short edad;
                int dni;
                bool retorno;
                  
                short.TryParse(form.Edad, out edad);
                int.TryParse(form.Dni, out dni);
                Empleado empleado = new Empleado(edad, form.Nombre, dni);
                retorno = bar + empleado;
                if (retorno == true)
                {
                    MessageBox.Show("Se ha agregado el empleado a la lista!", "Agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valorActualEmpleados++;
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el empleado a la lista porque no cumple los requerimientos de edad o ya se encuentra en la lista", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudEmpleados.Value--;



                }
            }
            else if (nudEmpleados.Value < valorActualEmpleados)
            {
                bar.Empleados.Remove(bar.Empleados.Last());
                MessageBox.Show("Se ha eliminado el ultimo empleado de la lista!", "Eliminado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            ControlPublicoForm form = new ControlPublicoForm();
            
            
            if (nudGente.Value >= valorActualGente)
            {
                form.ShowDialog();
                short edad;
                short.TryParse(form.Edad, out edad);
                Gente gente = new Gente(edad, form.Nombre);
                bool retorno = bar + gente;
                if (retorno == true)
                {
                    MessageBox.Show("Se ha agregado al cliente a la lista!", "Agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valorActualGente++;
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente a la lista o ya se encuentra en la lista", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudGente.Value--;


                }
            }
            else if (nudGente.Value < valorActualGente)
            {
                bar.Gente.Remove(bar.Gente.First());
                MessageBox.Show("Se ha eliminado el primer cliente de la lista", "Eliminado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
