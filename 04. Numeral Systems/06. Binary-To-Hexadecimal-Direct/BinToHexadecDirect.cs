/* Write a program to convert binary numbers to hexadecimal numbers (directly). */

using System;

class BinToHexadecDirect
{
    public static string ReverseString(string str)
    {
        char[] digits = str.ToCharArray();
        Array.Reverse(digits);
        str = new string(digits);

        return str;
    }

    private static void BinToHexConvert(ref string tempResult, ref string endResult)
    {
        switch (tempResult)
        {
            case "0000": endResult += "0"; break;
            case "0001": endResult += "1"; break;
            case "0010": endResult += "2"; break;
            case "0011": endResult += "3"; break;
            case "0100": endResult += "4"; break;
            case "0101": endResult += "5"; break;
            case "0110": endResult += "6"; break;
            case "0111": endResult += "7"; break;
            case "1000": endResult += "8"; break;
            case "1001": endResult += "9"; break;
            case "1010": endResult += "A"; break;
            case "1011": endResult += "B"; break;
            case "1100": endResult += "C"; break;
            case "1101": endResult += "D"; break;
            case "1110": endResult += "E"; break;
            case "1111": endResult += "F"; break;
        }

        tempResult = "";
    }

    static void Main()
    {
        //Input
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Binary number: ");
        string inputBinNum = Console.ReadLine();

        //Main logic
        string tempResult = String.Empty;
        string endResult = String.Empty;
        for (int i = inputBinNum.Length - 1; i >= 0; i--)
        {
            tempResult += inputBinNum[i];
            if (tempResult.Length == 4)
            {
                tempResult = ReverseString(tempResult);
                BinToHexConvert(ref tempResult, ref endResult);
            }
            else if (i == 0 && (tempResult.Length == 3))
            {
                tempResult = ReverseString(tempResult);
                tempResult = "0" + tempResult;
                BinToHexConvert(ref tempResult, ref endResult);
            }
            else if (i == 0 && (tempResult.Length == 2))
            {
                tempResult = ReverseString(tempResult);
                tempResult = "00" + tempResult;
                BinToHexConvert(ref tempResult, ref endResult);
            }
            else if (i == 0 && (tempResult.Length == 1))
            {
                tempResult = "000" + tempResult;
                BinToHexConvert(ref tempResult, ref endResult);
            }
        }

        string output = ReverseString(endResult);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hex represent: {0}", output);
    }    
}
