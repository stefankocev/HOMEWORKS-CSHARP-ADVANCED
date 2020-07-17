using SEDC.Adv.FinalHomework.Db.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Entities
{
    public class BaseActivity
    {
        public int Id { get; set; }
        public Stopwatch Stopwatch { get; set; }

        public string StopwatchTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            return stopwatch.Elapsed.ToString();
        }

    }
}
