/* Write a method that returns the last digit of given integer as an English word.
   Examples: 512 --> "two", 1024 --> "four", 12309 --> "nine". */

using System;

class DigitAsWord
{
    public static string LastDigitAsWord(int number)
    {
        string digitAsWord = String.Empty;
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 0: digitAsWord = "zero"; break;
            case 1: digitAsWord = "one"; break;
            case 2: digitAsWord = "two"; break;
            case 3: digitAsWord = "three"; break;
            case 4: digitAsWord = "four"; break;
            case 5: digitAsWord = "five"; break;
            case 6: digitAsWord = "six"; break;
            case 7: digitAsWord = "seven"; break;
            case 8: digitAsWord = "eight"; break;
            case 9: digitAsWord = "nine"; break;
        }

        return digitAsWord;
    }

    static void Main()
    {
        Console.Write("Please, input an integer number: ");
        int inputNum = int.Parse(Console.ReadLine());

        Console.Write("The last digit of the given number is: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(LastDigitAsWord(inputNum));
        Console.ForegroundColor = ConsoleColor.White;
    }
}
