using SEDC.Adv.FinalHomework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Interfaces
{
    public interface IUserService
    {
        public User Register();
        public User Login();
        void ChangeInfo(int userId, string userName, string password);
    }
}
