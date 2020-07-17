using SEDC.Adv.FinalHomework.Db.Enums;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Entities
{
    public class Exercising : BaseActivity, IBaseActivity
    {
        public int Hours { get; set; }
        public ExercisingType Type { get; set; }

        public string Info(User user)
        {
            return $"{user.Username} was doing {Type} for {StopwatchTime()}";
        }
    }
}
