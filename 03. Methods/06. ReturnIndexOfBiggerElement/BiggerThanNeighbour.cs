/* Write a method that returns the index of the first element in array that is bigger than its 
   neighbors, or -1, if there’s no such element.Use the method from the previous exercise. */

using System;

class BiggerThanNeighbour
{
    public static int IsBiggerThanNeighbour(int[] myArray)
    {
        bool isBigger = false;
        int searchedIndex = 0;

        for (int index = 1; index < myArray.Length - 1; index++)
        {
            if ((myArray[index] > myArray[index + 1]) && (myArray[index] > myArray[index - 1]))
            {
                isBigger = true;
                searchedIndex = index;
                break;
            }
        }

        if (isBigger == true)
        {
            return searchedIndex;
        }
        else
        {
            return -1;
        }
    }

    static void Main()
    {
        Console.Write("Please, initiate the size of your array: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] myArray = new int[arraySize];

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        if (IsBiggerThanNeighbour(myArray) != -1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The first number in given array which is bigger than\nhis neighbours is at position {0} and this number is {1}!", IsBiggerThanNeighbour(myArray), myArray[IsBiggerThanNeighbour(myArray)]);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(IsBiggerThanNeighbour(myArray));
        }       
    }    
}
