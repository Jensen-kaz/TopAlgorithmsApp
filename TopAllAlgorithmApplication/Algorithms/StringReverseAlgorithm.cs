using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopAllAlgorithmApplication.Core;
using System.Windows.Forms;

namespace TopAllAlgorithmApplication.Algorithms
{
    class StringReverseAlgorithm:AbstractClassAlgorithms
    {
        public override void StartAlgorithm(int[] mas)
        {
            Array.Clear(mas, 0, mas.Length - 1);

            char[] mas_char;

            //  string s = "hello world";
            string s, sResult = "";

            InputBox.InputBox inputBox = new InputBox.InputBox();
            s = inputBox.getString();

            char temp;

            mas_char = s.ToCharArray();

            for (int i = 0, j = mas_char.Length - 1; i < j; i++, j--)
            {
                temp = mas_char[i];
                mas_char[i] = mas_char[j];
                mas_char[j] = temp;


            }

            for (int i = 0; i < mas_char.Length; i++)
            { sResult+=mas_char[i]; }

            MessageBox.Show(sResult);
        }
    }
}
