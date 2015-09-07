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
            int length = 10000000;
            ArrayGenerator myArrayGenerator = new ArrayGenerator();
            BubbleSort bubblebubble = new BubbleSort();
            int[] randomOrder = myArrayGenerator.generateArrayRandom(length);
            Console.Write("RANDOM ");
            bubblebubble.sort(randomOrder);
            int[] order = myArrayGenerator.generateArray(length);
            Console.Write("SORTED ");
            bubblebubble.sort(order);
            

            Console.ReadLine();
        }
    }
}
