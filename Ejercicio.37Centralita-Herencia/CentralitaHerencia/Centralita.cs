using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Centralita:
//l.CalcularGanancia será privado.Este método recibe un Enumerado TipoLlamada y retornará
//el valor de lo recaudado, según el criterio elegido(ganancias por las llamadas del tipo Local,
//Provincial o de Todas según corresponda).
//m.El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales
//y provinciales y el detalle de las llamadas realizadas.


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
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
        }
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
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float gananciaTodas = 0;
            float retorno = 0;
            foreach (Llamada llamada in Llamadas)
            {
                switch(tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            retorno = gananciaLocal + ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            retorno = gananciaProvincial + ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            retorno = gananciaTodas + ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            retorno = gananciaTodas + ((Provincial)llamada).CostoLlamada;
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

        }




    }
}
