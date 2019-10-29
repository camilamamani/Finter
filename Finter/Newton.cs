using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finter
{
    class Newton
    {
        private int orden;
   
        private List<Double> x_k;//lista de valores de x
        private List<Double> y_k;//lista de valores de y
        private List<Double> b; //los valores que uso para newton progresivo


        public Newton(int order, List<Double> xs, List<Double> ys) {
            orden = order;
            x_k = xs;
            y_k = ys;
            b = new List<double>();
        }

        //Calculo los deltas
        public void CalcElements(List<Double> y, int order, int step)
        {
            int i;
            List<Double> xx;
            if (order >= 1)
            {
                xx = new List<double>();//f[xi, ..., xi+n]
                double diferencia;
                for (i = 0; i < order - 1; i++)
                {
                    diferencia = (y.ElementAt(i+1) - y.ElementAt(i)) / (x_k.ElementAt(i+step) - x_k.ElementAt(i));
                    xx.Add(diferencia);
                }
                b.Insert(step - 1, y.ElementAt(0));//newton progresivo
                Console.WriteLine("b --> " + y.ElementAt(0));
                CalcElements(xx, order - 1, step + 1);
            }
        }

        //Interpolando para un valor especifico de k
        public double Interpolate(double k)
        {
            int i, j;
            double tempYp = 0;
            double yp = 0;
            for (i = 1; i < orden; i++)
            {
                tempYp = b.ElementAt(i);
                for (j = 0; j < i; j++)
                {
                    tempYp = tempYp * (k - x_k.ElementAt(j));
                }
                yp = yp + tempYp;
            }
            return b.ElementAt(0) + yp;
        }

        public void CalcPolNewton(List<Global.Termino> polinomio, List<string> pasos)
        {
         
            int i, j;
     
            string polAux1;
            string aux1;
            
            polAux1 = "" + b.ElementAt(0);//pasos string
            polinomio.Add(new Global.Termino(b.ElementAt(0), 0));
            for (i = 1; i < orden; i++)
            {
                aux1 = " + " + b.ElementAt(i);//pasos string

                List<Global.Termino> terms = new List<Global.Termino>();
                terms.Add(new Global.Termino(b.ElementAt(i), 0));
                for (j = 0; j < i; j++)
                {
                    aux1 += "* (x - (" + x_k.ElementAt(j) + "))"; //pasos string

                    List<Global.Termino> newTerm = new List<Global.Termino>(); //Termino (x - xi)
                    newTerm.Add(new Global.Termino(1, 1)); // x 
                    newTerm.Add(new Global.Termino(-x_k.ElementAt(j), 0)); // -xi

                    List<Global.Termino> terminosParciales = new List<Global.Termino>();
                    for (int k = 0; k < terms.Count; k++)
                    {
                        Global.Termino aux = new Global.Termino(Util.Redondear(terms[k].coef * newTerm[0].coef), terms[k].grado + newTerm[0].grado);
                        terminosParciales.Add(aux);
                        aux = new Global.Termino(Util.Redondear(terms[k].coef * newTerm[1].coef), terms[k].grado + newTerm[1].grado);
                        terminosParciales.Add(aux);
                    }

                    terms = terminosParciales;
                }
                polAux1 += aux1;//pasos string
                polinomio.AddRange(terms);
            }
            
            // Reducir Polinomio Final
            Util.ReducirPol(polinomio);

            // Polinomio Formateado
            string polString = Util.PolToString(polinomio, "P", "x");

            // Pasos finales
            pasos.Add("Calculo del polinomio");
            pasos.Add("P(x) = " + polAux1);
            pasos.Add("");
            pasos.Add(polString);

            foreach (string p in pasos)
                Console.WriteLine(p);

        }

    }
}
