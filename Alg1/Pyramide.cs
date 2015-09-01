using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg1
{
    class Pyramide
    {
        private static int calcLoop(int n)
        {

            int total = 0;
            while (n > 0)
            {

                total = total + n;
                n--;

            }
            return total;

        }

        private static double calcFormula(int n)
        {
            return ((0.5 * n) * (n + 1));


        }

        private static int calcRecursive(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else
            {
                return n + calcRecursive(n - 1);
            }
        }
    }
}
