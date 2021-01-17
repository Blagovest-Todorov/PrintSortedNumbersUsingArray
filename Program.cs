using System;
using System.Collections.Generic;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int[] arr = new int[numCount];
            
            for (int i = 0 ; i < numCount; i++)
            {
                int inputNum = int.Parse (Console.ReadLine());
                arr[i] = inputNum;
            }
            Console.WriteLine();

            // we print the old array unsorted
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine();

            // now we sort the array and print it
            Array.Sort(arr);

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine();

            // now we reverse teh sorted array and print it
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
