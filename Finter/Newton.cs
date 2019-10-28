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
        }

        //Calculo los deltas
        void CalcElements(List<Double> y, int order, int step)
        {
            int i;
            List<Double> xx;
            if (order >= 1)
            {
                xx = new List<double>();//f[xi, ..., xi+n]
                double diferencia;
                for (i = 0; i < order - 1; i++)
                {
                    diferencia = (y.ElementAt(i+1) - y.ElementAt(i) / (x_k.ElementAt(i+step) - x_k.ElementAt(i)));
                    xx.Add(diferencia);
                }
                b.Insert(step - 1, y.ElementAt(0));//newton progresivo
                CalcElements(xx, order - 1, step + 1);
            }
        }

        //Interpolando para un valor especifico de k
        double Interpolate(double k)
        {
            int i, j;
            double tempYp = 0;
            double yp = 0;
            for (i = 1; i < orden; i++)
            {
                tempYp = b.ElementAt(0);
                for (j = 0; j < i; j++)
                {
                    tempYp = tempYp * (k - x_k.ElementAt(j));
                }
                yp = yp + tempYp;
            }
            return b.ElementAt(0) + yp;
        }

        public static void CalcPolNewton(List<Global.Punto> puntos, List<Global.Termino> polinomio)
        {
            //calcular el polinomio sin especializar para un valor de k
        }

    }
}
