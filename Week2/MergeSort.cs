using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class MergeSort
    {

        int equations = 0;
        int totalEquations;
        long swaps = 0;

        public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                swaps++;
                equations++;
                if (numbers[left] <= numbers[mid])
                {
                    temp[tmp_pos++] = numbers[left++];
                }
                else
                {
                    temp[tmp_pos++] = numbers[mid++];
                }
            }

            while (left <= left_end)
            {
                temp[tmp_pos++] = numbers[left++];
                swaps++;
            }

            while (mid <= right)
            {
                temp[tmp_pos++] = numbers[mid++];
                swaps++;
            }

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
                swaps++;
            }
        }

        public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        public void startSort(int[] arr)
        {
            equations = 0;
            MergeSort_Recursive(arr, 0, arr.Length - 1);
            totalEquations += equations;
        }

        public void sortTimes(int times)
        {
            Console.WriteLine("MERGESORT");
            Stopwatch stopw = new Stopwatch();
            ArrayGenerator myArrayGenerator = new ArrayGenerator();
            totalEquations = 0;
            stopw.Restart();
            for (int i = 0; i < times; i++)
            {
                int[] randomOrder = myArrayGenerator.generateArray(10000);
                startSort(randomOrder);

            }

            double averageTimes = (float)totalEquations / times;
            Console.WriteLine("Finished average equations: " + averageTimes);
            Console.WriteLine("Swaps: " + (float)swaps / times);

            Console.Out.WriteLine("Time " + (float)stopw.ElapsedMilliseconds / times);
        }
    }
}
