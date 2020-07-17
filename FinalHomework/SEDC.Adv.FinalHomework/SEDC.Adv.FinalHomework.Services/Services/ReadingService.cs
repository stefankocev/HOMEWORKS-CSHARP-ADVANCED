using SEDC.Adv.FinalHomework.Db.DataBase;
using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Services
{
    public class ReadingService<T> where T : Reading
    {
        private IActivityDb<Reading> _readingactivityDb;
        public ReadingService()
        {
            _readingactivityDb = new ActivityDb<Reading>();
        }
        public void AddReadingActivity(Reading reading)
        {
            _readingactivityDb.InsertActivity(reading);
        }
        public List<Reading> GetAllReadingActivities()
        {
            return _readingactivityDb.GetAllActivities();
        }

        public void Stats()
        {
            var readingList = GetAllReadingActivities();
            double totalHours = 0;
            int totalPages = 0;
            int bellesLetresType = 0;
            int fictionType = 0;
            int proffesionalLiteratureType = 0;
            foreach (var item in readingList)
            {
                totalHours += item.Stopwatch.Elapsed.TotalHours;
                totalPages += item.Pages;

                if (item.Type.ToString() == "BellesLetres")
                {
                    bellesLetresType++;
                }else if(item.Type.ToString() == "Fiction")
                {
                    fictionType++;
                }
                else
                {
                    proffesionalLiteratureType++;
                }
            }
            if (readingList.Count == 0)
            {
                Console.WriteLine("You have not read anything.");
            }
            else
            {
                Console.WriteLine($"Total hours reading: {totalHours}");
                Console.WriteLine($"Total number of pages {totalPages}");
                int favoriteType = new List<int> { bellesLetresType, fictionType, proffesionalLiteratureType }.Max();
                if (favoriteType == bellesLetresType)
                {
                    Console.WriteLine("Favorite type of books : Belles Lettres");
                }
                else if (favoriteType == fictionType)
                {
                    Console.WriteLine("Favorite type of books : Fiction");
                }
                else if (favoriteType == proffesionalLiteratureType)
                {
                    Console.WriteLine("Favorite type of books : Proffesional Literature");
                }
            }

        }
        public int TotalHours()
        {
            var readingList = GetAllReadingActivities();
            int totalHours = 0;
            foreach (var item in readingList)
            {
                totalHours += item.Stopwatch.Elapsed.Hours;
            }
            return totalHours;
        }
    }
}
