using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class QuikSort
    {
        int equations = 0;
        int totalEquations;
        int swaps;

        public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    swaps++;
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public void sort(int[] arr, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                equations++;
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    sort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    sort(arr, pivot + 1, right);
            }
            
        }

        public void startSort(int[] arr, int left, int right)
        {
            equations =0;
            sort(arr, left, right);
            totalEquations += equations;
        }

        public void sortTimes(int times)
        {
            Console.WriteLine("QUICKSORT");
            Stopwatch stopw = new Stopwatch();
            ArrayGenerator myArrayGenerator = new ArrayGenerator();
            totalEquations = 0;
            stopw.Restart();
            for (int i = 0; i < times; i++)
            {
                int[] randomOrder = myArrayGenerator.generateArray(10000);
                startSort(randomOrder, 1, 1000);
                
            }
            
            double averageTimes = (float)totalEquations / times;
            Console.WriteLine("Finished average equations: " + averageTimes);
            Console.WriteLine("Swaps: " + (float)swaps/times);
            
            Console.Out.WriteLine("Time " + (float)stopw.ElapsedMilliseconds/times);
        }
    }
}
