using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        public ETipo tipo;
        public enum ETipo
        {
            Ciclomotor, Sedan, SVU, Todos
        }


        #region "Constructores"
        /// <summary>
        /// Constructor que inicializa la lista generica
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor que inicializa el espacio disponible
        /// </summary>
        /// <param name="espacioDisponible">Espacio disponible en el taller</param>
        public Taller(int espacioDisponible)
            :this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string mostrar = Listar(this,ETipo.Todos);
            return mostrar;
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles\n", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.SVU:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            bool retorno = false;
            if (taller.vehiculos.Count == 0)
            {
                taller.vehiculos.Add(vehiculo);
                return taller;
            }
            else
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (vehiculo == v)
                    {
                        retorno = true;
                        break;
                    } 
                }
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if ((retorno == false) && taller.vehiculos.Count < taller.espacioDisponible)
                    {
                        taller.vehiculos.Add(vehiculo);
                        return taller;
                    }
                }
            }

            return taller;
            

        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            taller.vehiculos.Remove(vehiculo);
          
            return taller;
        }
        #endregion
    }
}
