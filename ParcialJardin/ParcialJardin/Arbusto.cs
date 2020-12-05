using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialJardin
{
    public class Arbusto : Planta
    {
        public Arbusto(string nombre, int tamanio)
            :base(nombre,tamanio)
        {
            
        }
        protected override bool TieneFlores
        {
            get
            {
                return false;
            }
        }
        protected override bool TieneFruto
        {
            get
            {
                return false;
            }
        }
    }
}
