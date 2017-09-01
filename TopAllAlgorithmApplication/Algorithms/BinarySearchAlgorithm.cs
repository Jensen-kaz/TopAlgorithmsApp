using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopAllAlgorithmApplication.Core;
using System.Windows.Forms;
using TopAllAlgorithmApplication;

namespace TopAllAlgorithmApplication.Algorithms
{
    class BinarySearchAlgorithm : AbstractClassAlgorithms
    {


        public override void StartAlgorithm(int[] mas)
        {
            
            int el=0;
            string str;
            
            InputBox.InputBox inputBox = new InputBox.InputBox();
            str = inputBox.getString();

            el = int.Parse(str);
            
            List<int> masList = mas.ToList();            
            binary_search(masList.Count() / 2, el, masList);
        }

        private void binary_search(int middle_mas, int el, List<int> masList)
        {

            if (masList.First() > el || masList.Last() < el)
            {
                 MessageBox.Show("Введеное число отсутствует в массиве");
                return;
            }

            if (masList.Count == 2)
            {
                for (int i = 0; i < masList.Count; i++)
                {
                    if (masList[i] == el)
                    {
                        MessageBox.Show("Введеное число присутствует в массиве " + masList[i]);
                        return;
                    }
                }
                MessageBox.Show("Введеное число отсутствует в массиве");
                return;
            }



            if (masList[middle_mas] > el)
            {
                masList.RemoveRange(middle_mas, (masList.Count - 1) - middle_mas);
            }
            else if (masList[middle_mas] < el)
            {
                masList.RemoveRange(0, middle_mas);
            }
            else
            {
                MessageBox.Show("Введеное число присутствует в массиве " + masList[middle_mas]);
                return;
            }

            binary_search(masList.Count / 2, el, masList);
        }
    }
}
