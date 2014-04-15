/* Write a program to convert from any numeral system of given base s
   to any other numeral system of base d (2 ≤ s, d ≤  16). */

using System;

class UniversalConversion
{
    static void Main()
    {
        //Input
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("What is the base value of the numeral system that you wish to convert from:\n s = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("What is the base value of the numeral system that you wish to convert into:\n d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Now, please enter your number that you want to convert: ");
        string inputNum = Console.ReadLine();

        //Output
        string convertNum = Convert.ToString(Convert.ToInt64(inputNum, s), d);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("After conversion, your number has a new value of: {0}", convertNum.ToUpper());
    }
}
