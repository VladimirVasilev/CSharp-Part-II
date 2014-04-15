/* Write a program to convert hexadecimal numbers to their decimal representation. */

using System;

class HexadecToDec
{
    static void Main()
    {
        //Input
        Console.Write("Please input a hexadecimal number to convert it \nto it's decimal representation: ");
        string hexaRepresentation = Console.ReadLine().ToUpper();

        //Main logic
        int digit;
        double power = 0;
        double result = 0;
        const int numSysBase = 16;

        for (int i = hexaRepresentation.Length - 1; i >= 0; i--)
        {
            switch (hexaRepresentation[i])
            {
                case 'F': digit = 15; break;
                case 'E': digit = 14; break;
                case 'D': digit = 13; break;
                case 'C': digit = 12; break;
                case 'B': digit = 11; break;
                case 'A': digit = 10; break;
                default: digit = int.Parse(hexaRepresentation[i].ToString()); break;
            }

            result += (long)(digit * Math.Pow(numSysBase, power));
            power++;
        }

        //Output
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Decimal representation of \nthe given nummber is: {0} ", result);
    }
}
