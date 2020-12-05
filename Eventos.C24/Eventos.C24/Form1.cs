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
namespace Eventos.C24
{
    public partial class Form1 : Form
    {
        //DELEGADO
        //DEBE COINCIDIR EL DELEGADO CON EL CAPTURADOR
        Partido partido = new Partido();
        public Form1()
        {
            InitializeComponent();

            Partido partido = new Partido();
            
            this.partido.AvisoGol += ActualizarMarcador; //LOS MANEJADORES TIENEN QUE CUMPLIR LA MISMA FIRMA DEL DELEGADO
            //SE PUEDE SUBSCRIBIR DE DISTINTOS LUGARES
        }
        //public Form1()
        //{
        //    InitializeComponent();
        //    this.button1.Click += button1_Click;
        //    //EVENTO              //PUNTERO O FUNCION/DELEGADO
        //    this.button1.Click += button2_Click;
        //    //EMISOR              //MENEJADORES O RECEPTOR

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.button1.Click -= button1_Click; //DESUBSCRIBIRSE AL EVENTO
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
        private void button1_Click(object sender, EventArgs e)
        {
            partido.JugarPartido(); //METODO QUE LANZA AL EVENTO
        }

        private void ActualizarMarcador(string nombre) //MISMO FIRMA QUE EL DELEGADO
        {
            MessageBox.Show(nombre);
        }

    }
}
