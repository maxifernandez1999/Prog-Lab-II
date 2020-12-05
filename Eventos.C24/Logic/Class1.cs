using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public delegate void AnotoGol(string quienAnota); //DELEGADO
    public class Partido
    {
        //MISMO NOMBRE QUE EL DELEGADO
        public event AnotoGol AvisoGol; //EVENTO
        public Partido()
        {

        }
        public void JugarPartido()
        {
            if (this.AvisoGol != null) //SI NADIE DE SUSBCRIBIO, ES NULL
            {
                this.AvisoGol.Invoke("Pity"); //DISPARADOR DE EVENTO //EJECUTA TODOS LOS METODOS SUBSCRIPTOS
            }

        }
    }
}
