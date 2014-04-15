using System;
using System.Numerics;

class NineGagNumbers
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        byte numSysBase = 9;

        string stringDigit = String.Empty;
        string number = String.Empty;

        for (int i = 0; i < inputStr.Length; i++)
        {
            stringDigit += inputStr[i];

            switch (stringDigit)
            {
                case "-!":
                    number += "0";
                    stringDigit = "";
                    break;
                case "**":
                    number += "1";
                    stringDigit = "";
                    break;
                case "!!!":
                    number += "2";
                    stringDigit = "";
                    break;
                case "&&":
                    number += "3";
                    stringDigit = "";
                    break;
                case "&-":
                    number += "4";
                    stringDigit = "";
                    break;
                case "!-":
                    number += "5";
                    stringDigit = "";
                    break;
                case "*!!!":
                    number += "6";
                    stringDigit = "";
                    break;
                case "&*!":
                    number += "7";
                    stringDigit = "";
                    break;
                case "!!**!-":
                    number += "8";
                    stringDigit = "";
                    break;
            }
        }

        BigInteger result = BigInteger.Parse(number[number.Length - 1].ToString());

        for (int i = number.Length - 2; i >= 0; i--)
        {
            result += BigInteger.Parse(number[i].ToString()) * BigInteger.Pow(numSysBase, number.Length - 1 - i);
        }

        Console.WriteLine(result);
    }
}
