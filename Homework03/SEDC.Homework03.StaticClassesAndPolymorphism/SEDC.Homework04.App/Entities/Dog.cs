using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework04.App.Entities
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public static string Bark()
        {
            return "Bark Bark";
        }
        public bool Validate(int id, string name, string color)
        {
            if (id != 0 && color != null && name.Length >= 2)
            {
                return true;
            }
            return false;    
        }
    }
   
}
