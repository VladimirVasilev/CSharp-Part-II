/* Write a method that reverses the digits of given decimal number. Example: 256 --> 652 */

using System;
using System.Text;

class ReverseDigit
{
    public static StringBuilder DigitsReverse(ref decimal inputNum)
    {
        StringBuilder result = new StringBuilder();
        string numString = Convert.ToString(inputNum);
        bool isNegative = false;

        if (inputNum < 0)
        {
            isNegative = true;
        }

        if (isNegative)
        {
            result.Append("-");
            for (int i = numString.Length - 1; i > 0; i--)
            {
                result.Append(numString[i]);
            }
        }
        else
        {
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                result.Append(numString[i]);
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Please input some decimal number to reverse it: ");
        decimal inputNum = decimal.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Input decimal number is: {0}", inputNum);
        StringBuilder result = DigitsReverse(ref inputNum);
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("After reversing we have: {0}", result);
    }   
}
