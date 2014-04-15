namespace _04.SubstringContain
{
    using System;
   
    class SubstringContain
    {
        static void Main()
        {
            string input = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days";

            input = input.ToLower();
            int counter = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == 'i' && input[i + 1] == 'n')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
