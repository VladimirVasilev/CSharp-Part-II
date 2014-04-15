/* Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or
   negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally. */

using System;

class SquareRootTry
{
    private static double CalcSqrt(double num)
    {
        if (num < 0)
        {
            throw new System.ArithmeticException();
        }

        return Math.Sqrt(num);
    }

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Input an integer number to\ncalculate its square root: ");
        try
        {
            int n = int.Parse(Console.ReadLine());
            double result = CalcSqrt(n);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Square root: {0}", result);
        }
        catch (System.OverflowException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid number! Given number causes an OverflowException,\nbecause it is out of range for type integer!");
        }
        catch (System.ArithmeticException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid number! Aritmetical operation failed.\nThe number must be non-negative!");
        }
        catch (System.FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid number! The number is not in the required format!");
        }
        catch (System.ArgumentNullException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid number! Argument NULL detected!");
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Good bye :]");
        }
    }
}
