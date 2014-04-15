/* You are given an array of strings. Write a method that sorts the array by
   the length of its elements (the number of characters composing them). */

using System;

class MethodToSortByLength
{
    static void Main()
    {
        //Input
        Console.Write("The length of your ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("array of strings ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("will be: ");
        int n = int.Parse(Console.ReadLine());
        string[] myArray = new string[n]; //Allocate array

        //Initialize the elements of our array
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("myArray[{0}]: ", index);
            myArray[index] = Console.ReadLine();
        }
                
        //Main logic
        Array.Sort(myArray, (x, y) => (x.Length).CompareTo(y.Length)); //ASCENDING order sort

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("The sorted array by length in ASCENDING order is:");
        foreach (string element in myArray)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine();

        Array.Sort(myArray, (x, y) => (y.Length).CompareTo(x.Length)); //DESCENDING order sort

        Console.WriteLine("The sorted array by length in DESCENDING order is:");
        foreach (string element in myArray)
        {
            Console.WriteLine(element);
        }
    }
}
