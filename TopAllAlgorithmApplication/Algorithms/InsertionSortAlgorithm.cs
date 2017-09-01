using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopAllAlgorithmApplication.Core;

namespace TopAllAlgorithmApplication.Algorithms
{
    class InsertionSortAlgorithm : AbstractClassAlgorithms
    {
        public override void StartAlgorithm(int[] mas)
        {
            int a;

            for (int i = 1; i < mas.Length; i++)
                for (int j = i; j > 0 && mas[j - 1] > mas[j]; j--)
                {
                    a = mas[j];
                    mas[j] = mas[j - 1];
                    mas[j - 1] = a;
                }
        }
    }
}
