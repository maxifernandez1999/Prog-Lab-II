using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialConcencionaria
{
    public class Auto : Vehiculo
    {
        public enum ETipo { Deportivo,Sedan,Coupe,Familiar}

        protected ETipo tipo;


        public Auto(string modelo,float precio,Fabricante fabricante,ETipo tipo)
            :base(modelo,precio,fabricante)
        {
            this.tipo = tipo;
        }
        public static bool operator ==(Auto a, Auto b)
        {
            if (a.GetType()==b.GetType() && a.tipo == b.tipo)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public static explicit operator string(Auto a)
        {
            return a.precio.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Auto)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fabricante: {base.Mostrar()}");
            sb.AppendLine($"Modelo: {this.tipo}");
            return base.ToString();
        }
    }
}
