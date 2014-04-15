/* Write a program that reads a text file and prints on the console its odd lines. */

using System;
using System.IO;

class OddLinesPrint
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../ReadThis.txt"))
        {
            int lineNum = 1;
            string line = input.ReadLine();
            while (line != null)
            {
                if (lineNum % 2 != 0)
                {
                    Console.WriteLine(line);
                }

                lineNum++;
                line = input.ReadLine();
            }
        }
    }
}
