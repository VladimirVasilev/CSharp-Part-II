namespace _06.FilledWithAsterisk
{
    using System;
    using System.Text;

    class FillWithAsterisk
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input.Length <= 20)
            {
                StringBuilder lengthTwenty = new StringBuilder();
                lengthTwenty.Append(input);
                while (lengthTwenty.Length < 20)
                {
                    lengthTwenty.Append('*');
                }

                Console.WriteLine(lengthTwenty);
            }
            else
            {
                Console.WriteLine("The input string must be less than 20 symbols.\nPlease, try again :( ");
                Main();
            }

            ////OTHER WAY
            ////string input = "This is text";
            ////string changedInput = input.PadRight(20, '*');
            ////Console.WriteLine(changedInput);
        }
    }
}
