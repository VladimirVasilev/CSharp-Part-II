namespace _02.ReverseString
{
    using System;
    
    class ReverseString
    {
        static void Main()
        {
            Console.Write("Please, input some string to reverse it: ");
            string input = Console.ReadLine();

            for (int index = input.Length - 1; index >= 0; index--)
            {
                Console.Write(input[index]);
            }

            Console.WriteLine();

            ////string inputString = "987654321";
            ////char[] myArray = inputString.ToCharArray();

            ////Array.Reverse(myArray);

            ////Console.WriteLine(myArray);
            ////Console.WriteLine(myArray, 2, 6);
        }
    }
}
