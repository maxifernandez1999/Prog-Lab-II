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

        Bar bar = Bar.GetBar();//Instancia el bar
        
        public CuentaGanadoForm()
        {
            InitializeComponent();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            
            MostrarDatos form = new MostrarDatos(bar);//llamo al form para que muestre los datos del bar
            form.ShowDialog();
            
        }

        /// <summary>
        /// Agrego empleado desde el NumericUpDown y elimino el ultimo de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            ControlPublicoForm form = new ControlPublicoForm();
            
            if (this.bar.Empleados.Count < nudEmpleados.Value)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
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
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el empleado a la lista porque no cumple los requerimientos de edad o ya se encuentra en la lista", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nudEmpleados.Value--;

                    }
                }
               
                
            }
            else if (nudEmpleados.Value < 0)
            {
                nudEmpleados.Value = 0;
                
            }
            else
            {
                bar.Empleados.Remove(bar.Empleados.Last());
                MessageBox.Show("Se ha eliminado el ultimo empleado de la lista!", "Eliminado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Agrego empleado desde el NumericUpDown y elimino el primero de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            ControlPublicoForm form = new ControlPublicoForm();
            
            if (this.bar.Gente.Count < nudGente.Value)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    short edad;
                    short.TryParse(form.Edad, out edad);
                    Gente gente = new Gente(edad, form.Nombre);
                    bool retorno = bar + gente;
                    if (retorno == true)
                    {
                        MessageBox.Show("Se ha agregado al cliente a la lista!", "Agregado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el cliente a la lista o ya se encuentra en la lista", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nudGente.Value--;

                    }
                }
                
                
            }
            else if (nudGente.Value < 0)
            {
                nudGente.Value = 0;

            }
            else
            {
                bar.Gente.Remove(bar.Gente.First());
                MessageBox.Show("Se ha eliminado el primer cliente de la lista", "Eliminado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
