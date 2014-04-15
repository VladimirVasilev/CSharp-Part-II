namespace _10.ConvertStringToUnicodeChar
{
    using System;
 
    class ConvertToChar
    {
        static void Main()
        {
            string input = @"Hi .NET Ninja!";

            foreach (var symbol in input)
            {
                Console.WriteLine("\\u{0:X4}", (int)symbol);
            }
        }
    }
}
