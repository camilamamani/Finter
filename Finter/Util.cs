using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finter
{
    static class Util
    {
        public static readonly double PRECISION = 0.01; // 2 digitos

        // Redondeo
        public static double Redondear(double x)
        {
            return Math.Round(x, 2, MidpointRounding.ToEven);
        }

        // Agrupar terminos de igual grado
        public static void ReducirPol(List<Global.Termino> pol)
        {
            List<Global.Termino> polAux = new List<Global.Termino>(pol);
            pol.Clear();
            foreach (Global.Termino o in polAux)
            {
                int index = pol.FindIndex(x => x.grado == o.grado);
                if (index != -1)
                {
                    Global.Termino aux = pol[index];
                    aux.coef += Redondear(o.coef);
                    pol[index] = aux;
                }
                else
                    pol.Add(o);
            }
        }

        // Devuelve otro polinomio multiplicado por un valor constante
        public static List<Global.Termino> MultPolPorCte(List<Global.Termino> pol, double cte)
        {
            List<Global.Termino> polOut = new List<Global.Termino>();
            foreach (Global.Termino o in pol)
            {
                Global.Termino oAux;
                oAux.coef = Redondear(o.coef * cte);
                oAux.grado = o.grado;
                polOut.Add(oAux);
            }

            return polOut;
        }

        // Devuelve un String con el polinomio formateado 
        public static String PolToString(List<Global.Termino> pol, String nombre, String x)
        {
            String SPol = "";
            
            if (nombre != "")
                SPol += nombre + "(" + x + ")" + "= ";
            
            int i = 0;
            foreach (Global.Termino o in pol)
            {
                if (i != 0)
                    SPol += " + ";
                if (o.grado == 0)
                {
                    if (o.coef < 0)
                        SPol += "(" + o.coef + ")";
                    else
                        SPol += o.coef;
                }
                else if (o.grado == 1)
                {
                    if (o.coef < 0)
                        SPol += "(" + o.coef + ")" + x;
                    else
                        SPol += o.coef + x;
                }
                else
                {
                    if (o.coef < 0)
                        SPol += "(" + o.coef + ")" + x + "^" + o.grado;
                    else
                        SPol += o.coef + x + "^" + o.grado;
                }

                i++;
            }

            return SPol;
        }

        // Devuelve el valor al especializar un polinomio
        public static double EspecializarPol(List<Global.Termino> pol, double k)
        {
            double valor = 0;

            foreach(Global.Termino term in pol)
            {
                valor += (term.coef * Math.Pow(k, term.grado));
            }
            return valor;
        }

        public static void onlyNumbersDouble(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-'
             && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        public static void onlyNumbersInt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool AlteracionValoresInicialesNoModificaPolinomio(List<Global.Termino> polinomioAnterior, List<Global.Punto> puntos)
        {
            if (polinomioAnterior.Count > puntos.Count)
                return false; // Hay terminos del polinomio de mas

            foreach(Global.Punto punto in puntos)
            {
                if(!MismosValoresConUnRangoDeError(EspecializarPol(polinomioAnterior, punto.x), punto.y))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool MismosValoresConUnRangoDeError(double v1, double v2)
        {
            return Math.Abs(v1 - v2) < PRECISION;
        }

    }
}
