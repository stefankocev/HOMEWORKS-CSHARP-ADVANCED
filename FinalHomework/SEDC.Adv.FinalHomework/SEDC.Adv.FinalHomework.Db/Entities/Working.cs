using SEDC.Adv.FinalHomework.Db.Enums;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Entities
{
    public class Working : BaseActivity, IBaseActivity
    {
        public int Hours { get; set; }
        public WorkingType WorkFrom { get; set; }

        public string Info(User user)
        {
            return $"{user.Username} was working from {WorkFrom} for {StopwatchTime()}";
        }
    }
}
