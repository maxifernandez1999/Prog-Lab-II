using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta class de creo como un nuevo proyecto de bibliotecas de clases .NET Frameork
//Se crea un nuevo proyecto por ejercicio
namespace ClassLibrary
{
    public class Mascota //es public para poder usarla en el el main
    {
        private string nombre; //atributos de la class Mascota
        private DateTime fechaNacimiento; // Formato de fecha (dd/MM/yyyy)
        private string especie; //atributo de la clase
        public const double ratioEdad = 2; // const se inicializa porque nunca cambia

        public Mascota(string nombre, DateTime fechaNacimiento,string especie) //Constructor por defecto
        {
            this.nombre = nombre; //se utiliza para guardar lo parametrizado dentro de los atributos
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }
        public string MostrarDatos() //Metodo para mostrar por consola
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Nombre : {0}\n", this.nombre);
            stringBuilder.AppendFormat("Fecha nacimiento: {0}\n", this.fechaNacimiento.ToString("dd/MM/yyyy")); // toString es para darle un formate especifico
            stringBuilder.AppendFormat("Especie : {0}\n",this.especie);
            stringBuilder.AppendFormat("La mascota tiene {0} años.", CalcularEdad());

            return stringBuilder.ToString(); //retorna en formato string para poder mostrarlo desde el Console.Write
            

        }

        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - this.fechaNacimiento.Year;
            if (this.fechaNacimiento.AddYears(edad) > fechaActual)
            {
                edad--;
            }
            return edad;
        }
    }
}
