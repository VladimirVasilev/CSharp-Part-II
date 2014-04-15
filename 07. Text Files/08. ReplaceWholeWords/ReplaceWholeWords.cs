/* Modify the solution of the previous problem to replace only whole words (not substrings). */

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

class ReplaceWholeWords
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader("../../InputFile.txt");
        using (inputFile)
        {
            StreamWriter outputFile = new StreamWriter("../../Output.txt");
            using (outputFile)
            {
                string pattern = @"\b(start)\b";
                Regex regExpress = new Regex(pattern);

                for (string line = inputFile.ReadLine(); line != null; line = inputFile.ReadLine())
                {
                    string outputLine = regExpress.Replace(line, "finish");
                    outputFile.WriteLine(outputLine);
                }
            }
        }

        //Simulating Loading Phase
        Console.Write("Processing");
        for (int i = 0; i < 21; i++)
        {
            Console.Write(".");
            Thread.Sleep(150);
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("DONE!");
    }
}
