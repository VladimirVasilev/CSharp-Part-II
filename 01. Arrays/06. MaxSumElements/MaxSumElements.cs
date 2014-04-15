/* Write a program that reads two integer numbers N and K and an array of N elements
   from the console. Find in the array those K elements that have maximal sum. */

using System;

class MaxSumElements
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        //Allocate array and initialize elements
        int[] myArray = new int[n];        

        //Main logic
        if (k > n)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Impossible! You are out of the array's border.\n \"N\" must be bigger than \"K\"! Please try again.");
            Console.ForegroundColor = ConsoleColor.White;
            Main();
        }
        else
        {
            for (int index = 0; index < myArray.Length; index++)
            {
                Console.Write("myArray[{0}] = ", index);
                myArray[index] = int.Parse(Console.ReadLine());
            }

            //Print array
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Your array is:");
            foreach (var element in myArray)
            {
                Console.Write("{0,3}", element);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Array.Sort(myArray); //Sort array

            //Output
            Console.WriteLine("Those {0} elements that have maximal sum are:", k);
            for (int index = myArray.Length - 1; index >= myArray.Length - k; index--)
            {
                Console.Write("{0,3}", myArray[index]);
            }

            Console.WriteLine();
        }
    }
}
