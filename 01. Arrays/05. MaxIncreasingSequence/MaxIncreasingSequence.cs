/* Write a program that finds the maximal increasing sequence in an array. 
        Example: {3, 2, 3, 4, 2, 2, 4} --> {2, 3, 4}.
 */

using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        //Allocate array
        Console.Write("Please set a length of your array: ");
        int elements = int.Parse(Console.ReadLine());
        int[] myArray = new int[elements];

        //Initialize array
        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("array[{0}] = ", index);
            myArray[index] = int.Parse(Console.ReadLine());
        }

        //Print array
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Your array is:");
        foreach (var item in myArray)
        {
            Console.Write("{0, 3}", item);
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        //Main logic
        int bestLen = 1;
        int currentLen = 1;
        int numIndex = 0;

        for (int index = 1; index < myArray.Length; index++)
        {
            if (myArray[index] > myArray[index - 1])
            {
                currentLen++; 
            }
            else
            {
                currentLen = 1;
            }

            if (currentLen > bestLen)
            {
                bestLen = currentLen;
                numIndex = index - currentLen + 1;
            }
        }

        //Output
        Console.Write("Max increasing sequence in the given array is: ");
        Console.Write("{");
        for (int i = 0; i < bestLen; i++)
        {
            if (i != bestLen - 1)
            {
                Console.Write("{0},", myArray[numIndex + i]);
            }
            else
            {
                Console.Write(myArray[numIndex + i]);
            }
        }

        Console.WriteLine("}");
    }
}
