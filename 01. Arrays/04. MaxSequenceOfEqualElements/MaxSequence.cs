/* Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} --> {2, 2, 2}.
 */

using System;

class MaxSequence
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
        int bestElement = 0;
        int tempLen = 1;
        int bestLen = 1;

        for (int index = 0; index < myArray.Length - 1; index++)
        {
            if (myArray[index] == myArray[index + 1])
            {
                tempLen++;
                if (tempLen > bestLen)
                {
                    bestLen = tempLen;
                    bestElement = myArray[index];
                }
            }
            else
            {
                tempLen = 1;
            }
        }

        //Output        
        if (bestLen != 1)
        {            
            Console.Write("The maximal sequence of equal elements in the given array is: ");
            Console.Write("{");
            for (int i = 0; i < bestLen; i++)
            {
                if (i < bestLen - 1)
                {
                    Console.Write(bestElement + ",");
                }
                else
                {
                    Console.Write(bestElement);
                }
            }

            Console.WriteLine("}");
        }
        else
        {
            Console.WriteLine("Each of the elements appears only once!");
        }

        Console.ForegroundColor = ConsoleColor.White;
    }
}
