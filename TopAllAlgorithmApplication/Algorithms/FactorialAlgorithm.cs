using System;
using TopAllAlgorithmApplication.Core;
using System.Windows.Forms;

namespace TopAllAlgorithmApplication.Algorithms
{
    class FactorialAlgorithm : AbstractClassAlgorithms
    {
        public override void StartAlgorithm(int[] mas)
        {
            Array.Clear(mas, 0, mas.Length-1);
            int n;

            string str;

            InputBox.InputBox inputBox = new InputBox.InputBox();
            str = inputBox.getString();

            n = int.Parse(str);

            MessageBox.Show("Факториал равен " + factorial_funct(n));
            
        }

        private int factorial_funct(int n)
        {

            if (n == 1)
                return 1;

            return n * factorial_funct(n - 1);
        }
    }
}
