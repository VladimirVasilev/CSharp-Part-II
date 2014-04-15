namespace _24.AlphabeticalOrderWords
{
    using System;
    using System.Linq;
 
    class AlphabeticalOrder
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split();

            var sortedWords = inputArr.OrderBy(x => x); // Alphabetical order sort
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
