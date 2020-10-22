using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        //        Clase Cerveza:
        //a.MEDIDA será una constante con el valor 330.
        //b.En los constructores, si no se asigna ningún Tipo de Botella, se asignará Vidrio.No repetir código.
        //c.ServirMedida gastará unidades de contenido con la misma lógica que agua, sólo que servirá el
        //80% del valor indicado en la variable MEDIDA, para dejar espacio para la espuma.
        //d.GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella de cerveza.
        public Cerveza(int capacidadML, string marca, Botella.Tipo tipo, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }
        public Cerveza(int capacidadML, string marca, int contenidoML)
            : this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        {

        }
        protected override string GenerarInforme()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"{base.GenerarInforme()}");
            str.AppendLine($"Tipo: {this.tipo}");
            return str.ToString();
        }
        public static implicit operator Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
        public override int ServirMedida()
        {
            int descuento;
            int medida = (int)(Cerveza.MEDIDA * 0.8f); // medida es el 80 porciento solo

            if (base.Contenido > medida)
            {
                descuento = base.Contenido;
            }
            else
            {
                descuento = base.Contenido;
            }
            base.Contenido -= descuento;
            return descuento;
        }


    }
}
