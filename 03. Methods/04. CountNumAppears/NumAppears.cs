/* Write a method that counts how many times given number appears in given array.
   Write a test program to check if the method is working correctly. */

using System;

class NumAppears
{
    public static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

    public static int NumberAppearsCounting(int[] arr, int checkNum)
    {
        int appearCount = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index] == checkNum)
            {
                appearCount++;
            }
        }

        return appearCount;
    }

    static void Main()
    {
        //Input
        Console.Write("Please define the count of your array elements: ");
        int arrayElements = int.Parse(Console.ReadLine());

        int[] myArray = new int[arrayElements]; //Allocate an array

        //Initialize array elements
        for (int index = 0; index < myArray.Length; index++)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("myArray[{0}] = ", index);
            myArray[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Number to check is: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        //Print array using method
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Your array is:");
        PrintArray(myArray);

        //With this method we find how many times given number appears in given array
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Searched number {0} appears {1} times", numberToCheck , NumberAppearsCounting(myArray, numberToCheck));
    }
}
