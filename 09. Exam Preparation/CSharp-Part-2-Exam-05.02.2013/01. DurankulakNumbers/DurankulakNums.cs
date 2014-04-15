using System;
using System.Collections.Generic;

class DurankulakNums
{
    static void Main()
    {  
        //Keep all letters
        string[] letters = new string[168];

        int index = 0;
        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters[index] = i.ToString();
            index++;
        }

        index = 25;
        for (char i = 'a'; i <= 'f'; i++)
        {
            if (i != 'f')
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    index++;
                    letters[index] = i.ToString() + j;
                }
            }
            else
            {
                for (char j = 'A'; j <= 'L'; j++)
                {
                    index++;
                    letters[index] = i.ToString() + j;
                }
            }
        }

        string inputStr = Console.ReadLine(); //MAIN INPUT
        byte numSysBase = 168;

        List<string> foundedNums = new List<string>();

        for (int i = 0; i < inputStr.Length; i++)
        {
            if (char.IsUpper(inputStr[i]))
            {
                foundedNums.Add(inputStr[i].ToString());
            }
            else
            {
                foundedNums.Add(inputStr[i].ToString() + inputStr[i + 1].ToString());
                i++;
            }
        }

        ulong result = 0;

        for (int i = foundedNums.Count - 1; i >= 0; i--)
        {
            result += (ulong)Array.IndexOf(letters, foundedNums[i]) * (ulong)Math.Pow(numSysBase, foundedNums.Count - 1 - i);
        }

        Console.WriteLine(result);
    }
}
