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

        private void button1_Click(object sender, EventArgs e)
        {

            // Limpiar Valores
            textBox2.Text = "";
            textBox3.Text = "";

         
            if (comboBox1.SelectedItem == "Lagrange")
            {
                // Calcular Lagrange
                List<Types.Termino> polinomio = new List<Types.Termino>();
                List<Types.Punto> puntos = new List<Types.Punto>();
                String polString;
                //Inicializacion
                puntos.Add(new Types.Punto(1, -2));
                puntos.Add(new Types.Punto(3, 1));
                puntos.Add(new Types.Punto(5, 2));
                puntos.Add(new Types.Punto(7, -3));
                // Armado del polinomio
                polinomio = Lagrange.CalcPolLagrange(puntos);
                // Reducir Polinomio Final
                Util.ReducirPol(polinomio);
                // Mostrar Polinomio Formateado
                polString = Util.PolToString(polinomio, "P", "X");
                textBox2.Text = polString;
            }
         }
    }
}
