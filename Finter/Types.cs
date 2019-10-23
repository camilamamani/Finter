using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finter
{
    static class Types
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
    }
}
