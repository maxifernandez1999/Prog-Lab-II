using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Agua : Botella
    {
//        Clase Agua:
//a.MEDIDA será una constante con el valor 400.
//b.ServirMedida gastará unidades de contenido con la siguiente lógica:
//i.Si la constante MEDIDA es menor o igual al contenido, gastará MEDIDA.
//ii.Si MEDIDA es mayor al contenido, tomará contenido.
//c.Generar una sobrecarga que reciba una cantidad a gastar que pueda ser diferente de MEDIDA.
//No repetir código.
//d.GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella de agua.
        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML)//atributos de la base
            :base(marca,capacidadML,contenidoML)
        {

        }
        public override int ServirMedida() //sirve una medida de Agua
        {
            return this.ServirMedida(Agua.MEDIDA);//constantes son staticas
        }
        public int ServirMedida(int medida)
        {
            int descuento;
            if (medida <= base.Contenido)//si medida es menor al contenido, se descontara la medida del contenido
                //ej : 400 y contenido 500, se descontara 400. porque no se puede servir mas de la medida
            {
                descuento = medida;
            }
            else
            {
                descuento = base.Contenido;//else se descontara el contenido que hay
                //ej: 400 y contenido 300 , se descontara, 300

            }
            base.Contenido -= descuento;// contenido le resto el descuento
            return descuento;
        }
        protected override string GenerarInforme()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"{base.GenerarInforme()}");
            return str.ToString();
        }

    }
}
