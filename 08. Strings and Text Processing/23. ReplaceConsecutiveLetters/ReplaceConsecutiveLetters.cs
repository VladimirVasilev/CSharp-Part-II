namespace _23.ReplaceConsecutiveLetters
{
    using System;
    using System.Text;
   
    class ReplaceConsecutiveLetters
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            for (int i = 0, index = 0; i < input.Length - 1; i++, index++)
            {
                char letter = input[i];
                while (index < input.Length - 1 && letter == input[index + 1])
                {
                    input.Remove(index + 1, 1);
                }
            }

            Console.WriteLine(input);
        }
    }
}
