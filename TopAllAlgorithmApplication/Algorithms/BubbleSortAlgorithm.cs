using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopAllAlgorithmApplication.Core;

namespace TopAllAlgorithmApplication.Algorithms
{
    class BubbleSortAlgorithm: AbstractClassAlgorithms
    {
        public override void StartAlgorithm(int[] mas)
        {
            int len_mas = mas.Length;
            int count, j;

            while (len_mas > 0)
            {
                j = 0;
                count = 0;

                for (int i = 0; i < mas.Length - 1; i++)
                {

                    j++;

                    if (mas[i] > mas[j])
                    {
                        Swap(ref mas[i], ref mas[j]);
                        count++;

                    }

                }
                len_mas--;


                if (count == 0)
                    break;
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int c;

            c = a;
            a = b;
            b = c;

        }

    }
}
