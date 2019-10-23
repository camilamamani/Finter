using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (textBox1.Text != "")
            {
                if (!int.TryParse(textBox1.Text, out result))
                {
                    textBox1.Text = "";
                    MessageBox.Show("Invalid Integer");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar Valores
            textBox2.Text = "";
            textBox3.Text = "";


            //Inicializacion
            List<Types.Punto> puntos = new List<Types.Punto>();
            puntos.Add(new Types.Punto(1, -2));
            puntos.Add(new Types.Punto(3, 1));
            puntos.Add(new Types.Punto(5, 2));
            puntos.Add(new Types.Punto(7, -3));

            if (puntos.Count == 0)
                MessageBox.Show("No se ingresaron datos");

            if (comboBox1.SelectedItem == null)
                MessageBox.Show("Debe seleccionar un tipo de polinomio");

            switch (comboBox1.SelectedIndex)
            {
                // Lagrange
                case 0:
                    List<Types.Termino> polinomio = new List<Types.Termino>();
                    String polString;

                    // Armado del polinomio
                    polinomio = Lagrange.CalcPolLagrange(puntos);
               
                    // Mostrar Polinomio Formateado
                    polString = Util.PolToString(polinomio, "P", "X");
                    textBox2.Text = polString;
                    
                    break;

                // Newton-Gregory Progresivo
                case 1:
                    Console.WriteLine("NG-Prog");
                    break;

                // Newton-Gregory Regresivo
                case 2:
                    Console.WriteLine("NG-Regr");
                    break;
            }
         }
    }
}
