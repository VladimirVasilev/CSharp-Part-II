namespace _14.Word_Description
{
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { ".NET", "– platform for applications from Microsoft" },
                { "CLR", "– managed execution environment for .NET" },
                { "namespace", "– hierarchical organization of classes" }                                       
            };

            Console.Write("Write a word /like: .NET, CLR, namespace/, to find its definition: ");
            string inputWord = Console.ReadLine();

            Console.WriteLine("{0} {1}", inputWord, dictionary[inputWord.ToLowerInvariant()]);
        }
    }
}
