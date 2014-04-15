/* Write a program that reads a text file containing a list of strings,
   sorts them and saves them to another text file. 
   Example:
	        Ivan			 George
	        Peter			 Ivan
	        Maria			 Maria
	        George		     Peter
 */

using System;
using System.IO;
using System.Threading;

class SortAListOfStrings
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader("../../TextFile.txt");
        using (inputFile)
        {
            string[] names = inputFile.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(names);

            StreamWriter outputFile = new StreamWriter("../../OutputFile.txt");
            using (outputFile)
            {
                foreach (var name in names)
                {
                    outputFile.WriteLine(name);
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
