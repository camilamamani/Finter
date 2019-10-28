using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finter
{
        // Global
        public static class Global
        {
            /// Estructura de conjunto de puntos 
            public struct Punto
            {
                public double x; // x
                public double y; // f(x)
                public Punto(double p1, double p2) // Setter
                {
                    x = p1;
                    y = p2;
                }
            }

            /// Estructura de conjunto terminos de un polinomio
            public struct Termino
            {
                public double coef; // C
                public int grado; // ^
                public Termino(double p1, int p2) // Setter
                {
                    coef = p1;
                    grado = p2;
                }
            }

            public static List<Punto> puntos = new List<Punto>();
            public static List<Punto> ultimosPuntosUtilizadosParaCalcularPolinomio = new List<Punto>();
            public static List<Termino> polinomio = new List<Termino>();  //[(C0,^0).....(Cn,^n)]
            public static int tipoPol;                                    // 0: Lagrange 1:NG-prog 2:NG-regr
            public static List<string> pasos = new List<string>();
            public static double valorPol;

    }
    }
