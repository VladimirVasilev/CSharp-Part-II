/* Write a program that removes from a text file all words listed in given
   another text file. Handle all possible exceptions in your methods. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

class RemoveListedWords
{
    static void Main()
    {
        string inputListWords = "../../ListedWords.txt";
        string inputText = "../../MyText.txt";

        string tempFile = Path.GetTempFileName();
        List<string> wordsToEliminate = new List<string>();

        try
        {
            StreamReader listedWords = new StreamReader(inputListWords);
            using (listedWords)
            {
                string line;
                while ((line = listedWords.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (var word in words)
                    {
                        wordsToEliminate.Add(word);
                    }
                }

                StreamReader readText = new StreamReader(inputText);
                using (readText)
                {
                    StreamWriter output = new StreamWriter(tempFile);
                    using (output)
                    {
                        string currentLine;
                        while ((currentLine = readText.ReadLine()) != null)
                        {
                            foreach (var word in wordsToEliminate)
                            {
                                currentLine = Regex.Replace(currentLine, @"\b" + word + @"\b", "");
                            }

                            output.WriteLine(currentLine);
                        }
                    }
                }
            }

            File.Delete(inputText);
            File.Move(tempFile, inputText);
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine(e.Message);
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
