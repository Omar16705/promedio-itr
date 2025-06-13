using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtPromObtenido.Clear();
            txtN1.ReadOnly = false;
            txtN2.ReadOnly = false;    
            txtN3.ReadOnly = false;
            txtPromObtenido.ReadOnly = false;

        }

        private void btnAgregarPromedio_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3,  promedio;
            if (string.IsNullOrEmpty(txtN1.Text) || string.IsNullOrEmpty(txtN2.Text) || string.IsNullOrEmpty(txtN3.Text))
            {
                lblerror.Text = "Existe un campo vaio, ingresa el dato que falta";
            }
            else
            { 
           nota1 = double.Parse(txtN1.Text);
                nota2 = double.Parse(txtN2.Text);
                nota3 = double.Parse(txtN3.Text);
                if ((nota1 > 10 || nota1 < 0) || (nota2 > 10 || nota2 < 0) || (nota3 > 10 || nota3 < 0))
                {
                    lblerror.Text = "Ingresa un valor entre 0 y 10";
                }
                else {
                    promedio = (nota1 + nota2 + nota3) / 3;
                    txtPromObtenido.Text = promedio.ToString("N2");
                    lblerror.Text = string.Empty;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtN3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
