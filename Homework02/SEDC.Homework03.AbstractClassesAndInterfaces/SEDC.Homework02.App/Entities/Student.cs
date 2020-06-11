using SEDC.Homework02.App.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework02.App.Entities
{

    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; } = new List<int>();



        public void PrintInfo(List<int> grades)
        {
            throw new NotImplementedException();
        }
    }
}
