using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopAllAlgorithmApplication.Core;

namespace TopAllAlgorithmApplication.Algorithms
{
    class MergeSort : AbstractClassAlgorithms
    {
        public override void StartAlgorithm(int[] mas)
        {
            mergeSort(mas, 0, mas.Length);
        }

        private void mergeSort(int[] a, int start, int end)
        {
            if (end - start < 2)
                return;

            if (end - start == 2)
            {
                if (a[start] > a[start + 1])
                {
                    int b = a[start];
                    a[start] = a[start + 1];
                    a[start + 1] = b;
                }
            }
            int left_en, start_right;

            left_en = start + (end - start) / 2;
            start_right = start + (end - start) / 2;

            mergeSort(a, start, left_en);
            mergeSort(a, start_right, end);

            List<int> mas_2 = new List<int>();
            int left = start;
            int left_end = start + (end - start) / 2;
            int right = left_end;

            while (mas_2.Count() < end - start)
            {
                if (left >= left_end || (right < end && a[right] <= a[left]))
                {
                    mas_2.Add(a[right]);
                    ++right;
                }
                else
                {
                    mas_2.Add(a[left]);
                    ++left;
                }
            }

            for (int i = start; i < end; ++i)
            {
                a[i] = mas_2[i - start];
            }

        }
    }
}
