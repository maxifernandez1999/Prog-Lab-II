using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio._63
{
    public partial class Form1 : Form
    {
        delegate void Hora();
        //        Generar tres prácticas, independientes, en el orden planteado:
        //i.Realizar la actualización de la hora 1 vez por segundo utilizando alguna estructura de
        //control dada en clase.
        //ii.Agregar un objeto del tipo Timer para refrescar la hora actual cada 1 segundo.
        //iii.Resolver el mismo ejercicio con Threads.
        public Form1()
        {
            InitializeComponent();
            Thread thread = new Thread(TraerHora);
            thread.Start();
        }

        public void AsignarHora()
        {
            if (this.richTextBox1.InvokeRequired)
            {
                Hora hora = new Hora(this.AsignarHora);
                this.Invoke(hora);
            }
            else
            {
                
                this.label1.Text = DateTime.Now.ToString();

                Thread.Sleep(1000);
                
            }
            
            
        }
        public void TraerHora()
        {
            while (true)
            {
                AsignarHora();
            }
        }
    }

    
}
