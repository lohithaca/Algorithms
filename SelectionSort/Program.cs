using System;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectionSort ss = new SelectionSort();
            int[] unsortArray = new int[4] { 2, 10, 25, 15 };

            int[] sortedArray;

            sortedArray = ss.selectionSort(unsortArray);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i]+",");
            }
            
        }
    }
}
