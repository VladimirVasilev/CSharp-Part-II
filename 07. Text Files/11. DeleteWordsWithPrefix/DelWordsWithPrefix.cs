/* Write a program that deletes from a text file all words that start with the prefix "test".
   Words contain only the symbols 0...9, a...z, A…Z, _. */

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

class DelWordsWithPrefix
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader("../../Input.txt");
        using (inputFile)
        {
            StreamWriter outputFile = new StreamWriter("../../Output.txt");
            using (outputFile)
            {
                string line = "";
                line = inputFile.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*(\s|\S)\b", "");
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
