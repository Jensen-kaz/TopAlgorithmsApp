using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopAllAlgorithmApplication.Core
{
    class SelectionAlgorithm
    {
     public AbstractClassAlgorithms SelectAlgorithm { get; set; }

        Random Rand = new Random();

        int[] mas = new int[20];

        


#region ArrayInitialization
        public void SetMassive()
            {
                for (int i = 0; i<mas.Length; i++)
                {
                    mas[i] = Rand.Next(1, 100);
                }
           }

        public int[] Mas
        {
            get
            { return mas; }    
        }
        #endregion

    }
}
