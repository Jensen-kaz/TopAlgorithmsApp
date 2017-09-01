using TopAllAlgorithmApplication.Core;
using System.Windows.Forms;

namespace TopAllAlgorithmApplication.Algorithms
{
    class LinearSearchAlgorithm : AbstractClassAlgorithms
    {
        public override void StartAlgorithm(int[] mas)
        {
            int el = 0;
            string str;

            bool flag = false;

            InputBox.InputBox inputBox = new InputBox.InputBox();
            str = inputBox.getString();

            el = int.Parse(str);

            for (int i = 0; i < mas.Length; i++)
            {
                if (el == mas[i])
                {
                    MessageBox.Show("Число присутствует в массиве на " + (i+1) + " позиции");
                    i = mas.Length;
                    flag = true;
                }               
            }

            if (flag == false)
            {
                MessageBox.Show("Числа нет в массиве");
            }

        }
    }
}
