/* Write a program that compares two char arrays lexicographically (letter by letter). */

using System;

class LexicCompareArrays
{
    static void Main()
    {
        //Hardcode the input (you can try to change or add a new array members)
        char[] firstArray = { 'f', 'i', 'r', 's', 't', 'a', 'r', 'r', 'a', 'y' };
        char[] secondArray = { 's', 'e', 'c', 'n', 'd', 'a', 'r', 'r', 'a', 'y' };
        bool areEqual;

        //Print first array
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("First array is:");
        foreach (var item in firstArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        //Print second array
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Second array is:");
        foreach (var item in secondArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        if (firstArray.Length == secondArray.Length) 
        {
            //Main logic
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] == secondArray[index])
                {
                    areEqual = true;
                }
                else
                {
                    areEqual = false;
                }

                Console.WriteLine("firstArray[{0}] = secondArray[{0}] --> {1}", index, areEqual);
            }
        }
        else if (firstArray.Length > secondArray.Length || secondArray.Length > firstArray.Length)
        {
            Console.WriteLine("The arrays are with different length!");
        }
    }
}
