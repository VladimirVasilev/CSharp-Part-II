/* Write a program that replaces all occurrences of the substring "start" with the 
   substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB). */

using System;
using System.IO;
using System.Threading;

class ReplaceSubstring
{
    static void Main()
    {
        string line = "";

        StreamReader inputFile = new StreamReader("../../InputFile.txt");
        using (inputFile)
        {
            StreamWriter outputFile = new StreamWriter("../../Output.txt");
            using (outputFile)
            {
                line = inputFile.ReadLine();
                while (line != null)
                {
                    line = line.Replace("start", "finish");
                    outputFile.WriteLine(line);
                    line = inputFile.ReadLine();
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
