namespace _22.DifferentWordsInString
{
    using System;
  
    class DifferentWordsInString
    {
        static void Main()
        {
            string input = "one four five two three four four five two three four five five three five";
            string[] splitted = input.Split(' ');

            int counter = 1;
            string lastWord = "";

            Array.Sort(splitted);

            for (int i = 0; i < splitted.Length - 1; i++)
            {                
                if (i < splitted.Length)
                {
                    if (splitted[i] == splitted[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} times", splitted[i], counter);
                        counter = 1;
                    }
                }

                lastWord = splitted[i];
            }

            Console.WriteLine("{0} - {1} times", lastWord, counter);
        }
    }
}
