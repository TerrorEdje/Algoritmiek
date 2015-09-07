using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayGenerator myArrayGenerator = new ArrayGenerator();
            int[] randomOrder = myArrayGenerator.generateArrayRandom(10000);
            for(int i = 0; i<randomOrder.Length; i ++){
                Console.WriteLine(randomOrder[i]);
            }


            Console.ReadLine();
        }
    }
}
