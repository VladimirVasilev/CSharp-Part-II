namespace _11.NumInDecaHexaPercentScient
{
    using System;
 
    class DecaHexaPercentScient
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", inputNum);   // Decimal
            Console.WriteLine("{0,15:X}", inputNum); // Hexadecimal
            Console.WriteLine("{0,15:P}", inputNum); // Percentage
            Console.WriteLine("{0,15:E}", inputNum); // Scientific notation
        }
    }
}
