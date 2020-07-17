using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SEDC.Adv.FinalHomework.Services.Interfaces
{
    public interface IActivityService
    {
        Stopwatch TrackActivity(string activity);
    }
}
