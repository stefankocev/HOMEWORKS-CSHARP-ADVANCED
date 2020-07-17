using SEDC.Adv.FinalHomework.Db.DataBase;
using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Services
{
    public class OtherHobbyService<T> where T : OtherHobby
    {
        private IActivityDb<OtherHobby> _otherHobbyActivityDb;
        public OtherHobbyService()
        {
            _otherHobbyActivityDb = new ActivityDb<OtherHobby>();
        }
        public void AddOtherHobbyActivity(OtherHobby otherHobby)
        {
            _otherHobbyActivityDb.InsertActivity(otherHobby);
        }
        public List<OtherHobby> GetAllOtherHobbyActivities()
        {
            return _otherHobbyActivityDb.GetAllActivities();
        }
        public void Stats()
        {
            var otherHobbiesList = GetAllOtherHobbyActivities();
            double totalHours = 0;
            List<string> hobbiesNames = new List<string>();
            foreach (var hobby in otherHobbiesList)
            {
                totalHours = hobby.Stopwatch.Elapsed.TotalHours;
                hobbiesNames.Add(hobby.HobbyName + " ");
            }
            if(otherHobbiesList.Count == 0)
            {
                Console.WriteLine("You have not done any hobby.");
            }
            else
            {
                Console.WriteLine($"Total hours doing other hobbies: {totalHours}.");
                List<string> hobbies = hobbiesNames.Distinct().ToList();
                Console.WriteLine($"Name of the hobbies you are doing:");
                foreach (var hobby in hobbies)
                {
                    Console.WriteLine(hobby);
                }
            }

        }
        public double TotalHours()
        {
            var otherHobbiesList = GetAllOtherHobbyActivities();
            double totalHours = 0;
            foreach (var hobby in otherHobbiesList)
            {
                totalHours += hobby.Stopwatch.Elapsed.TotalHours;
            }
            return totalHours;
        }
    }
}
