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

            // Limpiar Valores
            tbPolinomio.Text = "";
            tbPolinomioK.Text = "";

            // Validaciones
            Boolean error=false;

            if (Global.puntos.Count == 0)
            {
                error = true;
                MessageBox.Show("No se ingresaron datos");
            }

            if (cbTipoPol.SelectedItem == null)
            {
                error = false;
                MessageBox.Show("Debe seleccionar un tipo de polinomio");
            }

            if (tbValorK.Text == "") {
                error = false;
                MessageBox.Show("Debe ingresar un valor para K");
                tbValorK.Text = "0";
            }

            if (!error)
            {

                //Inicializacion
                double k = Convert.ToDouble(tbValorK.Text.Replace(".", ","));
                String polString;

                // Habilitar cuadro para mostrar pasos
                if (chMostrarPasos.Checked)
                {
                    label7.Visible = true;
                    tbPasos.Visible = true;
                }
                else
                {
                    label7.Visible = false;
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
                        Console.WriteLine("NG-Prog");
                        break;

                    // Newton-Gregory Regresivo
                    case 2:
                        Console.WriteLine("NG-Regr");
                        break;
                }

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
                    foreach (Global.Punto p in Global.puntos)
                    {
                        gridPuntos.Rows.Add();
                        int i = gridPuntos.Rows.Count - 1;
                        gridPuntos[0, i].Value = i;
                        gridPuntos[1, i].Value = p.x;
                        gridPuntos[2, i].Value = p.y;
                    }
                    MessageBox.Show("El punto ha sido borrado");
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
    }

}

