using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejercicio._67
{
    public delegate string encargatoTiempo();
    public class Temporizador
    {
        public event encargatoTiempo EventoTiempo;
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                return true;
            }
            set
            {
                if (value == true)
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                    
                    
                }
                if (value == false && hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }
        private void Corriendo()
        {
            while (true)
            {
                
                EventoTiempo += numeroAleatorio;
                EventoTiempo.Invoke();
                Thread.Sleep(this.intervalo);
                Console.WriteLine(numeroAleatorio());
                
            }
            
        }
        public string numeroAleatorio()
        {
            Random newr = new Random();
            
            return newr.Next(100, 1000).ToString();
        }
        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }

    }
}
