/* Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
 */

using System;

class MostFrequentNum
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
        int tempValue;
        int bestValue = 0;
        int frequentValue;
        int tempRepeater = 1;
        int bestRepeater = 0;

        for (int i = 0; i < myArray.Length - 1; i++)
        {
            tempValue = myArray[i];
            for (int j = 1; j < myArray.Length; j++)
            {
                if (tempValue == myArray[j])
                {
                    frequentValue = tempValue;
                    tempRepeater++;

                    if (tempRepeater > bestRepeater)
                    {
                        bestRepeater = tempRepeater;
                        bestValue = tempValue;
                    }
                }
            }

            tempRepeater = 0;
        }

        //Output
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("The most frequent value: {0} \nRepeated times: {1}", bestValue, bestRepeater);
    }
}
