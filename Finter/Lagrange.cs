using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finter
{
    static class Lagrange
    {

        // Calcular polinomio de Lagrange (Lista de puntos(x,y)) => Polinomio
        public static void CalcPolLagrange(List<Types.Punto> puntos, List<Types.Termino> polinomio, List<string> pasos)
        {
            List<Types.Termino> li;
            string auxStr1 = "";
            string auxStr2 = "";
            string polString;


            for (int i = 0; i < puntos.Count; i++)
            {
                string sNum = "";
                string sDen = "";

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

                        // Armar numerador Li
                        sNum += "(x" + " - " + puntos[j].x + ")";
                        // Armar denominador Li
                        sDen += "(" + puntos[i].x + " - " + puntos[j].x + ")";
                    }
                }
                
                // Reducir numerador Li
                Util.ReducirPol(numLi);
                // Armar Li
                li = Util.MultPolPorCte(numLi, (puntos[i].y / denomLi));
                // Mostrar Li formateado
                String liString = Util.PolToString(li, "", "x");
                //Console.WriteLine(liString);

                // Agregar Li al Polinomio Final
                polinomio.AddRange(li);

                // Pasos
                pasos.Add("Calculo de L" + i);
                pasos.Add("L" + i + "(x) = " + sNum + " / " + sDen);
                pasos.Add("f" + i + "(x)L" + i + "(x) = " + puntos[i].y + "(" + sNum + " / " + sDen + ")");
                pasos.Add("f" + i + "(x)L" + i + "(x) = " + (puntos[i].y / denomLi) + "(" + sNum + ")");
                pasos.Add("f" + i + "(x)L" + i + "(x) = " + liString);
                pasos.Add("");
                if (i == 0)
                {
                    auxStr1 += "f" + i + "(x)L" + i + "(x)";
                    auxStr2 += liString;
                }
                else
                {
                    auxStr1 += " + f" + i + "(x)L" + i + "(x) ";
                    auxStr2 += " + " + liString;
                }

            }

            // Reducir Polinomio Final
            Util.ReducirPol(polinomio);

            // Polinomio Formateado
            polString = Util.PolToString(polinomio, "P", "x");

            // Pasos finales
            pasos.Add("Calculo del polinomio");
            pasos.Add("P(x) = " + auxStr1);
            pasos.Add("");
            pasos.Add("P(x) = " + auxStr2);
            pasos.Add(polString);

            foreach (string p in pasos)
                Console.WriteLine(p);

        }

    }
}
