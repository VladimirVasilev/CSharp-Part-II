namespace _17.DateAndTimeAfter
{
    using System;
    using System.Globalization;

    class DateAndTimeAfter
    {
        static void Main()
        {
            Console.Write("Input a date to add 6 hours and 30 minutes: ");
            string inputDate = Console.ReadLine();

            DateTime date = DateTime.ParseExact(inputDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            date = date.AddHours(6.5);

            Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
        }
    }
}
