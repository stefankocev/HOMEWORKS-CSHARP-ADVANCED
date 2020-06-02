using System;
using System.Collections.Generic;

namespace SEDC.Homework01.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK 2
            List<DateTime> holidays = new List<DateTime>
            {
                new DateTime(1,1,1),
                new DateTime(1,1,7),
                new DateTime(1,4,20),
                new DateTime(1,5,1),
                new DateTime(1,5,25),
                new DateTime(1,8,3),
                new DateTime(1,9,8),
                new DateTime(1,10,12),
                new DateTime(1,10,23),
                new DateTime(1,12,8)
            };
            bool isHoliday = false;
            while (true)
            {
                Console.Write("Please enter the date you wanna check, in this format(YYYY/MM/DD):");
                var inputDate = Console.ReadLine();
                DateTime date = DateTime.Parse(inputDate);
                foreach (var holiday in holidays)
                {
                    if (date.Day == holiday.Day && date.Month == holiday.Month)
                    {
                        Console.WriteLine($"This day is {date.DayOfWeek}, and it's holiday.");
                        isHoliday = !isHoliday;
                    }

                }
                if (!isHoliday)
                {
                    if (date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday)
                        Console.WriteLine($"This day is {date.DayOfWeek} and is working day.");
                    else
                        Console.WriteLine($"It's {date.DayOfWeek}, it's weekend and it's not working day.");
                }
                Console.WriteLine("Do you want to check another date y/n");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.ToLower() == "y")
                {
                    continue;
                }
                if (yesOrNo.ToLower() == "n")
                {
                    break;
                }

            }
            //if ((date.Month == 1 && date.Day == 1) || (date.Month == 1 && date.Day == 7) ||
            //    (date.Month == 3 && date.Day == 20) || (date.Month == 5 && date.Day == 1) ||
            //    (date.Month == 8 && date.Day == 3) || (date.Month == 9 && date.Day == 8) ||
            //    (date.Month == 10 && date.Day == 12) || (date.Month == 10 && date.Day == 23) ||
            //    (date.Month == 12 && date.Day == 8))
            //{
            //    Console.WriteLine($"This day is {date.DayOfWeek}, and it's holiday.");
            //}
            //else if (date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday)
            //{
            //    Console.WriteLine($"This day is {date.DayOfWeek} and is working day.");
            //}
            //else
            //{
            //    Console.WriteLine($"It's {date.DayOfWeek}, it's weekend and it's not working day.");
            //}
            #endregion
            Console.ReadLine();
        }
    }
    }
