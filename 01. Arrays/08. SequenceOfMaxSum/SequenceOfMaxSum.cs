/* Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> {2, -1, 6, 4}
   Can you do it with only one loop (with single scan through the elements of the array)?
 */

using System;

class SequenceOfMaxSum
{
    static void Main()
    {
        Console.Write("How many elements your array will contain? ");
        int elements = int.Parse(Console.ReadLine());
        int[] myArray = new int[elements]; //Allocate array

        //Initialize array elements
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("myArray[{0}] = ", index);
            myArray[index] = int.Parse(Console.ReadLine());
        }

        //Print array
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Your array is:");
        foreach (var item in myArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        //Main logic
        int bestSum = int.MinValue;
        int tempSum = 0;
        int startIndex = 0;
        int lastIndex = 0;

        for (int index = 0; index < myArray.Length; index++)
        {
            tempSum += myArray[index];

            if (myArray[index] > tempSum)
            {
                tempSum = myArray[index];
                startIndex = index;
            }

            if (tempSum > bestSum)
            {
                bestSum = tempSum;
                lastIndex = index;
            }
        }

        //Output
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("The MAX sum of sequence members is {0} and the members are:", bestSum);
        for (int index = startIndex; index <= lastIndex; index++)
        {
            Console.Write(myArray[index] + " ");
        }

        Console.WriteLine();
    }
}
