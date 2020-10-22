using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
//    Clase DirectorTecnico:
//a.Mostrar retornará los datos de DirectorTecnico y su clase base.
//b.ValidarAptitud validará que el Director Técnico sea menor a 65 años y tenga al menos 2 años de
//experiencia.
    public class DirectorTecnico : Persona
    {
        protected int aniosExperiencia;

        public DirectorTecnico(string apellido,string nombre, int edad,int dni, int aniosExperiencia)
            : base(apellido, nombre,edad,dni)
        {
            this.aniosExperiencia = aniosExperiencia;
        }

        public int AniosExperiencia
        {
            set
            {
                this.aniosExperiencia = value;
            }
            get
            {
                return this.aniosExperiencia;
            }
        }
        
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()}");
            sb.Append($"{this.AniosExperiencia}");
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            if (base.Edad < 65 && this.AniosExperiencia >= 2)
            {
                return true;
            }
            return false;
        }

    }
}
