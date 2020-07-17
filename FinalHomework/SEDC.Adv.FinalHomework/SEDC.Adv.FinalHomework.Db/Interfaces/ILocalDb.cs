using SEDC.Adv.FinalHomework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Interfaces
{
    public interface ILocalDb
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        int InsertUser(User user);
        void UpdateUser(User user);
        void RemoveUser(int id);
        
    }
}
