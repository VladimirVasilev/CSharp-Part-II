namespace _09.ReplaceWordWithAsterisks
{
    using System;
 
    class AsteriskReplace
    {
        static void Main()
        {
            string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string[] forbidenWords = "PHP, CLR, Microsoft".Split(',');
            int length = forbidenWords.Length;

            for (int i = 0; i < length; i++)
            {
                input = input.Replace(forbidenWords[i].Trim(), new string('*', forbidenWords[i].Length));
            }

            Console.WriteLine(input);
        }
    }
}
