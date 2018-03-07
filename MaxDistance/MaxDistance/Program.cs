using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            /* V esta entre U e W se U é menor que V e V menor que W 
             * ou
             * U é maior que V, que é maior que W
             * A é um array
             * (P,Q) onde P menor que Q e menor que N tem valores adjacentes se nenhum valor estar entre A[P] e A[Q]  
             * Denomina-se "distancia" o valor A[P] - A[Q], onde P e Q tem valores adjacentes
             * Escrever método que retorne a maior distancia dentre todas as distancias calculadas entre os itens adjacentes
             */

            // Array de teste
            var A = new int[8];
            A[0] = 0;
            A[1] = 3;
            A[2] = 3;
            A[3] = 7;
            A[4] = 5;
            A[5] = 3;
            A[6] = 11;
            A[7] = 1;

            // Para este array de teste, o resultado deve ser 2
            Console.WriteLine(GetMaxDistance(A));
            Console.Read();
        }

        private static int GetMaxDistance(int[] a)
        {
            int max = -2;

            for (int p = 0; p < a.Length; p++)
            {
                for (int q = p + 1; q < a.Length; q++)
                {
                    var isAdjacent = true;

                    for (int i = 0; i < a.Length; i++)
                    {
                        if ((a[i] > a[p] && a[i] < a[q]) || (a[i] < a[p] && a[i] > a[q]))
                        {
                            isAdjacent = false;
                            break;
                        }
                    }

                    if (isAdjacent)
                    {
                        var distance = a[p] - a[q];

                        if (distance > max)
                        {
                            max = distance;
                        }
                    }
                }
            }

            return max;
        }
    }
}
