namespace _08.ExtractSentenceByGivenWord
{
    using System;
    using System.Text.RegularExpressions;
  
    class ExtractSentence
    {
        static void Main()
        {
            string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";

            string[] sentenceArr = input.Split('.');
            for (int i = 0; i < sentenceArr.Length; i++)
            {
                if (Regex.IsMatch(sentenceArr[i], @"\b" + word + @"\b", RegexOptions.IgnoreCase))
                {
                    Console.WriteLine((sentenceArr[i] + ".").Trim());
                }
            } 
        }
    }
}
