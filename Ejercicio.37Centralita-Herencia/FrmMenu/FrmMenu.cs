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
    public partial class FrmMenu : Form
    {
        Centralita c;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(c);
            llamador.ShowDialog();
        }
    }
}
