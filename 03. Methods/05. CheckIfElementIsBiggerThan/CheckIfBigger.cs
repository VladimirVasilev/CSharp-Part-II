/* Write a method that checks if the element at given position in given
   array of integers is bigger than its two neighbors (when such exist). */

using System;

class CheckIfBigger
{

    static void PrintArray(int[] myArray)
    {
        foreach (int member in myArray)
        {
            Console.Write(member + " ");
        }

        Console.WriteLine();
    }

    static void IfElementIsBigger(int[] myArray, int position)
    {
        bool isBigger = false;

        if (myArray.Length == 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The array has only one member!");
        }
        else if (position == 0)
        {
            if (myArray[position] > myArray[position + 1])
            {
                isBigger = true;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The number {0} of position {1} has only one neighbour /right-oriented/.\n" +
                    "Is the number Bigger than his heighbour? {2}", myArray[position], position, isBigger);
        }
        else if (position == myArray.Length - 1)
        {
            if (myArray[position] > myArray[position - 1])
            {
                isBigger = true;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The number {0} of position {1} has only one neighbour /left-oriented/.\n" +
                    "Is the number Bigger than his heighbour? {2}", myArray[position], position, isBigger);
        }
        else if (myArray[position] > myArray[position - 1] && myArray[position] > myArray[position + 1])
        {
            isBigger = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The number {0} of position {1} has two neighbours.\n" +
                     "Is the number Bigger than his heighbours? {2}", myArray[position], position, isBigger);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The number {0} of position {1} has two neighbours.\n" +
                    "Is the number Bigger than his heighbours? {2}", myArray[position], position, isBigger);
        }
    }

    static void Main()
    {
        int[] myArray = new int[] { 11, 3, 5, 2, 4, 8, 6, 7, 5, 7, 9, 34, 17, 69, 57, 75, 575 };

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Here, we have an array of integers with members:");
        PrintArray(myArray);

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("Input a position of one member to compare with his neighbours: ");
        int position = int.Parse(Console.ReadLine());

        if (position <= myArray.Length - 1 && position >= 0)
        {
            IfElementIsBigger(myArray, position);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("WTF.. Man, are you crazy?! You are trying to get out of array bounds.\n" +
                "Please, DON'T TRY THIS AT HOME ANYMORE!!!");
        }
    }
}
