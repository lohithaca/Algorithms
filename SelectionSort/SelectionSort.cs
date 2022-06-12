using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public class SelectionSort
    {
        public int[] selectionSort(int[] inputArray)
        {
            int[] array = inputArray;
            int loopCount = array.Length - 1;

            //Selecting the max value
            while (loopCount > 0)
            {
                int maxValue = array[0];
                int maxIndex = 0;

                for (int i = 0; i <= loopCount; i++)
                {
                    if (array[i] > maxValue)
                    {
                        maxValue = array[i];
                        maxIndex = i;
                    }
                }

                //Assigning the max value
                array[maxIndex] = array[loopCount];
                array[loopCount] = maxValue;
                loopCount--;
            }

            return array;
        }
    }
}
