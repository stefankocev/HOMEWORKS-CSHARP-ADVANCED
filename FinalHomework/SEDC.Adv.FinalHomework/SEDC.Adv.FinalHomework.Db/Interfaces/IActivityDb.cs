using SEDC.Adv.FinalHomework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Interfaces
{
    public interface IActivityDb<T> where T : BaseActivity
    {
        List<T> GetAllActivities();
        void InsertActivity(T activity);
        T GetActivityById(int id);
    }
}
