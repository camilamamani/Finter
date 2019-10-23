using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finter
{
    static class Util
    {
        // Redondeo
        public static double Redondear(double x)
        {
            return Math.Round(x, 2, MidpointRounding.ToEven);
        }

        // Agrupar terminos de igual grado
        public static void ReducirPol(List<Types.Termino> pol)
        {
            List<Types.Termino> polAux = new List<Types.Termino>(pol);
            pol.Clear();
            foreach (Types.Termino o in polAux)
            {
                int index = pol.FindIndex(x => x.grado == o.grado);
                if (index != -1)
                {
                    Types.Termino aux = pol[index];
                    aux.coef += Redondear(o.coef);
                    pol[index] = aux;
                }
                else
                    pol.Add(o);
            }
        }

        // Devuelve otro polinomio multiplicado por un valor constante
        public static List<Types.Termino> MultPolPorCte(List<Types.Termino> pol, double cte)
        {
            List<Types.Termino> polOut = new List<Types.Termino>();
            foreach (Types.Termino o in pol)
            {
                Types.Termino oAux;
                oAux.coef = Redondear(o.coef * cte);
                oAux.grado = o.grado;
                polOut.Add(oAux);
            }

            return polOut;
        }

        // Devuelve un String con el polinomio formateado 
        public static String PolToString(List<Types.Termino> pol, String nombre, String x)
        {
            String SPol = nombre + "(" + x + ")" + "= ";
            int i = 0;
            foreach (Types.Termino o in pol)
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
        public static double EspecializarPol(List<Types.Termino> pol,double k)
        {
            double valor = 0;

            foreach(Types.Termino term in pol)
            {
                valor += (term.coef * Math.Pow(k, term.grado));
            }
            return valor;
        }

    }
}
