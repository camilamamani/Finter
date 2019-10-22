using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finter
{
    class Lagrange
    {

        // Calcular polinomio de Lagrange (Lista de puntos(x,y)) => Polinomio
        public static List<Types.Termino> CalcPolLagrange(List<Types.Punto> puntos)
        {
            List<Types.Termino> polinomio = new List<Types.Termino>();
            for (int i = 0; i < puntos.Count; i++)
            {
                List<Types.Termino> numLi = new List<Types.Termino>();
                numLi.Add(new Types.Termino(1, 0));
                double denomLi = 1;
                for (int j = 0; j < puntos.Count; j++)
                {
                    if (i != j)
                    {
                        // Acumular denominador para dividir a Li
                        denomLi = denomLi * (puntos[i].x - puntos[j].x);
                        List<Types.Termino> nuevoTermino = new List<Types.Termino>();
                        nuevoTermino.Add(new Types.Termino(-puntos[j].x, 0));
                        nuevoTermino.Add(new Types.Termino(1, 1));
                        // Multiplicar nuevo termino para determinar nuevo Li
                        List<Types.Termino> numLiParcial = new List<Types.Termino>();
                        for (int k = 0; k < numLi.Count; k++)
                        {
                            Types.Termino aux = new Types.Termino(Util.Redondear(numLi[k].coef * nuevoTermino[0].coef), numLi[k].grado + nuevoTermino[0].grado);
                            numLiParcial.Add(aux);
                            aux = new Types.Termino(Util.Redondear(numLi[k].coef * nuevoTermino[1].coef), numLi[k].grado + nuevoTermino[1].grado);
                            numLiParcial.Add(aux);
                        }

                        numLi = numLiParcial;
                    }
                }

                // Reducir numerador Li
                Util.ReducirPol(numLi);
                // Armar Li
                List<Types.Termino> li;
                li = Util.MultPolPorCte(numLi, (puntos[i].y / denomLi));
                // Mostrar Li formateado
                String liString = Util.PolToString(li, "L" + i, "X");
                Console.WriteLine(liString);
                // Agregar Li al Polinomio Final
                polinomio.AddRange(li);
            }

            return polinomio;
        }

    }
}
