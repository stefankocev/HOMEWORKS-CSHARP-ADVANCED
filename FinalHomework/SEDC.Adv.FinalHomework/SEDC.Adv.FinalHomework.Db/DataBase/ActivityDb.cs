using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.DataBase
{
    public class ActivityDb<T> : IActivityDb<T> where T : BaseActivity
    {
        public int IdCounter { get; set; }
        public List<T> activitiesDb;
        public ActivityDb()
        {
            activitiesDb = new List<T>();
            IdCounter = 1;
        }

        public List<T> GetAllActivities()
        {
            return activitiesDb;
        }

        public void InsertActivity(T activity)
        {
            activity.Id = IdCounter;
            activitiesDb.Add(activity);
            IdCounter++;
        }

        public T GetActivityById(int id)
        {
            return activitiesDb.FirstOrDefault(activity => activity.Id == id);
        }
    }
}
