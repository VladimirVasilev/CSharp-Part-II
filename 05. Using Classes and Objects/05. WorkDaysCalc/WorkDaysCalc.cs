/* Write a method that calculates the number of workdays between today and given date,
   passed as parameter. Consider that workdays are all days from Monday to Friday except
   a fixed list of public holidays specified preliminary as array. */

using System;

class WorkDaysCalc
{
    static void Main()
    {
        Console.Write("Enter a date /format: DD.MM.YYYY format/\nto calculate the number of workdays: ");
        string[] endTo = Console.ReadLine().Split('.');
        int day = int.Parse(endTo[0]);
        int month = int.Parse(endTo[1]);
        int year = int.Parse(endTo[2]);

        DateTime startFrom = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int allDays = 0;
        allDays = Math.Abs((endDay - startFrom).Days);

        DateTime[] holidays =
            {
                new DateTime(2013, 8, 10),
                new DateTime(2013, 8, 11),
                new DateTime(2013, 8, 17),
                new DateTime(2013, 8, 18),
                new DateTime(2013, 8, 24),                
                new DateTime(2013, 8, 25),                
                new DateTime(2013, 8, 31),                
                new DateTime(2013, 9, 1),                
                new DateTime(2013, 9, 7),                
                new DateTime(2013, 9, 8),                
                new DateTime(2013, 9, 14),                
                new DateTime(2013, 9, 15),                
                new DateTime(2013, 9, 21),                
                new DateTime(2013, 9, 22),                
                new DateTime(2013, 9, 28),                
                new DateTime(2013, 9, 29),                
                new DateTime(2013, 10, 5),                
                new DateTime(2013, 10, 6),                
                new DateTime(2013, 10, 12),                
                new DateTime(2013, 10, 13),                
                new DateTime(2013, 10, 19),                
                new DateTime(2013, 10, 20),                
                new DateTime(2013, 10, 26),                
                new DateTime(2013, 10, 27),                
                new DateTime(2013, 11, 2),                
                new DateTime(2013, 11, 3),                
                new DateTime(2013, 11, 9),                
                new DateTime(2013, 11, 10),                
                new DateTime(2013, 11, 16),                
                new DateTime(2013, 11, 17),                
                new DateTime(2013, 11, 23),                
                new DateTime(2013, 11, 24),                
                new DateTime(2013, 11, 30),                
                new DateTime(2013, 12, 1),                
                new DateTime(2013, 12, 7),                
                new DateTime(2013, 12, 8),                
                new DateTime(2013, 12, 14),                
                new DateTime(2013, 12, 15),                
                new DateTime(2013, 12, 21),                
                new DateTime(2013, 12, 22),                
                new DateTime(2013, 12, 28),                
                new DateTime(2013, 12, 29),                
                new DateTime(2014, 1, 4),                
                new DateTime(2014, 1, 5),                
                new DateTime(2014, 1, 11),                
                new DateTime(2014, 1, 12)
            };

        int workDays = 0;
        bool isHoliday = false;

        for (int i = 0; i < allDays; i++)
        {
            startFrom = startFrom.AddDays(1);
            if ((startFrom.DayOfWeek != DayOfWeek.Sunday) && (startFrom.DayOfWeek != DayOfWeek.Saturday))
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startFrom == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDays++;
                }

                isHoliday = false;
            }
        }

        Console.WriteLine(" There are {0} days from today to given date\n and the number of workdays are: {1}", allDays, workDays);
    }
}
