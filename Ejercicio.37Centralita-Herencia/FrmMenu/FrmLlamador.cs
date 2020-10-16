﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace FrmMenu
{
    public partial class FrmLlamador : Form
    {
//        Si se presiona btnGenerarLlamada abrir un nuevo formulario como Dialog:
//i.Si la llamada comienza con #, es Provincial. Si la llamada no comienza con #, se
//deberá poner el combo cmbFranja en estado deshabilitado.
//ii.La fuente de txtNroDestino será 16. Este TextBox sólo se podrá cargar mediante el
//panel numérico.
//iii.El panel numérico se encontrará dentro de un GroupBox con el título “Panel”.
//iv.El TextBox situado por debajo de btnLimpiar será el txtNroOrigen.
        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
        }

        public Centralita c
        {
            get { return c; }
        }
        string numero = "";
        private void btn1_Click(object sender, EventArgs e)
        {
            numero = numero + "1";
            txtNroDestino.Text = numero;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numero = numero + "2";
            txtNroDestino.Text = numero;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numero = numero + "3";
            txtNroDestino.Text = numero;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numero = numero + "4";
            txtNroDestino.Text = numero;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numero = numero + "5";
            txtNroDestino.Text = numero;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numero = numero + "6";
            txtNroDestino.Text = numero;
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numero = numero + "7";
            txtNroDestino.Text = numero;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numero = numero + "8";
            txtNroDestino.Text = numero;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numero = numero + "9";
            txtNroDestino.Text = numero;
        }

        private void btnAterisco_Click(object sender, EventArgs e)
        {
            numero = numero + "*";
            txtNroDestino.Text = numero;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numero = numero + "0";
            txtNroDestino.Text = numero;
        }

        private void btn1Numeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "#";
            numero = numero + numero;
            
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Carga
            
            // Lectura
            
            
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Provincial.Franja franjas;
            Random rdm = new Random();
            if (txtNroDestino.Text == "#")
            {
                cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                int duracionProvincial = rdm.Next(1, 50);
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                Provincial l2 = new Provincial("Morón", franjas, duracionProvincial, "Bernal");
                MessageBox.Show(l2.ToString());

            }
            else
            {
                cmbFranja.Enabled = false;
            }
            int duracionLocal = rdm.Next(1, 50);
            double costo = ((float)rdm.NextDouble() * (5.6 - 0.5)) + 0.5;
            Local l1 = new Local("Bernal", duracionLocal, "Rosario", (float)costo);
            MessageBox.Show(l1.ToString());
        }
    }
}