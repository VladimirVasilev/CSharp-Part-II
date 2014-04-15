/* Write a program to convert decimal numbers to their binary representation. */

using System;
using System.Text;

class DecToBin
{
    static void Main()
    {
        //Input
        Console.Write("Please input a decimal number to convert it \nto it's binary representation: ");
        long inputNum = long.Parse(Console.ReadLine());

        //Main logic
        StringBuilder binRepresent = new StringBuilder();
        const byte numSysBase = 2;
        long remainder;

        while (inputNum > 0)
        {
            remainder = inputNum % numSysBase;
            binRepresent.Append(remainder);
            inputNum /= numSysBase;
        }

        //Output
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Binary representation of \nthe given nummber is: ");
        //Here we print in reverse order our string to get the binary representation of the number
        for (int i = binRepresent.Length - 1; i >= 0; i--) 
        {
            Console.Write(binRepresent[i]);
        }

        Console.WriteLine();
    }
}
