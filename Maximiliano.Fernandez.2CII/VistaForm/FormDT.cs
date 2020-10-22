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
namespace VistaForm
{
    public partial class FormDT : Form
    {
        DirectorTecnico dt;
        public FormDT()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int edad;
            int dni;
            int experiencia;
            int.TryParse(nudEdad.Value.ToString(), out edad);
            int.TryParse(nudDni.Value.ToString(), out dni);
            int.TryParse(nudExperiencia.Value.ToString(), out experiencia);

            dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, edad, dni, experiencia);
            MessageBox.Show("Se ha agregado el DT");


        }
//        “Aún no se ha creado el DT del formulario” en caso de que el director técnico del formulario aún no
//se haya instanciado
//b. “El DT es apto.” si el DT cumple con las validaciones de aptitud.
//c. “El DT no es apto.” si el DT no cumple con las validaciones de aptitud.
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                MessageBox.Show("Aun no se ha creado el DT del formulario");
            }
            else if(dt.ValidarAptitud() == false)
            {
                MessageBox.Show("El DT no es apto");

            }else if(dt.ValidarAptitud() == true)
            {
                MessageBox.Show("El DT es apto");
            }
        }
    }
}
