using System;
using System.Collections.Generic;
using System.Text;

class KaspichanNums
{
    static void Main()
    {
        ulong inputNum = ulong.Parse(Console.ReadLine());

        char[] digitsBig = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] digitsSmall = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

        ulong numSysBase = 256;

        List<ulong> remainders = new List<ulong>();

        StringBuilder result = new StringBuilder();


        if (inputNum == 0)
        {
            Console.WriteLine("A");
        }
        else
        {
            while (inputNum != 0)
            {
                remainders.Add(inputNum % numSysBase);
                inputNum /= numSysBase;
            }

            remainders.Reverse();

            for (int i = 0; i < remainders.Count; i++)
            {
                if (remainders[i] >= 0 && remainders[i] <= 25)
                {
                    result.Append(digitsBig[remainders[i]]);
                }
                else if (remainders[i] >= 26 && remainders[i] <= 51)
                {
                    result.Append(digitsSmall[0]);
                    result.Append(digitsBig[remainders[i] - 26]);
                }
                else if (remainders[i] >= 52 && remainders[i] <= 77)
                {
                    result.Append(digitsSmall[1]);
                    result.Append(digitsBig[remainders[i] - 52]);
                }
                else if (remainders[i] >= 78 && remainders[i] <= 103)
                {
                    result.Append(digitsSmall[2]);
                    result.Append(digitsBig[remainders[i] - 78]);
                }
                else if (remainders[i] >= 104 && remainders[i] <= 129)
                {
                    result.Append(digitsSmall[3]);
                    result.Append(digitsBig[remainders[i] - 104]);
                }
                else if (remainders[i] >= 130 && remainders[i] <= 155)
                {
                    result.Append(digitsSmall[4]);
                    result.Append(digitsBig[remainders[i] - 130]);
                }
                else if (remainders[i] >= 156 && remainders[i] <= 181)
                {
                    result.Append(digitsSmall[5]);
                    result.Append(digitsBig[remainders[i] - 156]);
                }
                else if (remainders[i] >= 182 && remainders[i] <= 207)
                {
                    result.Append(digitsSmall[6]);
                    result.Append(digitsBig[remainders[i] - 182]);
                }
                else if (remainders[i] >= 208 && remainders[i] <= 233)
                {
                    result.Append(digitsSmall[7]);
                    result.Append(digitsBig[remainders[i] - 208]);
                }
                else if (remainders[i] >= 234 && remainders[i] <= 255)
                {
                    result.Append(digitsSmall[8]);
                    result.Append(digitsBig[remainders[i] - 234]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
