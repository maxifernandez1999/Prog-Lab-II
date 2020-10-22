using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        //        Clase Cantina:
        //a.El único constructor será privado y se encargará tanto de inicializar la lista como de asignar la
        //cantidad de espacios disponibles para guardar botellas.
        //b.GetCantina implementará un patrón Singleton, para lo cual deberá:
        //i.Si la variable singleton es null, instanciará el objeto.
        //ii.Si no es null, modificará la cantidad de espacios en la cantina.
        //iii.En ambos casos, su última acción será retornar el objeto singleton.
        //c.El operador + agregará, siempre y cuando aún no se hayan ocupado todos los espacios
        //disponibles, retornando true si agregó y false en caso contrario.

        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        private Cantina(int espacio)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacio;
        }
        public static Cantina GetCantina(int espacios)
        {
            if (Cantina.singleton is null)
            {
                singleton = new Cantina(espacios);

            }
            Cantina.singleton.espaciosTotales = espacios;
            return Cantina.singleton;
        }
        public List<Botella> Botellas
        {
            get { return this.botellas; }

        }
        public static bool operator +(Cantina c, Botella b)
        {
            if (c.botellas.Count < c.espaciosTotales)
            {
                c.botellas.Add(b);
                return true;
            }
            return false;
        }


    }
}
