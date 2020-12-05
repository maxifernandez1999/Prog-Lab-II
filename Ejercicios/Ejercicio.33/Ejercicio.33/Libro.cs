using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._33
{
    class Libro
    {
        private List<string> paginas = new List<string>();

        public string this[int i]
        {
            set
            {
                paginas.Add(value);
                if (paginas.Count < i)//? 
                {
                    paginas.Add(value);
                }
            }
            get
            {
                if (i >= 0 && i < 300)
                {
                    return paginas[i];
                }
                else
                {
                    return "";
                }
                
                
            }
            
        }
    }
}
