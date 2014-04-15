/* Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
   If an invalid number or non-number text is entered, the method should throw an exception. 
   Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;

class IntegerInRange
{
    static int downLimit = 1;
    static int uplimit = 100;   

    public static void ReadNumber(int start, int end)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (number == 99)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You reach the limit of our interval! You have NO MORE tries !!!");
                Environment.Exit(0);
            }
            else
            {
                downLimit = number;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ACCEPTED!");
                Console.WriteLine("New interval [{0} .. {1}]", downLimit, end);
            }
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input format! It must be a number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid number! The number must be in the interval of ({0} < n < 100)", downLimit);
        }
        catch (OverflowException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Given number causes an OverflowException,\nbecause it is out of range for type integer!");
        }
    }

    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Input 10 integer numbers [{0} ; {1}]:", downLimit, uplimit);
        for (int counter = 0; counter < 10; counter++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(You have {0} more): ", 10 - counter);
            ReadNumber(downLimit, uplimit);
        }

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Bye-bye! :]");
    }    
}
