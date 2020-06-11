using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework02.App.Entities.Interfaces
{
   public interface ITeacher : IUser
    {
        public void PrintInfo(List<string> subjects);
    }
}
