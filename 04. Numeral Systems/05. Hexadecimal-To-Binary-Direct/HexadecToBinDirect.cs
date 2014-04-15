/* Write a program to convert hexadecimal numbers to binary numbers (directly). */

using System;
using System.Text;

class HexadecToBinDirect
{
    static void Main()
    {
        //Input
        Console.WriteLine("Please input a hexadecimal number to convert \nit directly to it's binary representation: ");
        string inputHexNum = Console.ReadLine().ToUpper();
        
        //Main logic
        StringBuilder resultBin = new StringBuilder();
        for (int i = 0; i < inputHexNum.Length; i++)
        {
            switch (inputHexNum[i])
            {
                case '0':
                    resultBin.Append("0000");
                    break;
                case '1':
                    resultBin.Append("0001");
                    break;
                case '2':
                    resultBin.Append("0010");
                    break;
                case '3':
                    resultBin.Append("0011");
                    break;
                case '4':
                    resultBin.Append("0100");
                    break;
                case '5':
                    resultBin.Append("0101");
                    break;
                case '6':
                    resultBin.Append("0110");
                    break;
                case '7':
                    resultBin.Append("0111");
                    break;
                case '8':
                    resultBin.Append("1000");
                    break;
                case '9':
                    resultBin.Append("1001");
                    break;
                case 'A':
                    resultBin.Append("1010");
                    break;
                case 'B':
                    resultBin.Append("1011");
                    break;
                case 'C':
                    resultBin.Append("1100");
                    break;
                case 'D':
                    resultBin.Append("1101");
                    break;
                case 'E':
                    resultBin.Append("1110");
                    break;
                case 'F':
                    resultBin.Append("1111");
                    break;
                default: 
                    resultBin.Append("");
                    break;
            }
        }

        //Output
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Binary representation of \nthe given nummber is: \n{0}", resultBin);
    }
}
