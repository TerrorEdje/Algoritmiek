using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class ArrayGenerator
    {

        public int[] generateArrayRandom(int size)
        {
            int[] original = generateArray(size);

            Random r = new Random();
            for (int i = original.Length; i > 0; i--)
            {
                int j = r.Next(i);
                int k = original[j];
                original[j] = original[i - 1];
                original[i - 1] = k;
            }

           

            return original;
        }

        public int[] generateArray(int size)
        {
            
            int[] returnValue = new int[size];
            for (int i = 0; i < size; i++)
            {
                returnValue[i] = i;
            }
            return returnValue;
        }
    }
}
