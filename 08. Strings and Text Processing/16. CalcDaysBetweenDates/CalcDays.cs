namespace _16.CalcDaysBetweenDates
{
    using System;
    using System.Globalization;
   
    class CalcDays
    {
        static void Main()
        {
            Console.Write("First date is: ");
            string dateNow = Console.ReadLine();            
            Console.Write("Second date is: ");
            string dateAfter = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(dateNow, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(dateAfter, "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.Write("The number of days between these two dates are: ");
            Console.WriteLine((endDate - startDate).TotalDays);
        }
    }
}
