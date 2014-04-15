namespace _18.ExtractEmailAddresses
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractEmail
    {
        static void Main(string[] args)
        {
            string input = @"Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string[] inputArr = input.Split(' ');

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (Regex.IsMatch(inputArr[i], @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}")) // From 2 to 20 letters, digits or underscore, followed by @, followed by 2 to 20 letters, digits or underscore, followed by SINGLE DOT '.', followed by 2 to 6 letters, digits or dot.
                {
                    Console.WriteLine(inputArr[i]);
                }
            }
        }
    }
}
