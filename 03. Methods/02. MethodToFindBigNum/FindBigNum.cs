/* Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program
   that reads 3 integers from the console and prints the biggest of them using the method GetMax(). */

using System;

class FindBigNum
{
    public static int GetMax(int firstNum, int secondNum)
    {
        int biggestNum = firstNum;
        if (secondNum > biggestNum)
        {
            biggestNum = secondNum;
        }

        return biggestNum;
    }

    static void Main()
    {
        Console.Write("Input a first number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Input a second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Input a third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine("The bigger value of the first two numbers {0} and {1} is: {2}", firstNum, secondNum, GetMax(firstNum, secondNum));
        Console.WriteLine("The biggest value of the given three numbers is: {0}", GetMax(GetMax(firstNum, secondNum), thirdNum));
    }
}
