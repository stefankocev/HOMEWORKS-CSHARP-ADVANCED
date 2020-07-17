using SEDC.Adv.FinalHomework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Services
{
    public class ActivityService : IActivityService
    {
        public Stopwatch TrackActivity(string activity)
        {
            Stopwatch timeSpent = new Stopwatch();
            timeSpent.Start();
            Console.WriteLine($"You have started {activity}");
            Console.WriteLine($"Press S if you want to stop {activity}");
            string userInput = Console.ReadLine();
            if(userInput.ToUpper() == "S")
            {
                timeSpent.Stop();
                Console.WriteLine($"You've stopped {activity}.");
            }
            return timeSpent;
        }
    }
}
