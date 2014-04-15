/* Write a program, that reads from the console an array of N integers and an integer K,
   sorts the array and using the method Array.BinSearch() finds the largest number in the
   array which is ≤ K. */

using System;

class FindTheLargestNumTilK
{
    static void Main()
    {
        //Input
        Console.Write("The length of your array will be: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n]; //Allocate array

        //Initialize the elements of our array
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("myArray[{0}]: ", index);
            myArray[index] = int.Parse(Console.ReadLine());
        }
        
        //Print array
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Your array is:");        
        for (int index = 0; index < myArray.Length; index++)
        {
            Console.Write("{0, -4}", myArray[index]);
        }

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Please, now set a value of \"k\" to find the \n" +
            "largest number in the array which is <= k: \n k = ");
        int k = int.Parse(Console.ReadLine());

        //Here, we sort our array
        Array.Sort(myArray);

        //Give to us an operational index which we use depending on 3 base cases
        int biggerThanSearched = Array.BinarySearch(myArray, k);
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        if (biggerThanSearched < -1)
        {
            Console.WriteLine("That number is: {0}", myArray[~biggerThanSearched - 1]);
        }
        else if (~biggerThanSearched == 0)
        {
            Console.WriteLine("There is no such number!!!");
        }
        else
        {
            Console.WriteLine("That number is: {0}", myArray[biggerThanSearched]);
        }
    }
}
