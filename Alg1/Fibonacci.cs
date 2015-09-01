using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg1
{
    class Fibonacci
    {

        public int calcRecursive( int n)
        {

            if (n <= 1)
            {
                return n;
            }
            else
            {
                return calcRecursive(n - 1) + calcRecursive(n - 2); 
            }
        }

        public int calcLoop(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
