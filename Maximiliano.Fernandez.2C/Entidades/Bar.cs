using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
//    Bar:
//a.Contendrá una lista de Gente y otra de Empleados.
//b.Por cada Empleado se aceptarán 10 personas en el Gente.Validarlo en el operador +.
//c. +: si están dadas las condiciones, agregará según corresponda.
//i.Para Empleado, no agregar repetidos según el criterio de comparación antes dado.
//d.Sobreescritura ToString: retornará un String con toda la información de los empleados y
//gente del bar.

    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton; //patron singleton

        private Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }
        public static Bar GetBar()
        {
            if (Bar.singleton == null) // si es null instancia el Bar
            {
                singleton = new Bar();
            }
            return singleton;
        }
        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }
        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }

        /// <summary>
        /// Operador + que agrega un empleado a la lista si este no pertenece a la misma
        /// </summary>
        /// <param name="bar">variable de tipo Bar</param>
        /// <param name="empleado">Empleado a agregar al Bar</param>
        /// <returns>true: pudo agregar, false:  no pudo</returns>
        public static bool operator +(Bar bar, Empleado empleado)//agrego un empleado
        {
            bool validacion = true;

            foreach (Empleado em in bar.empleados)
            {
                if (em == empleado)
                {
                    validacion = false;
                    break;
                }
                
            }
            if (empleado.Validar() && validacion == true)
            {
                bar.empleados.Add(empleado);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Operador + que agrega un cliente a la lista si este no pertenece a la misma
        /// </summary>
        /// <param name="bar">variable de tipo Bar</param>
        /// <param name="empleado">cliente a agregar al Bar</param>
        /// <returns>true: pudo agregar, false:  no pudo</returns>
        public static bool operator +(Bar bar, Gente gente)
        {
            bool validacion = true;
            int empleados = bar.empleados.Count * 10;
            foreach (Gente g in bar.gente)
            {
                if (g == gente)
                {
                    validacion = false;
                    break;
                }

            }
            if (bar.gente.Count < empleados && gente.Validar() && validacion == true)//agrega si por cada empleado hay menos de 10 clientes

            {
                bar.gente.Add(gente);
                return true;
            }

            return false;
        }
        
        
        public override string ToString()//muestra todos los datos de los empleados del Bar
        {
            StringBuilder sb = new StringBuilder();
            foreach (Empleado em in empleados)
            {
                sb.AppendLine($"{(string)em}");
            }
            foreach (Gente g in gente)
            {
                sb.AppendLine($"{(string)g}");
            }
            
            return sb.ToString();
            
        }
    }
}
