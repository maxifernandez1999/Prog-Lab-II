using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Llamada:
//a.La clase Llamada ahora será abstracta.Tendrá definida la propiedad de sólo lectura
//CostoLlamada que también será abstracta.
//b.Mostrar deberá ser declarado como virtual, protegido y retornará un string que contendrá
//los atributos propios de la clase Llamada
//c.El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
//(utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
//origen son iguales en ambas llamadas.
namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada {Local,Provincial,Todas }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        protected TipoLlamada tipoLlamada;

        #region PROPIEDADES
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
            
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
            
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }

        }
        public abstract float CostoLlamada { get; }
        #endregion


        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #region METODOS

        
        protected virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Duracion: {this.Duracion}\nNumero de destino: {this.NroDestino}\nNumero de origen: {this.NroOrigen}\nTipo de llamada: {this.tipoLlamada}");
            return str.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;
            }
            else if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            return retorno;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if(l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
        


    }
}
