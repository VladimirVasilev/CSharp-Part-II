namespace _03.CheckCorrectBrackets
{
    using System;
        
    class BracketsCorrect
    {
        static void Main()
        {
            string inputExpression = "( 3 + 4 ) * 5 + ( 14 - 7 )";

            int counterOpen = 0;
            int counterClose = 0;

            bool isTrue = true;

            for (int i = 0; i < inputExpression.Length; i++)
            {               
                if (inputExpression[i] == '(')
                {
                    counterOpen++;
                }
                else if (inputExpression[i] == ')')
                {
                    counterClose++;
                }                
             }

            if (counterOpen != counterClose)
            {
                isTrue = false;
                Console.WriteLine(isTrue);
            }
            else
            {
                Console.WriteLine(isTrue);
            }
        }
    }
}
