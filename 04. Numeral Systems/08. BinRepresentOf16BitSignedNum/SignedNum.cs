/* Write a program that shows the binary representation of
   given 16-bit signed integer number (the C# type short). */

using System;

class SignedNum
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Please enter a short integer number: ");
        short inputNum = short.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("The binary representation of the number is: ");
        Console.WriteLine(Convert.ToString(inputNum, 2));
    }
}
