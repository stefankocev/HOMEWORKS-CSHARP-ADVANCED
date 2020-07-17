using SEDC.Adv.FinalHomework.Db.DataBase;
using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Services
{
    public class ExercisingService<T> where T : Exercising
    {
        private IActivityDb<Exercising> _exercisingActivityDb;
        public ExercisingService()
        {
            _exercisingActivityDb = new ActivityDb<Exercising>();
        }
        public void AddExercisingActivity(Exercising exercising)
        {
            _exercisingActivityDb.InsertActivity(exercising);
        }
        public List<Exercising> GetAllExercisingActivities()
        {
            return _exercisingActivityDb.GetAllActivities();
        }
        public void Stats()
        {
            var exercisingList = GetAllExercisingActivities();
            double totalHours = 0;
            int general = 0;
            int running = 0;
            int sport = 0;
            foreach (var item in exercisingList)
            {
                totalHours += item.Stopwatch.Elapsed.TotalHours;
                if(item.Type.ToString() == "General")
                {
                    general++;
                }else if(item.Type.ToString() == "Running")
                {
                    running++;
                }
                else
                {
                    sport++;
                }
            }
            if(exercisingList.Count == 0)
            {
                Console.WriteLine("You haven't done any exercise.");
            }
            else
            {
                Console.WriteLine($"Total hours exercised: {totalHours}");
                int favoriteType = new List<int> { general, running, sport }.Max();
                if (favoriteType == general)
                {
                    Console.WriteLine("Favorite type of exercising : General.");
                }
                else if (favoriteType == running)
                {
                    Console.WriteLine("Favorite type of exercising : Runing.");
                }
                else if (favoriteType == sport)
                {
                    Console.WriteLine("Favorite type of exercising : Sports.");
                }
            }
        }
        public double TotalHours()
        {
            var exercisingList = GetAllExercisingActivities();
            double totalHours = 0;
            foreach (var item in exercisingList)
            {
                totalHours += item.Stopwatch.Elapsed.TotalHours;
            }
            return totalHours;
        }
    }
}
