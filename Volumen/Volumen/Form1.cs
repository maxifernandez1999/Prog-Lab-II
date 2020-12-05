using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCm3_Click(object sender, EventArgs e)
        {
            string txt = txtBoxMl.Text;
            double valor = Convert.ToDouble(txt);
            double retorno = 0;
            switch (cmbMl.Text)
                //base litros
            {
                case "mm3":
                    retorno = valor * 1000000;
                    break;
                case "cm3":
                    retorno = valor * 1000;
                    break;
                case "dm3":
                    retorno = valor * 1;
                    break;
                case "m3":
                    retorno = valor * 0.001;
                    break;
                case "dam3":
                    retorno = valor * 0.000001;
                    break;
                case "hm3":
                    retorno = valor * 0.000000001;
                    break;
                case "km3":
                    retorno = valor * 0.000000000001;
                    break;
                

                   
                default:
                    break;
            }
            string valor1 = Convert.ToString(retorno);
            label1.Text = valor1;
        }

        private void btnMl_Click(object sender, EventArgs e)
        {
            string txt = txtBoxCm3.Text;
            double valor = Convert.ToDouble(txt);
            double retorno = 0;
            switch (cmbCm3.Text)
            //base dm3
            {
                case "ml":
                    retorno = valor * 1000;
                    break;
                case "cl":
                    retorno = valor * 100;
                    break;
                case "dl":
                    retorno = valor * 10;
                    break;
                case "l":
                    retorno = valor * 1;
                    break;
                case "dal":
                    retorno = valor * 0.1;
                    break;
                case "hl":
                    retorno = valor * 0.01;
                    break;
                case "kl":
                    retorno = valor * 0.001;
                    break;



                default:
                    break;
            }
            string valor1 = Convert.ToString(retorno);
            label2.Text = valor1;
        }
    }
}
