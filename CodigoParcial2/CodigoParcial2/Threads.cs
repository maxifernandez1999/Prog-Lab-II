using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace CodigoParcial2
{
    class Threads
    {
        public Form1()
        {
            //Se pueden inicializar en el form
            InitializeComponent();
            Thread thread = new Thread(TraerHora);
            thread.Start();
        }

        public void AsignarHora(/*string dato*/)
        {

            //public delegate void Callback()
            if (this.richTextBox1.InvokeRequired)
            {
                Callback hora = new Callback(this.AsignarHora); //llamada recursiva
                //object[] obj = new object[] { /*dato*/ };
                this.Invoke(hora/*,obj*/);
            }
            else
            {

                this.label1.Text = DateTime.Now.ToString();

                Thread.Sleep(1000);

            }


        }
    }
}
