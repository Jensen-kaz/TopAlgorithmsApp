using System.Windows.Forms;
using TopAllAlgorithmApplication.Core;
using System.Linq;
using System;


namespace TopAllAlgorithmApplication.Algorithms
{
    class FibonacciSequenceAlgorithm: AbstractClassAlgorithms
    {
        public override void StartAlgorithm(int[] mas)
        {
            Array.Clear(mas, 0, mas.Length - 1);
            int n, result;

            string str;
            InputBox.InputBox inputBox = new InputBox.InputBox();

            str = inputBox.getString();
            n = int.Parse(str);

            result = fib_seq(n);

            MessageBox.Show(n + " значение последовательности равно: " + result);
        }

        static int fib_seq(int a)
        {
            if (a <= 2)
                return 1;

            int[] mas1 = new int[a];

            mas1[0] = 1; mas1[1] = 1;
            
            for (int i = 2; i < mas1.Length; i++)
            {
                mas1[i] = mas1[i - 1] + mas1[i - 2];
            }

            return mas1.Last();
        }
    }
}
