using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg1
{
    class NeiaardmoGnirts
    {

        public void runMe(String input)
        {
            if (input.Length > 0)
            {
                Console.Write(input.ElementAt(input.Length - 1));
                runMe(input.Remove(input.Length - 1));
            }
            
        }


        public bool testMe(string p)
        {
            if (p.Length == 1 || p.Length == 0)  //added check for even cases
                return true;
            if (p[0] != p[p.Length - 1])
                return false;

            return testMe(p.Substring(1, p.Length - 2));

        }
    }
}
