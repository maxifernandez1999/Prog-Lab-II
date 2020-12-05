using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialJardin
{
    public class Jardin
    {
        public enum Tipo { Terrozo,Arenozo}

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        static Jardin()
        {
            Jardin.suelo = Tipo.Terrozo;
        }
        private Jardin()
        {
            this.plantas = new List<Planta>();
        }
        public Jardin(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }

        public Tipo Suelo
        {
            set
            {
                Jardin.suelo = value;
            }
        }
        private int EspacioOcupado()
        {
            return this.espacioTotal;
        }
        private int EspacioOcupado(Planta planta)
        {
            return EspacioOcupado() + planta.Tamanio;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            if (jardin.plantas.Count < jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composicion del Jardin: {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado: {this.plantas.Count} de {this.EspacioOcupado()}\n");

            foreach (Planta p in plantas)
            {
                sb.AppendLine($"{p.ResumenDeDatos()}\n");
            }
            return sb.ToString();

        }
    }
}
