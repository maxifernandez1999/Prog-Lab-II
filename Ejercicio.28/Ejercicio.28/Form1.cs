using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio._28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Utilizar Diccionarios(Dictionary<string, int>) para realizar un contador de palabras, recorriendo el
        //texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al
        //diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador.
        //Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
        //Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string[] palabras;

            string cadenaDeTexto = txtBox.Text;
            palabras = cadenaDeTexto.Split(' ');//guarda en un Array cada palabra de una cadena de texto

            foreach (string palabra in palabras)
            {
                if (!diccionario.ContainsKey(palabra))//si esa palabra no es contenida en el diccionario
                {
                    diccionario.Add(palabra, 1);//lo agrega
                    
                }
                else
                {
                    diccionario[palabra]++;//aumenta el contador de palabras
                    
                }
            }
            List<KeyValuePair<string, int>> listaPalabras = diccionario.ToList();//transforma de diccionario a lista
            listaPalabras.Sort(OrdenarPalabras);
            MessageBox.Show($"La palabra mas usada es: {listaPalabras[0].Key} en {listaPalabras[0].Value} veces\n" +
                $"La palabra mas usada es: {listaPalabras[1].Key} en {listaPalabras[1].Value} veces\n" +
                $"La palabra mas usada es: {listaPalabras[2].Key} en {listaPalabras[2].Value} veces\n");




        }
        public static int OrdenarPalabras(KeyValuePair<string, int> palabraSiguiente, KeyValuePair<string, int> palabraActual)
        {
            int retorno = 0;
            if (palabraActual.Value > palabraSiguiente.Value)
            {
                retorno = 1;
            }
            else if (palabraActual.Value < palabraSiguiente.Value)
            {
                retorno = -1;

            }
            return retorno;
        }
    }
}
