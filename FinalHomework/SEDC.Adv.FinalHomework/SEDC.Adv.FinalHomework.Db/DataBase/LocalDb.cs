using SEDC.Adv.FinalHomework.Db.Entities;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.DataBase
{
    public class LocalDb : ILocalDb
    {

        public int IdCounter { get; set; }
        public List<User> db;
        public LocalDb()
        {
            db = new List<User>();
            IdCounter = 1;
        }
        public List<User> GetAllUsers()
        {
            return db;
        }

        public User GetUserById(int id)
        {
            return db.FirstOrDefault(user => user.Id == id);
        }

        public int InsertUser(User user)
        {
            IdCounter = user.Id;
            db.Add(user);
            IdCounter++;
            return user.Id;
        }
        public void UpdateUser(User user)
        {
            User userFound = db.FirstOrDefault(x => x.Id == user.Id);
            userFound = user;
        }

        public void RemoveUser(int id)
        {
            User userFound = db.FirstOrDefault(user => user.Id == id);
            db.Remove(userFound);
        }

      
    }
}
