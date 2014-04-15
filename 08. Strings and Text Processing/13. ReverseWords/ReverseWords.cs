namespace _13.ReverseWords
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    
    class ReverseWords
    {
        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";

            char[] separators = new char[] { ',', ' ', '!', '?', '.', ';', ':' };
            string[] wordsArr = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(wordsArr);

            string[] arr = Regex.Split(input, "[A-Za-z0-9#+/|-]"); // all capitals, lowers, digits, symbols like "+" "#"
            List<string> nonLetters = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != String.Empty)
                {
                    nonLetters.Add(arr[i]);
                }
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < nonLetters.Count; i++)
            {
                if (i < wordsArr.Length)
                {
                    result.Append(wordsArr[i]);
                }

                result.Append(nonLetters[i]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
