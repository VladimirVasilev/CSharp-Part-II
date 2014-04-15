/* Write a method that return the maximal element in a portion of array of integers starting at given index.
   Using it write another method that sorts an array in ascending / descending order. */

using System;

class MaxElement
{
    static int MaxElementInPortion(int[] myArray, int startIndex, int portionLen, out int maxNum, out int maxNumIndex)
    {
        maxNum = int.MinValue;
        maxNumIndex = 0;
        for (int i = startIndex; i < startIndex + portionLen; i++)
        {
            if (myArray[i] > maxNum)
            {
                maxNum = myArray[i];
                maxNumIndex = i;
            }
        }

        return maxNum;
    }

    static void PrintArray(int[] myArray)
    {
        foreach (int element in myArray)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int[] myArray = new int[] { 11, 3, 5, 2, 2, 2, 2, 7, 10, 5, 7, 9, 37, 14, 69, 57, 75, 575, 1, 2, 4, 3 };
        int startIndex = 8;
        int portionLen = 9;

        int maxNum;
        int maxNumIndex;

        Console.WriteLine("Our array at the beginning:");
        PrintArray(myArray);

        MaxElementInPortion(myArray, startIndex, portionLen, out maxNum, out maxNumIndex);
        Console.Write("The maximal element in given portion of the array is: ");
        Console.WriteLine("arr[{0}] = {1}", maxNumIndex, maxNum);

        Console.WriteLine("Our array after Descending Sort");
        Array.Sort(myArray, (x, y) => y.CompareTo(x)); // DESCENDING order sort
        PrintArray(myArray);

        Console.WriteLine("Our array after Ascending Sort");
        Array.Sort(myArray, (x, y) => x.CompareTo(y)); // ASCENDING order sort
        PrintArray(myArray);
    }   
}
