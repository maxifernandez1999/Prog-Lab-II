using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Centralita:
//j.Se reemplaza el método Mostrar por la sobrescritura del método ToString.
//k.AgregarLlamada es privado.Recibe una Llamada y la agrega a la lista de llamadas.




namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"razon social: {this.razonSocial}\nGanancia total: {this.GananciaPorTotal}\nGanancia por llamados locales: {this.GananciaPorLocal}\nGanancia por llamados provinciales: {this.GananciaPorProvincial}\n");
            foreach (Llamada llamadas in listaDeLlamadas)
            {
                str.AppendFormat($"Duracion: {llamadas.Duracion}\nNumero de origen {llamadas.NroOrigen}\nNumero de destino {llamadas.NroDestino}\n");
            }
            return str.ToString();
        }

        #region CONSTRUCTORES

        
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion


        #region PROPIEDADES

        
        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return this.GananciaPorLocal + this.GananciaPorProvincial;
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
           
        }
        #endregion

        #region METODOS

        
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            Llamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            //float gananciaLocal = 0;
            //float gananciaProvincial = 0;
            //float gananciaTodas = 0;
            float retorno = 0;
            foreach (Llamada llamada in Llamadas)
            {
                switch(tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            retorno =+ ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            retorno =+ ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            retorno =+ ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            retorno =+ ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    default:
                        break;


                }
            }
            return retorno;
            
        }
        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public override string ToString()
        {
            return Mostrar();
        }
        #endregion

        #region SOBRECARGA OPERADORES

        
        //l.El operador == retornará true si la Centralita contiene la Llamada en su lista genérica.Utilizar
        //sobrecarga == de Llamada.
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada l in c.listaDeLlamadas)
            {
                if (l == llamada)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        //m.El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la
        //Centralita (utilizar la sobrecarga del operador == de Centralita).
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c == nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
                return c; //?
            }
            return c;
        }
        #endregion






    }
}
