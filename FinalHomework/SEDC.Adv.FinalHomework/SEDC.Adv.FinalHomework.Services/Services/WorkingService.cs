using SEDC.Adv.FinalHomework.Db.DataBase;
using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Services
{
    public class WorkingService<T> where T : Working
    {
        private IActivityDb<Working> _workingActivityDb;
        public WorkingService()
        {
            _workingActivityDb = new ActivityDb<Working>();
        }
        public void AddWorkingActivity(Working working)
        {
            _workingActivityDb.InsertActivity(working);
        }
        public List<Working> GetAllWorkingActivities()
        {
            return _workingActivityDb.GetAllActivities();
        }
        public void Stats()
        {
            var workingList = GetAllWorkingActivities();
            double totalHours = 0;
            int home = 0;
            int office = 0;
            foreach (var work in workingList)
            {
                totalHours += work.Stopwatch.Elapsed.TotalHours;
                if(work.WorkFrom.ToString() == "Home")
                {
                    home++;
                }
                else
                {
                    office++;
                }
            }
            if(workingList.Count == 0)
            {
                Console.WriteLine("You have not done any work.");
            }
            else
            {
                Console.WriteLine($"Total hours spent working: {totalHours}");
                int favoritePlaceForWorking = new List<int> { home, office }.Max();
                if(favoritePlaceForWorking == home)
                {
                    Console.WriteLine("Favorite place for working: Home.");
                }
                else
                {
                    Console.WriteLine("Favorite place for working: Office.");

                }
            }
        }
        public double TotalHours()
        {
            var workingList = GetAllWorkingActivities();
            double totalHours = 0;
            foreach (var work in workingList)
            {
                totalHours += work.Stopwatch.Elapsed.TotalHours;
            }
            return totalHours;
        }
    }
}
