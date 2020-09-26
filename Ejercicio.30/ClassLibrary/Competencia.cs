using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Competencia
    {
        public enum TipoCompetencia { F1, Motocross}
        private short cantidadCompetidores;
        private short cantidadVueltas;
        public List<VehiculoDeCarrera> competidores;
        public TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            :this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }
       
        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str = str.AppendFormat($"Cantidad de competidores : {this.cantidadCompetidores}\nCantidad de Vueltas: {this.cantidadVueltas}\n");
            return str.ToString();
        }
        public string MostrarDatoss()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Tipo de competencia {this.Tipo}\nCantidad de Competidores: {this.CantidadCompetidores}\nCantidad de vueltas: {this.CantidadVueltas}\n");
            foreach (VehiculoDeCarrera vehiculos in competidores)
            {
                str.AppendFormat($"Datos de los competidores: {vehiculos.MostrarDatos()}");
            }
            return str.ToString();
        }
        
        #region Propiedades
        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        //public VehiculoDeCarrera this[int i]
        //{
        //    get
        //    {
        //        return ;
        //    }
            
        //}
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        #endregion
        
        
        public static bool operator +(Competencia c, VehiculoDeCarrera a) 
        {
            Random rdm = new Random();
            short vueltasRest = a.VueltasRestantes;
            short cantVueltas = c.CantidadVueltas;

            if ((c.competidores.Count < c.cantidadCompetidores))
            {
                a.EnCompetencia = true; 
                vueltasRest = cantVueltas;
                short cantCombustible = (short)rdm.Next(15, 100);
                a.CantidadCombustible = cantCombustible;
                return true;
            }

            return false;
        }
       
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if(c.Tipo == TipoCompetencia.Motocross)
            {
                if (a is MotoCross)
                {
                    c.competidores.Add((MotoCross)a);
                    return c + a; 

                }
            }
            else if (c.Tipo == TipoCompetencia.F1)
            {
                if (a is AutoF1)
                {
                    c.competidores.Add((AutoF1)a);
                    return c + a;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

    }
}
