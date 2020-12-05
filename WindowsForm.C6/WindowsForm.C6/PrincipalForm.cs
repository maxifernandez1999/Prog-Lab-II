using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.C6 //clase f7 sobre el Form
{
    public partial class PrincipalForm : Form //viene por defecto las funciones
    {//partial nos permite dividir una clase y que sea la misma // sirve para separar codigo que es el mismo en archivos distintos
        public PrincipalForm()
        {
            InitializeComponent();
            
        }
        
        
        private void Saludar_OnClick(object sender, EventArgs e)
        {

            string nombre = this.textBoxNombre.Text;//propiedad text
            //los string en c# son inmutables, no se pisan
            if (ValidarNombre(nombre))
            {
                nombre = nombre.Trim(); //elimina espacios al inicio y al final.
                //MessageBox.Show($"Hola {nombre}","Saludo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                MensajeForm mensajeForm = new MensajeForm();
                //mensajeForm.Show();// abre los formularios de forma no modal, sin atencion
                mensajeForm.ShowDialog();//forma modal

                mensajeForm.Mensaje = "hola"; //set
                string prueba = mensajeForm.Text; //get
            }
            else
            {
                
                DialogResult result = MessageBox.Show("Desea continuar? ", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            
        }
        private bool ValidarNombre(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Error, Debe ingresar un nombre", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
