/* Write a program that concatenates two text files into another text file. */

using System;
using System.IO;
using System.Threading;

class TwoTextFilesConcat
{
    static void Main()
    {
        StreamReader readInput1 = new StreamReader("../../TextFile1.txt");
        using (readInput1)
        {
            StreamReader readInput2 = new StreamReader("../../TextFile2.txt");
            using (readInput2)
            {
                StreamWriter writeOutput = new StreamWriter("../../TextFile3.txt");
                using (writeOutput)
                {
                    string line = readInput1.ReadLine();
                    while (line != null)
                    {
                        writeOutput.WriteLine(line);
                        line = readInput1.ReadLine();
                    }

                    line = readInput2.ReadLine();
                    while (line != null)
                    {
                        writeOutput.WriteLine(line);
                        line = readInput2.ReadLine();
                    }
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
