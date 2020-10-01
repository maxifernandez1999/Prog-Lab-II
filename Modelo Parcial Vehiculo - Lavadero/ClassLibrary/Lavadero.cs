using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lavadero
    {
        public enum EVehiculos { Auto,Camion,Moto}
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;
        public EVehiculos vehiculo;

        public Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto)
            :this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }


        public string MiLavadero
        {
            get
            {
                
                StringBuilder str = new StringBuilder();
                str.AppendFormat($"Precio Camion: {this.precioCamion}\nPrecio Auto: {this.precioAuto}\nPrecio Moto: {this.precioMoto}\n");
                foreach (Vehiculo v in vehiculos)
                {
                    
                    str.AppendFormat($"Patente: {v.Patente}\nMarca : {v.Marca}\nCantidad de ruedas: {v.CantRuedas}\n");

                }
                return str.ToString();
            }
            
        }
        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }

        }

        public double MostrarTotalFacturado()
        {
            double ganancia = 0;
            foreach (Vehiculo v in vehiculos)
            {
                if (v is Vehiculo)
                {
                    ganancia =+ this.precioAuto;
                }
                else if (v is Moto)
                {
                    ganancia =+ this.precioMoto;
                }
                else
                {
                    ganancia =+ this.precioCamion;
                }
            }
            return ganancia;
        }
        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double ganancia = 0;
            foreach (Vehiculo v in vehiculos)
            {
                switch (vehiculo)
                {
                    case EVehiculos.Auto:
                    if (v is Auto)
                    {
                        ganancia =+ this.precioAuto;
                    }
                    break;
                    case EVehiculos.Camion:
                        if (v is Camion)
                        {
                            ganancia = +this.precioAuto;
                        }
                        break;
                    case EVehiculos.Moto:
                        if (v is Moto)
                        {
                            ganancia = +this.precioAuto;
                        }
                        break;
                    default:
                    break;
                }
            }
            return ganancia;
            
        }
        public static bool operator ==(Lavadero l, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in l.vehiculos)
            {
                if (v == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Lavadero l, Vehiculo vehiculo)
        {
            return !(l == vehiculo);
        }
        public static Lavadero operator +(Lavadero l, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in l.vehiculos)
            {
                //if (!(v == vehiculo))
                //{
                    l.vehiculos.Add(vehiculo);
                    return l;
                //}
            }
            return l;
        }
        public static Lavadero operator -(Lavadero l, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in l.vehiculos)
            {
                if (v == vehiculo)
                {
                    l.vehiculos.Remove(vehiculo);
                    return l;
                }
            }
            return l;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            int retorno = 0;
            if (v1.Patente == v2.Patente)
            {
                retorno = 0;
            }
            else if(string.Compare(v1.Patente,v2.Patente) < 0)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }
        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            int retorno = 0;
            if (v1.Marca == v2.Marca)
            {
                retorno = 0;
            }
            else if (v1.Marca > v2.Marca)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }

    }
}
