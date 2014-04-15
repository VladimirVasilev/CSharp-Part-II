/* Write a program that reads two arrays from the console and compares them element by element. */

using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(new string('-', 55));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("This program compares two arrays element by element");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(new string('-', 55));

        // Allocate an arrays length with values sent by user
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("Please set a length for the first array: ");
        int firstArrElements = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstArrElements];
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("Please set a length for the second array: ");
        int secondArrElements = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondArrElements];

        bool areEqual = true;
        if (firstArray.Length == secondArray.Length)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Please set a values for the first array");

            //Initialize the elements of the first array
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("firstArray[{0}] = ", index);
                firstArray[index] = int.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Please set a values for the second array");

            //Initialize the elements of the second array
            for (int index = 0; index < secondArray.Length; index++)
            {
                Console.Write("secondArray[{0}] = ", index);
                secondArray[index] = int.Parse(Console.ReadLine());
            }

            //Compare element by element
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        else if (firstArray.Length > secondArray.Length || secondArray.Length > firstArray.Length)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The given arrays are with a diferent length!");
            areEqual = false;
        }

        //Output
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Are the array elements equal?! --> {0}", areEqual.ToString().ToUpper());
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(" If you want continue compare another two arrays type \"1\" and press Enter \n   -or- \n If you want exit program type any button and press Enter");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("I am expecting your choice: ");
        string userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            Main();
        }
        else
        {
            Console.WriteLine("Bye bye :]");
        }
    }
}
