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
        int equations = 0;
        int totalEquations;
        long swaps;

        public void sort(int[] arr)
        {
            int temp = 0;
            Stopwatch stopw = new Stopwatch();
            stopw.Restart();
            for (int write = 0; write < arr.Length; write++)
            {
                bool swapped = false;
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    equations++;
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                        swapped = true;
                        swaps++;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        public void startSort(int[] arr)
        {
            equations = 0;
            sort(arr);
            totalEquations += equations;
        }

        public void sortTimes(int times)
        {
            Console.WriteLine("BUBBLESORT");
            Stopwatch stopw = new Stopwatch();
            ArrayGenerator myArrayGenerator = new ArrayGenerator();
            totalEquations = 0;
            stopw.Restart();
            for (int i = 0; i < times; i++)
            {
                int[] randomOrder = myArrayGenerator.generateArrayRandom(10000);
                startSort(randomOrder);
                Console.WriteLine(i);

            }

            double averageTimes = (float)totalEquations / times;
            Console.WriteLine("Finished average equations: " + averageTimes);
            Console.WriteLine("Swaps: " + (long)swaps / times);

            Console.Out.WriteLine("Time " + (float)stopw.ElapsedMilliseconds / times);
        }
    }
}
