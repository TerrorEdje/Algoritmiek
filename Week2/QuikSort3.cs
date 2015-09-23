using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class QuikSort3
    {

        int equations = 0;
        int totalEquations;
        int swaps;


        void printArray(int[] numbers) {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+"-");
            }
            Console.WriteLine();
        }

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
            Console.WriteLine("Start ");
            printArray(arr);
            if (left < right)
            {
                equations++;
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    sort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    sort(arr, pivot + 1, right);
            }
            Console.WriteLine("End " );
            printArray(arr);
            
        }

        public void startSort(int[] arr, int left, int right)
        {
            equations = 0;
            sort(arr, left, right);
            Console.WriteLine("Finished after : " + equations);
            totalEquations += equations;
        }

        public void sortTimes(int times)
        {
            Stopwatch stopw = new Stopwatch();
            ArrayGenerator myArrayGenerator = new ArrayGenerator();
            totalEquations = 0;
            stopw.Restart();
            for (int i = 0; i < times; i++)
            {
                int[] randomOrder = myArrayGenerator.generateArrayRandom(20);
                startSort(randomOrder, 0, randomOrder.Length - 1);

            }

            double averageTimes = (float)totalEquations / times;
            Console.WriteLine("Finished average equations: " + averageTimes);
            Console.WriteLine("Swaps: " + (float)swaps / times);

            Console.Out.WriteLine("Time " + (float)stopw.ElapsedMilliseconds / times);
        }
    }
}
