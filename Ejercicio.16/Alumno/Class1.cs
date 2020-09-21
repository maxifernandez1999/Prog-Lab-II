using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;

        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void CalcularFinal()
        {
            Random rdm = new Random();
            int numeroRandom;
            numeroRandom = rdm.Next(4,11);
            if(nota1 >= 4 && nota2 >= 4)
            {
                this.notaFinal = numeroRandom;
            }
            else
            {
                this.notaFinal = -1;
            }
                    
        }
        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
            CalcularFinal();
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Nombre alumno {0}\n", this.nombre);
            stringBuilder.AppendFormat("Legajo {0}\n", this.legajo);

            stringBuilder.AppendFormat("Nota 1: {0}\n", this.nota1);
            stringBuilder.AppendFormat("Nota 2: {0}\n", this.nota2);
            if (this.notaFinal != -1)
            {
                stringBuilder.AppendFormat("Nota final: {0}\n", this.notaFinal);
            }
            else
            {
                stringBuilder.AppendFormat("Alumno desaprobado");
            }
            

            return stringBuilder.ToString();
        }
    }
}
