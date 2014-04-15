/* Write a program that creates an array containing all letters from the alphabet (A-Z). 
   Read a word from the console and print the index of each of its letters in the array. */

using System;

class AlphabeticArray
{
    static void Main()
    {
        //Allocate and assign an array containing all letters from the alphabet
        char[] myArray = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                             'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        //Input
        Console.Write("Please input some word: ");
        string word = Console.ReadLine().ToUpper();

        //Main logic
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("The coresponding indexes to each letter of the given word are:");
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == '0' || word[i] == '1' || word[i] == '2' || word[i] == '3' || word[i] == '4' ||
                    word[i] == '5' || word[i] == '6' || word[i] == '7' || word[i] == '8' || word[i] == '9')
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error! {0} is not a letter! Only string consist of letters are acceptable", word[i]);
            }
            else
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (word[i] == myArray[j])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Letter {0} is with index {1} and it's number in english alphabet is {2}", myArray[j], j, j + 1);
                    }
                }
            }
        }
    }
}
