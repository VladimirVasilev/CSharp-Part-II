/* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */

using System;
using System.Linq;

class SolvingTasks
{
    public static void MainMenu()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("".PadRight(25) + "WELCOME TO MAIN MENU!\n You have 3 options:");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(new string('~', 75));
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("# To REVERSE digits of given number, please enter \"1\"");
        Console.WriteLine("# To CALCULATE the average of given sequence of integers, please enter \"2\"");
        Console.WriteLine("# To SOLVE a linear equation / Example: a*x+b /, please enter \"3\"");
        Console.WriteLine("... to EXIT the program, press \"0\"");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(new string('~', 75));
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("Please make your choice: ");

        int choiceNum = int.Parse(Console.ReadLine());
        switch (choiceNum)
        {
            case 1: DigitReverse();
                break;
            case 2: CalculateAverage();
                break;
            case 3: SolveLinearEquation();
                break;
            case 0:
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bye-Bye! ;]");
                }

                break;
            default:
                {
                    Console.Clear();
                    Console.WriteLine(new string('=', 75));
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ERROR!!! Sorry, you have only 3 choices! Please make your choice correclty!");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(new string('=', 75));
                    MainMenu();
                }

                break;
        }
    }

    private static void DigitReverse()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to \"Reverse Digits Wizard\" :]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Please enter a number: ");
        decimal myNum = decimal.Parse(Console.ReadLine());

        string numAsString = myNum.ToString();

        if (myNum == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Number should be NON - NEGATIVE. Please input another!");
            DigitReverse();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Reversed number \"{0}\" is: ", myNum);

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                Console.Write(numAsString[i]);
            }

            Console.WriteLine();
        }
    }

    private static void CalculateAverage()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to \"Calculate Average Wizard\" :]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Please set the length of the sequence: ");
        int length = int.Parse(Console.ReadLine());

        if (length == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Number should be NON - NEGATIVE. Please input another!");
            CalculateAverage();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Now, enter a sequence of integer numbers:");
            decimal[] myArray = new decimal[length];

            for (int index = 0; index < length; index++)
            {
                Console.Write("number[{0}]= ", index + 1);
                myArray[index] = int.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Average of a given sequence is: {0}", myArray.Average());
        }
    }

    private static void SolveLinearEquation()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to \"Calculate Average Wizard\" of a kind / a * x + b = 0 / :]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Set a value of\n a = ");
        decimal a = decimal.Parse(Console.ReadLine());

        Console.Write("Set a value of\n b = ");

        if (a == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Number should be NON - NEGATIVE. Please input another!");
            SolveLinearEquation();
        }
        else
        {
            decimal b = decimal.Parse(Console.ReadLine());
            decimal x = -b / a;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Solution of the given Linear equation {0}x + {1} = 0 is:\n x = {2}", a, b, x);
        }
    }

    static void Main()
    {
        MainMenu();
    }
}
