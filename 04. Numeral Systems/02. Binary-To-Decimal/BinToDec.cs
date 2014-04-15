/* Write a program to convert binary numbers to their decimal representation. */

using System;

class BinToDec
{
    static void Main()
    {
        //Input
        Console.Write("Please input a binary number to convert it \nto it's decimal representation: ");
        string binaryRepresentation = Console.ReadLine();

        //Main logic
        double power = 0;
        double result = 0;
        const int numSysBase = 2;
        for (int i = binaryRepresentation.Length - 1; i >= 0 ; i--)
        {
            if (binaryRepresentation[i] == '1')
            {
                result += Math.Pow(numSysBase, power);
            }

            power++;
        }

        //Output
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Decimal representation of \nthe given nummber is: {0} ", result);
    }
}
