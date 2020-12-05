using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializador
{
    [Serializable]
    public class Games
    {
        private string nombre;
        private int codigo;

        public Games()
        {

        }

        public Games(string nombre, int codigo)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }



    }
}
