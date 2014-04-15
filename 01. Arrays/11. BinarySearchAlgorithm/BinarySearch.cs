/* Write a program that finds the index of given element in a sorted array of
   integers by using the binary search algorithm (find it in Wikipedia). */

using System;

class BinarySearch
{
    static void Main()
    {
        //Allocate and assign an array
        int[] myArray = { 3, 1, 5, 6, 8, 19, 15, 35, 7, 25, 78, 101 };

        Array.Sort(myArray); //Sort an array (binary search works ONLY in a sorted arrays!!!)

        //Print a sorted array
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Your sorted array is:");
        foreach (var item in myArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        //Input
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("Choose an element in a sorted array to find it's index: ");
        int searchedNum = int.Parse(Console.ReadLine());
       
        //Main logic
        int downBound = 0;
        int upBound = myArray.Length - 1;
        int middle;

        while (true)
        {
            middle = (downBound + upBound) / 2;
            if (searchedNum > myArray[middle])
            {
                downBound = middle + 1;
            }
            else if (searchedNum < myArray[middle])
            {
                upBound = middle - 1;
            }
            else if (searchedNum == myArray[middle])
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("The index of the given element {0} is {1}", searchedNum, middle);
                break;
            }
        }
    }
}
