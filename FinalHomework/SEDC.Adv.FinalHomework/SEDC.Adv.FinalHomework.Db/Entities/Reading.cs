using SEDC.Adv.FinalHomework.Db.Enums;
using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Entities
{
    public class Reading : BaseActivity, IBaseActivity
    {
        public int Hours { get; set; }
        public ReadingType Type { get; set; }
        public int Pages { get; set; }

        public string Info(User user)
        {
            return $"{user.Username} read total of {Pages} pages from {Type} type of book for {StopwatchTime()}"
;        }
    }
}
