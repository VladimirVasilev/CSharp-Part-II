/* Write a program that deletes from given text file all odd lines. The result should be in the same file. */

using System;
using System.IO;
using System.Threading;

class DeleteOddLines
{
    static void Main()
    {
        string inputFile = "../../Input.txt";
        string tempFile = Path.GetTempFileName();

        StreamReader readFile = new StreamReader("../../Input.txt");
        using (readFile)
        {
            StreamWriter outputFile = new StreamWriter(tempFile);
            using (outputFile)
            {
                int lineNumber = 1;
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        outputFile.WriteLine(line);
                    }

                    lineNumber++;
                }
            }
        }

        File.Delete(inputFile);
        File.Move(tempFile, inputFile);

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
