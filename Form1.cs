using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_el_descuento_de_un_producto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void lblOriginal_Click(object sender, EventArgs e)
        {

        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            double total, precio, descuento;
            if (double.TryParse(txtOriginal.Text,out precio)) 
            {
                if (precio <= 0)
                {
                    lblError.Text = "Esto no es posible\nIngrese dato numerico valido";
                    txtDescuento.Text=string.Empty;
                }
                else 
                {
                    descuento = precio * 0.65;
                    total = precio - descuento;
                    txtDescuento.Text = total.ToString("N2");
                    lblError.Text=string.Empty;

                    
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblError.Text=string.Empty;
            txtDescuento.Text=string.Empty;
            txtOriginal.Text=string.Empty;
        }

        private void txtOriginal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescuento_Click(object sender, EventArgs e)
        {

        }
    }
}
