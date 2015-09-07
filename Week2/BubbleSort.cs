using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class BubbleSort
    {
        public void sort(int[] arr)
        {
            Console.WriteLine("BUBBLESORT START");
            int temp = 0;
            int swaps = 0;
            int equations = 0;
            Stopwatch stopw = new Stopwatch();
            stopw.Restart();
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    equations++;
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                        swaps++;
                    }
                }
            }
            
            Console.WriteLine("SWAPS: " + swaps);
            Console.WriteLine("EQUATIONS: " + equations);
            Console.WriteLine("TIME: " + stopw.ElapsedMilliseconds);
            Console.WriteLine("BUBBLESORT DONE");


        }
    }
}
