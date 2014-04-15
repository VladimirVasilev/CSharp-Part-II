/* Write a program that reads a text file and inserts line numbers in front
   of each of its lines. The result should be written to another text file. */

using System;
using System.IO;
using System.Threading;

class LineNumberInsert
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../TextFile.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter("../../Output.txt");
            using (writer)
            {
                int lineNum = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("Line {0}: {1}", lineNum, line);
                    line = reader.ReadLine();
                    lineNum++;
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
