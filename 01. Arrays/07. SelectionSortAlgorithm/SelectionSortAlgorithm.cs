/* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
   Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the
   smallest from the rest, move it at the second position, etc. */

using System;

class SelectionSortAlgorithm
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
        int keepValue;
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            int smallestElement = myArray[i];
            for (int j = i + 1; j < myArray.Length; j++)
            {
                if (myArray[j] < smallestElement)
                {
                    smallestElement = myArray[j];
                    keepValue = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = keepValue;
                }
            }
        }

        //Output
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("After applying \"selection sort\" algorithm, our array looks like: ");
        foreach (var item in myArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
