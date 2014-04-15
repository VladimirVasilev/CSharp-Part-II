/* Write a program that reads a year from the console and checks whether it is a leap. Use DateTime. */

using System;

class LeapYearCheck
{
    static void Main()
    {
        Console.Write("Please, enter year: ");
        short year = short.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(year);

        Console.WriteLine("Is it {0} a leap year? {1}", year, isLeap);
    }
}
