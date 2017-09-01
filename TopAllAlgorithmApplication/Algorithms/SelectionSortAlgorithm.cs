using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopAllAlgorithmApplication.Core;

namespace TopAllAlgorithmApplication.Algorithms
{
    class SelectionSortAlgorithm : AbstractClassAlgorithms
    {
        public override void StartAlgorithm(int[] mas)
        {
            int index_min_element, a;

            for (int j = 0; j < mas.Length; j++)
            {
                index_min_element = j;
                for (int i = j; i < mas.Length; i++)
                {

                    if (mas[i] < mas[index_min_element])
                        index_min_element = i;
                }


                a = mas[index_min_element];
                mas[index_min_element] = mas[j];
                mas[j] = a;

            }
        }
    }
}
