namespace _20.Palindromes
{
    using System;
    using System.Text;
    
    class Palindromes
    {
        static void Main()
        {
            string input = "The abba, core-lamal and feed is fine. Deed this but beware of big pig in the exe?aManAplanAcatAhamAyakAyamAhatAcanalPanama";
            input = input.ToLower();

            char[] separators = { ' ', ',', '.', '?', '!', '-', '\n', '\r' };
            string[] inputSplit = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder output = new StringBuilder();

            foreach (string word in inputSplit)
            {
                bool isPalindrome = true;
                for (int i = 0; i < (word.Length / 2); i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    output.Append(word + " ");
                }
            }

            Console.WriteLine("Palindrome words are: {0}", output);
        }
    }
}
