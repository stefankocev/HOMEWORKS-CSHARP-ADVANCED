using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Entities
{
    public class OtherHobby : BaseActivity, IBaseActivity
    {
        public string HobbyName { get; set; }

        public string Info(User user)
        {
            return $"{user.Username} was doing {HobbyName} for {StopwatchTime()}";
        }
    }
}
