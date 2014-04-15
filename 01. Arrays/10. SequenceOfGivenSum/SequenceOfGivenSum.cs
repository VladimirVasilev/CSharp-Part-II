/* Write a program that finds in given array of integers a sequence of given
   sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5} */

using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        //Input
        Console.Write("How many elements your array will contain? ");
        int elements = int.Parse(Console.ReadLine());
        Console.Write("Searched sum: S = ");
        int sum = int.Parse(Console.ReadLine());

        //Allocate array
        int[] myArray = new int[elements];
                
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
        int tempSum = 0;
        int startIndex;
        int endIndex;
        int counterSeq = 0;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-Output-");
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            tempSum += myArray[i];
            startIndex = i;
            for (int j = i + 1; j < myArray.Length; j++)
            {
                tempSum += myArray[j];
                endIndex = j;

                if (tempSum > sum)
                {
                    tempSum = 0;
                    break;
                }
                else if (tempSum == sum)
                {
                    counterSeq++;
                    for (int index = startIndex; index <= endIndex; index++)
                    {
                        Console.Write(myArray[index] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }

        Console.WriteLine("There are {0} sequences in array with sum {1}!", counterSeq, sum);
    }
}
