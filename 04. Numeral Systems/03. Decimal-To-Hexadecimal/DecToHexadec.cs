/* Write a program to convert decimal numbers to their hexadecimal representation. */

using System;
using System.Text;

class DecToHexadec
{
    static void Main()
    {
        //Input
        Console.Write("Please input a decimal number to convert it \nto it's hexadecimal representation: ");
        long inputNum = long.Parse(Console.ReadLine());

        //Main logic
        StringBuilder hexaRepresent = new StringBuilder();
        const byte numSysBase = 16;
        long remainder;

        while (inputNum > 0)
        {
            remainder = inputNum % numSysBase;
            switch (remainder)
            {
                case 15: hexaRepresent.Append("F"); break;
                case 14: hexaRepresent.Append("E"); break;
                case 13: hexaRepresent.Append("D"); break;
                case 12: hexaRepresent.Append("C"); break;
                case 11: hexaRepresent.Append("B"); break;
                case 10: hexaRepresent.Append("A"); break;
                default: hexaRepresent.Append(remainder); break;
            }

            inputNum /= numSysBase;
        }

        //Output
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Hexadecimal representation of \nthe given nummber is: ");
        //Here we print in reverse order our string to get the hexadecimal representation of the number
        for (int i = hexaRepresent.Length - 1; i >= 0; i--)
        {
            Console.Write(hexaRepresent[i]);
        }

        Console.WriteLine();
    }
}
