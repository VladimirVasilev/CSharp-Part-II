/* Write a program that compares two text files line by line and prints the number of lines that are
   the same and the number of lines that are different. Assume the files have equal number of lines. */

using System;
using System.IO;
using System.Text;

class LineByLineCompare
{
    static void Main()
    {
        StringBuilder sameLines = new StringBuilder();
        StringBuilder differentLines = new StringBuilder();

        StreamReader readFile1 = new StreamReader("../../TextFile1.txt");
        using (readFile1)
        {
            StreamReader readFile2 = new StreamReader("../../TextFile2.txt");
            using (readFile2)
            {
                int lineNum = 0;
                string lineFile1 = readFile1.ReadLine();
                string lineFile2 = readFile2.ReadLine();
                while (lineFile1 != null && readFile2 != null)
                {
                    lineNum++;
                    if (lineFile1 == lineFile2)
                    {
                        sameLines.Append(lineNum).Append(" ");
                    }
                    else
                    {
                        differentLines.Append(lineNum).Append(" ");
                    }

                    lineFile1 = readFile1.ReadLine();
                    lineFile2 = readFile2.ReadLine();
                }
            }

            Console.WriteLine("The same line numbers are: {0}", sameLines);
            Console.WriteLine("The different line numbers are: {0}", differentLines);
        }
    }
}
