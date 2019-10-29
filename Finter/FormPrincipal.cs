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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void tbValorNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.onlyNumbersDouble(sender, e);
        }


        private void btCalcular_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (Global.puntos.Count == 0)
            {
                MessageBox.Show("No se ingresaron datos");
            }
            else if (Global.polinomio.Count > 0
                && !Global.puntos.SequenceEqual(Global.ultimosPuntosUtilizadosParaCalcularPolinomio) // Hubo cambios en los puntos
                && Util.AlteracionValoresInicialesNoModificaPolinomio(Global.polinomio, Global.puntos))
            {
                MessageBox.Show("La alteracion en los valores iniciales no modifica al polinomio ya generado");
            }
            else if (cbTipoPol.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de polinomio");
            }
            else if (tbValorK.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor para K");
            }
            else 
            {
                // Limpiar Valores
                tbPolinomio.Text = "";
                tbPolinomioK.Text = "";
                Global.polinomio.Clear();

                //Inicializacion
                double k = Convert.ToDouble(tbValorK.Text.Replace(".", ","));
                String polString;

                // Habilitar cuadro para mostrar pasos
                if (chMostrarPasos.Checked)
                {
                    lblPasos.Visible = true;
                    tbPasos.Visible = true;
                }
                else
                {
                    lblPasos.Visible = false;
                    tbPasos.Visible = false;
                }

                // Tipo de Polinomio
                Global.tipoPol = cbTipoPol.SelectedIndex;

                switch (Global.tipoPol)
                {
                    // Lagrange
                    case 0:

                        // Armado del polinomio
                        Lagrange.CalcPolLagrange(Global.puntos, Global.polinomio, Global.pasos);

                        // Mostrar Polinomio Formateado
                        polString = Util.PolToString(Global.polinomio, "P", "X");
                        tbPolinomio.Text = polString;

                        // Especializar Polinomio
                        Global.valorPol = Util.EspecializarPol(Global.polinomio, k);
                        tbPolinomioK.Text = Global.valorPol.ToString();

                        // Mostrar pasos
                        tbPasos.Text = string.Join(Environment.NewLine, Global.pasos);

                        break;

                    // Newton-Gregory Progresivo
                    case 1:
                        List<Double> xs = new List<double>();
                        List<Double> ys = new List<double>();
                        foreach (Global.Punto p in Global.puntos) {
                            xs.Add(p.x);
                            ys.Add(p.y);
                        }
                        int orden = Global.puntos.Count() - 1;
                        Newton newton = new Newton(orden, xs, ys);
                        newton.CalcElements(ys, orden, 1);

                        // Armado del polinomio
                        newton.CalcPolNewton(Global.polinomio, Global.pasos);

                        // Mostrar Polinomio Formateado
                        polString = Util.PolToString(Global.polinomio, "P", "x");
                        tbPolinomio.Text = polString;

                        // Especializar Polinomio
                        Global.valorPol = newton.Interpolate(k);
                        tbPolinomioK.Text = Global.valorPol.ToString();

                        // Mostrar pasos
                        tbPasos.Text = string.Join(Environment.NewLine, Global.pasos);

                        break;

                    // Newton-Gregory Regresivo
                    case 2:
                        Console.WriteLine("NG-Regr");
                        break;
                }

                // Me guardo los puntos utilizados para despues analizar si me agregaron o quitaron puntos
                Global.ultimosPuntosUtilizadosParaCalcularPolinomio = Global.puntos.ToList();
            }
         }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (tbValorX.Text.Length == 0 || tbValorY.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar valores para X e Y");
            }
            else
            {
                double x = Convert.ToDouble(tbValorX.Text.Replace(".", ","));
                double y = Convert.ToDouble(tbValorY.Text.Replace(".", ","));

                // Verificar que el punto no exista
                if (Global.puntos.Exists(p => p.x == x))
                    MessageBox.Show("El punto ya existe");
                else

                    try
                    {
                        Global.puntos.Add(new Global.Punto(x, y));

                        // Ordenar lista de puntos ascendente
                        Global.puntos.Sort((p1, p2) => p1.x.CompareTo(p2.x));

                        gridPuntos.Rows.Clear();
                        foreach(Global.Punto p in Global.puntos)
                        {
                            gridPuntos.Rows.Add();
                            int i = gridPuntos.Rows.Count - 1;
                            gridPuntos[0, i].Value = i;
                            gridPuntos[1, i].Value = p.x;
                            gridPuntos[2, i].Value = p.y;
                        }
                   

                        tbValorX.Text = "";
                        tbValorY.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("El punto no ha sido agregado");
                    }
                    
            }
            
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (Global.puntos.Count > 0 && gridPuntos.Rows.Count > 0)
            {

                int index =  Int32.Parse(gridPuntos.CurrentRow.Cells[0].Value.ToString());

                try
                {
                    Global.puntos.RemoveAt(index);
                    // Ordenar lista de puntos ascendente
                    Global.puntos.Sort((p1, p2) => p1.x.CompareTo(p2.x));

                    gridPuntos.Rows.Clear();
                    // Vuelvo a agregar los puntos a la UI
                    foreach (Global.Punto p in Global.puntos)
                    {
                        gridPuntos.Rows.Add();
                        int i = gridPuntos.Rows.Count - 1;
                        gridPuntos[0, i].Value = i;
                        gridPuntos[1, i].Value = p.x;
                        gridPuntos[2, i].Value = p.y;
                    }
                }
                catch
                {
                    MessageBox.Show("El punto no ha sido borrado");
                }
    
            }
            else
            {
                MessageBox.Show("No hay puntos para eliminar");
            }

        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            // Verificar los puntos con el polinomio generado
            if (Global.polinomio.Count == 0)
                MessageBox.Show("Aun no se calculo ningun polinomio");
            else
            {
               
            }
           
        }

        private void btBorrarCalc_Click(object sender, EventArgs e)
        {
            Global.polinomio.Clear();
            Global.tipoPol = -1;
            Global.valorPol = 0;

            tbPolinomio.Text = "";
            tbPolinomioK.Text = "";
            tbPasos.Text = "";
        }

        private void btLimpiarTodosLosPuntos_Click(object sender, EventArgs e)
        {
            Global.puntos.Clear();
            gridPuntos.Rows.Clear();
        }
    }

}

