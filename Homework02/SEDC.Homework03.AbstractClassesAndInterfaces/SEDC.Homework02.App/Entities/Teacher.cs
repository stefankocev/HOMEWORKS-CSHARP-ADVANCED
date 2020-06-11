using SEDC.Homework02.App.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework02.App.Entities
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();

        //public override void PrintInfo()
        //{
        //    throw new NotImplementedException();
        //}

        public override void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
