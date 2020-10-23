using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Importador;
namespace Test
{
    public partial class FormEmpresa : Form
    {
        //        Realizar un WindowsForm en el proyecto correspondiente que permita agregar productos y
        //mostrar todos los datos de la Empresa.

        Empresa empresa;
        public FormEmpresa()
        {
            
            InitializeComponent();
        }


        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            empresa = new Empresa(txtEmpresa.Text);
            
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            //cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));

            int valor;
            Producto.Origen origenEnum;
            int.TryParse(txtValorDeCompra.Text, out valor);
            Enum.TryParse<Producto.Origen>(cmbOrigen.Text, out origenEnum);
            if (cmbTipo.Text == "Smartphone")
            {
                Smartphone smf = new Smartphone(txtNombreProducto.Text, valor, origenEnum);
                empresa = empresa + smf;
                MessageBox.Show("Agregado");
            }
            else if (cmbTipo.Text == "LineaBlanca")
            {
                LineaBlanca lb = new LineaBlanca(txtNombreProducto.Text, valor, origenEnum);
                empresa = empresa + lb;
                MessageBox.Show("Agregado");
            }
            
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{empresa.ToString()}");
        }
    }
}
