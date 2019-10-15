using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting101
{
    class Program
    {
        public static int[] Merge(int[] arr1, int[] arr2)
        {
            int i = 0;
            int[] result = new int[arr1.Length + arr2.Length];
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < arr1.Length && rightIndex < arr2.Length)
            {
                if (arr1[leftIndex] < arr2[rightIndex])
                {
                    result[i] = arr1[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[i] = arr2[rightIndex];
                    rightIndex++;
                }

                i++;
            }

            while (leftIndex < arr1.Length)
            {
                result[i] = arr1[leftIndex];
                leftIndex++;
                i++;
            }

            while (rightIndex < arr2.Length)
            {
                result[i] = arr2[rightIndex];
                rightIndex++;
                i++;
            }

            return result;
        }

        public static int[] MergeSort(int[] unsorted)
        {
            if (unsorted.Length == 1) return unsorted;

            int mid = unsorted.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[unsorted.Length - mid];

            Array.Copy(unsorted, 0, left, 0, mid);
            Array.Copy(unsorted, mid, right, 0, unsorted.Length - mid);

            return Merge(MergeSort(left), MergeSort(right));
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the number of values to be added to the array: ");
            int size = -1;
            int.TryParse(Console.ReadLine(), out size);

            if (size < 1)
            {
                Console.WriteLine("Error: input must be greater than 0");
                Console.Read();
                return;
            }

            int[] nums = new int[size];
            int[] result = new int[size];

            Console.Write("Please enter all values to be added to the array: ");
            nums = Array.ConvertAll(Console.ReadLine().Split(' '), temp => Convert.ToInt32(temp));

            if (nums.Length != size)
                throw new ArgumentException();

            result = MergeSort(nums);
            Console.Write("The sorted array is: ");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }

            Console.Read();
        }
    }
}
