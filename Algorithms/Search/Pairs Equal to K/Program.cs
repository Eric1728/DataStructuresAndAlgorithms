using System;
using System.Collections.Generic;

namespace PairsEqualToK
{
    class Program
    {
        static int Pairs(int k, int[] arr)
        {
            int result = 0;
            HashSet<int> nums = new HashSet<int>();

            // add all values to set
            for (int i = 0; i < arr.Length; i++)
            {
                nums.Add(arr[i]);
            }

            // if array contains difference, increment result
            for (int i = 0; i < arr.Length; i++)
            {
                if (nums.Contains(arr[i] - k))
                {
                    result++;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            //get number of items in array and k-value
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), temp => Convert.ToInt32(temp));
            int result = Pairs(k, arr);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
